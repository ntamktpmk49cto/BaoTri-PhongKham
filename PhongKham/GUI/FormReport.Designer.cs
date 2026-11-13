using System;

namespace PhongKham.GUI
{
    partial class FormReport
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.lblAvgWait = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblEmergency = new System.Windows.Forms.Label();
            this.lblDone = new System.Windows.Forms.Label();
            this.lblWaiting = new System.Windows.Forms.Label();
            this.pnlSort = new System.Windows.Forms.Panel();
            this.btnSortArrAsc = new System.Windows.Forms.Button();
            this.btnSortArrDesc = new System.Windows.Forms.Button();
            this.btnSortWait = new System.Windows.Forms.Button();
            this.btnSortPri = new System.Windows.Forms.Button();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.chartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlTop.SuspendLayout();
            this.pnlStats.SuspendLayout();
            this.pnlSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pnlTop.Controls.Add(this.btnLoad);
            this.pnlTop.Controls.Add(this.dtpDate);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1143, 55);
            this.pnlTop.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(549, 9);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(93, 32);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "🔍 Xem";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(239, 12);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(287, 53);
            this.dtpDate.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📊 BÁO CÁO LỊCH SỬ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlStats
            // 
            this.pnlStats.BackColor = System.Drawing.Color.White;
            this.pnlStats.Controls.Add(this.lblAvgWait);
            this.pnlStats.Controls.Add(this.lblTotal);
            this.pnlStats.Controls.Add(this.lblEmergency);
            this.pnlStats.Controls.Add(this.lblDone);
            this.pnlStats.Controls.Add(this.lblWaiting);
            this.pnlStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStats.Location = new System.Drawing.Point(0, 55);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(1143, 73);
            this.pnlStats.TabIndex = 1;
            // 
            // lblAvgWait
            // 
            this.lblAvgWait.Font = new System.Drawing.Font("Arial", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgWait.Location = new System.Drawing.Point(668, 5);
            this.lblAvgWait.Name = "lblAvgWait";
            this.lblAvgWait.Size = new System.Drawing.Size(215, 67);
            this.lblAvgWait.TabIndex = 4;
            this.lblAvgWait.Text = "label1";
            this.lblAvgWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Arial", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(27, 6);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(157, 64);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "label1";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmergency
            // 
            this.lblEmergency.Font = new System.Drawing.Font("Arial", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmergency.Location = new System.Drawing.Point(518, 6);
            this.lblEmergency.Name = "lblEmergency";
            this.lblEmergency.Size = new System.Drawing.Size(157, 64);
            this.lblEmergency.TabIndex = 3;
            this.lblEmergency.Text = "label1";
            this.lblEmergency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDone
            // 
            this.lblDone.Font = new System.Drawing.Font("Arial", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDone.Location = new System.Drawing.Point(194, 6);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(157, 64);
            this.lblDone.TabIndex = 1;
            this.lblDone.Text = "label1";
            this.lblDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWaiting
            // 
            this.lblWaiting.Font = new System.Drawing.Font("Arial", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaiting.Location = new System.Drawing.Point(362, 6);
            this.lblWaiting.Name = "lblWaiting";
            this.lblWaiting.Size = new System.Drawing.Size(157, 64);
            this.lblWaiting.TabIndex = 2;
            this.lblWaiting.Text = "label1";
            this.lblWaiting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSort
            // 
            this.pnlSort.BackColor = System.Drawing.Color.LightGray;
            this.pnlSort.Controls.Add(this.btnSortArrAsc);
            this.pnlSort.Controls.Add(this.btnSortArrDesc);
            this.pnlSort.Controls.Add(this.btnSortWait);
            this.pnlSort.Controls.Add(this.btnSortPri);
            this.pnlSort.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSort.Location = new System.Drawing.Point(0, 128);
            this.pnlSort.Name = "pnlSort";
            this.pnlSort.Size = new System.Drawing.Size(1143, 86);
            this.pnlSort.TabIndex = 2;
            // 
            // btnSortArrAsc
            // 
            this.btnSortArrAsc.Location = new System.Drawing.Point(31, 24);
            this.btnSortArrAsc.Name = "btnSortArrAsc";
            this.btnSortArrAsc.Size = new System.Drawing.Size(181, 42);
            this.btnSortArrAsc.TabIndex = 0;
            this.btnSortArrAsc.Text = "⬇ Giờ đến (cũ→mới)";
            this.btnSortArrAsc.UseVisualStyleBackColor = true;
            // 
            // btnSortArrDesc
            // 
            this.btnSortArrDesc.Location = new System.Drawing.Point(239, 24);
            this.btnSortArrDesc.Name = "btnSortArrDesc";
            this.btnSortArrDesc.Size = new System.Drawing.Size(158, 42);
            this.btnSortArrDesc.TabIndex = 3;
            this.btnSortArrDesc.Text = "⬆ Giờ đến (mới→cũ)";
            this.btnSortArrDesc.UseVisualStyleBackColor = true;
            // 
            // btnSortWait
            // 
            this.btnSortWait.Location = new System.Drawing.Point(637, 24);
            this.btnSortWait.Name = "btnSortWait";
            this.btnSortWait.Size = new System.Drawing.Size(159, 42);
            this.btnSortWait.TabIndex = 4;
            this.btnSortWait.Text = "⏱ Thời gian chờ ↓";
            this.btnSortWait.UseVisualStyleBackColor = true;
            // 
            // btnSortPri
            // 
            this.btnSortPri.Location = new System.Drawing.Point(433, 24);
            this.btnSortPri.Name = "btnSortPri";
            this.btnSortPri.Size = new System.Drawing.Size(163, 42);
            this.btnSortPri.TabIndex = 5;
            this.btnSortPri.Text = "Mức ưu tiên ↑";
            this.btnSortPri.UseVisualStyleBackColor = true;
            // 
            // dgvHistory
            // 
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvHistory.Location = new System.Drawing.Point(0, 214);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.RowHeadersWidth = 102;
            this.dgvHistory.RowTemplate.Height = 40;
            this.dgvHistory.Size = new System.Drawing.Size(733, 694);
            this.dgvHistory.TabIndex = 6;
            // 
            // chartPie
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPie.ChartAreas.Add(chartArea1);
            this.chartPie.Dock = System.Windows.Forms.DockStyle.Right;
            legend1.Name = "Legend1";
            this.chartPie.Legends.Add(legend1);
            this.chartPie.Location = new System.Drawing.Point(739, 214);
            this.chartPie.Name = "chartPie";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPie.Series.Add(series1);
            this.chartPie.Size = new System.Drawing.Size(404, 694);
            this.chartPie.TabIndex = 7;
            this.chartPie.Text = "chart1";
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 908);
            this.Controls.Add(this.chartPie);
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.pnlSort);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormReport";
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlStats.ResumeLayout(false);
            this.pnlSort.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Label lblAvgWait;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblEmergency;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.Label lblWaiting;
        private System.Windows.Forms.Panel pnlSort;
        private System.Windows.Forms.Button btnSortArrAsc;
        private System.Windows.Forms.Button btnSortArrDesc;
        private System.Windows.Forms.Button btnSortWait;
        private System.Windows.Forms.Button btnSortPri;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPie;
        private void FormReport_Load(object sender, EventArgs e)
        {
            // Để trống cũng được, chỉ cần có tên hàm để Designer không báo lỗi
        }
    }
}