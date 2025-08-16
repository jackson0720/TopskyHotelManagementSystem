namespace EOM.TSHotelManagement.FormUI
{
    partial class FrmReserManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReserManager));
            label1 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            btnReserList = new AntdUI.Button();
            btnReser = new AntdUI.Button();
            txtCustoName = new AntdUI.Input();
            txtCustoTel = new AntdUI.Input();
            cboReserWay = new AntdUI.Dropdown();
            cboReserRoomNo = new AntdUI.Dropdown();
            dtpStartDate = new AntdUI.DatePicker();
            dtpEndDate = new AntdUI.DatePicker();
            whReserRoomManagement = new ucWindowHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(291, 56);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 106;
            label1.Text = "预约号码";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label9.Location = new Point(14, 59);
            label9.Name = "label9";
            label9.Size = new Size(88, 25);
            label9.TabIndex = 105;
            label9.Text = "客户姓名";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label10.Location = new Point(16, 106);
            label10.Name = "label10";
            label10.Size = new Size(88, 25);
            label10.TabIndex = 109;
            label10.Text = "预约渠道";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label11.Location = new Point(292, 104);
            label11.Name = "label11";
            label11.Size = new Size(88, 25);
            label11.TabIndex = 111;
            label11.Text = "预约房号";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label12.Location = new Point(14, 153);
            label12.Name = "label12";
            label12.Size = new Size(88, 25);
            label12.TabIndex = 113;
            label12.Text = "预约起始";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label13.Location = new Point(292, 152);
            label13.Name = "label13";
            label13.Size = new Size(88, 25);
            label13.TabIndex = 115;
            label13.Text = "预约止日";
            // 
            // btnReserList
            // 
            btnReserList.Font = new Font("Noto Sans SC", 12F);
            btnReserList.Location = new Point(316, 195);
            btnReserList.Name = "btnReserList";
            btnReserList.Size = new Size(139, 43);
            btnReserList.TabIndex = 118;
            btnReserList.Text = "查看预约列表";
            btnReserList.Click += btnReserList_Click;
            // 
            // btnReser
            // 
            btnReser.Font = new Font("Noto Sans SC", 12F);
            btnReser.Location = new Point(461, 195);
            btnReser.Name = "btnReser";
            btnReser.Size = new Size(87, 43);
            btnReser.TabIndex = 119;
            btnReser.Text = "预   约";
            btnReser.Type = AntdUI.TTypeMini.Info;
            btnReser.Click += btnReser_Click;
            // 
            // txtCustoName
            // 
            txtCustoName.Font = new Font("Noto Sans SC", 12F);
            txtCustoName.Location = new Point(107, 49);
            txtCustoName.Name = "txtCustoName";
            txtCustoName.Size = new Size(162, 45);
            txtCustoName.TabIndex = 121;
            // 
            // txtCustoTel
            // 
            txtCustoTel.Font = new Font("Noto Sans SC", 12F);
            txtCustoTel.Location = new Point(384, 49);
            txtCustoTel.Name = "txtCustoTel";
            txtCustoTel.Size = new Size(162, 45);
            txtCustoTel.TabIndex = 122;
            // 
            // cboReserWay
            // 
            cboReserWay.DropDownArrow = true;
            cboReserWay.Font = new Font("Noto Sans SC", 12F);
            cboReserWay.Location = new Point(107, 100);
            cboReserWay.Name = "cboReserWay";
            cboReserWay.Placement = AntdUI.TAlignFrom.Bottom;
            cboReserWay.Size = new Size(159, 40);
            cboReserWay.TabIndex = 123;
            cboReserWay.ToggleType = AntdUI.TTypeMini.Info;
            // 
            // cboReserRoomNo
            // 
            cboReserRoomNo.DropDownArrow = true;
            cboReserRoomNo.Font = new Font("Noto Sans SC", 12F);
            cboReserRoomNo.Location = new Point(386, 100);
            cboReserRoomNo.Name = "cboReserRoomNo";
            cboReserRoomNo.Placement = AntdUI.TAlignFrom.Bottom;
            cboReserRoomNo.Size = new Size(157, 40);
            cboReserRoomNo.TabIndex = 124;
            cboReserRoomNo.ToggleType = AntdUI.TTypeMini.Info;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Font = new Font("Noto Sans SC", 10F);
            dtpStartDate.Location = new Point(107, 146);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(162, 43);
            dtpStartDate.TabIndex = 125;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Font = new Font("Noto Sans SC", 10F);
            dtpEndDate.Location = new Point(384, 146);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(162, 43);
            dtpEndDate.TabIndex = 126;
            // 
            // whReserRoomManagement
            // 
            whReserRoomManagement.Location = new Point(0, 0);
            whReserRoomManagement.Name = "whReserRoomManagement";
            whReserRoomManagement.Size = new Size(562, 34);
            whReserRoomManagement.TabIndex = 141;
            // 
            // FrmReserManager
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(235, 243, 255);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(560, 251);
            Controls.Add(whReserRoomManagement);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(cboReserRoomNo);
            Controls.Add(cboReserWay);
            Controls.Add(txtCustoTel);
            Controls.Add(txtCustoName);
            Controls.Add(btnReser);
            Controls.Add(btnReserList);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label1);
            Controls.Add(label9);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmReserManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "预约管理";
            Load += FrmRoomManager_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private AntdUI.Button btnReserList;
        private AntdUI.Button btnReser;
        private AntdUI.Input txtCustoName;
        private AntdUI.Input txtCustoTel;
        private AntdUI.Dropdown cboReserWay;
        private AntdUI.Dropdown cboReserRoomNo;
        private AntdUI.DatePicker dtpStartDate;
        private AntdUI.DatePicker dtpEndDate;
        private ucWindowHeader whReserRoomManagement;
    }
}