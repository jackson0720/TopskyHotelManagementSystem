
namespace EOM.TSHotelManagement.FormUI
{
    partial class FrmMySpace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMySpace));
            label7 = new Label();
            btnUpdWorker = new Sunny.UI.UIButton();
            cbWorkerNation = new Sunny.UI.UIComboBox();
            label1 = new Label();
            cboWorkerClub = new Sunny.UI.UIComboBox();
            cboWorkerPosition = new Sunny.UI.UIComboBox();
            cboSex = new Sunny.UI.UIComboBox();
            txtWorkerNo = new Sunny.UI.UITextBox();
            txtWorkerName = new Sunny.UI.UITextBox();
            txtTel = new Sunny.UI.UITextBox();
            txtAddress = new Sunny.UI.UITextBox();
            label2 = new Label();
            label5 = new Label();
            label16 = new Label();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            openPic = new OpenFileDialog();
            uiTabControlMenu2 = new Sunny.UI.UITabControlMenu();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label3 = new AntdUI.Label();
            tabPage3 = new TabPage();
            label4 = new AntdUI.Label();
            picWorkerPic = new PictureBox();
            uiTabControlMenu2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picWorkerPic).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label7.Location = new Point(58, 171);
            label7.Name = "label7";
            label7.Size = new Size(88, 25);
            label7.TabIndex = 131;
            label7.Text = "联系方式";
            // 
            // btnUpdWorker
            // 
            btnUpdWorker.Cursor = Cursors.Hand;
            btnUpdWorker.Font = new Font("微软雅黑", 12F);
            btnUpdWorker.Location = new Point(562, 270);
            btnUpdWorker.MinimumSize = new Size(1, 1);
            btnUpdWorker.Name = "btnUpdWorker";
            btnUpdWorker.Radius = 20;
            btnUpdWorker.Size = new Size(109, 42);
            btnUpdWorker.TabIndex = 130;
            btnUpdWorker.Text = "修    改";
            btnUpdWorker.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnUpdWorker.Click += btnUpdWorker_Click;
            // 
            // cbWorkerNation
            // 
            cbWorkerNation.DataSource = null;
            cbWorkerNation.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbWorkerNation.FillColor = Color.White;
            cbWorkerNation.Font = new Font("微软雅黑", 15.75F);
            cbWorkerNation.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbWorkerNation.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbWorkerNation.Location = new Point(466, 116);
            cbWorkerNation.Margin = new Padding(4, 5, 4, 5);
            cbWorkerNation.MinimumSize = new Size(63, 0);
            cbWorkerNation.Name = "cbWorkerNation";
            cbWorkerNation.Padding = new Padding(0, 0, 30, 2);
            cbWorkerNation.Radius = 20;
            cbWorkerNation.Size = new Size(203, 35);
            cbWorkerNation.Style = Sunny.UI.UIStyle.Custom;
            cbWorkerNation.SymbolSize = 24;
            cbWorkerNation.TabIndex = 129;
            cbWorkerNation.TextAlignment = ContentAlignment.MiddleLeft;
            cbWorkerNation.Watermark = "";
            cbWorkerNation.SelectedIndexChanged += cbWorkerNation_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(369, 119);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 128;
            label1.Text = "民      族";
            // 
            // cboWorkerClub
            // 
            cboWorkerClub.DataSource = null;
            cboWorkerClub.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cboWorkerClub.FillColor = Color.White;
            cboWorkerClub.Font = new Font("微软雅黑", 15.75F);
            cboWorkerClub.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cboWorkerClub.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cboWorkerClub.Location = new Point(467, 12);
            cboWorkerClub.Margin = new Padding(4, 5, 4, 5);
            cboWorkerClub.MinimumSize = new Size(63, 0);
            cboWorkerClub.Name = "cboWorkerClub";
            cboWorkerClub.Padding = new Padding(0, 0, 30, 2);
            cboWorkerClub.Radius = 20;
            cboWorkerClub.ReadOnly = true;
            cboWorkerClub.Size = new Size(203, 35);
            cboWorkerClub.Style = Sunny.UI.UIStyle.Custom;
            cboWorkerClub.SymbolSize = 24;
            cboWorkerClub.TabIndex = 125;
            cboWorkerClub.TextAlignment = ContentAlignment.MiddleLeft;
            cboWorkerClub.Watermark = "";
            // 
            // cboWorkerPosition
            // 
            cboWorkerPosition.DataSource = null;
            cboWorkerPosition.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cboWorkerPosition.FillColor = Color.White;
            cboWorkerPosition.Font = new Font("微软雅黑", 15.75F);
            cboWorkerPosition.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cboWorkerPosition.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cboWorkerPosition.Location = new Point(467, 64);
            cboWorkerPosition.Margin = new Padding(4, 5, 4, 5);
            cboWorkerPosition.MinimumSize = new Size(63, 0);
            cboWorkerPosition.Name = "cboWorkerPosition";
            cboWorkerPosition.Padding = new Padding(0, 0, 30, 2);
            cboWorkerPosition.Radius = 20;
            cboWorkerPosition.ReadOnly = true;
            cboWorkerPosition.Size = new Size(203, 35);
            cboWorkerPosition.Style = Sunny.UI.UIStyle.Custom;
            cboWorkerPosition.SymbolSize = 24;
            cboWorkerPosition.TabIndex = 124;
            cboWorkerPosition.TextAlignment = ContentAlignment.MiddleLeft;
            cboWorkerPosition.Watermark = "";
            // 
            // cboSex
            // 
            cboSex.DataSource = null;
            cboSex.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cboSex.FillColor = Color.White;
            cboSex.Font = new Font("微软雅黑", 15.75F);
            cboSex.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cboSex.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cboSex.Location = new Point(155, 116);
            cboSex.Margin = new Padding(4, 5, 4, 5);
            cboSex.MinimumSize = new Size(63, 0);
            cboSex.Name = "cboSex";
            cboSex.Padding = new Padding(0, 0, 30, 2);
            cboSex.Radius = 20;
            cboSex.Size = new Size(203, 35);
            cboSex.Style = Sunny.UI.UIStyle.Custom;
            cboSex.SymbolSize = 24;
            cboSex.TabIndex = 123;
            cboSex.TextAlignment = ContentAlignment.MiddleLeft;
            cboSex.Watermark = "";
            // 
            // txtWorkerNo
            // 
            txtWorkerNo.Cursor = Cursors.IBeam;
            txtWorkerNo.Font = new Font("微软雅黑", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtWorkerNo.Location = new Point(156, 12);
            txtWorkerNo.Margin = new Padding(4, 5, 4, 5);
            txtWorkerNo.MinimumSize = new Size(1, 1);
            txtWorkerNo.Name = "txtWorkerNo";
            txtWorkerNo.Padding = new Padding(5);
            txtWorkerNo.Radius = 20;
            txtWorkerNo.ReadOnly = true;
            txtWorkerNo.ShowText = false;
            txtWorkerNo.Size = new Size(203, 35);
            txtWorkerNo.Style = Sunny.UI.UIStyle.Custom;
            txtWorkerNo.StyleCustomMode = true;
            txtWorkerNo.TabIndex = 122;
            txtWorkerNo.TextAlignment = ContentAlignment.MiddleLeft;
            txtWorkerNo.Watermark = "";
            // 
            // txtWorkerName
            // 
            txtWorkerName.Cursor = Cursors.IBeam;
            txtWorkerName.Font = new Font("微软雅黑", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtWorkerName.Location = new Point(156, 64);
            txtWorkerName.Margin = new Padding(4, 5, 4, 5);
            txtWorkerName.MinimumSize = new Size(1, 1);
            txtWorkerName.Name = "txtWorkerName";
            txtWorkerName.Padding = new Padding(5);
            txtWorkerName.Radius = 20;
            txtWorkerName.ShowText = false;
            txtWorkerName.Size = new Size(203, 35);
            txtWorkerName.Style = Sunny.UI.UIStyle.Custom;
            txtWorkerName.StyleCustomMode = true;
            txtWorkerName.TabIndex = 121;
            txtWorkerName.TextAlignment = ContentAlignment.MiddleLeft;
            txtWorkerName.Watermark = "";
            // 
            // txtTel
            // 
            txtTel.Cursor = Cursors.IBeam;
            txtTel.Font = new Font("微软雅黑", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtTel.Location = new Point(156, 164);
            txtTel.Margin = new Padding(4, 5, 4, 5);
            txtTel.MinimumSize = new Size(1, 1);
            txtTel.Name = "txtTel";
            txtTel.Padding = new Padding(5);
            txtTel.Radius = 20;
            txtTel.ShowText = false;
            txtTel.Size = new Size(515, 35);
            txtTel.Style = Sunny.UI.UIStyle.Custom;
            txtTel.StyleCustomMode = true;
            txtTel.TabIndex = 119;
            txtTel.TextAlignment = ContentAlignment.MiddleLeft;
            txtTel.Watermark = "";
            // 
            // txtAddress
            // 
            txtAddress.Cursor = Cursors.IBeam;
            txtAddress.Font = new Font("微软雅黑", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtAddress.Location = new Point(156, 216);
            txtAddress.Margin = new Padding(4, 5, 4, 5);
            txtAddress.MinimumSize = new Size(1, 1);
            txtAddress.Name = "txtAddress";
            txtAddress.Padding = new Padding(5);
            txtAddress.Radius = 20;
            txtAddress.ShowText = false;
            txtAddress.Size = new Size(515, 35);
            txtAddress.Style = Sunny.UI.UIStyle.Custom;
            txtAddress.StyleCustomMode = true;
            txtAddress.TabIndex = 117;
            txtAddress.TextAlignment = ContentAlignment.MiddleLeft;
            txtAddress.Watermark = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(58, 221);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 115;
            label2.Text = "居住地址";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label5.Location = new Point(369, 69);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 112;
            label5.Text = "现任职位";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label16.Location = new Point(369, 18);
            label16.Name = "label16";
            label16.Size = new Size(88, 25);
            label16.TabIndex = 111;
            label16.Text = "所在部门";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label30.Location = new Point(58, 119);
            label30.Name = "label30";
            label30.Size = new Size(86, 25);
            label30.TabIndex = 109;
            label30.Text = "性      别";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label31.Location = new Point(58, 69);
            label31.Name = "label31";
            label31.Size = new Size(88, 25);
            label31.TabIndex = 108;
            label31.Text = "员工姓名";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label32.Location = new Point(58, 18);
            label32.Name = "label32";
            label32.Size = new Size(88, 25);
            label32.TabIndex = 107;
            label32.Text = "员工编号";
            // 
            // openPic
            // 
            openPic.FileName = "openFileDialog1";
            openPic.Filter = "PNG文件|*.png|JPG文件|*.jpg|位图文件|*.bmp";
            openPic.FileOk += openPic_FileOk;
            // 
            // uiTabControlMenu2
            // 
            uiTabControlMenu2.Alignment = TabAlignment.Left;
            uiTabControlMenu2.Controls.Add(tabPage1);
            uiTabControlMenu2.Controls.Add(tabPage2);
            uiTabControlMenu2.Controls.Add(tabPage3);
            uiTabControlMenu2.DrawMode = TabDrawMode.OwnerDrawFixed;
            uiTabControlMenu2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTabControlMenu2.Location = new Point(3, 38);
            uiTabControlMenu2.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            uiTabControlMenu2.Multiline = true;
            uiTabControlMenu2.Name = "uiTabControlMenu2";
            uiTabControlMenu2.SelectedIndex = 0;
            uiTabControlMenu2.Size = new Size(929, 546);
            uiTabControlMenu2.SizeMode = TabSizeMode.Fixed;
            uiTabControlMenu2.TabBackColor = Color.FromArgb(235, 243, 255);
            uiTabControlMenu2.TabIndex = 15;
            uiTabControlMenu2.TabSelectedColor = Color.Snow;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label32);
            tabPage1.Controls.Add(btnUpdWorker);
            tabPage1.Controls.Add(label31);
            tabPage1.Controls.Add(cbWorkerNation);
            tabPage1.Controls.Add(label30);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label16);
            tabPage1.Controls.Add(cboWorkerClub);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(cboWorkerPosition);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(cboSex);
            tabPage1.Controls.Add(txtAddress);
            tabPage1.Controls.Add(txtWorkerNo);
            tabPage1.Controls.Add(txtTel);
            tabPage1.Controls.Add(txtWorkerName);
            tabPage1.Location = new Point(201, 0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(728, 546);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "个人信息";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(201, 0);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(728, 546);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "账号安全";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Location = new Point(210, 255);
            label3.Name = "label3";
            label3.Size = new Size(308, 36);
            label3.TabIndex = 0;
            label3.Text = "功能升级，重置密码需联系管理员进行！";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(picWorkerPic);
            tabPage3.Location = new Point(201, 0);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(728, 546);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "账号头像";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Location = new Point(257, 416);
            label4.Name = "label4";
            label4.Size = new Size(215, 23);
            label4.TabIndex = 1;
            label4.Text = "Tips:头像大小不能超过1MB";
            // 
            // picWorkerPic
            // 
            picWorkerPic.BackgroundImage = Properties.Resources.账号;
            picWorkerPic.BackgroundImageLayout = ImageLayout.Stretch;
            picWorkerPic.Location = new Point(257, 150);
            picWorkerPic.Name = "picWorkerPic";
            picWorkerPic.Size = new Size(215, 246);
            picWorkerPic.SizeMode = PictureBoxSizeMode.StretchImage;
            picWorkerPic.TabIndex = 0;
            picWorkerPic.TabStop = false;
            picWorkerPic.Click += picWorkerPic_Click;
            // 
            // FrmMySpace
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(937, 589);
            Controls.Add(uiTabControlMenu2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMySpace";
            ShowTitleIcon = true;
            Text = "个人中心";
            ZoomScaleRect = new Rectangle(15, 15, 873, 587);
            Load += FrmMySpace_Load;
            uiTabControlMenu2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picWorkerPic).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UIComboBox cbWorkerNation;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIComboBox cboWorkerClub;
        private Sunny.UI.UIComboBox cboWorkerPosition;
        private Sunny.UI.UIComboBox cboSex;
        private Sunny.UI.UITextBox txtWorkerNo;
        private Sunny.UI.UITextBox txtWorkerName;
        private Sunny.UI.UITextBox txtTel;
        private Sunny.UI.UITextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private Sunny.UI.UIButton btnUpdWorker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openPic;
        private Sunny.UI.UITabControlMenu uiTabControlMenu2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox picWorkerPic;
        private AntdUI.Label label3;
        private AntdUI.Label label4;
    }
}