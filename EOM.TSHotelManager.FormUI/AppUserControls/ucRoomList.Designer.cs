namespace EOM.TSHotelManager.FormUI
{
    partial class ucRoomList
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
            components = new System.ComponentModel.Container();
            cmsMain = new System.Windows.Forms.ContextMenuStrip(components);
            tsmiReserRoom = new System.Windows.Forms.ToolStripMenuItem();
            tsmiCheckIn = new System.Windows.Forms.ToolStripMenuItem();
            tsmiCheckOut = new System.Windows.Forms.ToolStripMenuItem();
            tsmiChangeRoom = new System.Windows.Forms.ToolStripMenuItem();
            tsmiSelectUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            tsmiChangeState = new System.Windows.Forms.ToolStripMenuItem();
            lblCustoName = new System.Windows.Forms.Label();
            lblRoomType = new System.Windows.Forms.Label();
            lblRoomNo = new System.Windows.Forms.Label();
            uttTips = new Sunny.UI.UIToolTip(components);
            lblMark = new Sunny.UI.UILabel();
            cmsMain.SuspendLayout();
            SuspendLayout();
            // 
            // cmsMain
            // 
            cmsMain.ImageScalingSize = new System.Drawing.Size(28, 28);
            cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiReserRoom, tsmiCheckIn, tsmiCheckOut, tsmiChangeRoom, tsmiSelectUserInfo, tsmiChangeState });
            cmsMain.Name = "cmsMain";
            cmsMain.Size = new System.Drawing.Size(149, 136);
            cmsMain.Opening += cmsMain_Opening;
            // 
            // tsmiReserRoom
            // 
            tsmiReserRoom.Name = "tsmiReserRoom";
            tsmiReserRoom.Size = new System.Drawing.Size(148, 22);
            tsmiReserRoom.Text = "预约房间";
            tsmiReserRoom.Click += tsmiReserRoom_Click;
            // 
            // tsmiCheckIn
            // 
            tsmiCheckIn.Name = "tsmiCheckIn";
            tsmiCheckIn.Size = new System.Drawing.Size(148, 22);
            tsmiCheckIn.Text = "入住房间";
            tsmiCheckIn.Click += tsmiCheckIn_Click;
            // 
            // tsmiCheckOut
            // 
            tsmiCheckOut.Name = "tsmiCheckOut";
            tsmiCheckOut.Size = new System.Drawing.Size(148, 22);
            tsmiCheckOut.Text = "结算退房";
            tsmiCheckOut.Click += tsmiCheckOut_Click;
            // 
            // tsmiChangeRoom
            // 
            tsmiChangeRoom.Name = "tsmiChangeRoom";
            tsmiChangeRoom.Size = new System.Drawing.Size(148, 22);
            tsmiChangeRoom.Text = "转换房间";
            tsmiChangeRoom.Click += tsmiChangeRoom_Click;
            // 
            // tsmiSelectUserInfo
            // 
            tsmiSelectUserInfo.Name = "tsmiSelectUserInfo";
            tsmiSelectUserInfo.Size = new System.Drawing.Size(148, 22);
            tsmiSelectUserInfo.Text = "查看用户信息";
            tsmiSelectUserInfo.Click += tsmiSelectUserInfo_Click;
            // 
            // tsmiChangeState
            // 
            tsmiChangeState.Name = "tsmiChangeState";
            tsmiChangeState.Size = new System.Drawing.Size(148, 22);
            tsmiChangeState.Text = "修改房间状态";
            tsmiChangeState.Click += tsmiChangeState_Click;
            // 
            // lblCustoName
            // 
            lblCustoName.AutoSize = true;
            lblCustoName.BackColor = System.Drawing.Color.Transparent;
            lblCustoName.ContextMenuStrip = cmsMain;
            lblCustoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            lblCustoName.Location = new System.Drawing.Point(37, 75);
            lblCustoName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCustoName.Name = "lblCustoName";
            lblCustoName.Size = new System.Drawing.Size(81, 17);
            lblCustoName.TabIndex = 10;
            lblCustoName.Text = "CustoName";
            lblCustoName.MouseClick += lblCustoNo_MouseClick;
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.BackColor = System.Drawing.Color.Transparent;
            lblRoomType.ContextMenuStrip = cmsMain;
            lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            lblRoomType.Location = new System.Drawing.Point(37, 9);
            lblRoomType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new System.Drawing.Size(61, 17);
            lblRoomType.TabIndex = 9;
            lblRoomType.Text = "RoomTy";
            lblRoomType.MouseClick += lblRoomType_MouseClick;
            // 
            // lblRoomNo
            // 
            lblRoomNo.AutoSize = true;
            lblRoomNo.BackColor = System.Drawing.Color.Transparent;
            lblRoomNo.ContextMenuStrip = cmsMain;
            lblRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            lblRoomNo.ForeColor = System.Drawing.Color.Black;
            lblRoomNo.Location = new System.Drawing.Point(37, 42);
            lblRoomNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRoomNo.Name = "lblRoomNo";
            lblRoomNo.Size = new System.Drawing.Size(63, 17);
            lblRoomNo.TabIndex = 8;
            lblRoomNo.Text = "RoomNo";
            lblRoomNo.MouseClick += lblRoomNo_MouseClick;
            // 
            // uttTips
            // 
            uttTips.BackColor = System.Drawing.Color.FromArgb(54, 54, 54);
            uttTips.ForeColor = System.Drawing.Color.FromArgb(239, 239, 239);
            uttTips.OwnerDraw = true;
            uttTips.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            uttTips.ToolTipTitle = "点击提示";
            // 
            // lblMark
            // 
            lblMark.Font = new System.Drawing.Font("微软雅黑", 12F);
            lblMark.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            lblMark.Location = new System.Drawing.Point(91, 33);
            lblMark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMark.Name = "lblMark";
            lblMark.Size = new System.Drawing.Size(18, 33);
            lblMark.TabIndex = 11;
            lblMark.Text = "uiLabel1";
            lblMark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblMark.Visible = false;
            // 
            // ucRoomList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.MenuHighlight;
            BackgroundImage = Properties.Resources.可住状态;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ContextMenuStrip = cmsMain;
            Controls.Add(lblMark);
            Controls.Add(lblCustoName);
            Controls.Add(lblRoomType);
            Controls.Add(lblRoomNo);
            DoubleBuffered = true;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "ucRoomList";
            Size = new System.Drawing.Size(122, 102);
            uttTips.SetToolTip(this, "a)、点击鼠标左键查看房间信息\r\nb)、点击鼠标右键打开选项菜单\r\nc)、快速双击鼠标左键可快速入住/查看信息");
            Load += ucRoomList_Load;
            SizeChanged += ucRoomList_SizeChanged;
            Click += ucRoomList_Click;
            DoubleClick += ucRoomList_DoubleClick;
            MouseClick += ucRoomList_MouseClick;
            cmsMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiCheckIn;
        private System.Windows.Forms.ToolStripMenuItem tsmiCheckOut;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectUserInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeState;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeRoom;
        private System.Windows.Forms.ToolStripMenuItem tsmiReserRoom;
        public System.Windows.Forms.Label lblCustoName;
        public System.Windows.Forms.Label lblRoomType;
        public System.Windows.Forms.Label lblRoomNo;
        private Sunny.UI.UIToolTip uttTips;
        public Sunny.UI.UILabel lblMark;
    }
}
