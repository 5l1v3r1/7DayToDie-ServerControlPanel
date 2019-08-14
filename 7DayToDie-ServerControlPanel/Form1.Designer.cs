namespace _7DayToDie_ServerControlPanel
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Reboot_btn = new System.Windows.Forms.Button();
            this.Stop_btn = new System.Windows.Forms.Button();
            this.Run_btn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ServerView = new System.Windows.Forms.DataGridView();
            this.Read_btn = new System.Windows.Forms.Button();
            this.SaveRe_btn = new System.Windows.Forms.Button();
            this.Save_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Log_richTextBox = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ServerPort_Label = new System.Windows.Forms.Label();
            this.WebPort_Label = new System.Windows.Forms.Label();
            this.TelnetPort_Label = new System.Windows.Forms.Label();
            this.Para = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tel_Status = new System.Windows.Forms.PictureBox();
            this.Web_Status = new System.Windows.Forms.PictureBox();
            this.Server_Status = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServerView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tel_Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Web_Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Server_Status)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TelnetPort_Label);
            this.groupBox1.Controls.Add(this.WebPort_Label);
            this.groupBox1.Controls.Add(this.ServerPort_Label);
            this.groupBox1.Controls.Add(this.Tel_Status);
            this.groupBox1.Controls.Add(this.Web_Status);
            this.groupBox1.Controls.Add(this.Server_Status);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务器状态";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telnet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "WEB:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Reboot_btn);
            this.groupBox2.Controls.Add(this.Stop_btn);
            this.groupBox2.Controls.Add(this.Run_btn);
            this.groupBox2.Location = new System.Drawing.Point(247, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 92);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "服务启停";
            // 
            // Reboot_btn
            // 
            this.Reboot_btn.Location = new System.Drawing.Point(276, 33);
            this.Reboot_btn.Name = "Reboot_btn";
            this.Reboot_btn.Size = new System.Drawing.Size(91, 37);
            this.Reboot_btn.TabIndex = 2;
            this.Reboot_btn.Text = "重启";
            this.Reboot_btn.UseVisualStyleBackColor = true;
            this.Reboot_btn.Click += new System.EventHandler(this.Reboot_btn_Click);
            // 
            // Stop_btn
            // 
            this.Stop_btn.Location = new System.Drawing.Point(159, 32);
            this.Stop_btn.Name = "Stop_btn";
            this.Stop_btn.Size = new System.Drawing.Size(91, 37);
            this.Stop_btn.TabIndex = 1;
            this.Stop_btn.Text = "停止";
            this.Stop_btn.UseVisualStyleBackColor = true;
            this.Stop_btn.Click += new System.EventHandler(this.Stop_btn_Click);
            // 
            // Run_btn
            // 
            this.Run_btn.Location = new System.Drawing.Point(42, 33);
            this.Run_btn.Name = "Run_btn";
            this.Run_btn.Size = new System.Drawing.Size(91, 37);
            this.Run_btn.TabIndex = 0;
            this.Run_btn.Text = "启动";
            this.Run_btn.UseVisualStyleBackColor = true;
            this.Run_btn.Click += new System.EventHandler(this.Run_btn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ServerView);
            this.groupBox4.Location = new System.Drawing.Point(13, 111);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(691, 624);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "本地配置";
            // 
            // ServerView
            // 
            this.ServerView.AllowUserToAddRows = false;
            this.ServerView.AllowUserToDeleteRows = false;
            this.ServerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServerView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Para,
            this.Value,
            this.Info});
            this.ServerView.Location = new System.Drawing.Point(7, 20);
            this.ServerView.MultiSelect = false;
            this.ServerView.Name = "ServerView";
            this.ServerView.RowHeadersVisible = false;
            this.ServerView.RowTemplate.Height = 23;
            this.ServerView.Size = new System.Drawing.Size(678, 598);
            this.ServerView.TabIndex = 1;
            // 
            // Read_btn
            // 
            this.Read_btn.Location = new System.Drawing.Point(741, 131);
            this.Read_btn.Name = "Read_btn";
            this.Read_btn.Size = new System.Drawing.Size(135, 45);
            this.Read_btn.TabIndex = 13;
            this.Read_btn.Text = "读取";
            this.Read_btn.UseVisualStyleBackColor = true;
            this.Read_btn.Click += new System.EventHandler(this.Read_btn_Click);
            // 
            // SaveRe_btn
            // 
            this.SaveRe_btn.Location = new System.Drawing.Point(741, 200);
            this.SaveRe_btn.Name = "SaveRe_btn";
            this.SaveRe_btn.Size = new System.Drawing.Size(135, 45);
            this.SaveRe_btn.TabIndex = 14;
            this.SaveRe_btn.Text = "保存&&重启服务";
            this.SaveRe_btn.UseVisualStyleBackColor = true;
            this.SaveRe_btn.Click += new System.EventHandler(this.SaveRe_btn_Click);
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(742, 268);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(135, 45);
            this.Save_btn.TabIndex = 15;
            this.Save_btn.Text = "仅保存";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Log_richTextBox);
            this.groupBox3.Location = new System.Drawing.Point(710, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 415);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "日志";
            // 
            // Log_richTextBox
            // 
            this.Log_richTextBox.BackColor = System.Drawing.Color.Black;
            this.Log_richTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Log_richTextBox.Location = new System.Drawing.Point(7, 21);
            this.Log_richTextBox.Name = "Log_richTextBox";
            this.Log_richTextBox.ReadOnly = true;
            this.Log_richTextBox.Size = new System.Drawing.Size(186, 388);
            this.Log_richTextBox.TabIndex = 0;
            this.Log_richTextBox.Text = "";
            this.Log_richTextBox.TextChanged += new System.EventHandler(this.Log_richTextBox_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // ServerPort_Label
            // 
            this.ServerPort_Label.AutoSize = true;
            this.ServerPort_Label.Location = new System.Drawing.Point(101, 20);
            this.ServerPort_Label.Name = "ServerPort_Label";
            this.ServerPort_Label.Size = new System.Drawing.Size(77, 12);
            this.ServerPort_Label.TabIndex = 6;
            this.ServerPort_Label.Text = "{ServerPort}";
            // 
            // WebPort_Label
            // 
            this.WebPort_Label.AutoSize = true;
            this.WebPort_Label.Location = new System.Drawing.Point(101, 46);
            this.WebPort_Label.Name = "WebPort_Label";
            this.WebPort_Label.Size = new System.Drawing.Size(59, 12);
            this.WebPort_Label.TabIndex = 7;
            this.WebPort_Label.Text = "{WebPort}";
            // 
            // TelnetPort_Label
            // 
            this.TelnetPort_Label.AutoSize = true;
            this.TelnetPort_Label.Location = new System.Drawing.Point(101, 71);
            this.TelnetPort_Label.Name = "TelnetPort_Label";
            this.TelnetPort_Label.Size = new System.Drawing.Size(77, 12);
            this.TelnetPort_Label.TabIndex = 8;
            this.TelnetPort_Label.Text = "{TelnetPort}";
            // 
            // Para
            // 
            this.Para.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Para.HeaderText = "参数";
            this.Para.Name = "Para";
            this.Para.ReadOnly = true;
            this.Para.Width = 54;
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Value.HeaderText = "值(选中后编辑)";
            this.Value.Name = "Value";
            this.Value.Width = 78;
            // 
            // Info
            // 
            this.Info.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Info.HeaderText = "说明";
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            this.Info.Width = 51;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_7DayToDie_ServerControlPanel.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(653, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Tel_Status
            // 
            this.Tel_Status.Location = new System.Drawing.Point(60, 66);
            this.Tel_Status.Name = "Tel_Status";
            this.Tel_Status.Size = new System.Drawing.Size(21, 20);
            this.Tel_Status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Tel_Status.TabIndex = 5;
            this.Tel_Status.TabStop = false;
            // 
            // Web_Status
            // 
            this.Web_Status.Location = new System.Drawing.Point(60, 42);
            this.Web_Status.Name = "Web_Status";
            this.Web_Status.Size = new System.Drawing.Size(21, 20);
            this.Web_Status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Web_Status.TabIndex = 4;
            this.Web_Status.TabStop = false;
            // 
            // Server_Status
            // 
            this.Server_Status.ImageLocation = "";
            this.Server_Status.Location = new System.Drawing.Point(60, 16);
            this.Server_Status.Name = "Server_Status";
            this.Server_Status.Size = new System.Drawing.Size(21, 20);
            this.Server_Status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Server_Status.TabIndex = 3;
            this.Server_Status.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(926, 745);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.SaveRe_btn);
            this.Controls.Add(this.Read_btn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7DayToDie-ServerSetPanel Beta1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServerView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tel_Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Web_Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Server_Status)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Read_btn;
        private System.Windows.Forms.DataGridView ServerView;
        private System.Windows.Forms.Button SaveRe_btn;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox Log_richTextBox;
        private System.Windows.Forms.Button Reboot_btn;
        private System.Windows.Forms.Button Stop_btn;
        private System.Windows.Forms.Button Run_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Server_Status;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Tel_Status;
        private System.Windows.Forms.PictureBox Web_Status;
        private System.Windows.Forms.Label TelnetPort_Label;
        private System.Windows.Forms.Label WebPort_Label;
        private System.Windows.Forms.Label ServerPort_Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Para;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
    }
}

