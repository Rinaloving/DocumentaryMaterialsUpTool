using CCWin;
using DataConvert.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Test
{
    public partial class Form3 : CCSkinMain
    {
        public static DialogResult checkResult; //用来判断连接是否成功

        public Form3()
        {
            InitializeComponent();
        }
        private string IP = string.Empty;
        private string Sid = string.Empty;
        private string estateName = string.Empty;
        private string estateWord = string.Empty;
        private string FtpIp = string.Empty;
        private string FtpName = string.Empty;
        private string FtpWord = string.Empty;
        private static string path = Application.StartupPath + "\\" + "UserLoginInfo";

        private void Form3_Load(object sender, EventArgs e)
        {
            //加载时，默认的初始值
            InitConfigurationFile();
        }
       

        //初始化配置文件    
        public void InitConfigurationFile()
        {
            if (!File.Exists(path))
            {
                //设置默认值
                IP = "127.0.0.1";
                Sid = "orcl";
                estateName = "estate";
                estateWord = "estate";
                FtpIp = "127.0.0.1";
                FtpName = "root";
                FtpWord = "123";
                //创建配置文件
                XElement root = new XElement("Categories",
                   new XElement("Category",
                       new XElement("IP", IP),
                       new XElement("Sid", Sid),
                       new XElement("estateName", estateName),
                       new XElement("estateWord", estateWord),
                       new XElement("FtpIp", FtpIp),
                       new XElement("FtpName", FtpName),
                       new XElement("FtpWord", FtpWord))
               );
                root.Save(path);

            }
        }


        /// <summary>
        /// 测试连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton1_Click(object sender, EventArgs e)
        {
            XElement root = XElement.Load(path);
            IP = root.Element("Category").Element("IP").Value;
            Sid = root.Element("Category").Element("Sid").Value;
            estateName = root.Element("Category").Element("estateName").Value;
            estateWord = root.Element("Category").Element("estateWord").Value;

            try
            {

                bool result2 = SystemHandler.Instance.TestOracleConnection1(IP, Sid, estateName, estateWord);

                if (result2)
                {
                    MessageBox.Show("连接成功！");
                    checkResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("连接失败！");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("连接失败！");
            }
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton2_Click(object sender, EventArgs e)
        {

            if (checkResult == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;    //返回一个登录成功的对话框状态
                this.Close();    //关闭登录窗口
            }
            else
            {
                MessageBox.Show("无法登录！");
            }

        }
    }
}
