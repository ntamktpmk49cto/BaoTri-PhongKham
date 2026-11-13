using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongKham.BLL.Models
{
    public class DashboardStats
    {
        public int TotalToday { get; set; }
        public int TotalWaiting { get; set; }
        public int TotalDone { get; set; }
        public int TotalEmergency { get; set; }
        public int TotalCancelled { get; set; }
        public double AvgWaitMinutes { get; set; }
    }

    public class HourlyStats
    {
        public int Hour { get; set; }
        public int Emergency { get; set; }
        public int Priority1 { get; set; }
        public int Normal { get; set; }
    }
}
