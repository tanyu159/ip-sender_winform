using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 获取公网ip并自动邮件
{
    public partial class MsgForm : Form
    {
        public MsgForm()
        {
            InitializeComponent();
        }

        private void MsgForm_Load(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// 用于更新提示form中信息的显示
        /// </summary>
        /// <param name="msg">要显示的信息</param>
        public void UpdateLabelTextShow(string msg)
        {
            label_tipsMSg.Text = msg;
        }

        private void button_closeForm_Click(object sender, EventArgs e)
        {
            this.Close();//关闭这个窗口，销毁了，非隐藏。this.hide为隐藏
           
        }
    }
}
