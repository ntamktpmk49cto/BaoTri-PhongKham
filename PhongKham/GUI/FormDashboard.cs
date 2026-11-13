using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PhongKham.BLL;
using PhongKham.BLL.Models;

namespace PhongKham.GUI
{
    public partial class FormDashboard : Form
    {
        private DashboardBLL _bll = new DashboardBLL();
        private System.Windows.Forms.Timer _timer;

        public FormDashboard()
        {
            InitializeComponent();
            SetupChart();
            SetupDgv();
            SetupTimer();
            LoadData();

            // --- ĐOẠN CODE TỐI ƯU: Lắng nghe tín hiệu đồng bộ để tự động Load lại dữ liệu tức thì ---
            TicketBLL.OnQueueDataChanged += () => {
                if (this.InvokeRequired) this.Invoke(new Action(LoadData));
                else LoadData();
            };
            // --------------------------------------------------------------------------------------

            // Nút điều hướng
            btnReception.Click += (s, e) => new FormReception().Show();
            btnCallStation.Click += (s, e) => new FormCallStation().Show();
            btnReport.Click += (s, e) => new FormReport().Show();
            btnRefresh.Click += (s, e) => LoadData();
        }

        private void SetupChart()
        {
            chartHourly.ChartAreas.Clear();
            var area = new ChartArea("main");
            area.AxisX.Title = "Giờ";
            area.AxisY.Title = "Số lượt";
            area.AxisX.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);
            chartHourly.ChartAreas.Add(area);

            chartHourly.Series.Clear();
            var s0 = new Series("Cấp cứu") { ChartType = SeriesChartType.StackedColumn, Color = Color.FromArgb(239, 68, 68) };
            var s1 = new Series("Ưu tiên") { ChartType = SeriesChartType.StackedColumn, Color = Color.FromArgb(234, 179, 8) };
            var s2 = new Series("Thường") { ChartType = SeriesChartType.StackedColumn, Color = Color.FromArgb(34, 197, 94) };
            chartHourly.Series.Add(s0);
            chartHourly.Series.Add(s1);
            chartHourly.Series.Add(s2);
        }

        private void SetupDgv()
        {
            dgvRooms.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 64, 175);
            dgvRooms.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRooms.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvRooms.EnableHeadersVisualStyles = false;

            colCode.Name = "colCode";
            colName.Name = "colName";
            colDoctor.Name = "colDoctor";
            colRoom.Name = "colRoom";
            colStatus.Name = "colStatus";
            colQueue.Name = "colQueue";
            colDone.Name = "colDone";
            colAvg.Name = "colAvg";

            dgvRooms.RowPrePaint += DgvRooms_RowPrePaint;
        }

        private void LoadData()
        {
            try
            {
                lblDateTime.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy  HH:mm:ss");
                var (stats, hourly, rooms) = _bll.GetAll();

                lblTotal.Text = "Tổng số lượt\n" + stats.TotalToday;
                lblWaiting.Text = "Đang chờ\n" + stats.TotalWaiting;
                lblDone.Text = "Đã khám xong\n" + stats.TotalDone;
                lblEmergency.Text = "Cấp cứu / Ưu tiên\n" + stats.TotalEmergency;
                lblCancelled.Text = "Đã hủy / Bỏ qua\n" + stats.TotalCancelled;
                lblAvgWait.Text = "TG Chờ trung bình\n" + $"{stats.AvgWaitMinutes:F0} phút";

                chartHourly.Series["Cấp cứu"].Points.Clear();
                chartHourly.Series["Ưu tiên"].Points.Clear();
                chartHourly.Series["Thường"].Points.Clear();
                foreach (var h in hourly)
                {
                    string x = h.Hour + ":00";
                    chartHourly.Series["Cấp cứu"].Points.AddXY(x, h.Emergency);
                    chartHourly.Series["Ưu tiên"].Points.AddXY(x, h.Priority1);
                    chartHourly.Series["Thường"].Points.AddXY(x, h.Normal);
                }

                dgvRooms.Rows.Clear();
                foreach (var d in rooms)
                    dgvRooms.Rows.Add(d.DeptCode, d.DeptName, d.DoctorName,
                        d.RoomNumber,
                        d.IsOpen ? "✓ Mở" : "✕ Đóng",
                        d.QueueCount, d.DoneCount,
                        d.AvgWait > 0 ? $"{d.AvgWait:F0}" : "-");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void DgvRooms_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvRooms.Rows[e.RowIndex];
            var st = row.Cells["colStatus"].Value?.ToString() ?? "";
            if (!st.Contains("Mở"))
                row.DefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            int q = 0;
            int.TryParse(row.Cells["colQueue"].Value?.ToString(), out q);
            if (q > 10)
                row.Cells["colQueue"].Style.ForeColor = Color.Red;
        }

        private void SetupTimer()
        {
            _timer = new System.Windows.Forms.Timer { Interval = 10000 };
            _timer.Tick += (s, e) => LoadData();
            _timer.Start();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _timer?.Stop();
            base.OnFormClosed(e);
        }

        private void FormDashboard_Load(object sender, EventArgs e) { }
        private void dgvRooms_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void pnlStats_Paint(object sender, PaintEventArgs e) { }
        private void btnRefresh_Click(object sender, EventArgs e) { }
        private void lblTotal_Click(object sender, EventArgs e) { }
    }
}