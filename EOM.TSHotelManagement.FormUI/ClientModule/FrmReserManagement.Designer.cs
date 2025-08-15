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
            btnReserList = new Sunny.UI.UIButton();
            txtCustoName = new Sunny.UI.UITextBox();
            txtCustoTel = new Sunny.UI.UITextBox();
            label1 = new Label();
            label9 = new Label();
            cboReserWay = new Sunny.UI.UIComboBox();
            label10 = new Label();
            cboReserRoomNo = new Sunny.UI.UIComboBox();
            label11 = new Label();
            dtpBookDate = new Sunny.UI.UIDatePicker();
            label12 = new Label();
            dtpEndDate = new Sunny.UI.UIDatePicker();
            label13 = new Label();
            btnReser = new Sunny.UI.UIButton();
            SuspendLayout();
            // 
            // btnReserList
            // 
            btnReserList.Cursor = Cursors.Hand;
            btnReserList.Font = new Font("微软雅黑", 12F);
            btnReserList.Location = new Point(89, 50);
            btnReserList.MinimumSize = new Size(1, 1);
            btnReserList.Name = "btnReserList";
            btnReserList.Radius = 15;
            btnReserList.Size = new Size(136, 35);
            btnReserList.Style = Sunny.UI.UIStyle.Custom;
            btnReserList.TabIndex = 72;
            btnReserList.Text = "查看预约列表";
            btnReserList.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnReserList.Click += btnReserList_Click;
            // 
            // txtCustoName
            // 
            txtCustoName.Cursor = Cursors.IBeam;
            txtCustoName.Font = new Font("微软雅黑", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtCustoName.Location = new Point(122, 94);
            txtCustoName.Margin = new Padding(4, 5, 4, 5);
            txtCustoName.MinimumSize = new Size(1, 1);
            txtCustoName.Name = "txtCustoName";
            txtCustoName.Padding = new Padding(5);
            txtCustoName.Radius = 20;
            txtCustoName.ShowText = false;
            txtCustoName.Size = new Size(159, 35);
            txtCustoName.Style = Sunny.UI.UIStyle.Custom;
            txtCustoName.StyleCustomMode = true;
            txtCustoName.TabIndex = 107;
            txtCustoName.TextAlignment = ContentAlignment.MiddleLeft;
            txtCustoName.Watermark = "";
            // 
            // txtCustoTel
            // 
            txtCustoTel.Cursor = Cursors.IBeam;
            txtCustoTel.Font = new Font("微软雅黑", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtCustoTel.Location = new Point(122, 147);
            txtCustoTel.Margin = new Padding(4, 5, 4, 5);
            txtCustoTel.MaxLength = 11;
            txtCustoTel.MinimumSize = new Size(1, 1);
            txtCustoTel.Name = "txtCustoTel";
            txtCustoTel.Padding = new Padding(5);
            txtCustoTel.Radius = 20;
            txtCustoTel.ShowText = false;
            txtCustoTel.Size = new Size(159, 35);
            txtCustoTel.Style = Sunny.UI.UIStyle.Custom;
            txtCustoTel.StyleCustomMode = true;
            txtCustoTel.TabIndex = 108;
            txtCustoTel.TextAlignment = ContentAlignment.MiddleLeft;
            txtCustoTel.Watermark = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(30, 151);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 106;
            label1.Text = "预约号码";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label9.Location = new Point(30, 99);
            label9.Name = "label9";
            label9.Size = new Size(88, 25);
            label9.TabIndex = 105;
            label9.Text = "客户姓名";
            // 
            // cboReserWay
            // 
            cboReserWay.DataSource = null;
            cboReserWay.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cboReserWay.FillColor = Color.White;
            cboReserWay.Font = new Font("微软雅黑", 15.75F);
            cboReserWay.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cboReserWay.Items.AddRange(new object[] { "前台", "小程序", "电话" });
            cboReserWay.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cboReserWay.Location = new Point(122, 200);
            cboReserWay.Margin = new Padding(4, 5, 4, 5);
            cboReserWay.MinimumSize = new Size(63, 0);
            cboReserWay.Name = "cboReserWay";
            cboReserWay.Padding = new Padding(0, 0, 30, 2);
            cboReserWay.Radius = 20;
            cboReserWay.ReadOnly = true;
            cboReserWay.Size = new Size(159, 35);
            cboReserWay.Style = Sunny.UI.UIStyle.Custom;
            cboReserWay.SymbolSize = 24;
            cboReserWay.TabIndex = 110;
            cboReserWay.TextAlignment = ContentAlignment.MiddleLeft;
            cboReserWay.Watermark = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label10.Location = new Point(33, 203);
            label10.Name = "label10";
            label10.Size = new Size(88, 25);
            label10.TabIndex = 109;
            label10.Text = "预约渠道";
            // 
            // cboReserRoomNo
            // 
            cboReserRoomNo.DataSource = null;
            cboReserRoomNo.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cboReserRoomNo.FillColor = Color.White;
            cboReserRoomNo.Font = new Font("微软雅黑", 15.75F);
            cboReserRoomNo.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cboReserRoomNo.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cboReserRoomNo.Location = new Point(122, 253);
            cboReserRoomNo.Margin = new Padding(4, 5, 4, 5);
            cboReserRoomNo.MinimumSize = new Size(63, 0);
            cboReserRoomNo.Name = "cboReserRoomNo";
            cboReserRoomNo.Padding = new Padding(0, 0, 30, 2);
            cboReserRoomNo.Radius = 20;
            cboReserRoomNo.Size = new Size(159, 35);
            cboReserRoomNo.Style = Sunny.UI.UIStyle.Custom;
            cboReserRoomNo.SymbolSize = 24;
            cboReserRoomNo.TabIndex = 112;
            cboReserRoomNo.TextAlignment = ContentAlignment.MiddleLeft;
            cboReserRoomNo.Watermark = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label11.Location = new Point(33, 255);
            label11.Name = "label11";
            label11.Size = new Size(88, 25);
            label11.TabIndex = 111;
            label11.Text = "预约房号";
            // 
            // dtpBookDate
            // 
            dtpBookDate.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            dtpBookDate.FillColor = Color.White;
            dtpBookDate.Font = new Font("Microsoft Sans Serif", 15.75F);
            dtpBookDate.Location = new Point(122, 307);
            dtpBookDate.Margin = new Padding(4, 5, 4, 5);
            dtpBookDate.MaxLength = 10;
            dtpBookDate.MinimumSize = new Size(63, 0);
            dtpBookDate.Name = "dtpBookDate";
            dtpBookDate.Padding = new Padding(0, 0, 30, 2);
            dtpBookDate.Radius = 20;
            dtpBookDate.Size = new Size(159, 31);
            dtpBookDate.Style = Sunny.UI.UIStyle.Custom;
            dtpBookDate.SymbolDropDown = 61555;
            dtpBookDate.SymbolNormal = 61555;
            dtpBookDate.SymbolSize = 24;
            dtpBookDate.TabIndex = 114;
            dtpBookDate.Text = "2021-05-13";
            dtpBookDate.TextAlignment = ContentAlignment.MiddleLeft;
            dtpBookDate.Value = new DateTime(2021, 5, 13, 0, 0, 0, 0);
            dtpBookDate.Watermark = "";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label12.Location = new Point(30, 307);
            label12.Name = "label12";
            label12.Size = new Size(88, 25);
            label12.TabIndex = 113;
            label12.Text = "预约起始";
            // 
            // dtpEndDate
            // 
            dtpEndDate.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            dtpEndDate.FillColor = Color.White;
            dtpEndDate.Font = new Font("Microsoft Sans Serif", 15.75F);
            dtpEndDate.Location = new Point(125, 356);
            dtpEndDate.Margin = new Padding(4, 5, 4, 5);
            dtpEndDate.MaxLength = 10;
            dtpEndDate.MinimumSize = new Size(63, 0);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Padding = new Padding(0, 0, 30, 2);
            dtpEndDate.Radius = 20;
            dtpEndDate.Size = new Size(156, 31);
            dtpEndDate.Style = Sunny.UI.UIStyle.Custom;
            dtpEndDate.SymbolDropDown = 61555;
            dtpEndDate.SymbolNormal = 61555;
            dtpEndDate.SymbolSize = 24;
            dtpEndDate.TabIndex = 116;
            dtpEndDate.Text = "2021-05-13";
            dtpEndDate.TextAlignment = ContentAlignment.MiddleLeft;
            dtpEndDate.Value = new DateTime(2021, 5, 13, 0, 0, 0, 0);
            dtpEndDate.Watermark = "";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label13.Location = new Point(33, 359);
            label13.Name = "label13";
            label13.Size = new Size(88, 25);
            label13.TabIndex = 115;
            label13.Text = "预约止日";
            // 
            // btnReser
            // 
            btnReser.Cursor = Cursors.Hand;
            btnReser.Font = new Font("微软雅黑", 12F);
            btnReser.Location = new Point(109, 411);
            btnReser.MinimumSize = new Size(1, 1);
            btnReser.Name = "btnReser";
            btnReser.Radius = 15;
            btnReser.Size = new Size(97, 35);
            btnReser.Style = Sunny.UI.UIStyle.Custom;
            btnReser.TabIndex = 117;
            btnReser.Text = "预约";
            btnReser.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnReser.Click += btnReser_Click;
            // 
            // FrmReserManager
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(235, 243, 255);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(315, 461);
            Controls.Add(btnReser);
            Controls.Add(dtpEndDate);
            Controls.Add(label13);
            Controls.Add(dtpBookDate);
            Controls.Add(label12);
            Controls.Add(cboReserRoomNo);
            Controls.Add(label11);
            Controls.Add(cboReserWay);
            Controls.Add(label10);
            Controls.Add(txtCustoName);
            Controls.Add(txtCustoTel);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(btnReserList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmReserManager";
            ShowTitleIcon = true;
            Style = Sunny.UI.UIStyle.Custom;
            Text = "预约管理";
            ZoomScaleRect = new Rectangle(15, 15, 315, 461);
            Load += FrmRoomManager_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Sunny.UI.UIButton btnReserList;
        private Sunny.UI.UITextBox txtCustoName;
        private Sunny.UI.UITextBox txtCustoTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private Sunny.UI.UIComboBox cboReserWay;
        private System.Windows.Forms.Label label10;
        private Sunny.UI.UIComboBox cboReserRoomNo;
        private System.Windows.Forms.Label label11;
        private Sunny.UI.UIDatePicker dtpBookDate;
        private System.Windows.Forms.Label label12;
        private Sunny.UI.UIDatePicker dtpEndDate;
        private System.Windows.Forms.Label label13;
        private Sunny.UI.UIButton btnReser;
    }
}