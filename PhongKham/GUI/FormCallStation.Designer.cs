using System;

namespace PhongKham.GUI
{
    partial class FormCallStation
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.cboRoom = new System.Windows.Forms.ComboBox();
            this.lblRoomLabel = new System.Windows.Forms.Label();
            this.lblCurrentNum = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnCallNext = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.dgvQueue = new System.Windows.Forms.DataGridView();
            this.lblQueueTitle = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Navy;
            this.pnlTop.Controls.Add(this.cboRoom);
            this.pnlTop.Controls.Add(this.lblRoomLabel);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1004, 59);
            this.pnlTop.TabIndex = 0;
            // 
            // cboRoom
            // 
            this.cboRoom.FormattingEnabled = true;
            this.cboRoom.Location = new System.Drawing.Point(105, 9);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(309, 54);
            this.cboRoom.TabIndex = 2;
            // 
            // lblRoomLabel
            // 
            this.lblRoomLabel.Location = new System.Drawing.Point(28, 8);
            this.lblRoomLabel.Name = "lblRoomLabel";
            this.lblRoomLabel.Size = new System.Drawing.Size(67, 29);
            this.lblRoomLabel.TabIndex = 1;
            this.lblRoomLabel.Text = "Phòng:";
            this.lblRoomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentNum
            // 
            this.lblCurrentNum.Font = new System.Drawing.Font("Courier New", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentNum.ForeColor = System.Drawing.Color.Gold;
            this.lblCurrentNum.Location = new System.Drawing.Point(23, 71);
            this.lblCurrentNum.Name = "lblCurrentNum";
            this.lblCurrentNum.Size = new System.Drawing.Size(180, 78);
            this.lblCurrentNum.TabIndex = 3;
            // 
            // lblPatientName
            // 
            this.lblPatientName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(73, 129);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(372, 46);
            this.lblPatientName.TabIndex = 4;
            this.lblPatientName.Text = " ";
            this.lblPatientName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPatientName.Click += new System.EventHandler(this.lblPatientName_Click);
            // 
            // lblPriority
            // 
            this.lblPriority.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.Location = new System.Drawing.Point(68, 199);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(372, 46);
            this.lblPriority.TabIndex = 5;
            this.lblPriority.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Courier New", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.LightGreen;
            this.lblTimer.Location = new System.Drawing.Point(117, 256);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(286, 65);
            this.lblTimer.TabIndex = 6;
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimer.Click += new System.EventHandler(this.lblTimer_Click);
            // 
            // btnCallNext
            // 
            this.btnCallNext.BackColor = System.Drawing.Color.Green;
            this.btnCallNext.Location = new System.Drawing.Point(110, 356);
            this.btnCallNext.Name = "btnCallNext";
            this.btnCallNext.Size = new System.Drawing.Size(296, 43);
            this.btnCallNext.TabIndex = 7;
            this.btnCallNext.Text = "▶ GỌI TIẾP THEO";
            this.btnCallNext.UseVisualStyleBackColor = false;
            // 
            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSkip.Location = new System.Drawing.Point(110, 423);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(296, 43);
            this.btnSkip.TabIndex = 8;
            this.btnSkip.Text = "⏭ BỎ QUA";
            this.btnSkip.UseVisualStyleBackColor = false;
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnComplete.Location = new System.Drawing.Point(110, 488);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(296, 43);
            this.btnComplete.TabIndex = 9;
            this.btnComplete.Text = "✅ HOÀN THÀNH";
            this.btnComplete.UseVisualStyleBackColor = false;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlRight.Controls.Add(this.dgvQueue);
            this.pnlRight.Controls.Add(this.lblQueueTitle);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(514, 59);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(490, 514);
            this.pnlRight.TabIndex = 10;
            // 
            // dgvQueue
            // 
            this.dgvQueue.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dgvQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQueue.Location = new System.Drawing.Point(0, 0);
            this.dgvQueue.Name = "dgvQueue";
            this.dgvQueue.RowHeadersWidth = 102;
            this.dgvQueue.RowTemplate.Height = 40;
            this.dgvQueue.Size = new System.Drawing.Size(490, 514);
            this.dgvQueue.TabIndex = 1;
            this.dgvQueue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQueue_CellContentClick);
            // 
            // lblQueueTitle
            // 
            this.lblQueueTitle.AutoSize = true;
            this.lblQueueTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueueTitle.ForeColor = System.Drawing.Color.Gold;
            this.lblQueueTitle.Location = new System.Drawing.Point(46, 44);
            this.lblQueueTitle.Name = "lblQueueTitle";
            this.lblQueueTitle.Size = new System.Drawing.Size(412, 46);
            this.lblQueueTitle.TabIndex = 0;
            this.lblQueueTitle.Text = "HÀNG ĐỢI HIỆN TẠI";
            // 
            // FormCallStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1004, 573);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnCallNext);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.lblCurrentNum);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCallStation";
            this.Text = "Màn hình gọi số";
            this.Load += new System.EventHandler(this.FormCallStation_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblRoomLabel;
        private System.Windows.Forms.ComboBox cboRoom;
        private System.Windows.Forms.Label lblCurrentNum;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnCallNext;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.DataGridView dgvQueue;
        private System.Windows.Forms.Label lblQueueTitle;
        private void FormCallStation_Load(object sender, EventArgs e)
        {
        }
    }
}