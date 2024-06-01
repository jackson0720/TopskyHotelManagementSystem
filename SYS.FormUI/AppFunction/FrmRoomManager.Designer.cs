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
            btnAll = new Sunny.UI.UIButton();
            btnBD = new Sunny.UI.UIButton();
            btnBS = new Sunny.UI.UIButton();
            btnHD = new Sunny.UI.UIButton();
            btnHS = new Sunny.UI.UIButton();
            btnQL = new Sunny.UI.UIButton();
            btnZT = new Sunny.UI.UIButton();
            picRefrech = new System.Windows.Forms.PictureBox();
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
            flpRoom.Location = new System.Drawing.Point(265, 84);
            flpRoom.Margin = new System.Windows.Forms.Padding(4);
            flpRoom.Name = "flpRoom";
            flpRoom.Size = new System.Drawing.Size(978, 601);
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
            pnlRoomState.Location = new System.Drawing.Point(2, 4);
            pnlRoomState.Margin = new System.Windows.Forms.Padding(4);
            pnlRoomState.Name = "pnlRoomState";
            pnlRoomState.Size = new System.Drawing.Size(255, 367);
            pnlRoomState.TabIndex = 5;
            // 
            // lblReser
            // 
            lblReser.AutoSize = true;
            lblReser.BackColor = System.Drawing.Color.RoyalBlue;
            lblReser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
            lblReser.ForeColor = System.Drawing.Color.White;
            lblReser.Location = new System.Drawing.Point(204, 325);
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
            lblFix.Location = new System.Drawing.Point(204, 249);
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
            pictureBox5.Location = new System.Drawing.Point(4, 310);
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
            pictureBox4.Location = new System.Drawing.Point(5, 234);
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
            lblNotClear.Location = new System.Drawing.Point(204, 172);
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
            lblCheck.Location = new System.Drawing.Point(204, 98);
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
            lblCanUse.Location = new System.Drawing.Point(204, 19);
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
            pictureBox3.Location = new System.Drawing.Point(4, 158);
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
            pictureBox2.Location = new System.Drawing.Point(4, 82);
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
            pnlRoomInfo.Location = new System.Drawing.Point(2, 380);
            pnlRoomInfo.Margin = new System.Windows.Forms.Padding(4);
            pnlRoomInfo.Name = "pnlRoomInfo";
            pnlRoomInfo.Size = new System.Drawing.Size(255, 305);
            pnlRoomInfo.TabIndex = 72;
            // 
            // lblRoomState
            // 
            lblRoomState.AutoSize = true;
            lblRoomState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            lblRoomState.Location = new System.Drawing.Point(132, 269);
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
            label11.Location = new System.Drawing.Point(12, 269);
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
            lblRoomNo.Location = new System.Drawing.Point(132, 14);
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
            lblCustoNo.Location = new System.Drawing.Point(132, 78);
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
            lblRoomPosition.Location = new System.Drawing.Point(132, 205);
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
            lblCheckTime.Location = new System.Drawing.Point(104, 142);
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
            label4.Location = new System.Drawing.Point(12, 205);
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
            label3.Location = new System.Drawing.Point(12, 142);
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
            label2.Location = new System.Drawing.Point(12, 78);
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
            // btnAll
            // 
            btnAll.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAll.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnAll.Location = new System.Drawing.Point(272, 18);
            btnAll.Margin = new System.Windows.Forms.Padding(4);
            btnAll.MinimumSize = new System.Drawing.Size(1, 1);
            btnAll.Name = "btnAll";
            btnAll.Size = new System.Drawing.Size(126, 42);
            btnAll.TabIndex = 0;
            btnAll.Text = "全部房间";
            btnAll.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnAll.Click += btnAll_Click;
            // 
            // btnBD
            // 
            btnBD.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBD.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnBD.Location = new System.Drawing.Point(404, 18);
            btnBD.Margin = new System.Windows.Forms.Padding(4);
            btnBD.MinimumSize = new System.Drawing.Size(1, 1);
            btnBD.Name = "btnBD";
            btnBD.Size = new System.Drawing.Size(126, 42);
            btnBD.TabIndex = 1;
            btnBD.Text = "标准单人间";
            btnBD.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnBD.Click += btnBD_Click;
            // 
            // btnBS
            // 
            btnBS.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBS.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnBS.Location = new System.Drawing.Point(536, 18);
            btnBS.Margin = new System.Windows.Forms.Padding(4);
            btnBS.MinimumSize = new System.Drawing.Size(1, 1);
            btnBS.Name = "btnBS";
            btnBS.Size = new System.Drawing.Size(126, 42);
            btnBS.TabIndex = 2;
            btnBS.Text = "标准双人间";
            btnBS.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnBS.Click += btnBS_Click;
            // 
            // btnHD
            // 
            btnHD.Cursor = System.Windows.Forms.Cursors.Hand;
            btnHD.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnHD.Location = new System.Drawing.Point(667, 18);
            btnHD.Margin = new System.Windows.Forms.Padding(4);
            btnHD.MinimumSize = new System.Drawing.Size(1, 1);
            btnHD.Name = "btnHD";
            btnHD.Size = new System.Drawing.Size(126, 42);
            btnHD.TabIndex = 3;
            btnHD.Text = "豪华单人间";
            btnHD.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnHD.Click += btnHD_Click;
            // 
            // btnHS
            // 
            btnHS.Cursor = System.Windows.Forms.Cursors.Hand;
            btnHS.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnHS.Location = new System.Drawing.Point(799, 18);
            btnHS.Margin = new System.Windows.Forms.Padding(4);
            btnHS.MinimumSize = new System.Drawing.Size(1, 1);
            btnHS.Name = "btnHS";
            btnHS.Size = new System.Drawing.Size(126, 42);
            btnHS.TabIndex = 4;
            btnHS.Text = "豪华双人间";
            btnHS.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnHS.Click += btnHS_Click;
            // 
            // btnQL
            // 
            btnQL.Cursor = System.Windows.Forms.Cursors.Hand;
            btnQL.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnQL.Location = new System.Drawing.Point(931, 18);
            btnQL.Margin = new System.Windows.Forms.Padding(4);
            btnQL.MinimumSize = new System.Drawing.Size(1, 1);
            btnQL.Name = "btnQL";
            btnQL.Size = new System.Drawing.Size(126, 42);
            btnQL.TabIndex = 5;
            btnQL.Text = "情侣套房";
            btnQL.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnQL.Click += btnQL_Click;
            // 
            // btnZT
            // 
            btnZT.Cursor = System.Windows.Forms.Cursors.Hand;
            btnZT.Font = new System.Drawing.Font("微软雅黑", 12F);
            btnZT.Location = new System.Drawing.Point(1063, 18);
            btnZT.Margin = new System.Windows.Forms.Padding(4);
            btnZT.MinimumSize = new System.Drawing.Size(1, 1);
            btnZT.Name = "btnZT";
            btnZT.Size = new System.Drawing.Size(126, 42);
            btnZT.TabIndex = 6;
            btnZT.Text = "总统套房";
            btnZT.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnZT.Click += btnZT_Click;
            // 
            // picRefrech
            // 
            picRefrech.BackColor = System.Drawing.Color.Transparent;
            picRefrech.BackgroundImage = Properties.Resources.blue_refresh;
            picRefrech.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            picRefrech.Location = new System.Drawing.Point(1195, 20);
            picRefrech.Margin = new System.Windows.Forms.Padding(4);
            picRefrech.Name = "picRefrech";
            picRefrech.Size = new System.Drawing.Size(43, 40);
            picRefrech.TabIndex = 94;
            picRefrech.TabStop = false;
            picRefrech.Click += picRefrech_Click;
            // 
            // FrmRoomManager
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1251, 694);
            Controls.Add(btnZT);
            Controls.Add(btnQL);
            Controls.Add(btnHS);
            Controls.Add(btnHD);
            Controls.Add(btnBS);
            Controls.Add(btnBD);
            Controls.Add(btnAll);
            Controls.Add(picRefrech);
            Controls.Add(pnlRoomInfo);
            Controls.Add(pnlRoomState);
            Controls.Add(flpRoom);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "FrmRoomManager";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "C";
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
        private Sunny.UI.UIButton btnAll;
        private Sunny.UI.UIButton btnBD;
        private Sunny.UI.UIButton btnBS;
        private Sunny.UI.UIButton btnHD;
        private Sunny.UI.UIButton btnHS;
        private Sunny.UI.UIButton btnQL;
        private Sunny.UI.UIButton btnZT;
        public System.Windows.Forms.Label lblRoomState;
        public System.Windows.Forms.Label lblRoomNo;
        public System.Windows.Forms.Label lblCustoNo;
        public System.Windows.Forms.Label lblRoomPosition;
        public System.Windows.Forms.Label lblCheckTime;
        public System.Windows.Forms.Panel pnlRoomInfo;
    }
}