namespace EOM.TSHotelManager.FormUI
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
            uiRichTextBox1 = new Sunny.UI.UIRichTextBox();
            SuspendLayout();
            // 
            // uiRichTextBox1
            // 
            uiRichTextBox1.BulletIndent = 5;
            uiRichTextBox1.FillColor = Color.White;
            uiRichTextBox1.Font = new Font("微软雅黑", 12F);
            uiRichTextBox1.HideSelection = false;
            uiRichTextBox1.Location = new Point(4, 32);
            uiRichTextBox1.Margin = new Padding(3, 4, 3, 4);
            uiRichTextBox1.MinimumSize = new Size(1, 1);
            uiRichTextBox1.Name = "uiRichTextBox1";
            uiRichTextBox1.Padding = new Padding(1, 2, 1, 2);
            uiRichTextBox1.Radius = 10;
            uiRichTextBox1.ReadOnly = true;
            uiRichTextBox1.ScrollBarStyleInherited = false;
            uiRichTextBox1.ShowText = false;
            uiRichTextBox1.Size = new Size(377, 146);
            uiRichTextBox1.Style = Sunny.UI.UIStyle.Custom;
            uiRichTextBox1.TabIndex = 0;
            uiRichTextBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // FrmAboutUs
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 243, 255);
            ClientSize = new Size(390, 192);
            Controls.Add(uiRichTextBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAboutUs";
            Text = "关于我们";
            Load += FrmAboutUs_Load;
            MouseDown += FrmAboutUs_MouseDown;
            MouseMove += FrmAboutUs_MouseMove;
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIRichTextBox uiRichTextBox1;
    }
}