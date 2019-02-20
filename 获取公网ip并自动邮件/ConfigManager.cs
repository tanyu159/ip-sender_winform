using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace 获取公网ip并自动邮件
{
   public class ConfigManager
    {
        /// <summary>
        /// 该类作为工具类，不可生成对象
        /// </summary>
        private ConfigManager()
        {
        }
        /// <summary>
        /// 生成配置信息xml文件
        /// </summary>
        /// <param name="path">存储路径</param>
        /// <param name="configInfoObj">获得的ConfigInfo对象</param>
        /// <param name="isDefault">是否生成默认值，即没有xml文件的情况下，因为要保证应用开启时回显上一次数据</param>
        public static void CreatConfigXML(string path, ConfigInfo configInfoObj, bool isDefault)
        {
            if (isDefault)
            {
                XmlDocument xmldoc = new XmlDocument();
                XmlElement root=xmldoc.CreateElement("root");
                XmlElement senderEmailAddress = xmldoc.CreateElement("senderEmailAddress");
                XmlElement senderEmailSecurityCode = xmldoc.CreateElement("senderEmailSecurityCode");
                XmlElement receiverEmailAddress = xmldoc.CreateElement("receiverEmailAddress");
                XmlElement emailTitle = xmldoc.CreateElement("emailTitle");
                XmlElement pcName = xmldoc.CreateElement("pcName");
                //默认值情况赋值，仅仅表示一个格式
                senderEmailAddress.InnerText = "123@qq.com";
                senderEmailSecurityCode.InnerText = "abCdEfghI";
                receiverEmailAddress.InnerText = "456@qq.com";
                emailTitle.InnerText = "来自 五航战-瑞鹤酱 的主机";
                pcName.InnerText = "zuikaku's pc";
                //节点父子关系确定
                xmldoc.AppendChild(root);//设置根节点
                //其余都是root的子节点，且平级
                root.AppendChild(senderEmailAddress);
                root.AppendChild(senderEmailSecurityCode);
                root.AppendChild(receiverEmailAddress);
                root.AppendChild(emailTitle);
                root.AppendChild(pcName);
                //写入文件
                xmldoc.Save(path);
            }
            else {
                XmlDocument xmldoc = new XmlDocument();
                XmlElement root = xmldoc.CreateElement("root");
                XmlElement senderEmailAddress = xmldoc.CreateElement("senderEmailAddress");
                XmlElement senderEmailSecurityCode = xmldoc.CreateElement("senderEmailSecurityCode");
                XmlElement receiverEmailAddress = xmldoc.CreateElement("receiverEmailAddress");
                XmlElement emailTitle = xmldoc.CreateElement("emailTitle");
                XmlElement pcName = xmldoc.CreateElement("pcName");
                //设置面板输入值的情况
                senderEmailAddress.InnerText = configInfoObj.senderEmailAddress;
                senderEmailSecurityCode.InnerText = configInfoObj.senderEmailSecurityCode;
                receiverEmailAddress.InnerText = configInfoObj.receiverEmailAddress;
                emailTitle.InnerText = configInfoObj.emailTitle;
                pcName.InnerText = configInfoObj.pcName;
                //节点父子关系确定
                xmldoc.AppendChild(root);//设置根节点
                //其余都是root的子节点，且平级
                root.AppendChild(senderEmailAddress);
                root.AppendChild(senderEmailSecurityCode);
                root.AppendChild(receiverEmailAddress);
                root.AppendChild(emailTitle);
                root.AppendChild(pcName);
                //写入文件
                xmldoc.Save(path);
                
            }
        }
        /// <summary>
        /// 解析保存的xml配置文件
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <returns></returns>
        public static ConfigInfo ParseConfigXml(string path)
        {
           
            if (!File.Exists(path))
            {
                //文件不存在则说明是首次启用，则直接载入默认配置
                CreatConfigXML(path, null, true);
            }
            //前面保证了必然存在配置文件，现进行解析
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
            XmlNodeList senderEmailAddressNode = xmlDoc.GetElementsByTagName("senderEmailAddress");
            XmlNodeList senderEmailSecurityCodeNode = xmlDoc.GetElementsByTagName("senderEmailSecurityCode");
            XmlNodeList receiverEmailAddressNode = xmlDoc.GetElementsByTagName("receiverEmailAddress");
            XmlNodeList emailTitleNode = xmlDoc.GetElementsByTagName("emailTitle");
            XmlNodeList pcNameNode = xmlDoc.GetElementsByTagName("pcName");
            string senderEmailAddress = senderEmailAddressNode[0].InnerText;
            string senderEmailSecurityCode = senderEmailSecurityCodeNode[0].InnerText;
            string receiverEmailAddress = receiverEmailAddressNode[0].InnerText;
            string emailTitle = emailTitleNode[0].InnerText;
            string pcName = pcNameNode[0].InnerText;
            ConfigInfo configInfo = new ConfigInfo(senderEmailAddress, senderEmailSecurityCode, receiverEmailAddress, emailTitle, pcName);
            return configInfo;
        }
    }
}
