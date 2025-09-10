namespace EOM.TSHotelManagement.FormUI
{
    partial class ucRoom
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            btnRoom = new AntdUI.Button();
            SuspendLayout();
            // 
            // btnRoom
            // 
            btnRoom.AutoEllipsis = true;
            btnRoom.BackColor = Color.Transparent;
            btnRoom.BackgroundImage = Properties.Resources.可住状态;
            btnRoom.Font = new Font("Noto Sans SC", 9F);
            btnRoom.Ghost = true;
            btnRoom.IconRatio = 0.5F;
            btnRoom.JoinLeft = true;
            btnRoom.JoinRight = true;
            btnRoom.Location = new Point(0, 0);
            btnRoom.Name = "btnRoom";
            btnRoom.Radius = 12;
            btnRoom.Size = new Size(122, 102);
            btnRoom.TabIndex = 0;
            btnRoom.Text = "总统套房\r\n\r\nBS001\r\n\r\n小T呀";
            btnRoom.Click += btnRoom_Click;
            btnRoom.MouseClick += btnRoom_MouseClick;
            // 
            // ucRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRoom);
            Name = "ucRoom";
            Size = new Size(122, 102);
            Load += ucRoom_Load;
            ResumeLayout(false);
        }

        #endregion

        public AntdUI.Button btnRoom;
        private AntdUI.Button button1;
    }
}
