namespace PhongKham.GUI
{
    partial class FormReception
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnTake = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblAutoDetect = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.rdoNormal = new System.Windows.Forms.RadioButton();
            this.rdoPriority = new System.Windows.Forms.RadioButton();
            this.rdoEmergency = new System.Windows.Forms.RadioButton();
            this.lblPriority = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cboRoom = new System.Windows.Forms.ComboBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblPreviewInfo = new System.Windows.Forms.Label();
            this.lblPreviewNum = new System.Windows.Forms.Label();
            this.lblPreviewTitle = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1108, 64);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(477, 14);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(277, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📋 TIẾP NHẬN BỆNH NHÂN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Controls.Add(this.btnClear);
            this.pnlLeft.Controls.Add(this.btnTake);
            this.pnlLeft.Controls.Add(this.txtNotes);
            this.pnlLeft.Controls.Add(this.lblAutoDetect);
            this.pnlLeft.Controls.Add(this.lblNotes);
            this.pnlLeft.Controls.Add(this.rdoNormal);
            this.pnlLeft.Controls.Add(this.rdoPriority);
            this.pnlLeft.Controls.Add(this.rdoEmergency);
            this.pnlLeft.Controls.Add(this.lblPriority);
            this.pnlLeft.Controls.Add(this.txtPhone);
            this.pnlLeft.Controls.Add(this.lblPhone);
            this.pnlLeft.Controls.Add(this.txtAge);
            this.pnlLeft.Controls.Add(this.lblAge);
            this.pnlLeft.Controls.Add(this.txtName);
            this.pnlLeft.Controls.Add(this.lblName);
            this.pnlLeft.Controls.Add(this.cboRoom);
            this.pnlLeft.Controls.Add(this.lblRoom);
            this.pnlLeft.Location = new System.Drawing.Point(12, 89);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(669, 489);
            this.pnlLeft.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(320, 369);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 46);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "🗑 Xoá";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnTake
            // 
            this.btnTake.BackColor = System.Drawing.Color.Green;
            this.btnTake.ForeColor = System.Drawing.Color.White;
            this.btnTake.Location = new System.Drawing.Point(54, 369);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(198, 46);
            this.btnTake.TabIndex = 15;
            this.btnTake.Text = "✅ CẤP SỐ PHIẾU";
            this.btnTake.UseVisualStyleBackColor = false;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(117, 292);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(300, 33);
            this.txtNotes.TabIndex = 14;
            // 
            // lblAutoDetect
            // 
            this.lblAutoDetect.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblAutoDetect.Location = new System.Drawing.Point(496, 38);
            this.lblAutoDetect.Name = "lblAutoDetect";
            this.lblAutoDetect.Size = new System.Drawing.Size(141, 59);
            this.lblAutoDetect.TabIndex = 6;
            this.lblAutoDetect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(6, 295);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(158, 46);
            this.lblNotes.TabIndex = 13;
            this.lblNotes.Text = "Ghi chú";
            // 
            // rdoNormal
            // 
            this.rdoNormal.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoNormal.Checked = true;
            this.rdoNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoNormal.Location = new System.Drawing.Point(434, 214);
            this.rdoNormal.Name = "rdoNormal";
            this.rdoNormal.Size = new System.Drawing.Size(150, 40);
            this.rdoNormal.TabIndex = 12;
            this.rdoNormal.TabStop = true;
            this.rdoNormal.Text = "🟢 Thường";
            this.rdoNormal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoNormal.UseVisualStyleBackColor = true;
            // 
            // rdoPriority
            // 
            this.rdoPriority.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoPriority.Location = new System.Drawing.Point(274, 214);
            this.rdoPriority.Name = "rdoPriority";
            this.rdoPriority.Size = new System.Drawing.Size(114, 40);
            this.rdoPriority.TabIndex = 11;
            this.rdoPriority.Text = "🟡 Ưu tiên";
            this.rdoPriority.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoPriority.UseVisualStyleBackColor = true;
            // 
            // rdoEmergency
            // 
            this.rdoEmergency.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoEmergency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoEmergency.Location = new System.Drawing.Point(115, 214);
            this.rdoEmergency.Name = "rdoEmergency";
            this.rdoEmergency.Size = new System.Drawing.Size(120, 40);
            this.rdoEmergency.TabIndex = 10;
            this.rdoEmergency.Text = "🔴 Cấp cứu";
            this.rdoEmergency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoEmergency.UseVisualStyleBackColor = true;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(4, 234);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(252, 46);
            this.lblPriority.TabIndex = 9;
            this.lblPriority.Text = "Mức ưu tiên *";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(117, 171);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 53);
            this.txtPhone.TabIndex = 8;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(3, 177);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(254, 46);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "Số điện thoại";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(117, 118);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(80, 53);
            this.txtAge.TabIndex = 5;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(3, 124);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(124, 46);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Tuổi *";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 53);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(164, 46);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Họ tên *";
            // 
            // cboRoom
            // 
            this.cboRoom.FormattingEnabled = true;
            this.cboRoom.Location = new System.Drawing.Point(117, 20);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(300, 54);
            this.cboRoom.TabIndex = 1;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(3, 20);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(270, 46);
            this.lblRoom.TabIndex = 0;
            this.lblRoom.Text = "Phòng khám *";
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlRight.Controls.Add(this.lblPreviewInfo);
            this.pnlRight.Controls.Add(this.lblPreviewNum);
            this.pnlRight.Controls.Add(this.lblPreviewTitle);
            this.pnlRight.Location = new System.Drawing.Point(710, 89);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(373, 489);
            this.pnlRight.TabIndex = 2;
            // 
            // lblPreviewInfo
            // 
            this.lblPreviewInfo.BackColor = System.Drawing.Color.White;
            this.lblPreviewInfo.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviewInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblPreviewInfo.Location = new System.Drawing.Point(127, 295);
            this.lblPreviewInfo.Name = "lblPreviewInfo";
            this.lblPreviewInfo.Size = new System.Drawing.Size(146, 73);
            this.lblPreviewInfo.TabIndex = 19;
            this.lblPreviewInfo.Text = "---";
            this.lblPreviewInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPreviewNum
            // 
            this.lblPreviewNum.BackColor = System.Drawing.Color.White;
            this.lblPreviewNum.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviewNum.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblPreviewNum.Location = new System.Drawing.Point(127, 118);
            this.lblPreviewNum.Name = "lblPreviewNum";
            this.lblPreviewNum.Size = new System.Drawing.Size(146, 73);
            this.lblPreviewNum.TabIndex = 18;
            this.lblPreviewNum.Text = "---";
            this.lblPreviewNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPreviewTitle
            // 
            this.lblPreviewTitle.AutoSize = true;
            this.lblPreviewTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviewTitle.Location = new System.Drawing.Point(111, 38);
            this.lblPreviewTitle.Name = "lblPreviewTitle";
            this.lblPreviewTitle.Size = new System.Drawing.Size(406, 46);
            this.lblPreviewTitle.TabIndex = 17;
            this.lblPreviewTitle.Text = "PHIẾU KHÁM BỆNH";
            // 
            // FormReception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 619);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormReception";
            this.Text = "Tiếp nhận - Lấy số";
            this.pnlHeader.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.ComboBox cboRoom;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblAutoDetect;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.RadioButton rdoEmergency;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.RadioButton rdoNormal;
        private System.Windows.Forms.RadioButton rdoPriority;
        private System.Windows.Forms.Label lblPreviewTitle;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblPreviewInfo;
        private System.Windows.Forms.Label lblPreviewNum;
    }
}