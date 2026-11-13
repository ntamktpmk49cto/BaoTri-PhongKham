using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PhongKham.BLL.Models;
using PhongKham.DAL;

namespace PhongKham.BLL
{
    public class DashboardBLL
    {
        public (DashboardStats stats, List<HourlyStats> hourly, List<DepartmentModel> rooms)
            GetAll()
        {
            var stats = new DashboardStats();
            var hourly = new List<HourlyStats>();
            var rooms = new List<DepartmentModel>();

            using (var conn = DBConnection.GetConnection())
            using (var cmd = new SqlCommand("sp_GetDashboardStats", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                using (var r = cmd.ExecuteReader())
                {
                    if (r.Read())
                    {
                        stats.TotalToday = Convert.ToInt32(r["TotalToday"]);
                        stats.TotalWaiting = Convert.ToInt32(r["TotalWaiting"]);
                        stats.TotalDone = Convert.ToInt32(r["TotalDone"]);
                        stats.TotalEmergency = Convert.ToInt32(r["TotalEmergency"]);
                        stats.TotalCancelled = Convert.ToInt32(r["TotalCancelled"]);
                        stats.AvgWaitMinutes = r["AvgWaitMinutes"] == DBNull.Value ? 0 : Convert.ToDouble(r["AvgWaitMinutes"]);
                    }
                    r.NextResult();
                    while (r.Read())
                        hourly.Add(new HourlyStats
                        {
                            Hour = Convert.ToInt32(r["Hour"]),
                            Emergency = Convert.ToInt32(r["Emergency"]),
                            Priority1 = Convert.ToInt32(r["Priority1"]),
                            Normal = Convert.ToInt32(r["Normal"])
                        });
                    r.NextResult();
                    while (r.Read())
                        rooms.Add(new DepartmentModel
                        {
                            DeptID = Convert.ToInt32(r["DeptID"]),
                            DeptCode = r["DeptCode"].ToString(),
                            DeptName = r["DeptName"].ToString(),
                            DoctorName = r["DoctorName"].ToString(),
                            RoomNumber = r["RoomNumber"].ToString(),
                            IsOpen = Convert.ToBoolean(r["IsOpen"]),
                            QueueCount = r["QueueCount"] == DBNull.Value ? 0 : Convert.ToInt32(r["QueueCount"]),
                            DoneCount = r["DoneCount"] == DBNull.Value ? 0 : Convert.ToInt32(r["DoneCount"]),
                            AvgWait = r["AvgWait"] == DBNull.Value ? 0 : Convert.ToDouble(r["AvgWait"])
                        });
                }
            }
            return (stats, hourly, rooms);
        }
    }
}