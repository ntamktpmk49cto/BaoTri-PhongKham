using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongKham.BLL.Models
{
    public class DepartmentModel
    {
        public int DeptID { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string DoctorName { get; set; }
        public string RoomNumber { get; set; }
        public bool IsOpen { get; set; }
        public int? CurrentServing { get; set; }
        // Thống kê đi kèm
        public int QueueCount { get; set; }
        public int DoneCount { get; set; }
        public double AvgWait { get; set; }
        // Để ComboBox hiển thị đúng
        public override string ToString() => $"{DeptCode} — {DeptName}";
    }
}
