using CCWin;
using DataConvert.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Test.MyTool;

namespace Test
{
   
    public partial class FileChoose : CCSkinMain
    {
        public FileChoose()
        {
            InitializeComponent();
        }


        public static string newName = ""; //用来保存第一个图片名，全局静态变量
       

        /// <summary>
        /// 根据图片路径获取图片名称
        /// </summary>
        /// <param name="length"></param>
        /// <param name="picPath"></param>
        /// <returns></returns>
        private string getPicName(int length,string picPath)
        {
            return picPath.Split('\\')[length - 1].Substring(0, picPath.Split('\\')[length - 1].LastIndexOf("."));
        }
        /// <summary>
        /// 根据图片路径获取数据名称（图片所在文件夹名称）
        /// </summary>
        /// <param name="length"></param>
        /// <param name="picPath"></param>
        /// <returns></returns>
        private string getDataName(int length, string picPath)
        {
            return picPath.Split('\\')[length - 1];
        }
     

        private void button2_Click(object sender, EventArgs e)
        {

            //int n ;

            //n = UploadFtp("C:\\Users\\Administrator\\Desktop\\3333333.jpg");
            ////MessageBox.Show("@\"" + textBox1.Text + "\""); //转换一下路径
            ////string covFileName ="" ;
            ////MessageBox.Show(textBox1.Text.Replace("\\", "\\\\")); //转换一下路径
            ////fsc = UploadFileInFTP(textBox1.Text.Replace("\\","\\\\")); //可以根据文件完整路径来上传到指定位置
            //if (n == -1)
            //{
            //    MessageBox.Show("上传失败！");
            //}
            //else if (n == 0)
            //{
            //    MessageBox.Show("上传成功！");
            //}
        }

        private void getPicName(string picPath)
        {

        }

