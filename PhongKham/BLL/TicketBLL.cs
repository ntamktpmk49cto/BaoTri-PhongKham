using System;
using System.Collections.Generic;
using PhongKham.BLL.Models;
using PhongKham.DAL;

namespace PhongKham.BLL
{
    public class TicketBLL
    {
        private readonly TicketDAL _dal = new TicketDAL();
        private readonly Dictionary<int, PriorityQueueBLL> _heaps;

        // --- ĐOẠN CODE TỐI ƯU: Khai báo Sự kiện tĩnh toàn cục ---
        public static event Action OnQueueDataChanged;
        private static void NotifyDataChanged() => OnQueueDataChanged?.Invoke();
        // --------------------------------------------------------

        public TicketBLL(Dictionary<int, PriorityQueueBLL> heaps) { _heaps = heaps; }

        // Tự động xác định ưu tiên theo tuổi
        public (int priority, string reason) AutoDetect(int age)
        {
            if (age < 6) return (1, $"Trẻ em dưới 6 tuổi ({age} tuổi)");
            if (age >= 65) return (1, $"Người cao tuổi ≥65 ({age} tuổi)");
            return (2, null);
        }

        // Kiểm tra hợp lệ
        public string Validate(string name, int age, int deptID)
        {
            if (string.IsNullOrWhiteSpace(name)) return "Vui lòng nhập họ tên!";
            if (age < 0 || age > 150) return "Tuổi không hợp lệ (0–150)!";
            if (deptID <= 0) return "Vui lòng chọn phòng khám!";
            return null;
        }

        // Lấy số: lưu DB + thêm vào Heap
        public (int id, string num) TakeNumber(int deptID, string name, int age,
            string phone, string gender, int priority, string reason, string notes)
        {
            var (id, num) = _dal.TakeNumber(deptID, name, age, phone, gender, priority, reason, notes);
            var ticket = new TicketModel
            {
                TicketID = id,
                TicketNumber = num,
                DeptID = deptID,
                PatientName = name,
                PatientAge = age,
                Priority = priority,
                PriorityReason = reason,
                ArrivalTime = DateTime.Now,
                Status = "waiting"
            };
            if (!_heaps.ContainsKey(deptID)) _heaps[deptID] = new PriorityQueueBLL();
            _heaps[deptID].Insert(ticket);

            // TỐI ƯU: Kích hoạt phát tín hiệu đến các Form khác khi vừa cấp số mới thành công
            NotifyDataChanged();
            return (id, num);
        }

        // Gọi số: Extract-Min từ DB, đồng bộ Heap
        public TicketModel CallNext(int deptID)
        {
            var t = _dal.CallNext(deptID);
            if (t != null && _heaps.ContainsKey(deptID)) _heaps[deptID].Remove(t.TicketID);

            // TỐI ƯU: Kích hoạt phát tín hiệu khi Bác sĩ vừa ấn gọi bệnh nhân tiếp theo
            NotifyDataChanged();
            return t;
        }

        public void Skip(int ticketID, int deptID, bool requeue)
        {
            _ = deptID;
            _dal.Skip(ticketID, requeue);

            // TỐI ƯU: Phát tín hiệu đồng bộ khi Bác sĩ ấn bỏ qua phiếu
            NotifyDataChanged();
        }

        public void Complete(int ticketID)
        {
            _dal.Complete(ticketID);

            // TỐI ƯU: Phát tín hiệu đồng bộ khi Bác sĩ bấm hoàn thành ca khám
            NotifyDataChanged();
        }

        public List<TicketModel> GetQueue(int deptID) => _dal.GetQueue(deptID);
        public List<TicketModel> GetHistory(DateTime date) => _dal.GetHistory(date);

        public (int ahead, int estMin) EstimateWait(int deptID, int priority, DateTime arrival)
        {
            int ahead = _dal.CountPeopleAhead(deptID, priority, arrival);
            return (ahead, ahead * 10);
        }

        // Rebuild heap từ DB (gọi khi khởi động)
        public void RebuildHeap(int deptID)
        {
            var queue = _dal.GetQueue(deptID);
            if (!_heaps.ContainsKey(deptID)) _heaps[deptID] = new PriorityQueueBLL();
            _heaps[deptID].BuildHeap(queue);
        }
    }
}