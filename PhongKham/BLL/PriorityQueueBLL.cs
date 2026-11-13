using System;
using System.Collections.Generic;
using PhongKham.BLL.Models;

namespace PhongKham.BLL
{
    /// <summary>
    /// MIN-HEAP tự cài đặt bằng List<T>
    /// Biểu diễn cây nhị phân dạng mảng:
    ///   Nút cha tại i → Con trái: 2i+1 | Con phải: 2i+2
    ///   Nút con tại i → Cha: (i-1)/2
    /// </summary>
    public class PriorityQueueBLL
    {
        private List<TicketModel> _heap = new List<TicketModel>();

        public int Count => _heap.Count;
        public bool IsEmpty => _heap.Count == 0;

        // INSERT — O(log n): Thêm vào cuối, rồi HeapifyUp
        public void Insert(TicketModel ticket)
        {
            _heap.Add(ticket);          // Bước 1: thêm vào cuối mảng
            HeapifyUp(_heap.Count - 1); // Bước 2: điều chỉnh lên trên
        }

        // EXTRACT-MIN — O(log n): Lấy gốc, đưa lá lên gốc, HeapifyDown
        public TicketModel ExtractMin()
        {
            if (IsEmpty) throw new InvalidOperationException("Hàng đợi rỗng!");
            var min = _heap[0];                   // Lấy phần tử nhỏ nhất (gốc)
            int last = _heap.Count - 1;
            _heap[0] = _heap[last];               // Đưa phần tử cuối lên gốc
            _heap.RemoveAt(last);
            if (!IsEmpty) HeapifyDown(0);         // Điều chỉnh từ gốc xuống
            return min;
        }

        // PEEK — O(1): Xem phần tử nhỏ nhất (không lấy ra)
        public TicketModel Peek() => IsEmpty ? null : _heap[0];

        // PEEK ALL — Trả bản sao đã sắp xếp (hiển thị danh sách)
        public List<TicketModel> PeekAll()
        {
            var copy = new List<TicketModel>(_heap);
            copy.Sort();
            return copy;
        }

        // REMOVE — xóa theo TicketID (khi huỷ phiếu)
        public bool Remove(int ticketID)
        {
            int idx = _heap.FindIndex(t => t.TicketID == ticketID);
            if (idx < 0) return false;
            int last = _heap.Count - 1;
            _heap[idx] = _heap[last];
            _heap.RemoveAt(last);
            if (idx < _heap.Count) { HeapifyUp(idx); HeapifyDown(idx); }
            return true;
        }

        // BUILD HEAP — O(n): Xây từ danh sách có sẵn (khi load từ DB)
        public void BuildHeap(List<TicketModel> tickets)
        {
            _heap = new List<TicketModel>(tickets);
            for (int i = _heap.Count / 2 - 1; i >= 0; i--)
                HeapifyDown(i);
        }

        // HEAPIFY UP — sau Insert: so sánh với cha, hoán đổi nếu nhỏ hơn
        private void HeapifyUp(int i)
        {
            while (i > 0)
            {
                int parent = (i - 1) / 2;
                if (_heap[i].CompareTo(_heap[parent]) < 0) // vi phạm heap property
                {
                    Swap(i, parent);
                    i = parent;
                }
                else break; // đúng vị trí
            }
        }

        // HEAPIFY DOWN — sau ExtractMin: tìm con nhỏ nhất, hoán đổi nếu cần
        private void HeapifyDown(int i)
        {
            int n = _heap.Count;
            while (true)
            {
                int smallest = i;
                int left = 2 * i + 1;
                int right = 2 * i + 2;
                if (left < n && _heap[left].CompareTo(_heap[smallest]) < 0) smallest = left;
                if (right < n && _heap[right].CompareTo(_heap[smallest]) < 0) smallest = right;
                if (smallest != i) { Swap(i, smallest); i = smallest; }
                else break;
            }
        }

        private void Swap(int a, int b)
        {
            var tmp = _heap[a]; _heap[a] = _heap[b]; _heap[b] = tmp;
        }
    }
}