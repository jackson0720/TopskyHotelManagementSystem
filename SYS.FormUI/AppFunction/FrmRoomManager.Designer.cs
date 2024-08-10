namespace SYS.FormUI
{
    partial class FrmRoomManager
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
            flpRoom = new System.Windows.Forms.FlowLayoutPanel();
            pnlRoomInfo = new System.Windows.Forms.Panel();
            lblRoomState = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            lblRoomNo = new System.Windows.Forms.Label();
            lblCustoNo = new System.Windows.Forms.Label();
            lblRoomPosition = new System.Windows.Forms.Label();
            lblCheckTime = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            flpRoomTypes = new Sunny.UI.UIFlowLayoutPanel();
            muRoomState = new AntdUI.Menu();
            pnlRoomInfo.SuspendLayout();
            SuspendLayout();
            // 
            // flpRoom
            // 
            flpRoom.AutoScroll = true;
            flpRoom.BackColor = System.Drawing.Color.Transparent;
            flpRoom.Location = new System.Drawing.Point(265, 103);
            flpRoom.Margin = new System.Windows.Forms.Padding(4);
            flpRoom.Name = "flpRoom";
            flpRoom.Size = new System.Drawing.Size(804, 383);
            flpRoom.TabIndex = 71;
            // 
            // pnlRoomInfo
            // 
            pnlRoomInfo.BackColor = System.Drawing.Color.Transparent;
            pnlRoomInfo.Controls.Add(lblRoomState);
            pnlRoomInfo.Controls.Add(label11);
            pnlRoomInfo.Controls.Add(lblRoomNo);
            pnlRoomInfo.Controls.Add(lblCustoNo);
            pnlRoomInfo.Controls.Add(lblRoomPosition);
            pnlRoomInfo.Controls.Add(lblCheckTime);
            pnlRoomInfo.Controls.Add(label4);
            pnlRoomInfo.Controls.Add(label3);
            pnlRoomInfo.Controls.Add(label2);
            pnlRoomInfo.Controls.Add(label1);
            pnlRoomInfo.Location = new System.Drawing.Point(2, 312);
            pnlRoomInfo.Margin = new System.Windows.Forms.Padding(4);
            pnlRoomInfo.Name = "pnlRoomInfo";
            pnlRoomInfo.Size = new System.Drawing.Size(255, 174);
            pnlRoomInfo.TabIndex = 72;
            // 
            // lblRoomState
            // 
            lblRoomState.AutoSize = true;
            lblRoomState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            lblRoomState.Location = new System.Drawing.Point(86, 146);
            lblRoomState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRoomState.Name = "lblRoomState";
            lblRoomState.Size = new System.Drawing.Size(10, 15);
            lblRoomState.TabIndex = 16;
            lblRoomState.Text = " ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            label11.Location = new System.Drawing.Point(11, 146);
            label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(67, 15);
            label11.TabIndex = 15;
            label11.Text = "房间状态：";
            // 
            // lblRoomNo
            // 
            lblRoomNo.AutoSize = true;
            lblRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            lblRoomNo.Location = new System.Drawing.Point(86, 13);
            lblRoomNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRoomNo.Name = "lblRoomNo";
            lblRoomNo.Size = new System.Drawing.Size(10, 15);
            lblRoomNo.TabIndex = 14;
            lblRoomNo.Text = " ";
            // 
            // lblCustoNo
            // 
            lblCustoNo.AutoSize = true;
            lblCustoNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            lblCustoNo.Location = new System.Drawing.Point(86, 46);
            lblCustoNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCustoNo.Name = "lblCustoNo";
            lblCustoNo.Size = new System.Drawing.Size(10, 15);
            lblCustoNo.TabIndex = 12;
            lblCustoNo.Text = " ";
            // 
            // lblRoomPosition
            // 
            lblRoomPosition.AutoSize = true;
            lblRoomPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            lblRoomPosition.Location = new System.Drawing.Point(86, 113);
            lblRoomPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRoomPosition.Name = "lblRoomPosition";
            lblRoomPosition.Size = new System.Drawing.Size(10, 15);
            lblRoomPosition.TabIndex = 10;
            lblRoomPosition.Text = " ";
            // 
            // lblCheckTime
            // 
            lblCheckTime.AutoSize = true;
            lblCheckTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            lblCheckTime.Location = new System.Drawing.Point(86, 80);
            lblCheckTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCheckTime.Name = "lblCheckTime";
            lblCheckTime.Size = new System.Drawing.Size(10, 15);
            lblCheckTime.TabIndex = 9;
            lblCheckTime.Text = " ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            label4.Location = new System.Drawing.Point(11, 113);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "所在区域：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            label3.Location = new System.Drawing.Point(11, 80);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "入住时间：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            label2.Location = new System.Drawing.Point(11, 46);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "客户名字：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            label1.Location = new System.Drawing.Point(11, 13);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "房间号码：";
            // 
            // flpRoomTypes
            // 
            flpRoomTypes.BackColor = System.Drawing.Color.Transparent;
            flpRoomTypes.FillColor = System.Drawing.Color.Transparent;
            flpRoomTypes.FillColor2 = System.Drawing.Color.Transparent;
            flpRoomTypes.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            flpRoomTypes.Location = new System.Drawing.Point(265, 4);
            flpRoomTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            flpRoomTypes.MinimumSize = new System.Drawing.Size(1, 1);
            flpRoomTypes.Name = "flpRoomTypes";
            flpRoomTypes.Padding = new System.Windows.Forms.Padding(2);
            flpRoomTypes.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            flpRoomTypes.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            flpRoomTypes.ShowText = false;
            flpRoomTypes.Size = new System.Drawing.Size(804, 90);
            flpRoomTypes.TabIndex = 95;
            flpRoomTypes.Text = "uiFlowLayoutPanel1";
            flpRoomTypes.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // muRoomState
            // 
            muRoomState.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            muRoomState.Indent = true;
            muRoomState.Location = new System.Drawing.Point(2, 4);
            muRoomState.Mode = AntdUI.TMenuMode.Vertical;
            muRoomState.Name = "muRoomState";
            muRoomState.Size = new System.Drawing.Size(255, 301);
            muRoomState.TabIndex = 96;
            muRoomState.SelectChanged += muRoomState_SelectChanged;
            // 
            // FrmRoomManager
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1072, 490);
            Controls.Add(muRoomState);
            Controls.Add(flpRoomTypes);
            Controls.Add(pnlRoomInfo);
            Controls.Add(flpRoom);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "FrmRoomManager";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            TransparencyKey = System.Drawing.Color.White;
            Load += FrmRoomManager_Load;
            pnlRoomInfo.ResumeLayout(false);
            pnlRoomInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public System.Windows.Forms.FlowLayoutPanel pe;
        private System.Windows.Forms.FlowLayoutPanel flpRoom;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblRoomState;
        public System.Windows.Forms.Label lblRoomNo;
        public System.Windows.Forms.Label lblCustoNo;
        public System.Windows.Forms.Label lblRoomPosition;
        public System.Windows.Forms.Label lblCheckTime;
        public System.Windows.Forms.Panel pnlRoomInfo;
        private Sunny.UI.UIFlowLayoutPanel flpRoomTypes;
        private AntdUI.Menu muRoomState;
    }
}