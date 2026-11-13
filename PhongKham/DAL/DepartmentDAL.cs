using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PhongKham.BLL.Models;

namespace PhongKham.DAL
{
    public class DepartmentDAL
    {
        public List<DepartmentModel> GetAllWithStats()
        {
            var list = new List<DepartmentModel>();
            string sql = @"
                SELECT d.DeptID, d.DeptCode, d.DeptName, d.DoctorName,
                       d.RoomNumber, d.IsOpen, d.CurrentServing,
                       COUNT(CASE WHEN q.Status='waiting' THEN 1 END) AS QueueCount,
                       COUNT(CASE WHEN q.Status='done'    THEN 1 END) AS DoneCount,
                       AVG(CAST(q.WaitMinutes AS FLOAT))              AS AvgWait
                FROM Department d
                LEFT JOIN Queue_Ticket q
                    ON d.DeptID=q.DeptID AND CAST(q.ArrivalTime AS DATE)=CAST(GETDATE() AS DATE)
                GROUP BY d.DeptID,d.DeptCode,d.DeptName,d.DoctorName,
                         d.RoomNumber,d.IsOpen,d.CurrentServing
                ORDER BY d.DeptCode";

            using (var conn = DBConnection.GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            using (var r = cmd.ExecuteReader())
                while (r.Read()) list.Add(Map(r));
            return list;
        }

        private DepartmentModel Map(IDataReader r)
        {
            return new DepartmentModel
            {
                DeptID = (int)r["DeptID"],
                DeptCode = r["DeptCode"].ToString(),
                DeptName = r["DeptName"].ToString(),
                DoctorName = r["DoctorName"] == DBNull.Value ? "" : r["DoctorName"].ToString(),
                RoomNumber = r["RoomNumber"] == DBNull.Value ? "" : r["RoomNumber"].ToString(),
                IsOpen = (bool)r["IsOpen"],
                CurrentServing = r["CurrentServing"] == DBNull.Value ? (int?)null : (int)r["CurrentServing"],
                QueueCount = r["QueueCount"] == DBNull.Value ? 0 : Convert.ToInt32(r["QueueCount"]),
                DoneCount = r["DoneCount"] == DBNull.Value ? 0 : Convert.ToInt32(r["DoneCount"]),
                AvgWait = r["AvgWait"] == DBNull.Value ? 0 : Convert.ToDouble(r["AvgWait"]),
            };
        }
    }
}