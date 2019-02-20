namespace 获取公网ip并自动邮件
{
    partial class MainMenu
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
            this.label_SenderEmail = new System.Windows.Forms.Label();
            this.textBox_senderEmail = new System.Windows.Forms.TextBox();
            this.Apply = new System.Windows.Forms.Button();
            this.label_senderSecurityCode = new System.Windows.Forms.Label();
            this.textBox_securityCode = new System.Windows.Forms.TextBox();
            this.label_receiverEmail = new System.Windows.Forms.Label();
            this.textBox_receiverEmail = new System.Windows.Forms.TextBox();
            this.label_EmailTitle = new System.Windows.Forms.Label();
            this.richTextBox_EmailTitle = new System.Windows.Forms.RichTextBox();
            this.label_PcName = new System.Windows.Forms.Label();
            this.textBox_PcName = new System.Windows.Forms.TextBox();
            this.label_CurrentTime = new System.Windows.Forms.Label();
            this.label_IpAddress = new System.Windows.Forms.Label();
            this.label_State = new System.Windows.Forms.Label();
            this.label_checkCount = new System.Windows.Forms.Label();
            this.label_changeCount = new System.Windows.Forms.Label();
            this.button_help = new System.Windows.Forms.Button();
            this.button_About = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_SenderEmail
            // 
            this.label_SenderEmail.AutoSize = true;
            this.label_SenderEmail.Location = new System.Drawing.Point(38, 37);
            this.label_SenderEmail.Name = "label_SenderEmail";
            this.label_SenderEmail.Size = new System.Drawing.Size(113, 12);
            this.label_SenderEmail.TabIndex = 0;
            this.label_SenderEmail.Text = "发送者邮箱(QQ邮箱)";
            // 
            // textBox_senderEmail
            // 
            this.textBox_senderEmail.Location = new System.Drawing.Point(40, 52);
            this.textBox_senderEmail.Name = "textBox_senderEmail";
            this.textBox_senderEmail.Size = new System.Drawing.Size(115, 21);
            this.textBox_senderEmail.TabIndex = 1;
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(40, 344);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(75, 23);
            this.Apply.TabIndex = 2;
            this.Apply.Text = "保存并应用";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // label_senderSecurityCode
            // 
            this.label_senderSecurityCode.AutoSize = true;
            this.label_senderSecurityCode.Location = new System.Drawing.Point(40, 80);
            this.label_senderSecurityCode.Name = "label_senderSecurityCode";
            this.label_senderSecurityCode.Size = new System.Drawing.Size(173, 12);
            this.label_senderSecurityCode.TabIndex = 3;
            this.label_senderSecurityCode.Text = "发送者邮箱安全码(非邮箱密码)";
            // 
            // textBox_securityCode
            // 
            this.textBox_securityCode.Location = new System.Drawing.Point(40, 99);
            this.textBox_securityCode.Name = "textBox_securityCode";
            this.textBox_securityCode.Size = new System.Drawing.Size(113, 21);
            this.textBox_securityCode.TabIndex = 4;
            // 
            // label_receiverEmail
            // 
            this.label_receiverEmail.AutoSize = true;
            this.label_receiverEmail.Location = new System.Drawing.Point(42, 123);
            this.label_receiverEmail.Name = "label_receiverEmail";
            this.label_receiverEmail.Size = new System.Drawing.Size(101, 12);
            this.label_receiverEmail.TabIndex = 5;
            this.label_receiverEmail.Text = "接收者邮箱(任意)";
            // 
            // textBox_receiverEmail
            // 
            this.textBox_receiverEmail.Location = new System.Drawing.Point(40, 139);
            this.textBox_receiverEmail.Name = "textBox_receiverEmail";
            this.textBox_receiverEmail.Size = new System.Drawing.Size(113, 21);
            this.textBox_receiverEmail.TabIndex = 6;
            // 
            // label_EmailTitle
            // 
            this.label_EmailTitle.AutoSize = true;
            this.label_EmailTitle.Location = new System.Drawing.Point(38, 208);
            this.label_EmailTitle.Name = "label_EmailTitle";
            this.label_EmailTitle.Size = new System.Drawing.Size(53, 12);
            this.label_EmailTitle.TabIndex = 7;
            this.label_EmailTitle.Text = "邮件标题";
            // 
            // richTextBox_EmailTitle
            // 
            this.richTextBox_EmailTitle.Location = new System.Drawing.Point(40, 223);
            this.richTextBox_EmailTitle.Name = "richTextBox_EmailTitle";
            this.richTextBox_EmailTitle.Size = new System.Drawing.Size(166, 47);
            this.richTextBox_EmailTitle.TabIndex = 8;
            this.richTextBox_EmailTitle.Text = "";
            // 
            // label_PcName
            // 
            this.label_PcName.AutoSize = true;
            this.label_PcName.Location = new System.Drawing.Point(40, 286);
            this.label_PcName.Name = "label_PcName";
            this.label_PcName.Size = new System.Drawing.Size(53, 12);
            this.label_PcName.TabIndex = 9;
            this.label_PcName.Text = "主机名称";
            // 
            // textBox_PcName
            // 
            this.textBox_PcName.Location = new System.Drawing.Point(40, 302);
            this.textBox_PcName.Name = "textBox_PcName";
            this.textBox_PcName.Size = new System.Drawing.Size(166, 21);
            this.textBox_PcName.TabIndex = 10;
            // 
            // label_CurrentTime
            // 
            this.label_CurrentTime.AutoSize = true;
            this.label_CurrentTime.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_CurrentTime.Location = new System.Drawing.Point(293, 60);
            this.label_CurrentTime.Name = "label_CurrentTime";
            this.label_CurrentTime.Size = new System.Drawing.Size(123, 35);
            this.label_CurrentTime.TabIndex = 11;
            this.label_CurrentTime.Text = "当前时间";
            // 
            // label_IpAddress
            // 
            this.label_IpAddress.AutoSize = true;
            this.label_IpAddress.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_IpAddress.Location = new System.Drawing.Point(299, 147);
            this.label_IpAddress.Name = "label_IpAddress";
            this.label_IpAddress.Size = new System.Drawing.Size(61, 21);
            this.label_IpAddress.TabIndex = 12;
            this.label_IpAddress.Text = "公网IP:";
            // 
            // label_State
            // 
            this.label_State.AutoSize = true;
            this.label_State.Location = new System.Drawing.Point(303, 223);
            this.label_State.Name = "label_State";
            this.label_State.Size = new System.Drawing.Size(89, 12);
            this.label_State.TabIndex = 13;
            this.label_State.Text = "状态：等待配置";
            // 
            // label_checkCount
            // 
            this.label_checkCount.AutoSize = true;
            this.label_checkCount.Location = new System.Drawing.Point(303, 258);
            this.label_checkCount.Name = "label_checkCount";
            this.label_checkCount.Size = new System.Drawing.Size(71, 12);
            this.label_checkCount.TabIndex = 14;
            this.label_checkCount.Text = "检测次数：0";
            // 
            // label_changeCount
            // 
            this.label_changeCount.AutoSize = true;
            this.label_changeCount.Location = new System.Drawing.Point(303, 286);
            this.label_changeCount.Name = "label_changeCount";
            this.label_changeCount.Size = new System.Drawing.Size(83, 12);
            this.label_changeCount.TabIndex = 15;
            this.label_changeCount.Text = "IP变动次数：0";
            // 
            // button_help
            // 
            this.button_help.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_help.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_help.Location = new System.Drawing.Point(138, 344);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(75, 23);
            this.button_help.TabIndex = 16;
            this.button_help.Text = "用前必读";
            this.button_help.UseVisualStyleBackColor = true;
            this.button_help.Click += new System.EventHandler(this.button_help_Click);
            // 
            // button_About
            // 
            this.button_About.Location = new System.Drawing.Point(234, 344);
            this.button_About.Name = "button_About";
            this.button_About.Size = new System.Drawing.Size(75, 23);
            this.button_About.TabIndex = 17;
            this.button_About.Text = "关于作者";
            this.button_About.UseVisualStyleBackColor = true;
            this.button_About.Click += new System.EventHandler(this.button_About_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(612, 430);
            this.Controls.Add(this.button_About);
            this.Controls.Add(this.button_help);
            this.Controls.Add(this.label_changeCount);
            this.Controls.Add(this.label_checkCount);
            this.Controls.Add(this.label_State);
            this.Controls.Add(this.label_IpAddress);
            this.Controls.Add(this.label_CurrentTime);
            this.Controls.Add(this.textBox_PcName);
            this.Controls.Add(this.label_PcName);
            this.Controls.Add(this.richTextBox_EmailTitle);
            this.Controls.Add(this.label_EmailTitle);
            this.Controls.Add(this.textBox_receiverEmail);
            this.Controls.Add(this.label_receiverEmail);
            this.Controls.Add(this.textBox_securityCode);
            this.Controls.Add(this.label_senderSecurityCode);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.textBox_senderEmail);
            this.Controls.Add(this.label_SenderEmail);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "获取公网IP并发送邮件V1.0 By五航战瑞鹤酱";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_SenderEmail;
        private System.Windows.Forms.TextBox textBox_senderEmail;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Label label_senderSecurityCode;
        private System.Windows.Forms.TextBox textBox_securityCode;
        private System.Windows.Forms.Label label_receiverEmail;
        private System.Windows.Forms.TextBox textBox_receiverEmail;
        private System.Windows.Forms.Label label_EmailTitle;
        private System.Windows.Forms.RichTextBox richTextBox_EmailTitle;
        private System.Windows.Forms.Label label_PcName;
        private System.Windows.Forms.TextBox textBox_PcName;
        private System.Windows.Forms.Label label_CurrentTime;
        private System.Windows.Forms.Label label_IpAddress;
        private System.Windows.Forms.Label label_State;
        private System.Windows.Forms.Label label_checkCount;
        private System.Windows.Forms.Label label_changeCount;
        private System.Windows.Forms.Button button_help;
        private System.Windows.Forms.Button button_About;
    }
}

