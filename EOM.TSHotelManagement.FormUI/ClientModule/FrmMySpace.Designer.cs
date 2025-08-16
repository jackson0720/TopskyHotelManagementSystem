
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
            AntdUI.Tabs.StyleCard styleCard1 = new AntdUI.Tabs.StyleCard();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMySpace));
            ucWindowHeader1 = new ucWindowHeader();
            tbPersonnelCenterTabs = new AntdUI.Tabs();
            tbPersonnelInfo = new AntdUI.TabPage();
            pnlPage = new Panel();
            tpPersonnelInfo = new AntdUI.TabPage();
            tpAccountSecurity = new AntdUI.TabPage();
            tpAccountAvatar = new AntdUI.TabPage();
            tbPersonnelCenterTabs.SuspendLayout();
            tbPersonnelInfo.SuspendLayout();
            SuspendLayout();
            // 
            // ucWindowHeader1
            // 
            ucWindowHeader1.Location = new Point(-2, 0);
            ucWindowHeader1.Name = "ucWindowHeader1";
            ucWindowHeader1.Size = new Size(641, 35);
            ucWindowHeader1.TabIndex = 16;
            // 
            // tbPersonnelCenterTabs
            // 
            tbPersonnelCenterTabs.Controls.Add(tbPersonnelInfo);
            tbPersonnelCenterTabs.Controls.Add(tpPersonnelInfo);
            tbPersonnelCenterTabs.Controls.Add(tpAccountSecurity);
            tbPersonnelCenterTabs.Controls.Add(tpAccountAvatar);
            tbPersonnelCenterTabs.Font = new Font("Noto Sans SC", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPersonnelCenterTabs.Location = new Point(2, 37);
            tbPersonnelCenterTabs.Name = "tbPersonnelCenterTabs";
            tbPersonnelCenterTabs.Pages.Add(tpPersonnelInfo);
            tbPersonnelCenterTabs.Pages.Add(tpAccountSecurity);
            tbPersonnelCenterTabs.Pages.Add(tpAccountAvatar);
            tbPersonnelCenterTabs.Size = new Size(637, 421);
            tbPersonnelCenterTabs.Style = styleCard1;
            tbPersonnelCenterTabs.TabIndex = 18;
            tbPersonnelCenterTabs.Type = AntdUI.TabType.Card;
            tbPersonnelCenterTabs.TabClick += tbPersonnelCenterTabs_TabClick;
            // 
            // tbPersonnelInfo
            // 
            tbPersonnelInfo.Controls.Add(pnlPage);
            tbPersonnelInfo.Location = new Point(3, 27);
            tbPersonnelInfo.Name = "tbPersonnelInfo";
            tbPersonnelInfo.Size = new Size(631, 391);
            tbPersonnelInfo.TabIndex = 0;
            tbPersonnelInfo.Text = "个人信息";
            // 
            // pnlPage
            // 
            pnlPage.Location = new Point(3, 3);
            pnlPage.Name = "pnlPage";
            pnlPage.Size = new Size(628, 388);
            pnlPage.TabIndex = 0;
            // 
            // tpPersonnelInfo
            // 
            tpPersonnelInfo.Location = new Point(3, 27);
            tpPersonnelInfo.Name = "tpPersonnelInfo";
            tpPersonnelInfo.Size = new Size(631, 391);
            tpPersonnelInfo.TabIndex = 3;
            tpPersonnelInfo.Text = "个人信息";
            // 
            // tpAccountSecurity
            // 
            tpAccountSecurity.Location = new Point(0, 0);
            tpAccountSecurity.Name = "tpAccountSecurity";
            tpAccountSecurity.Size = new Size(0, 0);
            tpAccountSecurity.TabIndex = 1;
            tpAccountSecurity.Text = "账号安全";
            // 
            // tpAccountAvatar
            // 
            tpAccountAvatar.Location = new Point(0, 0);
            tpAccountAvatar.Name = "tpAccountAvatar";
            tpAccountAvatar.Size = new Size(0, 0);
            tpAccountAvatar.TabIndex = 2;
            tpAccountAvatar.Text = "账号头像";
            // 
            // FrmMySpace
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(235, 243, 255);
            ClientSize = new Size(641, 461);
            Controls.Add(tbPersonnelCenterTabs);
            Controls.Add(ucWindowHeader1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMySpace";
            Text = "个人中心";
            Load += FrmMySpace_Load;
            tbPersonnelCenterTabs.ResumeLayout(false);
            tbPersonnelInfo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ucWindowHeader ucWindowHeader1;
        private AntdUI.Tabs tbPersonnelCenterTabs;
        private AntdUI.TabPage tpAccountSecurity;
        private AntdUI.TabPage tpAccountAvatar;
        private AntdUI.TabPage tbPersonnelInfo;
        private Panel pnlPage;
        private AntdUI.TabPage tpPersonnelInfo;
    }
}