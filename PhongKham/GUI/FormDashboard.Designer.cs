namespace PhongKham.GUI
{
    partial class FormDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnCallStation = new System.Windows.Forms.Button();
            this.btnReception = new System.Windows.Forms.Button();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.pnlCard6 = new System.Windows.Forms.Panel();
            this.lblAvgWait = new System.Windows.Forms.Label();
            this.pnlCard5 = new System.Windows.Forms.Panel();
            this.lblCancelled = new System.Windows.Forms.Label();
            this.pnlCard4 = new System.Windows.Forms.Panel();
            this.lblEmergency = new System.Windows.Forms.Label();
            this.pnlCard3 = new System.Windows.Forms.Panel();
            this.lblDone = new System.Windows.Forms.Label();
            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.lblWaiting = new System.Windows.Forms.Label();
            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chartHourly = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQueue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            this.pnlStats.SuspendLayout();
            this.pnlCard6.SuspendLayout();
            this.pnlCard5.SuspendLayout();
            this.pnlCard4.SuspendLayout();
            this.pnlCard3.SuspendLayout();
            this.pnlCard2.SuspendLayout();
            this.pnlCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHourly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.pnlHeader.Controls.Add(this.btnRefresh);
            this.pnlHeader.Controls.Add(this.lblDateTime);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1117, 70);
            this.pnlHeader.TabIndex = 6;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(1001, 18);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(91, 35);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(707, 25);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(334, 26);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "Ngày giờ hiện tại...";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(180)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1104, 81);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "HỆ THỐNG HÀNG ĐỢI PHÒNG KHÁM";
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnReport.Location = new System.Drawing.Point(494, 90);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(220, 60);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "BÁO CÁO TỔNG";
            this.btnReport.UseVisualStyleBackColor = false;
            // 
            // btnCallStation
            // 
            this.btnCallStation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.btnCallStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCallStation.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnCallStation.Location = new System.Drawing.Point(260, 90);
            this.btnCallStation.Name = "btnCallStation";
            this.btnCallStation.Size = new System.Drawing.Size(220, 60);
            this.btnCallStation.TabIndex = 4;
            this.btnCallStation.Text = "BÁC SĨ GỌI SỐ";
            this.btnCallStation.UseVisualStyleBackColor = false;
            // 
            // btnReception
            // 
            this.btnReception.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.btnReception.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReception.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnReception.Location = new System.Drawing.Point(26, 90);
            this.btnReception.Name = "btnReception";
            this.btnReception.Size = new System.Drawing.Size(220, 60);
            this.btnReception.TabIndex = 5;
            this.btnReception.Text = "KIOSK LẤY SỐ";
            this.btnReception.UseVisualStyleBackColor = false;
            // 
            // pnlStats
            // 
            this.pnlStats.Controls.Add(this.pnlCard6);
            this.pnlStats.Controls.Add(this.pnlCard5);
            this.pnlStats.Controls.Add(this.pnlCard4);
            this.pnlStats.Controls.Add(this.pnlCard3);
            this.pnlStats.Controls.Add(this.pnlCard2);
            this.pnlStats.Controls.Add(this.pnlCard1);
            this.pnlStats.Location = new System.Drawing.Point(26, 170);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(1090, 120);
            this.pnlStats.TabIndex = 2;
            this.pnlStats.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStats_Paint);
            // 
            // pnlCard6
            // 
            this.pnlCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.pnlCard6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard6.Controls.Add(this.lblAvgWait);
            this.pnlCard6.Location = new System.Drawing.Point(900, 10);
            this.pnlCard6.Name = "pnlCard6";
            this.pnlCard6.Size = new System.Drawing.Size(146, 100);
            this.pnlCard6.TabIndex = 0;
            // 
            // lblAvgWait
            // 
            this.lblAvgWait.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvgWait.Location = new System.Drawing.Point(0, 0);
            this.lblAvgWait.Name = "lblAvgWait";
            this.lblAvgWait.Size = new System.Drawing.Size(144, 98);
            this.lblAvgWait.TabIndex = 0;
            this.lblAvgWait.Text = "TG Chờ trung bình:\n0 phút";
            this.lblAvgWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCard5
            // 
            this.pnlCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.pnlCard5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard5.Controls.Add(this.lblCancelled);
            this.pnlCard5.Location = new System.Drawing.Point(720, 10);
            this.pnlCard5.Name = "pnlCard5";
            this.pnlCard5.Size = new System.Drawing.Size(146, 100);
            this.pnlCard5.TabIndex = 1;
            // 
            // lblCancelled
            // 
            this.lblCancelled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCancelled.Location = new System.Drawing.Point(0, 0);
            this.lblCancelled.Name = "lblCancelled";
            this.lblCancelled.Size = new System.Drawing.Size(144, 98);
            this.lblCancelled.TabIndex = 0;
            this.lblCancelled.Text = "Đã hủy:\n0";
            this.lblCancelled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCard4
            // 
            this.pnlCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.pnlCard4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard4.Controls.Add(this.lblEmergency);
            this.pnlCard4.Location = new System.Drawing.Point(540, 10);
            this.pnlCard4.Name = "pnlCard4";
            this.pnlCard4.Size = new System.Drawing.Size(146, 100);
            this.pnlCard4.TabIndex = 2;
            // 
            // lblEmergency
            // 
            this.lblEmergency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmergency.Location = new System.Drawing.Point(0, 0);
            this.lblEmergency.Name = "lblEmergency";
            this.lblEmergency.Size = new System.Drawing.Size(144, 98);
            this.lblEmergency.TabIndex = 0;
            this.lblEmergency.Text = "Ưu tiên/Cấp cứu:\n0";
            this.lblEmergency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCard3
            // 
            this.pnlCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.pnlCard3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard3.Controls.Add(this.lblDone);
            this.pnlCard3.Location = new System.Drawing.Point(360, 10);
            this.pnlCard3.Name = "pnlCard3";
            this.pnlCard3.Size = new System.Drawing.Size(146, 100);
            this.pnlCard3.TabIndex = 3;
            // 
            // lblDone
            // 
            this.lblDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDone.Location = new System.Drawing.Point(0, 0);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(144, 98);
            this.lblDone.TabIndex = 0;
            this.lblDone.Text = "Đã khám xong:\n0";
            this.lblDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCard2
            // 
            this.pnlCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.pnlCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard2.Controls.Add(this.lblWaiting);
            this.pnlCard2.Location = new System.Drawing.Point(180, 10);
            this.pnlCard2.Name = "pnlCard2";
            this.pnlCard2.Size = new System.Drawing.Size(146, 100);
            this.pnlCard2.TabIndex = 4;
            // 
            // lblWaiting
            // 
            this.lblWaiting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWaiting.Location = new System.Drawing.Point(0, 0);
            this.lblWaiting.Name = "lblWaiting";
            this.lblWaiting.Size = new System.Drawing.Size(144, 98);
            this.lblWaiting.TabIndex = 0;
            this.lblWaiting.Text = "Đang chờ:\n0";
            this.lblWaiting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCard1
            // 
            this.pnlCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.pnlCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard1.Controls.Add(this.lblTotal);
            this.pnlCard1.Location = new System.Drawing.Point(0, 10);
            this.pnlCard1.Name = "pnlCard1";
            this.pnlCard1.Size = new System.Drawing.Size(146, 100);
            this.pnlCard1.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(144, 98);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Tổng số lượt:\n0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // chartHourly
            // 
            chartArea1.Name = "ChartArea1";
            this.chartHourly.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartHourly.Legends.Add(legend1);
            this.chartHourly.Location = new System.Drawing.Point(26, 296);
            this.chartHourly.Name = "chartHourly";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Lưu lượng";
            this.chartHourly.Series.Add(series1);
            this.chartHourly.Size = new System.Drawing.Size(1045, 281);
            this.chartHourly.TabIndex = 1;
            // 
            // dgvRooms
            // 
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.AllowUserToDeleteRows = false;
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRooms.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRooms.ColumnHeadersHeight = 40;
            this.dgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
            this.colName,
            this.colDoctor,
            this.colRoom,
            this.colStatus,
            this.colQueue,
            this.colDone,
            this.colAvg});
            this.dgvRooms.EnableHeadersVisualStyles = false;
            this.dgvRooms.Location = new System.Drawing.Point(26, 583);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.ReadOnly = true;
            this.dgvRooms.RowHeadersVisible = false;
            this.dgvRooms.RowHeadersWidth = 102;
            this.dgvRooms.RowTemplate.Height = 35;
            this.dgvRooms.Size = new System.Drawing.Size(1045, 326);
            this.dgvRooms.TabIndex = 0;
            this.dgvRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellContentClick);
            // 
            // colCode
            // 
            this.colCode.HeaderText = "Mã Khoa";
            this.colCode.MinimumWidth = 12;
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "Tên Khoa/Phòng";
            this.colName.MinimumWidth = 12;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colDoctor
            // 
            this.colDoctor.HeaderText = "Bác Sĩ";
            this.colDoctor.MinimumWidth = 12;
            this.colDoctor.Name = "colDoctor";
            this.colDoctor.ReadOnly = true;
            // 
            // colRoom
            // 
            this.colRoom.HeaderText = "Số Phòng";
            this.colRoom.MinimumWidth = 12;
            this.colRoom.Name = "colRoom";
            this.colRoom.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Trạng Thái";
            this.colStatus.MinimumWidth = 12;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colQueue
            // 
            this.colQueue.HeaderText = "Hàng Đợi";
            this.colQueue.MinimumWidth = 12;
            this.colQueue.Name = "colQueue";
            this.colQueue.ReadOnly = true;
            // 
            // colDone
            // 
            this.colDone.HeaderText = "Đã Khám";
            this.colDone.MinimumWidth = 12;
            this.colDone.Name = "colDone";
            this.colDone.ReadOnly = true;
            // 
            // colAvg
            // 
            this.colAvg.HeaderText = "TG Chờ TB";
            this.colAvg.MinimumWidth = 12;
            this.colAvg.Name = "colAvg";
            this.colAvg.ReadOnly = true;
            // 
            // FormDashboard
            // 
            this.ClientSize = new System.Drawing.Size(1117, 921);
            this.Controls.Add(this.dgvRooms);
            this.Controls.Add(this.chartHourly);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnCallStation);
            this.Controls.Add(this.btnReception);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard - Quản lý phòng khám";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlStats.ResumeLayout(false);
            this.pnlCard6.ResumeLayout(false);
            this.pnlCard5.ResumeLayout(false);
            this.pnlCard4.ResumeLayout(false);
            this.pnlCard3.ResumeLayout(false);
            this.pnlCard2.ResumeLayout(false);
            this.pnlCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartHourly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnCallStation;
        private System.Windows.Forms.Button btnReception;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Panel pnlCard4;
        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Panel pnlCard5;
        private System.Windows.Forms.Panel pnlCard6;
        private System.Windows.Forms.Label lblAvgWait;
        private System.Windows.Forms.Label lblCancelled;
        private System.Windows.Forms.Label lblEmergency;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.Label lblWaiting;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHourly;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQueue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvg;
    }
}