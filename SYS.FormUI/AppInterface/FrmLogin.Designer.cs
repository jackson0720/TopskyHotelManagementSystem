namespace SYS.FormUI
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
            label2 = new System.Windows.Forms.Label();
            picLogin = new Sunny.UI.UIButton();
            txtWorkerId = new Sunny.UI.UITextBox();
            txtWorkerPwd = new Sunny.UI.UITextBox();
            btnLoginBackSystem = new Sunny.UI.UIButton();
            picFormSize = new Sunny.UI.UIButton();
            uiButton1 = new Sunny.UI.UIButton();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            label2.Location = new System.Drawing.Point(368, 199);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(29, 20);
            label2.TabIndex = 5;
            label2.Text = "  ";
            // 
            // picLogin
            // 
            picLogin.BackColor = System.Drawing.Color.Transparent;
            picLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            picLogin.Font = new System.Drawing.Font("微软雅黑", 12F);
            picLogin.Location = new System.Drawing.Point(658, 415);
            picLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            picLogin.MinimumSize = new System.Drawing.Size(1, 1);
            picLogin.Name = "picLogin";
            picLogin.Radius = 30;
            picLogin.Size = new System.Drawing.Size(191, 57);
            picLogin.Style = Sunny.UI.UIStyle.Custom;
            picLogin.TabIndex = 15;
            picLogin.Text = "登      录";
            picLogin.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            picLogin.Click += picLogin_Click;
            // 
            // txtWorkerId
            // 
            txtWorkerId.BackColor = System.Drawing.Color.Transparent;
            txtWorkerId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            txtWorkerId.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtWorkerId.FillColor = System.Drawing.Color.FromArgb(238, 224, 224);
            txtWorkerId.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            txtWorkerId.Location = new System.Drawing.Point(648, 194);
            txtWorkerId.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            txtWorkerId.MinimumSize = new System.Drawing.Size(1, 1);
            txtWorkerId.Name = "txtWorkerId";
            txtWorkerId.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            txtWorkerId.Radius = 20;
            txtWorkerId.RectColor = System.Drawing.Color.FromArgb(238, 224, 224);
            txtWorkerId.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            txtWorkerId.ShowText = false;
            txtWorkerId.Size = new System.Drawing.Size(238, 45);
            txtWorkerId.Style = Sunny.UI.UIStyle.Custom;
            txtWorkerId.TabIndex = 16;
            txtWorkerId.Text = "WK010";
            txtWorkerId.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtWorkerId.Watermark = "";
            // 
            // txtWorkerPwd
            // 
            txtWorkerPwd.BackColor = System.Drawing.Color.Transparent;
            txtWorkerPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtWorkerPwd.FillColor = System.Drawing.Color.FromArgb(238, 224, 224);
            txtWorkerPwd.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            txtWorkerPwd.Location = new System.Drawing.Point(648, 266);
            txtWorkerPwd.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            txtWorkerPwd.MinimumSize = new System.Drawing.Size(1, 1);
            txtWorkerPwd.Name = "txtWorkerPwd";
            txtWorkerPwd.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            txtWorkerPwd.PasswordChar = '*';
            txtWorkerPwd.Radius = 20;
            txtWorkerPwd.RectColor = System.Drawing.Color.FromArgb(238, 224, 224);
            txtWorkerPwd.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            txtWorkerPwd.ShowText = false;
            txtWorkerPwd.Size = new System.Drawing.Size(238, 47);
            txtWorkerPwd.Style = Sunny.UI.UIStyle.Custom;
            txtWorkerPwd.TabIndex = 17;
            txtWorkerPwd.Text = "admin";
            txtWorkerPwd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtWorkerPwd.Watermark = "";
            // 
            // btnLoginBackSystem
            // 
            btnLoginBackSystem.BackColor = System.Drawing.Color.Transparent;
            btnLoginBackSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLoginBackSystem.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnLoginBackSystem.Location = new System.Drawing.Point(658, 343);
            btnLoginBackSystem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnLoginBackSystem.MinimumSize = new System.Drawing.Size(1, 1);
            btnLoginBackSystem.Name = "btnLoginBackSystem";
            btnLoginBackSystem.Radius = 30;
            btnLoginBackSystem.Size = new System.Drawing.Size(191, 57);
            btnLoginBackSystem.Style = Sunny.UI.UIStyle.Custom;
            btnLoginBackSystem.TabIndex = 18;
            btnLoginBackSystem.Text = "进入后台管理系统";
            btnLoginBackSystem.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnLoginBackSystem.Click += btnLoginBackSystem_Click;
            // 
            // picFormSize
            // 
            picFormSize.BackColor = System.Drawing.Color.Transparent;
            picFormSize.BackgroundImage = Properties.Resources.arrow_down_b;
            picFormSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            picFormSize.FillColor = System.Drawing.Color.Transparent;
            picFormSize.FillHoverColor = System.Drawing.Color.RoyalBlue;
            picFormSize.FillSelectedColor = System.Drawing.Color.RoyalBlue;
            picFormSize.Font = new System.Drawing.Font("微软雅黑", 12F);
            picFormSize.Location = new System.Drawing.Point(826, 1);
            picFormSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            picFormSize.MinimumSize = new System.Drawing.Size(1, 1);
            picFormSize.Name = "picFormSize";
            picFormSize.Radius = 0;
            picFormSize.RectHoverColor = System.Drawing.Color.RoyalBlue;
            picFormSize.RectPressColor = System.Drawing.Color.RoyalBlue;
            picFormSize.RectSelectedColor = System.Drawing.Color.RoyalBlue;
            picFormSize.Size = new System.Drawing.Size(41, 38);
            picFormSize.Style = Sunny.UI.UIStyle.Custom;
            picFormSize.StyleCustomMode = true;
            picFormSize.TabIndex = 31;
            picFormSize.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            picFormSize.Click += picMin_Click;
            picFormSize.MouseDown += picFormSize_MouseDown;
            picFormSize.MouseLeave += picFormSize_MouseLeave;
            picFormSize.MouseHover += picFormSize_MouseHover;
            // 
            // uiButton1
            // 
            uiButton1.BackColor = System.Drawing.Color.Transparent;
            uiButton1.BackgroundImage = Properties.Resources.close;
            uiButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            uiButton1.FillColor = System.Drawing.Color.Transparent;
            uiButton1.FillHoverColor = System.Drawing.Color.RoyalBlue;
            uiButton1.FillSelectedColor = System.Drawing.Color.RoyalBlue;
            uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            uiButton1.Location = new System.Drawing.Point(874, 1);
            uiButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Radius = 0;
            uiButton1.RectHoverColor = System.Drawing.Color.RoyalBlue;
            uiButton1.RectPressColor = System.Drawing.Color.RoyalBlue;
            uiButton1.RectSelectedColor = System.Drawing.Color.RoyalBlue;
            uiButton1.Size = new System.Drawing.Size(41, 38);
            uiButton1.Style = Sunny.UI.UIStyle.Custom;
            uiButton1.TabIndex = 30;
            uiButton1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            uiButton1.Click += picClose_Click;
            uiButton1.MouseDown += uiButton1_MouseDown;
            uiButton1.MouseLeave += uiButton1_MouseLeave;
            uiButton1.MouseHover += uiButton1_MouseHover;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(916, 510);
            Controls.Add(picFormSize);
            Controls.Add(uiButton1);
            Controls.Add(btnLoginBackSystem);
            Controls.Add(txtWorkerPwd);
            Controls.Add(txtWorkerId);
            Controls.Add(picLogin);
            Controls.Add(label2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "FrmLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "TS酒店管理系统";
            FormClosing += FrmLogin_FormClosing;
            Load += FrmLogin_Load;
            MouseDown += FrmLogin_MouseDown;
            MouseMove += FrmLogin_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UIButton picLogin;
        private Sunny.UI.UITextBox txtWorkerId;
        private Sunny.UI.UITextBox txtWorkerPwd;
        private Sunny.UI.UIButton btnLoginBackSystem;
        private Sunny.UI.UIButton picFormSize;
        private Sunny.UI.UIButton uiButton1;
    }
}

