namespace 获取公网ip并自动邮件
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "1：使用前先确保宽带运营商给你分配的IP地址是否是公网IP，这是前提，否则只能进行内网穿透。\r\n你可以直接百度ip地址，可以获得你的外网ip，若显示\"保留地址\"则" +
    "非公网ip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(515, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "2：发件邮箱只能使用QQ邮箱，因为该程序代码已经指定好了邮件服务器，如果需要其他的邮箱，\r\n可以与我联系，我会在以后的版本更改。安全校验码不是指QQ密码，需要登陆" +
    "QQ邮箱，到\r\n设置-账户-POP3/IMAP/SMTP/Exchange/CardDAV/CalDAV服务，开启那4个服务，下面生成授权码\r\n该授权码就是填在" +
    "这里的邮箱安全码。收件邮箱可以是任意。\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(503, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "3：首次启动该应用，这些信息只是一个格式，你需要手动将你的邮箱信息输入，每项不可为空\r\n也不能出错。点击保存并应用就会开启服务。立即将公网IP地址和时间发送邮件至" +
    "设置的邮箱\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(473, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "4：检测时间间隔为10min一次，若ip发生变动，会再次重新发送新的ip地址到指定邮箱。";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(503, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "5：作者现在是大学生，为大家开发些有用的小工具，如果你愿意的话，也可以支持下我，谢谢\r\n _(:△」∠)_";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(312, 226);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 320);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button_close
            // 
            this.button_close.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_close.Location = new System.Drawing.Point(64, 445);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(163, 62);
            this.button_close.TabIndex = 6;
            this.button_close.Text = "我知道了";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 558);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "帮助";
            this.Load += new System.EventHandler(this.HelpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_close;
    }
}