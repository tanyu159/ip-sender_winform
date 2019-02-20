using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 获取公网ip并自动邮件
{
    /// <summary>
    /// 配置信息类
    /// </summary>
    public class ConfigInfo
    {
        /// <summary>
        /// 发送者邮箱地址
        /// </summary>
        public string senderEmailAddress;
        /// <summary>
        /// 发送者邮箱安全码
        /// </summary>
        public string senderEmailSecurityCode;
        /// <summary>
        /// 接收者邮箱安全码
        /// </summary>
        public string receiverEmailAddress;
         /// <summary>
         /// 邮件标题
         /// </summary>
        public string emailTitle;
        /// <summary>
        /// 主机名字
        /// </summary>
        public string pcName;

        public ConfigInfo(string senderEmailAddress, string senderEmailSecurityCode, string receiverEmailAddress, string emailTitle, string pcName)
        {
            this.senderEmailAddress = senderEmailAddress;
            this.senderEmailSecurityCode = senderEmailSecurityCode;
            this.receiverEmailAddress = receiverEmailAddress;
            this.emailTitle = emailTitle;
            this.pcName = pcName;
        }

        public override string ToString()
        {
            return "发件人邮箱:" + senderEmailAddress + "\n"
                   + "发件人邮箱安全校验码:" + senderEmailSecurityCode + "\n"
                   + "收件人邮箱:" + receiverEmailAddress + "\n"
                   + "邮件标题:" + emailTitle + "\n"
                   + "主机名字:" + pcName;
        }
    }
}
