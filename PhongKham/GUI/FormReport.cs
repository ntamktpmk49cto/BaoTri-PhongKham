using PhongKham.BLL;
using PhongKham.BLL.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PhongKham.GUI
{
    public partial class FormReport : Form
    {
        private TicketBLL _bll = new TicketBLL(Program.SharedHeaps);
        private List<TicketModel> _list = new List<TicketModel>();

        public FormReport()
        {
            InitializeComponent();
            SetupDgv();
            SetupPie();
            SetupSortButtons();
            btnLoad.Click += (s, e) => LoadData();
            LoadData();
        }

        private void SetupDgv()
        {
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.ReadOnly = true;
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 64, 175);
            dgvHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvHistory.EnableHeadersVisualStyles = false;
            dgvHistory.Columns.Add("colNum", "Số phiếu");
            dgvHistory.Columns.Add("colName", "Họ tên");
            dgvHistory.Columns.Add("colAge", "Tuổi");
            dgvHistory.Columns.Add("colPri", "Ưu tiên");
            dgvHistory.Columns.Add("colTime", "Giờ đến");
            dgvHistory.Columns.Add("colWait", "Chờ (p)");
            dgvHistory.Columns.Add("colStatus", "Trạng thái");
            dgvHistory.RowPrePaint += DgvHistory_RowPrePaint;
        }

        private void SetupPie()
        {
            chartPie.ChartAreas.Clear();
            var area = new ChartArea("pie");
            chartPie.ChartAreas.Add(area);

            chartPie.Series.Clear();
            var s = new Series("Phân loại") { ChartType = SeriesChartType.Pie };

            // --- Ép số phần trăm hiển thị vào TRONG vòng tròn ---
            s["PieLabelStyle"] = "Inside";
            s.Label = "#PERCENT{P0}"; 
            // -----------------------------------------------------------

            chartPie.Series.Add(s);

            // Giữ bảng chú thích màu sắc ở trên đỉnh cho thoáng mắt
            if (chartPie.Legends.Count > 0)
            {
                chartPie.Legends[0].Docking = Docking.Top;
                chartPie.Legends[0].Alignment = StringAlignment.Center;
            }
        }

        private void SetupSortButtons()
        {
            // Sử dụng cơ chế async/await kết hợp Task.Run để chạy thuật toán Selection Sort dưới nền RAM
            btnSortArrAsc.Click += async (s, e) =>
            {
                btnSortArrAsc.Enabled = false; // Tạm khóa nút để tránh người dùng click spam liên tục
                await Task.Run(() => SortingBLL.SortByArrivalTime(_list, true));
                RefreshGrid();
                btnSortArrAsc.Enabled = true; // Mở khóa lại nút sau khi sắp xếp xong
            };

            btnSortArrDesc.Click += async (s, e) =>
            {
                btnSortArrDesc.Enabled = false;
                await Task.Run(() => SortingBLL.SortByArrivalTime(_list, false));
                RefreshGrid();
                btnSortArrDesc.Enabled = true;
            };

            btnSortWait.Click += async (s, e) =>
            {
                btnSortWait.Enabled = false;
                await Task.Run(() => SortingBLL.SortByWaitTime(_list, false));
                RefreshGrid();
                btnSortWait.Enabled = true;
            };

            btnSortPri.Click += async (s, e) =>
            {
                btnSortPri.Enabled = false;
                await Task.Run(() => SortingBLL.SortByPriority(_list, true));
                RefreshGrid();
                btnSortPri.Enabled = true;
            };
        }

        private void LoadData()
        {
            _list = _bll.GetHistory(dtpDate.Value.Date);
            RefreshGrid();
            RefreshPie();
            RefreshStats();
        }

        private void RefreshGrid()
        {
            dgvHistory.Rows.Clear();
            foreach (var t in _list)
                dgvHistory.Rows.Add(
                    t.TicketNumber, t.PatientName, t.PatientAge,
                    t.PriorityFullLabel,
                    t.ArrivalTime.ToString("HH:mm"),
                    t.WaitMinutes?.ToString() ?? "-",
                    t.Status == "done" ? "✅ Hoàn thành" :
                    t.Status == "cancelled" ? "❌ Huỷ" :
                    t.Status == "skipped" ? "⏭ Bỏ qua" :
                    t.Status == "waiting" ? "⏳ Chờ" : t.Status);
        }

        private void DgvHistory_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var st = dgvHistory.Rows[e.RowIndex].Cells["colStatus"].Value?.ToString() ?? "";
            dgvHistory.Rows[e.RowIndex].DefaultCellStyle.BackColor =
                st.Contains("Hoàn thành") ? Color.FromArgb(240, 253, 244) :
                st.Contains("Huỷ") ? Color.FromArgb(254, 242, 242) :
                st.Contains("Bỏ qua") ? Color.FromArgb(255, 251, 235) :
                Color.White;
        }

        private void RefreshPie()
        {
            chartPie.Series["Phân loại"].Points.Clear();
            int e0 = 0, p1 = 0, n2 = 0;
            foreach (var t in _list)
            {
                if (t.Priority == 0) e0++;
                else if (t.Priority == 1) p1++;
                else n2++;
            }

            
            Font labelFont = new Font("Segoe UI", 11, FontStyle.Bold);

            if (e0 > 0)
            {
                var pt = chartPie.Series["Phân loại"].Points.Add(e0);
                pt.LegendText = "Cấp cứu";
                pt.Color = Color.FromArgb(239, 68, 68); // Nền đỏ
                pt.Font = labelFont;
                pt.LabelForeColor = Color.FromArgb(64, 40, 0);    
            }

            if (p1 > 0)
            {
                var pt = chartPie.Series["Phân loại"].Points.Add(p1);
                pt.LegendText = "Ưu tiên";
                pt.Color = Color.FromArgb(234, 179, 8);  
                pt.Font = labelFont;
                pt.LabelForeColor = Color.FromArgb(64, 40, 0); 
            }

            if (n2 > 0)
            {
                var pt = chartPie.Series["Phân loại"].Points.Add(n2);
                pt.LegendText = "Thường";
                pt.Color = Color.FromArgb(34, 197, 94); 
                pt.Font = labelFont;
                pt.LabelForeColor = Color.FromArgb(64, 40, 0);       
            }
        }

        private void RefreshStats()
        {
            // --- ĐOẠN CODE ĐÃ SỬA: Nối tiêu đề rõ ràng kèm dấu xuống dòng \n cho 5 ô thống kê ---
            lblTotal.Text = "Tổng số phiếu\n" + _list.Count;
            lblDone.Text = "Đã khám xong\n" + _list.FindAll(t => t.Status == "done").Count;
            lblWaiting.Text = "Đang xếp hàng\n" + _list.FindAll(t => t.Status == "waiting").Count;
            lblEmergency.Text = "Số ca cấp cứu\n" + _list.FindAll(t => t.Priority == 0).Count;

            double avg = 0; int cnt = 0;
            foreach (var t in _list)
            {
                if (t.WaitMinutes.HasValue)
                {
                    avg += t.WaitMinutes.Value;
                    cnt++;
                }
            }

            lblAvgWait.Text = "TG chờ trung bình\n" + (cnt > 0 ? $"{avg / cnt:F0} phút" : "-");
            // ----------------------------------------------------------------------------------
        }
    }
}