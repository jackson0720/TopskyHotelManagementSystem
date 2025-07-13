namespace EOM.TSHotelManagement.FormUI
{
    partial class FrmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            label2 = new Label();
            txtAccount = new AntdUI.Input();
            txtWorkerPwd = new AntdUI.Input();
            picLogin = new AntdUI.Button();
            picFormSize = new AntdUI.Button();
            picClose = new AntdUI.Button();
            avatar1 = new AntdUI.Avatar();
            avatar2 = new AntdUI.Avatar();
            label1 = new AntdUI.Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("宋体", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(368, 199);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 5;
            label2.Text = "  ";
            // 
            // txtAccount
            // 
            txtAccount.BackColor = Color.White;
            txtAccount.Font = new Font("Microsoft YaHei UI", 14F);
            txtAccount.Location = new Point(648, 190);
            txtAccount.Name = "txtAccount";
            txtAccount.PlaceholderText = "";
            txtAccount.Size = new Size(238, 52);
            txtAccount.TabIndex = 32;
            // 
            // txtWorkerPwd
            // 
            txtWorkerPwd.BackColor = Color.White;
            txtWorkerPwd.Font = new Font("Microsoft YaHei UI", 14F);
            txtWorkerPwd.Location = new Point(648, 264);
            txtWorkerPwd.Name = "txtWorkerPwd";
            txtWorkerPwd.PasswordChar = '*';
            txtWorkerPwd.PasswordCopy = true;
            txtWorkerPwd.PlaceholderColorExtend = "";
            txtWorkerPwd.PlaceholderText = "";
            txtWorkerPwd.Size = new Size(238, 52);
            txtWorkerPwd.TabIndex = 33;
            // 
            // picLogin
            // 
            picLogin.Font = new Font("Microsoft YaHei UI", 12F);
            picLogin.Location = new Point(658, 342);
            picLogin.Name = "picLogin";
            picLogin.Radius = 8;
            picLogin.Shape = AntdUI.TShape.Round;
            picLogin.Size = new Size(191, 57);
            picLogin.TabIndex = 34;
            picLogin.Text = "登      录";
            picLogin.Type = AntdUI.TTypeMini.Primary;
            picLogin.Click += picLogin_Click;
            // 
            // picFormSize
            // 
            picFormSize.BackColor = Color.Transparent;
            picFormSize.BackgroundImage = Properties.Resources.arrow_down_b;
            picFormSize.Font = new Font("Microsoft YaHei UI", 9F);
            picFormSize.Ghost = true;
            picFormSize.Location = new Point(822, 1);
            picFormSize.Name = "picFormSize";
            picFormSize.Size = new Size(41, 38);
            picFormSize.TabIndex = 36;
            picFormSize.Click += picMin_Click;
            // 
            // picClose
            // 
            picClose.BackColor = Color.Transparent;
            picClose.BackgroundImage = Properties.Resources.close;
            picClose.Font = new Font("Microsoft YaHei UI", 9F);
            picClose.Ghost = true;
            picClose.Location = new Point(875, 1);
            picClose.Name = "picClose";
            picClose.Size = new Size(41, 38);
            picClose.TabIndex = 37;
            picClose.Click += picClose_Click;
            // 
            // avatar1
            // 
            avatar1.Image = (Image)resources.GetObject("avatar1.Image");
            avatar1.ImageFit = AntdUI.TFit.None;
            avatar1.Location = new Point(605, 195);
            avatar1.Name = "avatar1";
            avatar1.Size = new Size(45, 43);
            avatar1.TabIndex = 38;
            avatar1.Text = "a";
            // 
            // avatar2
            // 
            avatar2.Image = (Image)resources.GetObject("avatar2.Image");
            avatar2.ImageFit = AntdUI.TFit.None;
            avatar2.Location = new Point(605, 268);
            avatar2.Name = "avatar2";
            avatar2.Size = new Size(45, 43);
            avatar2.TabIndex = 39;
            avatar2.Text = "a";
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 14F);
            label1.Location = new Point(648, 72);
            label1.Name = "label1";
            label1.Size = new Size(222, 83);
            label1.TabIndex = 40;
            label1.Text = "欢迎登录";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 243, 255);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(916, 510);
            Controls.Add(label1);
            Controls.Add(avatar2);
            Controls.Add(avatar1);
            Controls.Add(picClose);
            Controls.Add(picFormSize);
            Controls.Add(picLogin);
            Controls.Add(txtWorkerPwd);
            Controls.Add(txtAccount);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TS酒店管理系统";
            Load += FrmLogin_Load;
            MouseDown += FrmLogin_MouseDown;
            MouseMove += FrmLogin_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label2;
        private AntdUI.Input txtAccount;
        private AntdUI.Input txtWorkerPwd;
        private AntdUI.Button picLogin;
        private AntdUI.Button picFormSize;
        private AntdUI.Button picClose;
        private AntdUI.Avatar avatar1;
        private AntdUI.Avatar avatar2;
        private AntdUI.Label label1;
    }
}

