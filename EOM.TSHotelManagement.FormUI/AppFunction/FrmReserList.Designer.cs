namespace EOM.TSHotelManagement.FormUI
{
    partial class FrmReserList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReserList));
            cbCustoType = new Sunny.UI.UIComboBox();
            cbPassportType = new Sunny.UI.UIComboBox();
            cbSex = new Sunny.UI.UIComboBox();
            txtCustoNo = new Sunny.UI.UITextBox();
            txtCustoName = new Sunny.UI.UITextBox();
            txtCardID = new Sunny.UI.UITextBox();
            txtTel = new Sunny.UI.UITextBox();
            dtpBirthday = new Sunny.UI.UIDatePicker();
            txtCustoAdress = new Sunny.UI.UITextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnSelect = new Sunny.UI.UIButton();
            dgvReserList = new AntdUI.Table();
            btnPg = new AntdUI.Pagination();
            SuspendLayout();
            // 
            // cbCustoType
            // 
            cbCustoType.DataSource = null;
            cbCustoType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbCustoType.FillColor = Color.White;
            cbCustoType.Font = new Font("微软雅黑", 15.75F);
            cbCustoType.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbCustoType.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbCustoType.Location = new Point(499, 290);
            cbCustoType.Margin = new Padding(4, 5, 4, 5);
            cbCustoType.MinimumSize = new Size(63, 0);
            cbCustoType.Name = "cbCustoType";
            cbCustoType.Padding = new Padding(0, 0, 30, 2);
            cbCustoType.Radius = 20;
            cbCustoType.ReadOnly = true;
            cbCustoType.Size = new Size(250, 35);
            cbCustoType.SymbolSize = 24;
            cbCustoType.TabIndex = 134;
            cbCustoType.TextAlignment = ContentAlignment.MiddleLeft;
            cbCustoType.Watermark = "";
            // 
            // cbPassportType
            // 
            cbPassportType.DataSource = null;
            cbPassportType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbPassportType.FillColor = Color.White;
            cbPassportType.Font = new Font("微软雅黑", 15.75F);
            cbPassportType.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbPassportType.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbPassportType.Location = new Point(499, 341);
            cbPassportType.Margin = new Padding(4, 5, 4, 5);
            cbPassportType.MinimumSize = new Size(63, 0);
            cbPassportType.Name = "cbPassportType";
            cbPassportType.Padding = new Padding(0, 0, 30, 2);
            cbPassportType.Radius = 20;
            cbPassportType.Size = new Size(250, 35);
            cbPassportType.SymbolSize = 24;
            cbPassportType.TabIndex = 133;
            cbPassportType.TextAlignment = ContentAlignment.MiddleLeft;
            cbPassportType.Watermark = "";
            // 
            // cbSex
            // 
            cbSex.DataSource = null;
            cbSex.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbSex.FillColor = Color.White;
            cbSex.Font = new Font("微软雅黑", 15.75F);
            cbSex.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbSex.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbSex.Location = new Point(123, 397);
            cbSex.Margin = new Padding(4, 5, 4, 5);
            cbSex.MinimumSize = new Size(63, 0);
            cbSex.Name = "cbSex";
            cbSex.Padding = new Padding(0, 0, 30, 2);
            cbSex.Radius = 20;
            cbSex.Size = new Size(250, 35);
            cbSex.SymbolSize = 24;
            cbSex.TabIndex = 132;
            cbSex.TextAlignment = ContentAlignment.MiddleLeft;
            cbSex.Watermark = "";
            // 
            // txtCustoNo
            // 
            txtCustoNo.Cursor = Cursors.IBeam;
            txtCustoNo.Font = new Font("微软雅黑", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtCustoNo.Location = new Point(123, 293);
            txtCustoNo.Margin = new Padding(4, 5, 4, 5);
            txtCustoNo.MinimumSize = new Size(1, 1);
            txtCustoNo.Name = "txtCustoNo";
            txtCustoNo.Padding = new Padding(5);
            txtCustoNo.Radius = 20;
            txtCustoNo.ReadOnly = true;
            txtCustoNo.ShowText = false;
            txtCustoNo.Size = new Size(250, 35);
            txtCustoNo.Style = Sunny.UI.UIStyle.Custom;
            txtCustoNo.StyleCustomMode = true;
            txtCustoNo.TabIndex = 131;
            txtCustoNo.TextAlignment = ContentAlignment.MiddleLeft;
            txtCustoNo.Watermark = "";
            // 
            // txtCustoName
            // 
            txtCustoName.Cursor = Cursors.IBeam;
            txtCustoName.Font = new Font("微软雅黑", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtCustoName.Location = new Point(123, 345);
            txtCustoName.Margin = new Padding(4, 5, 4, 5);
            txtCustoName.MinimumSize = new Size(1, 1);
            txtCustoName.Name = "txtCustoName";
            txtCustoName.Padding = new Padding(5);
            txtCustoName.Radius = 20;
            txtCustoName.ShowText = false;
            txtCustoName.Size = new Size(250, 35);
            txtCustoName.Style = Sunny.UI.UIStyle.Custom;
            txtCustoName.StyleCustomMode = true;
            txtCustoName.TabIndex = 130;
            txtCustoName.TextAlignment = ContentAlignment.MiddleLeft;
            txtCustoName.Watermark = "";
            // 
            // txtCardID
            // 
            txtCardID.Cursor = Cursors.IBeam;
            txtCardID.Font = new Font("微软雅黑", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtCardID.Location = new Point(499, 392);
            txtCardID.Margin = new Padding(4, 5, 4, 5);
            txtCardID.MinimumSize = new Size(1, 1);
            txtCardID.Name = "txtCardID";
            txtCardID.Padding = new Padding(5);
            txtCardID.Radius = 20;
            txtCardID.ShowText = false;
            txtCardID.Size = new Size(250, 35);
            txtCardID.Style = Sunny.UI.UIStyle.Custom;
            txtCardID.StyleCustomMode = true;
            txtCardID.TabIndex = 129;
            txtCardID.TextAlignment = ContentAlignment.MiddleLeft;
            txtCardID.Watermark = "";
            txtCardID.Validated += txtCardID_Validated;
            // 
            // txtTel
            // 
            txtTel.Cursor = Cursors.IBeam;
            txtTel.Font = new Font("微软雅黑", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtTel.Location = new Point(499, 443);
            txtTel.Margin = new Padding(4, 5, 4, 5);
            txtTel.MinimumSize = new Size(1, 1);
            txtTel.Name = "txtTel";
            txtTel.Padding = new Padding(5);
            txtTel.Radius = 20;
            txtTel.ShowText = false;
            txtTel.Size = new Size(250, 35);
            txtTel.Style = Sunny.UI.UIStyle.Custom;
            txtTel.StyleCustomMode = true;
            txtTel.TabIndex = 128;
            txtTel.TextAlignment = ContentAlignment.MiddleLeft;
            txtTel.Watermark = "";
            // 
            // dtpBirthday
            // 
            dtpBirthday.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            dtpBirthday.FillColor = Color.White;
            dtpBirthday.Font = new Font("Microsoft Sans Serif", 15.75F);
            dtpBirthday.Location = new Point(123, 449);
            dtpBirthday.Margin = new Padding(4, 5, 4, 5);
            dtpBirthday.MaxLength = 10;
            dtpBirthday.MinimumSize = new Size(63, 0);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Padding = new Padding(0, 0, 30, 2);
            dtpBirthday.Radius = 20;
            dtpBirthday.ReadOnly = true;
            dtpBirthday.Size = new Size(250, 31);
            dtpBirthday.SymbolDropDown = 61555;
            dtpBirthday.SymbolNormal = 61555;
            dtpBirthday.SymbolSize = 24;
            dtpBirthday.TabIndex = 127;
            dtpBirthday.Text = "2020-11-24";
            dtpBirthday.TextAlignment = ContentAlignment.MiddleLeft;
            dtpBirthday.Value = new DateTime(2020, 11, 24, 22, 50, 36, 791);
            dtpBirthday.Watermark = "";
            // 
            // txtCustoAdress
            // 
            txtCustoAdress.Cursor = Cursors.IBeam;
            txtCustoAdress.Font = new Font("微软雅黑", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtCustoAdress.Location = new Point(121, 497);
            txtCustoAdress.Margin = new Padding(4, 5, 4, 5);
            txtCustoAdress.MinimumSize = new Size(1, 1);
            txtCustoAdress.Name = "txtCustoAdress";
            txtCustoAdress.Padding = new Padding(5);
            txtCustoAdress.Radius = 20;
            txtCustoAdress.ShowText = false;
            txtCustoAdress.Size = new Size(628, 35);
            txtCustoAdress.Style = Sunny.UI.UIStyle.Custom;
            txtCustoAdress.StyleCustomMode = true;
            txtCustoAdress.TabIndex = 126;
            txtCustoAdress.TextAlignment = ContentAlignment.MiddleLeft;
            txtCustoAdress.Watermark = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label10.Location = new Point(14, 505);
            label10.Name = "label10";
            label10.Size = new Size(88, 25);
            label10.TabIndex = 122;
            label10.Text = "居住地址";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label9.Location = new Point(403, 450);
            label9.Name = "label9";
            label9.Size = new Size(88, 25);
            label9.TabIndex = 121;
            label9.Text = "联系方式";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label8.Location = new Point(403, 399);
            label8.Name = "label8";
            label8.Size = new Size(88, 25);
            label8.TabIndex = 120;
            label8.Text = "证件号码";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label7.Location = new Point(403, 348);
            label7.Name = "label7";
            label7.Size = new Size(88, 25);
            label7.TabIndex = 119;
            label7.Text = "证件类型";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label6.Location = new Point(403, 297);
            label6.Name = "label6";
            label6.Size = new Size(88, 25);
            label6.TabIndex = 118;
            label6.Text = "客户类型";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label5.Location = new Point(16, 453);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 117;
            label5.Text = "出生日期";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label4.Location = new Point(16, 401);
            label4.Name = "label4";
            label4.Size = new Size(86, 25);
            label4.TabIndex = 116;
            label4.Text = "性      别";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.Location = new Point(16, 349);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 115;
            label3.Text = "客户姓名";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(16, 297);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 114;
            label2.Text = "客户编号";
            // 
            // btnSelect
            // 
            btnSelect.Cursor = Cursors.Hand;
            btnSelect.Font = new Font("微软雅黑", 12F);
            btnSelect.Location = new Point(19, 44);
            btnSelect.MinimumSize = new Size(1, 1);
            btnSelect.Name = "btnSelect";
            btnSelect.Radius = 15;
            btnSelect.Size = new Size(129, 29);
            btnSelect.TabIndex = 135;
            btnSelect.Text = "入住并注册";
            btnSelect.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnSelect.Click += btnSelect_Click;
            // 
            // dgvReserList
            // 
            dgvReserList.Location = new Point(14, 83);
            dgvReserList.Name = "dgvReserList";
            dgvReserList.Size = new Size(735, 160);
            dgvReserList.TabIndex = 136;
            dgvReserList.Text = "table1";
            dgvReserList.CellClick += dgvReserList_CellClick;
            // 
            // btnPg
            // 
            btnPg.Current = 0;
            btnPg.Location = new Point(14, 253);
            btnPg.Name = "btnPg";
            btnPg.PageSize = 15;
            btnPg.ShowSizeChanger = true;
            btnPg.Size = new Size(735, 31);
            btnPg.TabIndex = 137;
            btnPg.Total = 1000000;
            btnPg.ValueChanged += btnPg_ValueChanged;
            btnPg.ShowTotalChanged += btnPg_ShowTotalChanged;
            // 
            // FrmReserList
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(763, 556);
            Controls.Add(btnPg);
            Controls.Add(dgvReserList);
            Controls.Add(btnSelect);
            Controls.Add(cbCustoType);
            Controls.Add(cbPassportType);
            Controls.Add(cbSex);
            Controls.Add(txtCustoNo);
            Controls.Add(txtCustoName);
            Controls.Add(txtCardID);
            Controls.Add(txtTel);
            Controls.Add(dtpBirthday);
            Controls.Add(txtCustoAdress);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmReserList";
            ShowTitleIcon = true;
            Text = "预约列表";
            ZoomScaleRect = new Rectangle(15, 15, 763, 556);
            Load += FrmReserList_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Sunny.UI.UIComboBox cbCustoType;
        private Sunny.UI.UIComboBox cbPassportType;
        private Sunny.UI.UIComboBox cbSex;
        private Sunny.UI.UITextBox txtCustoNo;
        private Sunny.UI.UITextBox txtCustoName;
        private Sunny.UI.UITextBox txtCardID;
        private Sunny.UI.UITextBox txtTel;
        private Sunny.UI.UIDatePicker dtpBirthday;
        private Sunny.UI.UITextBox txtCustoAdress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UIButton btnSelect;
        private AntdUI.Table dgvReserList;
        private AntdUI.Pagination btnPg;
    }
}