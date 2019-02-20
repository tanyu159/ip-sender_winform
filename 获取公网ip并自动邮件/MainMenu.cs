using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
namespace 获取公网ip并自动邮件
{
    public partial class MainMenu : CCSkinMain
    {
        public static string lastIP = "";//用于保存上次ip地址
        public static int checkCount = 0;//检查次数
        public static int changeCount = 0;//变化次数
        public static ConfigInfo configInfoObj;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            //加载上次设置，配置文件
           ConfigInfo configInfoObj=  ConfigManager.ParseConfigXml(Application.StartupPath + @"\config.xml");
            //数据回显
            textBox_senderEmail.Text = configInfoObj.senderEmailAddress;
            textBox_securityCode.Text = configInfoObj.senderEmailSecurityCode;
            textBox_receiverEmail.Text = configInfoObj.receiverEmailAddress;
            richTextBox_EmailTitle.Text = configInfoObj.emailTitle;
            textBox_PcName.Text = configInfoObj.pcName;
        }

        /// <summary>
        /// 获取输入的设置,并验证格式正确
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Apply_Click(object sender, EventArgs e)
        {
            label_State.Text = "状态：配置成功尝试,获取IP,并发送邮件";
            string senderEmailAddress = "";
            string senderEmailSecurityCode = "";
            string receiverEmailAddress = "";
            string emailTitle = "";
            string pcName = "";
            //两个邮箱来判断邮箱格式是否合法
            string IsEmailAddressRegex = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            if (Regex.IsMatch(textBox_senderEmail.Text, IsEmailAddressRegex))
            {
                senderEmailAddress = textBox_senderEmail.Text;
            }
            else
            {
                //:弹出新form，邮箱格式错误提示
                //Console.WriteLine("发件者邮箱格式不正确");
                MsgForm errorMsg = new MsgForm();
                errorMsg.UpdateLabelTextShow("emm,发件邮箱格式不正确");//传入错误信息
                errorMsg.ShowDialog();//显示
                return;//程序结束，不再执行
            }

            if (Regex.IsMatch(textBox_receiverEmail.Text, IsEmailAddressRegex))
            {
                receiverEmailAddress = textBox_receiverEmail.Text;
            }
            else
            {
                //:弹出新form，邮箱格式错误提示
                MsgForm errorMsg = new MsgForm();
                errorMsg.UpdateLabelTextShow("emm,收件邮箱格式不正确");//传入错误信息
                errorMsg.ShowDialog();//显示
                return;//程序结束，不再执行
            }
            //其他属性判段不为空
            if (textBox_securityCode.Text != "")
            {
                senderEmailSecurityCode = textBox_securityCode.Text;
            }
            else
            {
                //:弹出新form，属性为空，请重新输入
                MsgForm errorMsg = new MsgForm();
                errorMsg.UpdateLabelTextShow("emm,安全校验码不为空");//传入错误信息
                errorMsg.ShowDialog();//显示
                return;//程序结束，不再执行
            }
            if (richTextBox_EmailTitle.Text != "")
            {
                emailTitle = richTextBox_EmailTitle.Text;
            }
            else
            {
                //:弹出新form，属性为空，请重新输入
                MsgForm errorMsg = new MsgForm();
                errorMsg.UpdateLabelTextShow("emm,邮件标题不为空");//传入错误信息
                errorMsg.ShowDialog();//显示
                return;//程序结束，不再执行
            }
            if (textBox_PcName.Text != "")
            {
                pcName = textBox_PcName.Text;
            }
            else
            {
                //:弹出新form，属性为空，请重新输入
                MsgForm errorMsg = new MsgForm();
                errorMsg.UpdateLabelTextShow("emm,主机名不为空");//传入错误信息
                errorMsg.ShowDialog();//显示
                return;//程序结束，不再执行
            }
             configInfoObj = new ConfigInfo(senderEmailAddress, senderEmailSecurityCode, receiverEmailAddress, emailTitle, pcName);
            //:对这个ConfigInfo对象解析，写入xml文件
            //Console.WriteLine(configInfoObj);
            ConfigManager.CreatConfigXML(Application.StartupPath + @"\config.xml", configInfoObj, false);
            //给出提示
            MsgForm saveSuccess = new MsgForm();
            saveSuccess.UpdateLabelTextShow("保存成功");
            saveSuccess.ShowDialog();
            //开启新线程，实时显示当前时间            
            //label_CurrentTime.Text = "变动时间:  " + DateTime.Now.ToLocalTime().ToString(" HH: mm:ss");
            Thread timerThread = new Thread(UpdateTime)
            {
                IsBackground = true
            };
            timerThread.Start();


            #region 首次获取外网ip并发送邮件
            //:获取外网ip
            string allWebContentPath = IPConfig.GetAllWebContent("http://www.net.cn/static/customercare/yourip.asp");
            string availableContentXMLPath = IPConfig.GetAvailableInfo(allWebContentPath,53,54);
            string externalIP = IPConfig.GetExternal_IP(availableContentXMLPath);
            Console.WriteLine("外网ip为:"+externalIP);
            label_checkCount.Text = "检测次数：1";
            label_IpAddress.Text = "公网IP: " + externalIP;
            //:发送邮件
            string content = "来自:" + configInfoObj.pcName + "的无人值守服务器" + "\n"
                                 + "公网IP地址：" + externalIP + "\n"
                                 + "当前时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            IPConfig.SendEmail(configInfoObj.emailTitle, content, configInfoObj.senderEmailAddress, configInfoObj.senderEmailSecurityCode, configInfoObj.receiverEmailAddress);
            Console.WriteLine("发送成功");
            label_State.Text = "状态：邮件已发送";
            lastIP = externalIP;
            #endregion

            //开启线程检测ip变化，如果ip发生变化，则重新发送一次邮件告知，检测间隔时间为10min
            Thread checkIPChange = new Thread(UpdateIPAddress)
            {
                IsBackground = true
            };
            checkIPChange.Start();
            //保存并应用按钮设置为不可点击状态
            Apply.Enabled = false;
        }
        /// <summary>
        /// 计时器更新线程
        /// </summary>
        public void UpdateTime()
        {
            while (true)
            {
                label_CurrentTime.BeginInvoke(new MethodInvoker(() => label_CurrentTime.Text = "当前时间: " + DateTime.Now.ToString("yyyy-MM-dd" + "\n"+"                  "  +"HH:mm:ss"))); 
                Thread.Sleep(1000);//时间1s更新一次
            }
        }
        /// <summary>
        /// 检测IP更改，更改后重新发送邮件线程
        /// </summary>
        public void UpdateIPAddress()
        {
            while (true)
            {
                string allWebContentPath = IPConfig.GetAllWebContent("http://www.net.cn/static/customercare/yourip.asp");
                string availableContentXMLPath = IPConfig.GetAvailableInfo(allWebContentPath, 53, 54);
                string newExternalIP = IPConfig.GetExternal_IP(availableContentXMLPath);
                if (!newExternalIP.Equals(lastIP))//这次获得的IP和上次不同时，则修改ip重发邮件,更新界面显示
                {
                    lastIP = newExternalIP;
                    checkCount++;
                    changeCount++;
                    //重发邮件
                    string content = "来自:" + configInfoObj.pcName + "的无人值守服务器" + "\n"
                                + "公网IP发生了变化,变化次数:"+ checkCount+"\n"
                                + "公网IP地址：" + newExternalIP + "\n"
                                + "当前时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    IPConfig.SendEmail(configInfoObj.emailTitle, content, configInfoObj.senderEmailAddress, configInfoObj.senderEmailSecurityCode, configInfoObj.receiverEmailAddress);
                    //Console.WriteLine("发送成功");
                    label_State.Text = "状态：邮件已重新发送";
                    //更新界面显示x3,IP地址，检查次数，以及变化次数
                    label_IpAddress.BeginInvoke(new MethodInvoker(() => label_IpAddress.Text = newExternalIP));
                    label_checkCount.BeginInvoke(new MethodInvoker(() => label_checkCount.Text = "检查次数：" + checkCount));
                    label_changeCount.BeginInvoke(new MethodInvoker(() => label_changeCount.Text = "IP变动次数：" + changeCount));

                }
                else {
                    checkCount++;
                    label_checkCount.BeginInvoke(new MethodInvoker(() => label_checkCount.Text = "检查次数：" + checkCount));
                }
                Thread.Sleep(600000);
            }
        }
        /// <summary>
        /// 帮助按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_help_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }
        /// <summary>
        /// 关于按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_About_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void skinWaterTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
