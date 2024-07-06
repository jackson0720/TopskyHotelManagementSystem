namespace SYS.FormUI
{
    partial class FrmMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            lblTime = new System.Windows.Forms.Label();
            tmrDate = new System.Windows.Forms.Timer(components);
            lblSoftName = new System.Windows.Forms.Label();
            pnlMID = new System.Windows.Forms.Panel();
            notifyIcon1 = new System.Windows.Forms.NotifyIcon(components);
            cmsMain = new System.Windows.Forms.ContextMenuStrip(components);
            tsmiChangeUser = new System.Windows.Forms.ToolStripMenuItem();
            tsmiMySpace = new System.Windows.Forms.ToolStripMenuItem();
            tsmiExChange = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            tsmiLockScreen = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            tsmiLoginBackSystem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            tsmiCheckUpdate = new System.Windows.Forms.ToolStripMenuItem();
            tsmiAboutUs = new System.Windows.Forms.ToolStripMenuItem();
            tsmiExitSystem = new System.Windows.Forms.ToolStripMenuItem();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            lblScroll = new Sunny.UI.UIScrollingText();
            tmrFont = new System.Windows.Forms.Timer(components);
            label3 = new System.Windows.Forms.Label();
            btnHello = new Sunny.UI.UIButton();
            uiButton1 = new Sunny.UI.UIButton();
            pnlCheckInfo = new System.Windows.Forms.Panel();
            lblClose = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            lblCheckDay = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            picLogo = new System.Windows.Forms.PictureBox();
            muNavBar = new AntdUI.Menu();
            btnClose = new AntdUI.Button();
            btnFormSize = new AntdUI.Button();
            btnSetting = new AntdUI.Button();
            cmsMain.SuspendLayout();
            pnlCheckInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTime.AutoSize = true;
            lblTime.BackColor = System.Drawing.Color.Transparent;
            lblTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            lblTime.Location = new System.Drawing.Point(53, 141);
            lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new System.Drawing.Size(92, 24);
            lblTime.TabIndex = 2;
            lblTime.Text = "NowTime";
            // 
            // tmrDate
            // 
            tmrDate.Enabled = true;
            tmrDate.Interval = 60000;
            tmrDate.Tick += tmrDate_Tick;
            // 
            // lblSoftName
            // 
            lblSoftName.BackColor = System.Drawing.Color.Transparent;
            lblSoftName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lblSoftName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSoftName.Location = new System.Drawing.Point(328, 7);
            lblSoftName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSoftName.Name = "lblSoftName";
            lblSoftName.Size = new System.Drawing.Size(597, 36);
            lblSoftName.TabIndex = 14;
            lblSoftName.Text = "TS酒店管理系统";
            lblSoftName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMID
            // 
            pnlMID.BackColor = System.Drawing.Color.Transparent;
            pnlMID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pnlMID.Location = new System.Drawing.Point(4, 225);
            pnlMID.Margin = new System.Windows.Forms.Padding(4);
            pnlMID.Name = "pnlMID";
            pnlMID.Size = new System.Drawing.Size(1072, 490);
            pnlMID.TabIndex = 23;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (System.Drawing.Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "TS酒店管理系统";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipClosed += notifyIcon1_BalloonTipClosed;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // cmsMain
            // 
            cmsMain.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 134);
            cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiChangeUser, tsmiMySpace, tsmiExChange, toolStripSeparator3, tsmiLockScreen, toolStripSeparator4, tsmiLoginBackSystem, toolStripSeparator2, tsmiCheckUpdate, tsmiAboutUs, tsmiExitSystem });
            cmsMain.Name = "cmsMain";
            cmsMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            cmsMain.Size = new System.Drawing.Size(208, 214);
            // 
            // tsmiChangeUser
            // 
            tsmiChangeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            tsmiChangeUser.Image = Properties.Resources.切换账号;
            tsmiChangeUser.Name = "tsmiChangeUser";
            tsmiChangeUser.Size = new System.Drawing.Size(207, 24);
            tsmiChangeUser.Text = "切换用户";
            tsmiChangeUser.Click += tsmiChangeUser_Click;
            // 
            // tsmiMySpace
            // 
            tsmiMySpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            tsmiMySpace.Image = Properties.Resources.个人中心;
            tsmiMySpace.Name = "tsmiMySpace";
            tsmiMySpace.Size = new System.Drawing.Size(207, 24);
            tsmiMySpace.Text = "个人中心";
            tsmiMySpace.Click += tsmiMySpace_Click;
            // 
            // tsmiExChange
            // 
            tsmiExChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            tsmiExChange.Name = "tsmiExChange";
            tsmiExChange.Size = new System.Drawing.Size(207, 24);
            tsmiExChange.Text = "换班";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(204, 6);
            // 
            // tsmiLockScreen
            // 
            tsmiLockScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            tsmiLockScreen.Image = Properties.Resources.锁屏;
            tsmiLockScreen.Name = "tsmiLockScreen";
            tsmiLockScreen.Size = new System.Drawing.Size(207, 24);
            tsmiLockScreen.Text = "快速锁屏";
            tsmiLockScreen.Click += tsmiLockScreen_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(204, 6);
            // 
            // tsmiLoginBackSystem
            // 
            tsmiLoginBackSystem.Enabled = false;
            tsmiLoginBackSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            tsmiLoginBackSystem.Image = Properties.Resources.系统管理员;
            tsmiLoginBackSystem.Name = "tsmiLoginBackSystem";
            tsmiLoginBackSystem.Size = new System.Drawing.Size(207, 24);
            tsmiLoginBackSystem.Text = "进入后台管理系统";
            tsmiLoginBackSystem.Click += tsmiLoginBackSystem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(204, 6);
            // 
            // tsmiCheckUpdate
            // 
            tsmiCheckUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            tsmiCheckUpdate.Image = Properties.Resources.检查更新__1_;
            tsmiCheckUpdate.Name = "tsmiCheckUpdate";
            tsmiCheckUpdate.Size = new System.Drawing.Size(207, 24);
            tsmiCheckUpdate.Text = "检查更新";
            tsmiCheckUpdate.Click += tsmiCheckUpdate_Click;
            // 
            // tsmiAboutUs
            // 
            tsmiAboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            tsmiAboutUs.Image = Properties.Resources.关于我们;
            tsmiAboutUs.Name = "tsmiAboutUs";
            tsmiAboutUs.Size = new System.Drawing.Size(207, 24);
            tsmiAboutUs.Text = "关于我们";
            tsmiAboutUs.Click += tsmiAboutUs_Click;
            // 
            // tsmiExitSystem
            // 
            tsmiExitSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            tsmiExitSystem.Image = Properties.Resources.注销;
            tsmiExitSystem.Name = "tsmiExitSystem";
            tsmiExitSystem.Size = new System.Drawing.Size(207, 24);
            tsmiExitSystem.Text = "退出系统";
            tsmiExitSystem.Click += tsmiExitSystem_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = System.Drawing.Color.Transparent;
            linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            linkLabel1.Location = new System.Drawing.Point(214, 25);
            linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(50, 17);
            linkLabel1.TabIndex = 26;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "未打卡";
            linkLabel1.VisitedLinkColor = System.Drawing.Color.Green;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // lblScroll
            // 
            lblScroll.Active = true;
            lblScroll.FillColor = System.Drawing.Color.FromArgb(235, 243, 255);
            lblScroll.Font = new System.Drawing.Font("微软雅黑", 12F);
            lblScroll.Interval = 1000;
            lblScroll.Location = new System.Drawing.Point(328, 58);
            lblScroll.Margin = new System.Windows.Forms.Padding(4);
            lblScroll.MinimumSize = new System.Drawing.Size(1, 1);
            lblScroll.Name = "lblScroll";
            lblScroll.Radius = 0;
            lblScroll.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            lblScroll.ScrollingType = Sunny.UI.UIScrollingText.UIScrollingType.LeftToRight;
            lblScroll.Size = new System.Drawing.Size(597, 33);
            lblScroll.TabIndex = 0;
            // 
            // tmrFont
            // 
            tmrFont.Enabled = true;
            tmrFont.Interval = 1000;
            tmrFont.Tick += tmrFont_Tick;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            label3.Location = new System.Drawing.Point(53, 193);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(54, 24);
            label3.TabIndex = 30;
            label3.Text = "Hello";
            // 
            // btnHello
            // 
            btnHello.BackColor = System.Drawing.Color.Transparent;
            btnHello.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnHello.FillColor = System.Drawing.Color.Transparent;
            btnHello.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnHello.Location = new System.Drawing.Point(5, 183);
            btnHello.Margin = new System.Windows.Forms.Padding(4);
            btnHello.MinimumSize = new System.Drawing.Size(1, 1);
            btnHello.Name = "btnHello";
            btnHello.Radius = 20;
            btnHello.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            btnHello.RectColor = System.Drawing.Color.Transparent;
            btnHello.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            btnHello.Size = new System.Drawing.Size(40, 34);
            btnHello.Style = Sunny.UI.UIStyle.Custom;
            btnHello.StyleCustomMode = true;
            btnHello.TabIndex = 33;
            btnHello.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            // 
            // uiButton1
            // 
            uiButton1.BackColor = System.Drawing.Color.Transparent;
            uiButton1.BackgroundImage = (System.Drawing.Image)resources.GetObject("uiButton1.BackgroundImage");
            uiButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            uiButton1.FillColor = System.Drawing.Color.Transparent;
            uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiButton1.Location = new System.Drawing.Point(6, 127);
            uiButton1.Margin = new System.Windows.Forms.Padding(4);
            uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Radius = 20;
            uiButton1.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            uiButton1.RectColor = System.Drawing.Color.Transparent;
            uiButton1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            uiButton1.Size = new System.Drawing.Size(40, 39);
            uiButton1.Style = Sunny.UI.UIStyle.Custom;
            uiButton1.StyleCustomMode = true;
            uiButton1.TabIndex = 31;
            uiButton1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            // 
            // pnlCheckInfo
            // 
            pnlCheckInfo.BackColor = System.Drawing.Color.Transparent;
            pnlCheckInfo.BackgroundImage = Properties.Resources.打卡2;
            pnlCheckInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pnlCheckInfo.Controls.Add(lblClose);
            pnlCheckInfo.Controls.Add(label4);
            pnlCheckInfo.Controls.Add(lblCheckDay);
            pnlCheckInfo.Controls.Add(label2);
            pnlCheckInfo.Location = new System.Drawing.Point(208, 58);
            pnlCheckInfo.Margin = new System.Windows.Forms.Padding(4);
            pnlCheckInfo.Name = "pnlCheckInfo";
            pnlCheckInfo.Size = new System.Drawing.Size(103, 103);
            pnlCheckInfo.TabIndex = 27;
            pnlCheckInfo.Visible = false;
            // 
            // lblClose
            // 
            lblClose.AutoSize = true;
            lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            lblClose.Location = new System.Drawing.Point(77, 7);
            lblClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblClose.Name = "lblClose";
            lblClose.Size = new System.Drawing.Size(16, 17);
            lblClose.TabIndex = 3;
            lblClose.Text = "×";
            lblClose.Click += lblClose_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            label4.Location = new System.Drawing.Point(21, 68);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(22, 17);
            label4.TabIndex = 2;
            label4.Text = "天";
            // 
            // lblCheckDay
            // 
            lblCheckDay.AutoSize = true;
            lblCheckDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            lblCheckDay.Location = new System.Drawing.Point(8, 40);
            lblCheckDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCheckDay.Name = "lblCheckDay";
            lblCheckDay.Size = new System.Drawing.Size(48, 17);
            lblCheckDay.TabIndex = 1;
            lblCheckDay.Text = "36500";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            label2.Location = new System.Drawing.Point(6, 6);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(67, 15);
            label2.TabIndex = 0;
            label2.Text = "您已打卡：";
            // 
            // picLogo
            // 
            picLogo.BackColor = System.Drawing.Color.Transparent;
            picLogo.BackgroundImage = (System.Drawing.Image)resources.GetObject("picLogo.BackgroundImage");
            picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            picLogo.Location = new System.Drawing.Point(5, 7);
            picLogo.Margin = new System.Windows.Forms.Padding(4);
            picLogo.Name = "picLogo";
            picLogo.Size = new System.Drawing.Size(165, 111);
            picLogo.TabIndex = 15;
            picLogo.TabStop = false;
            picLogo.Click += picLogo_Click;
            // 
            // muNavBar
            // 
            muNavBar.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            muNavBar.Location = new System.Drawing.Point(211, 172);
            muNavBar.Mode = AntdUI.TMenuMode.Horizontal;
            muNavBar.Name = "muNavBar";
            muNavBar.Size = new System.Drawing.Size(865, 45);
            muNavBar.TabIndex = 39;
            muNavBar.Text = "menu1";
            muNavBar.SelectChanged += muNavBar_SelectChanged;
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.Color.Transparent;
            btnClose.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            btnClose.Ghost = true;
            btnClose.Image = Properties.Resources.close;
            btnClose.ImageSize = new System.Drawing.Size(32, 32);
            btnClose.Location = new System.Drawing.Point(1032, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(41, 38);
            btnClose.TabIndex = 41;
            btnClose.Click += picClose_Click;
            // 
            // btnFormSize
            // 
            btnFormSize.BackColor = System.Drawing.Color.Transparent;
            btnFormSize.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            btnFormSize.Ghost = true;
            btnFormSize.Image = Properties.Resources.arrow_down_b;
            btnFormSize.ImageSize = new System.Drawing.Size(32, 32);
            btnFormSize.Location = new System.Drawing.Point(982, 5);
            btnFormSize.Name = "btnFormSize";
            btnFormSize.Size = new System.Drawing.Size(41, 38);
            btnFormSize.TabIndex = 40;
            btnFormSize.Click += picFormSize_Click;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = System.Drawing.Color.Transparent;
            btnSetting.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            btnSetting.Ghost = true;
            btnSetting.Image = Properties.Resources.settings2;
            btnSetting.ImageSize = new System.Drawing.Size(32, 32);
            btnSetting.Location = new System.Drawing.Point(932, 5);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new System.Drawing.Size(41, 38);
            btnSetting.TabIndex = 42;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1080, 721);
            Controls.Add(lblScroll);
            Controls.Add(btnSetting);
            Controls.Add(btnClose);
            Controls.Add(btnFormSize);
            Controls.Add(muNavBar);
            Controls.Add(btnHello);
            Controls.Add(uiButton1);
            Controls.Add(label3);
            Controls.Add(pnlCheckInfo);
            Controls.Add(linkLabel1);
            Controls.Add(pnlMID);
            Controls.Add(picLogo);
            Controls.Add(lblSoftName);
            Controls.Add(lblTime);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4);
            Name = "FrmMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "TS酒店管理系统";
            FormClosing += FrmMain_FormClosing;
            FormClosed += FrmMain_FormClosed;
            Load += FrmMain_Load;
            MouseDown += FrmMain_MouseDown_1;
            MouseMove += FrmMain_MouseMove_1;
            cmsMain.ResumeLayout(false);
            pnlCheckInfo.ResumeLayout(false);
            pnlCheckInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrDate;
        private System.Windows.Forms.Label lblSoftName;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlMID;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiLockScreen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiCheckUpdate;
        private System.Windows.Forms.ToolStripMenuItem tsmiExitSystem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAboutUs;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel pnlCheckInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCheckDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClose;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        public System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.Timer tmrFont;
        private Sunny.UI.UIScrollingText lblScroll;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton btnHello;
        private System.Windows.Forms.ToolStripMenuItem tsmiMySpace;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoginBackSystem;
        private Sunny.UI.UIButton picSetting;
        private System.Windows.Forms.ToolStripMenuItem tsmiExChange;
        private AntdUI.Menu muNavBar;
        private AntdUI.Button btnClose;
        private AntdUI.Button btnFormSize;
        private AntdUI.Button btnSetting;
    }
}