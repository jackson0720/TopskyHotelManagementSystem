namespace EOM.TSHotelManagement.FormUI.AppUserControls
{
    partial class ucRoomType
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
            btnRoomType = new AntdUI.Button();
            SuspendLayout();
            // 
            // btnRoomType
            // 
            btnRoomType.Font = new Font("Noto Sans SC", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRoomType.Location = new Point(2, 0);
            btnRoomType.Name = "btnRoomType";
            btnRoomType.Size = new Size(113, 37);
            btnRoomType.TabIndex = 0;
            btnRoomType.Type = AntdUI.TTypeMini.Info;
            // 
            // ucRoomType
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRoomType);
            Name = "ucRoomType";
            Size = new Size(117, 38);
            ResumeLayout(false);
        }

        #endregion

        public AntdUI.Button btnRoomType;
    }
}