        //文件上传ftp服务器的方法一
        public static FtpStatusCode UploadFileInFTP(string filename)
        {
            Stream requestStream = null;
            FileStream fileStream = null;
            FtpWebResponse uploadResponse = null;
            FtpWebRequest uploadRequest = null;
            string serverIP = "10.148.135.161"; /* ftp://10.148.135.161/ */
            string userName = "";
            string password = "";
            string uploadurl;

            try
            {
                //serverIP = System.Configuration.ConfigurationManager.AppSettings["FTPServerIP"];
                //userName = System.Configuration.ConfigurationManager.AppSettings["UserName"];
                //password = System.Configuration.ConfigurationManager.AppSettings["Password"];
                uploadurl = "ftp://" + serverIP + "/" + Path.GetFileName(filename);//上传到ftp根目录下
                uploadRequest = (FtpWebRequest)WebRequest.Create(uploadurl);
                uploadRequest.Method = WebRequestMethods.Ftp.UploadFile;
                uploadRequest.Proxy = null;
                NetworkCredential nc = new NetworkCredential();
                nc.UserName = userName;
                nc.Password = password;
                uploadRequest.Credentials = nc;
                requestStream = uploadRequest.GetRequestStream();
                fileStream = File.Open(filename, FileMode.Open);

                byte[] buffer = new byte[1024];
                int bytesRead;

                while (true)
                {
                    bytesRead = fileStream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0)
                    {
                        break;
                    }
                    requestStream.Write(buffer, 0, bytesRead);
                    requestStream.Flush();
                }

                requestStream.Close();
                uploadResponse = (FtpWebResponse)uploadRequest.GetResponse();
                return uploadResponse.StatusCode;
            }
            catch (Exception e)
            {
                //SystemLog.logger(e.InnerException.Message);
            }
            finally
            {
                if (uploadResponse != null)
                {
                    uploadResponse.Close();
                }
                if (fileStream != null)
                {
                    fileStream.Close();
                }
                if (requestStream != null)
                {
                    requestStream.Close();
                }

            }
            return FtpStatusCode.Undefined;
        }
        FtpStatusCode fsc;
        private void button2_Click_1(object sender, EventArgs e)
        {

            fsc = new FtpStatusCode();
            fsc = UploadFileInFTP("C:\\Users\\Administrator\\Desktop\\3333333.jpg");
            //MessageBox.Show("@\"" + textBox1.Text + "\""); //转换一下路径
            //string covFileName ="" ;
            //MessageBox.Show(textBox1.Text.Replace("\\", "\\\\")); //转换一下路径
            //fsc = UploadFileInFTP(textBox1.Text.Replace("\\","\\\\")); //可以根据文件完整路径来上传到指定位置
            if (fsc.ToString().Equals("Undefined"))
            {
                MessageBox.Show("上传失败！");
            }
            else if (fsc.ToString().Equals("ClosingData"))
            {
                MessageBox.Show("上传成功！");
            }
        }
        //文件上传ftp服务器的方法二 F:\ftproot\case\recdata\2016\1
        public static int UploadFtp(string fileName,int i)
        {
            //读取C:\UserLoginInfo文件中的信息
            //string path = @"D:\UserLoginInfo";
            string path = Application.StartupPath + "\\" + "UserLoginInfo";
            XElement root = XElement.Load(path);
            string ftpServerIP = root.Element("Category").Element("FtpIp").Value;
            string ftpUserID = root.Element("Category").Element("FtpName").Value;
            string ftpPassword = root.Element("Category").Element("FtpWord").Value;

           
            // 需要上传到FTP服务器的本地文件  
            FileInfo fileInfo = new FileInfo(fileName);

            // 用于接收上传文件的FTP服务器上的文件地址  
            //string uri = "ftp://" + ftpServerIP + "/" + Path.GetFileName(fileName);//上传到ftp根目录下;
            string fileuri = "ftp://" + ftpServerIP + "/case/recdata/2016/1/" + FileManage.currentCaseNum; //ftp文件夹的目录


            FtpWebRequest req = (FtpWebRequest)WebRequest.Create(fileuri);
            req.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
            req.UseBinary = true;
            req.UsePassive = true;
            req.KeepAlive = false;
            req.Timeout = 6000000;
            req.Method = WebRequestMethods.Ftp.MakeDirectory;
           
            try
            {
                System.Net.ServicePointManager.DefaultConnectionLimit = 200;
                FtpWebResponse response = (FtpWebResponse)req.GetResponse();
                response.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("异常：" + ex.Message);
                req.Abort();

            }

            //获取图片原来的名字string uri = fileuri + "/" + Path.GetFileName

            string dirPath = ""; //图片所在文件夹的路径
            dirPath = fileName.Substring(0, fileName.LastIndexOf("\\"));
            string uri = "";
            string[] files = Directory.GetFiles(dirPath, "*.jpg",SearchOption.AllDirectories);
            //MessageBox.Show("图片个数："+files.Length);
           
            //string newName = "";
            if (i == 0)
            {
                //newName = System.Guid.NewGuid().ToString("N");
                uri = fileuri + "/" + newName + ".jpg";
                   
                 
            }
            if (i > 0)
            {
                i = i + 1;
                uri = fileuri + "/" + newName + "-" + i + ".jpg";
                   
            }


            FtpWebRequest reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(uri));
            try
            {
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword); // 设置FTP服务器的用户名和密码  
                reqFTP.KeepAlive = false;   // 执行完命令之后关闭连接  
                reqFTP.UseBinary = true;    // 使用二进制传输方式  
                reqFTP.EnableSsl = false;   // 不使用SSL连接  
                reqFTP.UsePassive = true;   // 使用被动模式  

                // 指定发送到FTP服务器的命令为：上传  
                reqFTP.Method = WebRequestMethods.Ftp.UploadFile;

                int buffLength = 2048;
                byte[] buff = new byte[buffLength];

                // 读取本地文件数据流  
                FileStream fs = fileInfo.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                int contentLen = fs.Read(buff, 0, buffLength);

