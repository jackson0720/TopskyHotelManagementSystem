namespace EOM.TSHotelManagement.FormUI
{
    partial class FrmAboutUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAboutUs));
            rtbAboutUs = new Sunny.UI.UIRichTextBox();
            btnOk = new AntdUI.Button();
            SuspendLayout();
            // 
            // rtbAboutUs
            // 
            rtbAboutUs.BulletIndent = 5;
            rtbAboutUs.FillColor = Color.White;
            rtbAboutUs.Font = new Font("微软雅黑", 12F);
            rtbAboutUs.HideSelection = false;
            rtbAboutUs.Location = new Point(3, 2);
            rtbAboutUs.Margin = new Padding(3, 4, 3, 4);
            rtbAboutUs.MinimumSize = new Size(1, 1);
            rtbAboutUs.Name = "rtbAboutUs";
            rtbAboutUs.Padding = new Padding(1, 2, 1, 2);
            rtbAboutUs.Radius = 10;
            rtbAboutUs.ReadOnly = true;
            rtbAboutUs.ScrollBarStyleInherited = false;
            rtbAboutUs.ShowText = false;
            rtbAboutUs.Size = new Size(385, 146);
            rtbAboutUs.Style = Sunny.UI.UIStyle.Custom;
            rtbAboutUs.TabIndex = 0;
            rtbAboutUs.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Microsoft YaHei UI", 12F);
            btnOk.Location = new Point(145, 152);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(93, 36);
            btnOk.TabIndex = 129;
            btnOk.Text = "知道了！";
            btnOk.Type = AntdUI.TTypeMini.Primary;
            btnOk.Click += btnOk_Click;
            // 
            // FrmAboutUs
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 243, 255);
            ClientSize = new Size(390, 192);
            Controls.Add(btnOk);
            Controls.Add(rtbAboutUs);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "FrmAboutUs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "关于我们";
            Load += FrmAboutUs_Load;
            MouseDown += FrmAboutUs_MouseDown;
            MouseMove += FrmAboutUs_MouseMove;
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIRichTextBox rtbAboutUs;
        private AntdUI.Button btnOk;
    }
}