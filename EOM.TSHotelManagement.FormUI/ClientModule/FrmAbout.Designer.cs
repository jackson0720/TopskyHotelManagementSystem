namespace EOM.TSHotelManagement.FormUI
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            btnClose = new AntdUI.Button();
            picLogo = new PictureBox();
            lblSoftName = new Label();
            lblServerVersion = new AntdUI.Label();
            lblClientVersion = new AntdUI.Label();
            lblServerVersionDescriotion = new AntdUI.Label();
            lblClientVersionDescriotion = new AntdUI.Label();
            lblCopyright = new AntdUI.Label();
            lblNotice = new AntdUI.Label();
            lblFrameworkVersion = new AntdUI.Label();
            lblFrameworkVersionDescription = new AntdUI.Label();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundImage = Properties.Resources.close;
            btnClose.Font = new Font("Microsoft YaHei UI", 9F);
            btnClose.Ghost = true;
            btnClose.Location = new Point(348, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(41, 38);
            btnClose.TabIndex = 42;
            btnClose.Click += btnClose_Click;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.BackgroundImage = (Image)resources.GetObject("picLogo.BackgroundImage");
            picLogo.BackgroundImageLayout = ImageLayout.Stretch;
            picLogo.Cursor = Cursors.Hand;
            picLogo.Location = new Point(113, 57);
            picLogo.Margin = new Padding(4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(165, 111);
            picLogo.TabIndex = 43;
            picLogo.TabStop = false;
            // 
            // lblSoftName
            // 
            lblSoftName.BackColor = Color.Transparent;
            lblSoftName.FlatStyle = FlatStyle.Flat;
            lblSoftName.Font = new Font("Noto Sans SC", 14.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoftName.Location = new Point(13, 195);
            lblSoftName.Margin = new Padding(4, 0, 4, 0);
            lblSoftName.Name = "lblSoftName";
            lblSoftName.Size = new Size(364, 36);
            lblSoftName.TabIndex = 44;
            lblSoftName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblServerVersion
            // 
            lblServerVersion.BackColor = Color.Transparent;
            lblServerVersion.Font = new Font("Noto Sans SC", 9F);
            lblServerVersion.Location = new Point(194, 287);
            lblServerVersion.Name = "lblServerVersion";
            lblServerVersion.Size = new Size(103, 23);
            lblServerVersion.TabIndex = 48;
            lblServerVersion.Text = "";
            // 
            // lblClientVersion
            // 
            lblClientVersion.BackColor = Color.Transparent;
            lblClientVersion.Font = new Font("Noto Sans SC", 9F);
            lblClientVersion.Location = new Point(194, 258);
            lblClientVersion.Name = "lblClientVersion";
            lblClientVersion.Size = new Size(103, 23);
            lblClientVersion.TabIndex = 47;
            lblClientVersion.Text = "";
            // 
            // lblServerVersionDescriotion
            // 
            lblServerVersionDescriotion.BackColor = Color.Transparent;
            lblServerVersionDescriotion.Font = new Font("Noto Sans SC", 9F);
            lblServerVersionDescriotion.Location = new Point(94, 287);
            lblServerVersionDescriotion.Name = "lblServerVersionDescriotion";
            lblServerVersionDescriotion.Size = new Size(90, 23);
            lblServerVersionDescriotion.TabIndex = 46;
            lblServerVersionDescriotion.Text = "";
            lblServerVersionDescriotion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblClientVersionDescriotion
            // 
            lblClientVersionDescriotion.BackColor = Color.Transparent;
            lblClientVersionDescriotion.Font = new Font("Noto Sans SC", 9F);
            lblClientVersionDescriotion.Location = new Point(94, 258);
            lblClientVersionDescriotion.Name = "lblClientVersionDescriotion";
            lblClientVersionDescriotion.Size = new Size(90, 23);
            lblClientVersionDescriotion.TabIndex = 45;
            lblClientVersionDescriotion.Text = "";
            lblClientVersionDescriotion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCopyright
            // 
            lblCopyright.BackColor = Color.Transparent;
            lblCopyright.Font = new Font("Noto Sans SC", 9F);
            lblCopyright.Location = new Point(71, 346);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(240, 23);
            lblCopyright.TabIndex = 49;
            lblCopyright.Text = "";
            lblCopyright.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNotice
            // 
            lblNotice.BackColor = Color.Transparent;
            lblNotice.Font = new Font("Noto Sans SC", 9F);
            lblNotice.Location = new Point(71, 375);
            lblNotice.Name = "lblNotice";
            lblNotice.Size = new Size(240, 23);
            lblNotice.TabIndex = 50;
            lblNotice.Text = "";
            lblNotice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFrameworkVersion
            // 
            lblFrameworkVersion.BackColor = Color.Transparent;
            lblFrameworkVersion.Font = new Font("Noto Sans SC", 9F);
            lblFrameworkVersion.Location = new Point(194, 316);
            lblFrameworkVersion.Name = "lblFrameworkVersion";
            lblFrameworkVersion.Size = new Size(103, 23);
            lblFrameworkVersion.TabIndex = 52;
            lblFrameworkVersion.Text = "";
            // 
            // lblFrameworkVersionDescription
            // 
            lblFrameworkVersionDescription.BackColor = Color.Transparent;
            lblFrameworkVersionDescription.Font = new Font("Noto Sans SC", 9F);
            lblFrameworkVersionDescription.Location = new Point(94, 316);
            lblFrameworkVersionDescription.Name = "lblFrameworkVersionDescription";
            lblFrameworkVersionDescription.Size = new Size(90, 23);
            lblFrameworkVersionDescription.TabIndex = 51;
            lblFrameworkVersionDescription.Text = "";
            lblFrameworkVersionDescription.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FrmAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 243, 255);
            ClientSize = new Size(390, 476);
            Controls.Add(lblFrameworkVersion);
            Controls.Add(lblFrameworkVersionDescription);
            Controls.Add(lblNotice);
            Controls.Add(lblCopyright);
            Controls.Add(lblServerVersion);
            Controls.Add(lblClientVersion);
            Controls.Add(lblServerVersionDescriotion);
            Controls.Add(lblClientVersionDescriotion);
            Controls.Add(lblSoftName);
            Controls.Add(picLogo);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "FrmAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "关于我们";
            Load += FrmAboutUs_Load;
            MouseDown += FrmAboutUs_MouseDown;
            MouseMove += FrmAboutUs_MouseMove;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Button btnClose;
        private PictureBox picLogo;
        private Label lblSoftName;
        private AntdUI.Label lblServerVersion;
        private AntdUI.Label lblClientVersion;
        private AntdUI.Label lblServerVersionDescriotion;
        private AntdUI.Label lblClientVersionDescriotion;
        private AntdUI.Label lblCopyright;
        private AntdUI.Label lblNotice;
        private AntdUI.Label lblFrameworkVersion;
        private AntdUI.Label lblFrameworkVersionDescription;
    }
}