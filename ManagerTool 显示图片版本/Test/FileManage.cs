using CCWin;
using DataConvert.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Test
{
    public partial class FileManage : CCSkinMain
    {
        public static string currentCaseNum = "";
        public FileManage()
        {
            InitializeComponent();
        }

        private void FileManage_Load(object sender, EventArgs e)
        {

        }
        //获取当前不动产单元号的受理过的案件编号
        public void Print_CaseNum(IList<REUANDCASE> reuandcaselist, DataGridView dataGridView1)
        {

            for (int i = 0; i < reuandcaselist.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = reuandcaselist[i].CASENUM;   //流程号
                string caseNum = dataGridView1.Rows[i].Cells[0].Value.ToString();
                Print_Recandappform(caseNum, i, dataGridView1);
                //MessageBox.Show(pr2[i].PROCESS_NAME);
                //dataGridView1.Rows[i].Cells[1].Value = caseNames[i]
            }
            //隐藏所有REUANDCASE表中列
            dataGridView1.Columns["REALEUNUM"].Visible = false;
            dataGridView1.Columns["CASENUM"].Visible = false;
            dataGridView1.Columns["TRADEPRICE"].Visible = false;
            dataGridView1.Columns["EVAAMOUNT"].Visible = false;
            dataGridView1.Columns["PLEAMOUNT"].Visible = false;
            dataGridView1.Columns["PLERANGE"].Visible = false;
            dataGridView1.Columns["ORGCARDNUM"].Visible = false;
            //dataGridView1.Columns["YID"].Visible = false;
            dataGridView1.Columns["ID"].Visible = false;
        }

       
        //根据不动产单元号来获取申请表中的信息
        public void Print_Recandappform(string caseNum,int i, DataGridView dataGridView1)
        {
            RECANDAPPFORM recandappform = SystemHandler.Instance.EstateContext.GetEntity<RECANDAPPFORM>("CASENUM", caseNum);
            if (recandappform != null)
            {
                dataGridView1.Rows[i].Cells[1].Value = recandappform.BUSTYPE; //登记类型
                dataGridView1.Rows[i].Cells[2].Value = recandappform.RECMAN; //权利人
                dataGridView1.Rows[i].Cells[3].Value = recandappform.OBLIGEENAME; //义务人
            }
            
        }

   
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (skinDataGridView1.Columns[e.ColumnIndex].Name == "Column10" && skinDataGridView1.Rows[0].Cells[0].Value != null)
            {
                
                //MessageBox.Show("按钮被点击了" + dataGridView1.CurrentRow.Cells[0].Value); //获取当前行的流程号
                currentCaseNum = skinDataGridView1.CurrentRow.Cells[0].Value.ToString();
                FileChoose fileChoose = new FileChoose();
                fileChoose.ShowDialog();

            }
        }



        private void skinButton1_Click(object sender, EventArgs e)
        {
            //读取C:\UserLoginInfo文件中的信息
            //string path = @"D:\UserLoginInfo";
            string path = Application.StartupPath +"\\"+ "UserLoginInfo";

            XElement root = XElement.Load(path);
            string IP = root.Element("Category").Element("IP").Value;
            string Sid = root.Element("Category").Element("Sid").Value;
            string estateName = root.Element("Category").Element("estateName").Value;
            string estateWord = root.Element("Category").Element("estateWord").Value;
            //连接不动产库

            SystemHandler.Instance.Estateconnectionstring = string.Format(SystemHandler.commonOracleDataBaseConnectionStr1, IP, Sid, estateName, estateWord); //连接不动产库
            //获取不动产单元号
            string realnum = "";
            realnum = skinTextBox1.Text.Trim();
            if (realnum.Equals("") || realnum == null)
            {
                MessageBox.Show("请输入不动产单元号！");
            }
            else if (realnum.Length < 28)
            {
                MessageBox.Show("不动产单元号长度有误！");
            }
            else
            {
                //MessageBox.Show(realnum);
                IList<REUANDCASE> reuandcaselist = SystemHandler.Instance.EstateContext.GetList<REUANDCASE>("WHERE  REALEUNUM = '" + realnum + "'"); //获取REUANDCASE
                skinDataGridView1.DataSource = reuandcaselist;
                if (reuandcaselist.Count() > 0)
                {
                    Print_CaseNum(reuandcaselist, skinDataGridView1);
                }


            }

        }
    }
}
