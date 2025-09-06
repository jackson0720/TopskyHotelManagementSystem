namespace EOM.TSHotelManagement.FormUI
{
    partial class FrmLoading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoading));
            lblTips = new AntdUI.Label();
            lbInternetSoftwareVersion = new AntdUI.Label();
            lblLocalSoftwareVersion = new AntdUI.Label();
            label2 = new AntdUI.Label();
            label1 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            lblReleaseLog = new AntdUI.Input();
            fbdSavePath = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // lblTips
            // 
            lblTips.Font = new Font("Noto Sans SC", 9F);
            lblTips.Location = new Point(12, 48);
            lblTips.Name = "lblTips";
            lblTips.Size = new Size(311, 23);
            lblTips.TabIndex = 3;
            lblTips.Text = "检测新版本中，请让计算机保持联网状态.....";
            lblTips.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbInternetSoftwareVersion
            // 
            lbInternetSoftwareVersion.BackColor = Color.Transparent;
            lbInternetSoftwareVersion.Font = new Font("Noto Sans SC", 9F);
            lbInternetSoftwareVersion.Location = new Point(152, 106);
            lbInternetSoftwareVersion.Name = "lbInternetSoftwareVersion";
            lbInternetSoftwareVersion.Size = new Size(140, 23);
            lbInternetSoftwareVersion.TabIndex = 7;
            lbInternetSoftwareVersion.Text = "";
            lbInternetSoftwareVersion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLocalSoftwareVersion
            // 
            lblLocalSoftwareVersion.BackColor = Color.Transparent;
            lblLocalSoftwareVersion.Font = new Font("Noto Sans SC", 9F);
            lblLocalSoftwareVersion.Location = new Point(152, 77);
            lblLocalSoftwareVersion.Name = "lblLocalSoftwareVersion";
            lblLocalSoftwareVersion.Size = new Size(140, 23);
            lblLocalSoftwareVersion.TabIndex = 6;
            lblLocalSoftwareVersion.Text = "";
            lblLocalSoftwareVersion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Noto Sans SC", 9F);
            label2.Location = new Point(43, 106);
            label2.Name = "label2";
            label2.Size = new Size(103, 23);
            label2.TabIndex = 5;
            label2.Text = "最新程序版本：";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Noto Sans SC", 9F);
            label1.Location = new Point(43, 77);
            label1.Name = "label1";
            label1.Size = new Size(103, 23);
            label1.TabIndex = 4;
            label1.Text = "本地程序版本：";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Noto Sans SC", 9F);
            label3.Location = new Point(43, 135);
            label3.Name = "label3";
            label3.Size = new Size(103, 23);
            label3.TabIndex = 8;
            label3.Text = "程序更新日志：";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblReleaseLog
            // 
            lblReleaseLog.AutoScroll = true;
            lblReleaseLog.Location = new Point(12, 164);
            lblReleaseLog.Multiline = true;
            lblReleaseLog.Name = "lblReleaseLog";
            lblReleaseLog.Size = new Size(311, 179);
            lblReleaseLog.TabIndex = 9;
            // 
            // FrmLoading
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(243, 249, 255);
            ClientSize = new Size(335, 355);
            Controls.Add(lblReleaseLog);
            Controls.Add(label3);
            Controls.Add(lbInternetSoftwareVersion);
            Controls.Add(lblLocalSoftwareVersion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTips);
            Font = new Font("Noto Sans SC", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLoading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLoading";
            Load += FrmLoading_Load;
            ResumeLayout(false);
        }

        #endregion
        private AntdUI.Label lblTips;
        private AntdUI.Label lbInternetSoftwareVersion;
        private AntdUI.Label lblLocalSoftwareVersion;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.Label label3;
        private AntdUI.Input lblReleaseLog;
        private FolderBrowserDialog fbdSavePath;
    }
}