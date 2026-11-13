using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PhongKham.BLL;
using PhongKham.DAL;

namespace PhongKham
{
    static class Program
    {
        // Dictionary heap dùng chung toàn app
        public static Dictionary<int, PriorityQueueBLL> SharedHeaps
            = new Dictionary<int, PriorityQueueBLL>();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Kiểm tra kết nối DB
            if (!DBConnection.TestConnection())
            {
                MessageBox.Show(
                    "❌ Không kết nối được SQL Server!\n\n" +
                    "Kiểm tra:\n1. SQL Server đang chạy\n" +
                    "2. Database 'PhongKhamDB' đã tạo\n3. Connection string trong App.config",
                    "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Khởi tạo heap từ DB
            try
            {
                var bll = new TicketBLL(SharedHeaps);
                var depts = new DepartmentDAL().GetAllWithStats();
                foreach (var d in depts)
                    if (d.IsOpen) bll.RebuildHeap(d.DeptID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo: " + ex.Message);
            }

            Application.Run(new GUI.FormDashboard());
        }
    }
}