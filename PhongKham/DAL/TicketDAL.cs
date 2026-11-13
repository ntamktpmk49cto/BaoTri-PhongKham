using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PhongKham.BLL.Models;

namespace PhongKham.DAL
{
    public class TicketDAL
    {
        // Gọi sp_TakeNumber — tạo phiếu mới
        public (int id, string num) TakeNumber(int deptID, string name, int age,
            string phone, string gender, int priority, string reason, string notes)
        {
            using (var conn = DBConnection.GetConnection())
            using (var cmd = new SqlCommand("sp_TakeNumber", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DeptID", deptID);
                cmd.Parameters.AddWithValue("@PatientName", name);
                cmd.Parameters.AddWithValue("@PatientAge", age);
                cmd.Parameters.AddWithValue("@PatientPhone", (object)phone ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@PatientGender", (object)gender ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Priority", priority);
                cmd.Parameters.AddWithValue("@PriorityReason", (object)reason ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Notes", (object)notes ?? DBNull.Value);

                var pID = new SqlParameter("@NewTicketID", SqlDbType.Int) { Direction = ParameterDirection.Output };
                var pNum = new SqlParameter("@TicketNumber", SqlDbType.VarChar, 10) { Direction = ParameterDirection.Output };
                cmd.Parameters.Add(pID);
                cmd.Parameters.Add(pNum);
                cmd.ExecuteNonQuery();
                return ((int)pID.Value, pNum.Value.ToString());
            }
        }

        // GỌI SỐ TIẾP THEO 
        public TicketModel CallNext(int deptID)
        {
            using (var conn = DBConnection.GetConnection())
            using (var cmd = new SqlCommand("sp_CallNextNumber", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DeptID", deptID);

                var pID = new SqlParameter("@TicketID", SqlDbType.Int) { Direction = ParameterDirection.Output };
                var pNum = new SqlParameter("@TicketNum", SqlDbType.VarChar, 10) { Direction = ParameterDirection.Output };
                var pPri = new SqlParameter("@Priority", SqlDbType.Int) { Direction = ParameterDirection.Output };

                cmd.Parameters.Add(pID);
                cmd.Parameters.Add(pNum);
                cmd.Parameters.Add(pPri);

                cmd.ExecuteNonQuery();

                if (pID.Value == DBNull.Value) return null;

                int targetTicketID = (int)pID.Value;
                string patientName = "";
                int patientAge = 0;

                // --- Truy vấn nhanh dữ liệu hành khách vừa được gọi ---
                string sqlGetInfo = "SELECT PatientName, PatientAge FROM Queue_Ticket WHERE TicketID = @TicketID";
                using (SqlCommand cmdInfo = new SqlCommand(sqlGetInfo, conn))
                {
                    cmdInfo.Parameters.AddWithValue("@TicketID", targetTicketID);
                    using (SqlDataReader reader = cmdInfo.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            patientName = reader["PatientName"].ToString();
                            patientAge = Convert.ToInt32(reader["PatientAge"]);
                        }
                    }
                }
                // ----------------------------------------------------------------------

                return new TicketModel
                {
                    TicketID = targetTicketID,
                    TicketNumber = pNum.Value.ToString(),
                    Priority = (int)pPri.Value,
                    PatientName = patientName, 
                    PatientAge = patientAge,   
                    Status = "calling",
                    CallTime = DateTime.Now
                };
            }
        }

        public void Skip(int ticketID, bool requeue)
        {
            using (var conn = DBConnection.GetConnection())
            using (var cmd = new SqlCommand("sp_SkipCurrent", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TicketID", ticketID);
                cmd.Parameters.AddWithValue("@Requeue", requeue ? 1 : 0);
                cmd.ExecuteNonQuery();
            }
        }

        public void Complete(int ticketID)
        {
            using (var conn = DBConnection.GetConnection())
            using (var cmd = new SqlCommand("sp_CompleteServing", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TicketID", ticketID);
                cmd.ExecuteNonQuery();
            }
        }

        public List<TicketModel> GetQueue(int deptID)
        {
            var list = new List<TicketModel>();
            using (var conn = DBConnection.GetConnection())
            using (var cmd = new SqlCommand("sp_GetQueue", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DeptID", deptID);
                using (var r = cmd.ExecuteReader())
                    while (r.Read()) list.Add(MapTicket(r));
            }
            return list;
        }

        public List<TicketModel> GetHistory(DateTime date)
        {
            var list = new List<TicketModel>();
            string sql = @"SELECT * FROM Queue_Ticket
                           WHERE CAST(ArrivalTime AS DATE)=@d ORDER BY ArrivalTime DESC";
            using (var conn = DBConnection.GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@d", date.Date);
                using (var r = cmd.ExecuteReader())
                    while (r.Read()) list.Add(MapTicket(r));
            }
            return list;
        }

        public int CountPeopleAhead(int deptID, int priority, DateTime arrival)
        {
            string sql = @"SELECT COUNT(*) FROM Queue_Ticket
                           WHERE DeptID=@d AND Status='waiting'
                             AND (Priority<@p OR (Priority=@p AND ArrivalTime<@a))";
            using (var conn = DBConnection.GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@d", deptID);
                cmd.Parameters.AddWithValue("@p", priority);
                cmd.Parameters.AddWithValue("@a", arrival);
                return (int)cmd.ExecuteScalar();
            }
        }

        private TicketModel MapTicket(IDataReader r)
        {
            return new TicketModel
            {
                TicketID = (int)r["TicketID"],
                TicketNumber = r["TicketNumber"].ToString(),
                DeptID = (int)r["DeptID"],
                PatientName = r["PatientName"].ToString(),
                PatientAge = (int)r["PatientAge"],
                PatientPhone = r["PatientPhone"] == DBNull.Value ? "" : r["PatientPhone"].ToString(),
                PatientGender = r["PatientGender"] == DBNull.Value ? "" : r["PatientGender"].ToString(),
                Priority = (int)r["Priority"],
                PriorityReason = r["PriorityReason"] == DBNull.Value ? "" : r["PriorityReason"].ToString(),
                ArrivalTime = (DateTime)r["ArrivalTime"],
                Status = r["Status"].ToString(),
                CallTime = r["CallTime"] == DBNull.Value ? (DateTime?)null : (DateTime)r["CallTime"],
                ServeStartTime = r["ServeStartTime"] == DBNull.Value ? (DateTime?)null : (DateTime)r["ServeStartTime"],
                ServeEndTime = r["ServeEndTime"] == DBNull.Value ? (DateTime?)null : (DateTime)r["ServeEndTime"],
                SkipCount = (int)r["SkipCount"],
                WaitMinutes = r["WaitMinutes"] == DBNull.Value ? (int?)null : Convert.ToInt32(r["WaitMinutes"]),
                ServeMinutes = r["ServeMinutes"] == DBNull.Value ? (int?)null : Convert.ToInt32(r["ServeMinutes"]),
                Notes = r["Notes"] == DBNull.Value ? "" : r["Notes"].ToString(),
            };
        }
    }
}