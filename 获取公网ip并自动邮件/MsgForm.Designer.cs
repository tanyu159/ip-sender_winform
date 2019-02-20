namespace 获取公网ip并自动邮件
{
    partial class MsgForm
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
            this.label_tipsMSg = new System.Windows.Forms.Label();
            this.button_closeForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_tipsMSg
            // 
            this.label_tipsMSg.AutoSize = true;
            this.label_tipsMSg.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_tipsMSg.Location = new System.Drawing.Point(41, 62);
            this.label_tipsMSg.Name = "label_tipsMSg";
            this.label_tipsMSg.Size = new System.Drawing.Size(0, 21);
            this.label_tipsMSg.TabIndex = 0;
            // 
            // button_closeForm
            // 
            this.button_closeForm.Location = new System.Drawing.Point(97, 125);
            this.button_closeForm.Name = "button_closeForm";
            this.button_closeForm.Size = new System.Drawing.Size(75, 23);
            this.button_closeForm.TabIndex = 1;
            this.button_closeForm.Text = "我知道了";
            this.button_closeForm.UseVisualStyleBackColor = true;
            this.button_closeForm.Click += new System.EventHandler(this.button_closeForm_Click);
            // 
            // MsgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 171);
            this.Controls.Add(this.button_closeForm);
            this.Controls.Add(this.label_tipsMSg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MsgForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "提示";
            this.Load += new System.EventHandler(this.MsgForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_tipsMSg;
        private System.Windows.Forms.Button button_closeForm;
    }
}