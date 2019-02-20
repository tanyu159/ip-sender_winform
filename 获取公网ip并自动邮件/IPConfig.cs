using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace 获取公网ip并自动邮件
{
    public class IPConfig
    {
        /// <summary>
        /// 爬去到url对应的所有网页内容，即html页面
        /// </summary>
        /// <param name="url">网页链接</param>
        /// <returns></returns>
        public static string GetAllWebContent(string url)
        {

            WebRequest request = WebRequest.Create(url); //目标网页的URL
            WebResponse response = (WebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();//用流来接受爬出的数据
            StreamReader reader = new StreamReader(dataStream, Encoding.UTF8);
            string text = reader.ReadToEnd();//读取数据
            string allWebContentFilePath = Application.StartupPath+ @"\allContent.txt";
            File.WriteAllText(allWebContentFilePath, text);//写入XML文件中
            if (File.Exists(allWebContentFilePath))
            {
                return allWebContentFilePath;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取有效信息，对源码进行截取，输入到新的xml中
        /// </summary>
        /// <param name="allContentFilePath">\allContent.txt的路径</param>
        /// <param name="start">开始行</param>
        /// <param name="end">结束行</param>
        /// <returns></returns>
        public static string GetAvailableInfo(string allContentFilePath, int start, int end)
        {
            string[] allLines = File.ReadAllLines(allContentFilePath);
            //信息结构化之后存储路径
            string constructXMLpath = Application.StartupPath+ @"\availableInfo.xml";
            string[] temp = new string[end - start + 3];
            temp[0] = "<root>";
            for (int i = start; i <= end; i++)
            {
                temp[i - start + 1] = allLines[i];

            }
            temp[end - start + 2] = "</root>";
            //写入到结果文件，所需要的信息存储在E:\availableInfo.xml中
            File.WriteAllLines(constructXMLpath, temp);
            if (File.Exists(constructXMLpath))
            {
                return constructXMLpath;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 解析xml获得外网地址
        /// </summary>
        /// <param name="xmlPath">availableInfo.xml的路径</param>
        /// <returns>外网ip地址：xxx.xxx.xxx.xxx</returns>
        public static string GetExternal_IP(string xmlPath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlPath);
            XmlNodeList h2Node = xmlDoc.GetElementsByTagName("h2");
            string ipAddress = h2Node[0].InnerText;
            return ipAddress;
        }

        



        /// <summary>
        /// 发送邮件到指定邮箱
        /// </summary>
        /// <param name="mailTitle">邮件标题</param>
        /// <param name="content">邮件内容</param>
        /// <param name="senderMailAddress">发送者邮箱</param>
        /// <param name="senderMailSecurityCode">发送者邮箱校验码</param>
        /// <param name="recevierMailAdress">接收者邮箱</param>
        public static void SendEmail(string mailTitle, string content, string senderMailAddress, string senderMailSecurityCode, string recevierMailAdress)
        {
            //实例化一个发送邮件类。
            MailMessage mailMessage = new MailMessage();
            //发件人邮箱地址，方法重载不同，可以根据需求自行选择。
            mailMessage.From = new MailAddress(senderMailAddress);
            //收件人邮箱地址。
            mailMessage.To.Add(new MailAddress(recevierMailAdress));
            //邮件标题。
            mailMessage.Subject = mailTitle;
            //邮件内容。
            mailMessage.Body = content;
            //实例化一个SmtpClient类。
            SmtpClient client = new SmtpClient();
            //在这里我使用的是qq邮箱，所以是smtp.qq.com，如果你使用的是126邮箱，那么就是smtp.126.com。
            client.Host = "smtp.qq.com";
            //使用安全加密连接。
            client.EnableSsl = true;
            //不和请求一块发送。
            client.UseDefaultCredentials = false;
            //验证发件人身份(发件人的邮箱，邮箱里的生成授权码,非邮箱密码);"1274659231@qq.com", "rzkjceaurwazhibd"
            client.Credentials = new NetworkCredential(senderMailAddress, senderMailSecurityCode);
            //发送
            client.Send(mailMessage);

        }
    }
}
