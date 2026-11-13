using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PhongKham.BLL;
using PhongKham.BLL.Models;
using PhongKham.DAL;

namespace PhongKham.GUI
{
    public partial class FormReception : Form
    {
        private TicketBLL _bll = new TicketBLL(Program.SharedHeaps);
        private int _priority = 2; // Mặc định: Thông thường

        public FormReception()
        {
            InitializeComponent();
            LoadRooms();
            SetupPriorityButtons();
            txtAge.TextChanged += TxtAge_Changed;
            btnTake.Click += BtnTake_Click;
            btnClear.Click += (s, e) => ClearForm();
        }

        private void LoadRooms()
        {
            var rooms = new DepartmentDAL().GetAllWithStats();
            cboRoom.Items.Clear();
            foreach (var r in rooms)
                if (r.IsOpen) cboRoom.Items.Add(r);
        }

        private void SetupPriorityButtons()
        {
            // --- ĐOẠN CODE BỔ SUNG: Ép đổi tên hiển thị của 3 nút RadioButton ngay khi chạy form ---
            rdoEmergency.Text = "Cấp cứu";
            rdoPriority.Text = "Ưu tiên";
            rdoNormal.Text = "Thông thường";
            // -------------------------------------------------------------------------------------

            // Màu nền khi chọn (Giữ nguyên code cũ của bạn)
            rdoEmergency.BackColor = Color.FromArgb(254, 226, 226);
            rdoPriority.BackColor = Color.FromArgb(254, 249, 195);
            rdoNormal.BackColor = Color.FromArgb(220, 252, 231);
            rdoNormal.Checked = true;

            rdoEmergency.CheckedChanged += (s, e) => { if (rdoEmergency.Checked) SetPriority(0); };
            rdoPriority.CheckedChanged += (s, e) => { if (rdoPriority.Checked) SetPriority(1); };
            rdoNormal.CheckedChanged += (s, e) => { if (rdoNormal.Checked) SetPriority(2); };
        }

        private void SetPriority(int p)
        {
            _priority = p;
            lblPreviewNum.ForeColor =
                p == 0 ? Color.Red :
                p == 1 ? Color.FromArgb(180, 130, 0) : Color.FromArgb(21, 128, 61);
        }

        private void TxtAge_Changed(object sender, EventArgs e)
        {
            // Nếu ô nhập trống hoặc gõ chữ lỗi, xóa dòng thông báo nhận diện
            if (!int.TryParse(txtAge.Text, out int age))
            {
                lblAutoDetect.Text = "";
                return;
            }

            // Gọi BLL để tự động nhận diện nhóm ưu tiên theo số tuổi hiện tại
            var (pri, reason) = _bll.AutoDetect(age);

            if (pri == 1)
            {
                // TỰ ĐỘNG NÂNG CẤP: Nếu là Trẻ em (<6) hoặc Người già (>=65)
                rdoPriority.Checked = true;
                lblAutoDetect.Text = $"✨ {reason}";
            }
            else if (pri == 2)
            {
                // TỰ ĐỘNG HẠ CẤP: Khi gõ thêm số để thành tuổi người lớn (Ví dụ: 2 thành 20)
                // Hệ thống sẽ tự động tích trả lại ô "Thông thường" và xóa thông báo lý do
                rdoNormal.Checked = true;
                lblAutoDetect.Text = "";
            }
        }

        private void BtnTake_Click(object sender, EventArgs e)
        {
            if (!(cboRoom.SelectedItem is DepartmentModel dept))
            { MessageBox.Show("Chọn phòng khám!"); return; }

            if (!int.TryParse(txtAge.Text, out int age))
            { MessageBox.Show("Tuổi không hợp lệ!"); return; }

            string err = _bll.Validate(txtName.Text, age, dept.DeptID);
            if (err != null) { MessageBox.Show(err); return; }

            string reason = lblAutoDetect.Text.Replace("✨ ", "");
            var (id, num) = _bll.TakeNumber(
                dept.DeptID, txtName.Text.Trim(), age,
                txtPhone.Text.Trim(), "Nam",
                _priority, reason, txtNotes.Text.Trim());

            // Tính ước tính chờ
            var (ahead, estMin) = _bll.EstimateWait(dept.DeptID, _priority, DateTime.Now);

            lblPreviewNum.Text = num;
            lblPreviewInfo.Text = $"Còn {ahead} người phía trước\nƯớc tính chờ: ~{estMin} phút";

            MessageBox.Show(
               $"✅ Cấp phiếu thành công!\n\nSố phiếu: {num}\n" +
               $"Mức ưu tiên: {(new[] { "Cấp cứu", "Ưu tiên", "Thông thường" })[_priority]}\n" + // <-- ĐÃ SỬA mảng chữ ở đây
               $"Người đang chờ: {ahead}\nƯớc tính: ~{estMin} phút",
               "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

        private void ClearForm()
        {
            txtName.Clear(); txtAge.Clear(); txtPhone.Clear(); txtNotes.Clear();
            rdoNormal.Checked = true;
            lblAutoDetect.Text = "";
            lblPreviewNum.Text = "---";
            lblPreviewInfo.Text = "Vui lòng nhập thông tin";
        }

    }
}