                // 通过FTP服务器上传数据流将本地文件数据写入到服务器上  
                Stream strm = reqFTP.GetRequestStream();
                while (contentLen != 0)
                {
                    strm.Write(buff, 0, contentLen);
                    contentLen = fs.Read(buff, 0, buffLength);
                }

                // 关闭流  
                strm.Flush();
                strm.Close();
                fs.Flush();
                fs.Close();
                return 0;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("异常："+ex.Message);
                return -1;
            }

           
        }

        //读取指定xml文件，把节点中的值放入集合中
        private static IList<string> getXmlValue(XmlNodeList xnl, IList<string> arr)
        {
            foreach (XmlElement item in xnl)
            {
                // Console.WriteLine(item.InnerText.ToString().Trim());
                arr.Add(item.InnerText.ToString().Trim());
            }
            return arr;
        }

        private void FileChoose_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileNames[this.listView1.SelectedItems[0].Index];

            }
        }
        /// <summary>
        /// 实现异步上传
        /// </summary>
        static class DoAsyncUpload
        {
            public static async Task<int> UpAsync(string path, int i)
            {
                int sum = await Task.Run(()=>GetSum(path,i));
                return sum;
            }

            private static int GetSum(string path, int i)
            {
                return UploadFtp(path, i); 
            }
        }


        public void UploadAllFile(int piccounts)
        {
            for (int i = 0; i < piccounts; i++)
            {

                string fileName = openFileDialog1.FileNames[i];
                string fileDir = Path.GetDirectoryName(openFileDialog1.FileName);
                //GetPicThumbnail(fileName, fileDir+"\\TEMP", 2592, 1943, 1);
                //MessageBox.Show(textBox1.Text);
                skinTextBox1.Text = fileName;
                this.imageList1.Images.Add(Image.FromFile(fileName));

                this.listView1.Items.Add(fileName.Substring(fileName.LastIndexOf(@"\") + 1), i);
                this.listView1.LargeImageList = this.imageList1;
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName); //显示第一张

                try
                {

                    // pic[i].Image = Image.FromFile(openFileDialog1.FileNames[i]); //显示图片
                    Task<int> n;

                    // n = UploadFtp(openFileDialog1.FileNames[i].Replace("\\", "\\\\"), i); //可以根据文件完整路径来上传到指定位置



                    n = DoAsyncUpload.UpAsync(openFileDialog1.FileNames[i].Replace("\\", "\\\\"), i);

                    if (n == null) // n == -1
                    {
                        MessageBox.Show("图片上传失败！");
                    }
                    else if (n != null) //  n == 0;
                    {
                        // MessageBox.Show("图片上传成功！");
                    }


                }
                catch (Exception)
                {
                    //MessageBox.Show("上传失败！");
                    throw;
                }
                finally
                {
                    listView1.EndUpdate();
                }

            }
        }

        public delegate void UpDelegate(int i);
        private void skinButton1_Click(object sender, EventArgs e)
        {
            //openFileDialog1.Filter = "你想要的文件类型";
            // openFileDialog1.FileName = "";
            //选取多个文件
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //textBox1.Text = openFileDialog1.FileName;
                //string fileName = "";
              
                listView1.Items.Clear();//每次点击事件后将ListView中的数据清空，重新显示
                imageList1.Images.Clear(); //每次点击事件后将imageList中的图片清空，重新显示

                listView1.View = View.LargeIcon;
                listView1.BeginUpdate();

                int piccounts = openFileDialog1.FileNames.Count();

                UpDelegate ud = UploadAllFile;
                //ud.Invoke(piccounts);

                  ud.BeginInvoke(piccounts, null, null);

                
                string dirPath = ""; //图片所在文件夹的路径

               // dirPath = skinTextBox1.Text.Substring(0, skinTextBox1.Text.LastIndexOf("\\"));
                dirPath = Path.GetDirectoryName(openFileDialog1.FileName);

                string[] files = Directory.GetFiles(dirPath, "*.jpg", SearchOption.AllDirectories);
                //MessageBox.Show("图片个数：" + files.Length);//获取所选取文件夹下所有图片的文件
                //获取图片名称（不包含图片后缀名）
                int picNum;
                picNum = dirPath.Split('\\').Count();
                //string picNameWithoutJpg = getPicName(picNum, skinTextBox1.Text.Trim()); //图片名
                string picNameWithoutJpg = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                //MessageBox.Show("图片名："+picNameWithoutJpg);
                string dateName = getDataName(picNum, dirPath);
               
                //插入RECDATA表中
                //RECDATA rec = SystemHandler.Instance.EstateContext.GetEntity<RECDATA>();
                RECANDAPPFORM recandappform = SystemHandler.Instance.EstateContext.GetEntity<RECANDAPPFORM>("CASENUM", FileManage.currentCaseNum);
                string lastCaseName = "";
                if (recandappform != null)
                {
                    RECDATA rec = new RECDATA();
                    rec.RECDATAID = newName;
                    rec.CASENUM = recandappform.CASENUM;
                    rec.DATANO = MyUtil.getDataNo(dateName);
                    rec.DATANAME = dateName;
                    rec.DATATYPES = "1";
                    rec.LOTNUM = 1;
                    rec.RECDATE = recandappform.RECDATE;
                    rec.ISRECVEIVE = 1;
                    rec.ISMUST = 1;
                    rec.STOREPATH = "2016/1/" + rec.CASENUM;
                    //根据各类型名称顺序和文件夹下图片数量确定STARTPAGE和PAGENUM的值
                    IList<RECDATA> recdata = SystemHandler.Instance.EstateContext.GetList<RECDATA>("CASENUM", rec.CASENUM);
                    if (recdata.Count() > 0)
                    {
                        //MessageBox.Show("集合长度： " + recdata.Count());
                        lastCaseName = recdata[recdata.Count() - 1].DATANAME;
                    }

                    if (rec.DATANAME.Equals("不动产登记申请表"))
                    {
                        if (MyUtil.isPicNull(files.Length))
                        {
                            rec.PAGENUM = 0;
                            rec.STARTPAGE = 0;
                        }
                        else
                        {
                            if (recdata.Count() == 0)
                            {
                                rec.PAGENUM = files.Length;
                                rec.STARTPAGE = 1;
                                try
                                {
                                    SystemHandler.Instance.EstateContext.Add(rec);
                                }
                                catch (Exception)
                                {

                                    throw;
                                }
                               

                            }
                        }

                    }
                    else
                    {

                        //rec.PAGENUM = files.Length;
                        //rec.STARTPAGE = 1;
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.Load("dataname.xml"); //"D:\dataname.xml
                                                     // 得到根节点bookstore
                        XmlNode xn = xmlDoc.SelectSingleNode("DATANAMES");
                        // 得到根节点的所有子节点
                        XmlNodeList xnl = xn.ChildNodes;
                        IList<string> CurrcaseNames = new List<string>();
                        getXmlValue(xnl, CurrcaseNames);
                        //string[] CurrcaseNames = { "不动产登记审批表", "不动产权调查资料", "不动产权证书原件及复印件", "查档记录表", "法律、行政法规规定的其他必要材料",
                        //                             "房产测绘报告","房屋买卖合同或其他证明不动产权发生转移德材料","购房发票","其他","商品房用地宗地分割转让登记证明" 
                        //                         ,"授权委托书及委托人身份证复印件","双方申请人身份证明","完税证明及税费发票复印件","宗地图"};

                        foreach (var item in CurrcaseNames)
                        {
                            if (rec.DATANAME.Equals(item))
                            {
                                MyUtil.setStartPageAndPageNum(rec.DATANAME, lastCaseName, rec, files.Length, files, newName);
                            }
                        }





                        MessageBox.Show("数据导入完成！");
                    }


                }

            }

            // openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

        }

        private void FileChoose_Load_1(object sender, EventArgs e)
        {
            newName = System.Guid.NewGuid().ToString("N"); //弹出导入界面的时候赋初始值
        }
    }
}
