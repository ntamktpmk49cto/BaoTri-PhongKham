using System;
using System.Drawing;
using System.Windows.Forms;
using PhongKham.BLL;
using PhongKham.BLL.Models;
using PhongKham.DAL;

namespace PhongKham.GUI
{
    public partial class FormCallStation : Form
    {
        private TicketBLL _bll = new TicketBLL(Program.SharedHeaps);
        private TicketModel _current;
        private int _deptID;
        private DateTime _callStart;
        private System.Windows.Forms.Timer _callTimer;

        public FormCallStation()
        {
            InitializeComponent();
            SetupDgv();
            SetupCallTimer();
            LoadRooms();

            cboRoom.SelectedIndexChanged += (s, e) => {
                _deptID = (cboRoom.SelectedItem as DepartmentModel)?.DeptID ?? 0;
                RefreshQueue();
            };
            btnCallNext.Click += BtnCallNext_Click;
            btnSkip.Click += BtnSkip_Click;
            btnComplete.Click += BtnComplete_Click;
        }

        private void SetupDgv()
        {
            dgvQueue.BackgroundColor = Color.FromArgb(20, 33, 61);
            dgvQueue.BorderStyle = BorderStyle.None;
            dgvQueue.GridColor = Color.FromArgb(40, 60, 100);
            dgvQueue.DefaultCellStyle.BackColor = Color.FromArgb(20, 33, 61);
            dgvQueue.DefaultCellStyle.ForeColor = Color.White;
            dgvQueue.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 64, 175);
            dgvQueue.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvQueue.EnableHeadersVisualStyles = false;
            dgvQueue.Columns.Add("colNum", "Số phiếu");
            dgvQueue.Columns.Add("colName", "Họ tên");
            dgvQueue.Columns.Add("colPri", "Ưu tiên");
            dgvQueue.Columns.Add("colWait", "Đã chờ");
            dgvQueue.RowPrePaint += DgvQueue_RowPrePaint;
        }

        private void SetupCallTimer()
        {
            _callTimer = new System.Windows.Forms.Timer { Interval = 1000 };
            _callTimer.Tick += (s, e) => {
                if (_current != null)
                    lblTimer.Text = (DateTime.Now - _callStart).ToString(@"mm\:ss");
            };
        }

        private void BtnCallNext_Click(object sender, EventArgs e)
        {
            if (_deptID == 0) { MessageBox.Show("Chọn phòng khám!"); return; }

            // --- Chốt chặn bảo vệ ca khám dở dang ---
            if (_current != null)
            {
                var confirm = MessageBox.Show(
                    $"Bệnh nhân số {_current.TicketNumber} ({_current.PatientName}) chưa được khám xong!\n\n" +
                    "Bạn có muốn BỎ QUA bệnh nhân cũ này để gọi người tiếp theo không?",
                    "Lưu ý",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    // Nếu bác sĩ bấm Yes: Tự động đánh dấu Bỏ qua ca cũ (requeue = false để chuyển vào lịch sử hủy)
                    _bll.Skip(_current.TicketID, _deptID, false);
                }
                else
                {
                    // Nếu bấm No hoặc Cancel: Dừng lệnh gọi lại, bác sĩ phải bấm Hoàn thành/Bỏ qua ca cũ thủ công
                    return;
                }
            }
            // -------------------------------------------------------------

            _current = _bll.CallNext(_deptID);
            if (_current == null) { MessageBox.Show("Hàng đợi trống!"); return; }

            // (Giữ nguyên toàn bộ đoạn code hiển thị dữ liệu bảng LED và Timer bên dưới của bạn)
            lblCurrentNum.Text = _current.TicketNumber;
            lblPatientName.Text = _current.PatientName + $"  (Tuổi: {_current.PatientAge})";
            lblPriority.Text = _current.PriorityEmoji + " " + _current.PriorityLabel;
            lblCurrentNum.ForeColor =
                _current.Priority == 0 ? Color.Red :
                _current.Priority == 1 ? Color.FromArgb(250, 204, 21) :
                                         Color.FromArgb(52, 211, 153);
            _callStart = DateTime.Now;
            _callTimer.Start();
            RefreshQueue();
        }

        private void BtnSkip_Click(object sender, EventArgs e)
        {
            if (_current == null) return;
            var ans = MessageBox.Show("Đưa về cuối hàng đợi (Requeue)?",
                "Bỏ qua", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (ans == DialogResult.Cancel) return;
            _bll.Skip(_current.TicketID, _deptID, ans == DialogResult.Yes);
            Reset();
        }

        private void BtnComplete_Click(object sender, EventArgs e)
        {
            if (_current == null) return;
            _bll.Complete(_current.TicketID);
            MessageBox.Show("✅ Hoàn thành khám!");
            Reset();
        }

        private void Reset()
        {
            _current = null;
            lblCurrentNum.Text = "---";
            lblPatientName.Text = "Chưa có số đang gọi";
            lblPriority.Text = "";
            lblTimer.Text = "00:00";
            _callTimer.Stop();
            RefreshQueue();
        }

        private void RefreshQueue()
        {
            if (_deptID == 0) return;
            dgvQueue.Rows.Clear();
            foreach (var t in _bll.GetQueue(_deptID))
                // Thay thế thuộc tính ghép chuỗi cũ bằng t.PriorityFullLabel
                dgvQueue.Rows.Add(t.TicketNumber, t.PatientName, t.PriorityFullLabel, $"{t.WaitedMinutes}p");
        }

        private void DgvQueue_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var pri = dgvQueue.Rows[e.RowIndex].Cells["colPri"].Value?.ToString() ?? "";
            dgvQueue.Rows[e.RowIndex].DefaultCellStyle.BackColor =
                pri.Contains("Cấp cứu") ? Color.FromArgb(80, 30, 30) :
                pri.Contains("Ưu tiên") ? Color.FromArgb(70, 60, 20) :
                                          Color.FromArgb(20, 50, 40);
        }

        private void LoadRooms()
        {
            var rooms = new DepartmentDAL().GetAllWithStats();
            cboRoom.Items.Clear();
            foreach (var r in rooms) if (r.IsOpen) cboRoom.Items.Add(r);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _callTimer?.Stop();
            base.OnFormClosed(e);
        }

        private void dgvQueue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblPatientName_Click(object sender, EventArgs e)
        {

        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }
    }
}