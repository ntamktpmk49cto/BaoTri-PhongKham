using System.Collections.Generic;
using PhongKham.BLL.Models;

namespace PhongKham.BLL
{
    public static class SortingBLL
    {
        // SELECTION SORT theo ArrivalTime — O(n²) thời gian, O(1) không gian
        public static void SortByArrivalTime(List<TicketModel> list, bool asc = true)
        {
            int n = list.Count;
            for (int i = 0; i < n - 1; i++)
            {
                int ext = i;
                for (int j = i + 1; j < n; j++)
                {
                    bool swap = asc ? list[j].ArrivalTime < list[ext].ArrivalTime
                                    : list[j].ArrivalTime > list[ext].ArrivalTime;
                    if (swap) ext = j;
                }
                if (ext != i) { var t = list[i]; list[i] = list[ext]; list[ext] = t; }
            }
        }

        // SELECTION SORT theo WaitMinutes
        public static void SortByWaitTime(List<TicketModel> list, bool asc = false)
        {
            int n = list.Count;
            for (int i = 0; i < n - 1; i++)
            {
                int ext = i;
                for (int j = i + 1; j < n; j++)
                {
                    int vj = list[j].WaitMinutes ?? 0, ve = list[ext].WaitMinutes ?? 0;
                    if (asc ? vj < ve : vj > ve) ext = j;
                }
                if (ext != i) { var t = list[i]; list[i] = list[ext]; list[ext] = t; }
            }
        }

        // SELECTION SORT theo Priority
        public static void SortByPriority(List<TicketModel> list, bool asc = true)
        {
            int n = list.Count;
            for (int i = 0; i < n - 1; i++)
            {
                int ext = i;
                for (int j = i + 1; j < n; j++)
                    if (asc ? list[j].Priority < list[ext].Priority
                             : list[j].Priority > list[ext].Priority) ext = j;
                if (ext != i) { var t = list[i]; list[i] = list[ext]; list[ext] = t; }
            }
        }
    }
}