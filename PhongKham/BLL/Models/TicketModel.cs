using System;

namespace PhongKham.BLL.Models
{
    public class TicketModel : IComparable<TicketModel>
    {
        public int TicketID { get; set; }
        public string TicketNumber { get; set; }
        public int DeptID { get; set; }
        public string PatientName { get; set; }
        public int PatientAge { get; set; }
        public string PatientPhone { get; set; }
        public string PatientGender { get; set; }

        // Khóa sắp xếp Min-Heap
        public int Priority { get; set; }  // 0=Cấp cứu, 1=Ưu tiên, 2=Thường
        public string PriorityReason { get; set; }
        public DateTime ArrivalTime { get; set; }  // Khóa FIFO thứ cấp
        public string Status { get; set; }
        public DateTime? CallTime { get; set; }
        public DateTime? ServeStartTime { get; set; }
        public DateTime? ServeEndTime { get; set; }
        public int SkipCount { get; set; }
        public int? WaitMinutes { get; set; }
        public int? ServeMinutes { get; set; }
        public string Notes { get; set; }

        public string PriorityLabel =>
            Priority == 0 ? "Cấp cứu" : Priority == 1 ? "Ưu tiên" : "Thông thường";

        public string PriorityEmoji => "";


        public string PriorityFullLabel =>
            Priority == 0 ? "Cấp cứu" : Priority == 1 ? "Ưu tiên" : "Thông thường";

        public int WaitedMinutes =>
            (int)(DateTime.Now - ArrivalTime).TotalMinutes;

        public int CompareTo(TicketModel other)
        {
            if (other == null) return -1;
            int cmp = Priority.CompareTo(other.Priority);
            return cmp != 0 ? cmp : ArrivalTime.CompareTo(other.ArrivalTime);
        }
    }
}