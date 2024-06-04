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
            pnlRoomState = new System.Windows.Forms.Panel();
            lblReser = new System.Windows.Forms.Label();
            lblFix = new System.Windows.Forms.Label();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            lblNotClear = new System.Windows.Forms.Label();
            lblCheck = new System.Windows.Forms.Label();
            lblCanUse = new System.Windows.Forms.Label();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
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
            picRefrech = new System.Windows.Forms.PictureBox();
            flpRoomTypes = new Sunny.UI.UIFlowLayoutPanel();
            pnlRoomState.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlRoomInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRefrech).BeginInit();
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
            // pnlRoomState
            // 
            pnlRoomState.BackColor = System.Drawing.Color.Transparent;
            pnlRoomState.Controls.Add(lblReser);
            pnlRoomState.Controls.Add(lblFix);
            pnlRoomState.Controls.Add(pictureBox5);
            pnlRoomState.Controls.Add(pictureBox4);
            pnlRoomState.Controls.Add(lblNotClear);
            pnlRoomState.Controls.Add(lblCheck);
            pnlRoomState.Controls.Add(lblCanUse);
            pnlRoomState.Controls.Add(pictureBox3);
            pnlRoomState.Controls.Add(pictureBox2);
            pnlRoomState.Controls.Add(pictureBox1);
            pnlRoomState.Location = new System.Drawing.Point(2, 5);
            pnlRoomState.Margin = new System.Windows.Forms.Padding(4);
            pnlRoomState.Name = "pnlRoomState";
            pnlRoomState.Size = new System.Drawing.Size(255, 294);
            pnlRoomState.TabIndex = 5;
            // 
            // lblReser
            // 
            lblReser.AutoSize = true;
            lblReser.BackColor = System.Drawing.Color.RoyalBlue;
            lblReser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
            lblReser.ForeColor = System.Drawing.Color.White;
            lblReser.Location = new System.Drawing.Point(204, 253);
            lblReser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblReser.Name = "lblReser";
            lblReser.Size = new System.Drawing.Size(19, 20);
            lblReser.TabIndex = 14;
            lblReser.Text = "0";
            // 
            // lblFix
            // 
            lblFix.AutoSize = true;
            lblFix.BackColor = System.Drawing.Color.FromArgb(95, 167, 203);
            lblFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
            lblFix.ForeColor = System.Drawing.Color.White;
            lblFix.Location = new System.Drawing.Point(204, 195);
            lblFix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFix.Name = "lblFix";
            lblFix.Size = new System.Drawing.Size(19, 20);
            lblFix.TabIndex = 13;
            lblFix.Text = "0";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = System.Drawing.Color.White;
            pictureBox5.BackgroundImage = Properties.Resources.预约房icon;
            pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox5.Location = new System.Drawing.Point(4, 238);
            pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(247, 50);
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            pictureBox5.MouseLeave += pictureBox5_MouseLeave;
            pictureBox5.MouseHover += pictureBox5_MouseHover;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = System.Drawing.Color.White;
            pictureBox4.BackgroundImage = Properties.Resources.维修房icon;
            pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox4.Location = new System.Drawing.Point(4, 180);
            pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(247, 50);
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            pictureBox4.MouseLeave += pictureBox4_MouseLeave;
            pictureBox4.MouseHover += pictureBox4_MouseHover;
            // 
            // lblNotClear
            // 
            lblNotClear.AutoSize = true;
            lblNotClear.BackColor = System.Drawing.Color.FromArgb(140, 155, 138);
            lblNotClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
            lblNotClear.ForeColor = System.Drawing.Color.White;
            lblNotClear.Location = new System.Drawing.Point(204, 137);
            lblNotClear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblNotClear.Name = "lblNotClear";
            lblNotClear.Size = new System.Drawing.Size(19, 20);
            lblNotClear.TabIndex = 11;
            lblNotClear.Text = "0";
            // 
            // lblCheck
            // 
            lblCheck.AutoSize = true;
            lblCheck.BackColor = System.Drawing.Color.FromArgb(108, 195, 96);
            lblCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
            lblCheck.ForeColor = System.Drawing.Color.White;
            lblCheck.Location = new System.Drawing.Point(204, 78);
            lblCheck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCheck.Name = "lblCheck";
            lblCheck.Size = new System.Drawing.Size(19, 20);
            lblCheck.TabIndex = 10;
            lblCheck.Text = "0";
            // 
            // lblCanUse
            // 
            lblCanUse.AutoSize = true;
            lblCanUse.BackColor = System.Drawing.Color.FromArgb(102, 255, 204);
            lblCanUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
            lblCanUse.ForeColor = System.Drawing.Color.White;
            lblCanUse.Location = new System.Drawing.Point(204, 20);
            lblCanUse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCanUse.Name = "lblCanUse";
            lblCanUse.Size = new System.Drawing.Size(19, 20);
            lblCanUse.TabIndex = 9;
            lblCanUse.Text = "0";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = System.Drawing.Color.White;
            pictureBox3.BackgroundImage = Properties.Resources.脏房icon1;
            pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox3.Location = new System.Drawing.Point(4, 122);
            pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(247, 50);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            pictureBox3.MouseLeave += pictureBox3_MouseLeave;
            pictureBox3.MouseHover += pictureBox3_MouseHover;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            pictureBox2.BackgroundImage = Properties.Resources.已住房icon;
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox2.Location = new System.Drawing.Point(4, 64);
            pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(247, 50);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.MouseLeave += pictureBox2_MouseLeave;
            pictureBox2.MouseHover += pictureBox2_MouseHover;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.White;
            pictureBox1.BackgroundImage = Properties.Resources.可住房icon;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Location = new System.Drawing.Point(4, 4);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(247, 52);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            pictureBox1.MouseHover += pictureBox1_MouseHover;
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
            pnlRoomInfo.Location = new System.Drawing.Point(2, 307);
            pnlRoomInfo.Margin = new System.Windows.Forms.Padding(4);
            pnlRoomInfo.Name = "pnlRoomInfo";
            pnlRoomInfo.Size = new System.Drawing.Size(255, 179);
            pnlRoomInfo.TabIndex = 72;
            // 
            // lblRoomState
            // 
            lblRoomState.AutoSize = true;
            lblRoomState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            lblRoomState.Location = new System.Drawing.Point(87, 147);
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
            label11.Location = new System.Drawing.Point(12, 147);
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
            lblRoomNo.Location = new System.Drawing.Point(87, 14);
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
            lblCustoNo.Location = new System.Drawing.Point(87, 47);
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
            lblRoomPosition.Location = new System.Drawing.Point(87, 114);
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
            lblCheckTime.Location = new System.Drawing.Point(87, 81);
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
            label4.Location = new System.Drawing.Point(12, 114);
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
            label3.Location = new System.Drawing.Point(12, 81);
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
            label2.Location = new System.Drawing.Point(12, 47);
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
            label1.Location = new System.Drawing.Point(12, 14);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "房间号码：";
            // 
            // picRefrech
            // 
            picRefrech.BackColor = System.Drawing.Color.Transparent;
            picRefrech.BackgroundImage = Properties.Resources.blue_refresh;
            picRefrech.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            picRefrech.Location = new System.Drawing.Point(1030, 25);
            picRefrech.Margin = new System.Windows.Forms.Padding(4);
            picRefrech.Name = "picRefrech";
            picRefrech.Size = new System.Drawing.Size(39, 39);
            picRefrech.TabIndex = 94;
            picRefrech.TabStop = false;
            picRefrech.Click += picRefrech_Click;
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
            flpRoomTypes.Size = new System.Drawing.Size(757, 92);
            flpRoomTypes.TabIndex = 95;
            flpRoomTypes.Text = "uiFlowLayoutPanel1";
            flpRoomTypes.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmRoomManager
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1072, 490);
            Controls.Add(picRefrech);
            Controls.Add(flpRoomTypes);
            Controls.Add(pnlRoomInfo);
            Controls.Add(pnlRoomState);
            Controls.Add(flpRoom);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "FrmRoomManager";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            TransparencyKey = System.Drawing.Color.White;
            Load += FrmRoomManager_Load;
            pnlRoomState.ResumeLayout(false);
            pnlRoomState.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlRoomInfo.ResumeLayout(false);
            pnlRoomInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picRefrech).EndInit();
            ResumeLayout(false);
        }

        #endregion
        public System.Windows.Forms.FlowLayoutPanel pe;
        private System.Windows.Forms.FlowLayoutPanel flpRoom;
        private System.Windows.Forms.Panel pnlRoomState;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblNotClear;
        public System.Windows.Forms.Label lblCheck;
        public System.Windows.Forms.Label lblCanUse;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picRefrech;
        public System.Windows.Forms.Label lblFix;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.Label lblReser;
        public System.Windows.Forms.Label lblRoomState;
        public System.Windows.Forms.Label lblRoomNo;
        public System.Windows.Forms.Label lblCustoNo;
        public System.Windows.Forms.Label lblRoomPosition;
        public System.Windows.Forms.Label lblCheckTime;
        public System.Windows.Forms.Panel pnlRoomInfo;
        private Sunny.UI.UIFlowLayoutPanel flpRoomTypes;
    }
}