using SmartMap.DataClient.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
namespace DataConvert.Business
{
    public class SystemHandler
    {
        #region 声明
        private static SystemHandler mInstance = null;

        private static readonly object lockAssistant = new object();

        public static SystemHandler Instance
        {
            get
            {
                if (mInstance == null)
                {
                    lock (lockAssistant)
                    {
                        if (mInstance == null)
                        {
                            mInstance = new SystemHandler();
                        }
                    }
                }
                return mInstance;
            }
        }

        private SystemHandler()
        { }
        #endregion
        /// <summary>
        /// 创建日志表DDL
        /// </summary>
        public static readonly string createtoestatelog = @"create table toestatelog(logid   nvarchar2(40),djh  nvarchar2(30) not null,logtype integer,logmemo nvarchar2(1024),logtime date);comment on column toestatelog.logid is '主键';comment on column toestatelog.djh is '19位地籍号';comment on column toestatelog.logtype is '日志类型(1转换成功2转换失败3不转换)'; comment on column toestatelog.logmemo is '日志内容'; comment on column toestatelog.logtime is '日志时间'; alter table toestatelog add constraint pktoestate primary key (LOGID);  alter table toestatelog add constraint unqtoestate unique (DJH)";
        /// <summary>
        /// 创建IMG日志表DDL
        /// </summary>
        public static readonly string createimglog = @"create table CLFJ_TAB_LOG( LOGID  NVARCHAR2(40) not null,CLFJID  INTEGER,SJDBH  NVARCHAR2(32),XH INTEGER,CLFJMC NVARCHAR2(255),FJCLGS NVARCHAR2(32),SFHF INTEGER,BZ1 NVARCHAR2(255),BZ2 NVARCHAR2(255),BZ3 NVARCHAR2(255),BZ4 NVARCHAR2(255),LCSLID NVARCHAR2(40),ISFIXEDACCESSORY NVARCHAR2(5),LOGTYPE INTEGER,LOGMEMO NVARCHAR2(1024),LOGTIME DATE);comment on column CLFJ_TAB_LOG.LOGID is '主键';comment on column CLFJ_TAB_LOG.LOGTYPE is '日志类型(1转换成功2转换失败)';comment on column CLFJ_TAB_LOG.LOGMEMO is '日志内容';comment on column CLFJ_TAB_LOG.LOGTIME  is '日志时间';alter table CLFJ_TAB_LOG add constraint PK_LOG primary key (LOGID)";
        /// <summary>
        /// 创建注销房产日志表DDL
        /// </summary>
        public static readonly string createzxlog = @"CREATE TABLE zxlog ([LOGID] nvarchar(50) NOT NULL ,[keycode] nvarchar(50) NULL ,[LOGTYPE] int NULL ,[LOGMEMO] nvarchar(2000) NULL ,[LOGTIME] datetime NULL ,PRIMARY KEY ([LOGID]))";
        /// <summary>
        /// 创建撤销注销房产日志表DDL
        /// </summary>
        public static readonly string createcxzxlog = @"CREATE TABLE cxzxlog ([LOGID] nvarchar(50) NOT NULL ,[keycode] nvarchar(50) NULL ,[LOGTYPE] int NULL ,[LOGMEMO] nvarchar(2000) NULL ,[LOGTIME] datetime NULL ,PRIMARY KEY ([LOGID]))";
        /// <summary>
        /// 创建汇交日志表DDL
        /// </summary>
        public static readonly string createhjlog = @"create table hjlog(logid nvarchar2(40),logtype integer,logtablename nvarchar2(40),logtablepk nvarchar2(100),logmemo nvarchar2(1024),logtime date);comment on table hjlog is '汇交日志表';comment on column hjlog.logid is '主键';comment on column hjlog.logtype is '日志类型(1成功2失败)';comment on column hjlog.logtablename is '日志数据来源的表名称，如BUILDING';comment on column hjlog.logtablepk is '日志数据来源的表关键数据，如BUILDINGID';comment on column hjlog.logmemo is '日志内容';comment on column hjlog.logtime is '日志时间';alter table hjlog add constraint pkhjlog primary key (LOGID);create index idxLOGTYPE on HJLOG (logtype);create index idxLOGTABLENAME on HJLOG (logtablename);create index idxLOGTABLEPK on HJLOG (logtablepk)";
        /// <summary>
        /// 通用Oracle连接字符串(瘦连接)
        /// </summary>
        public static string commonOracleDataBaseConnectionStr1 = @"Data Source=(DESCRIPTION =  (ADDRESS_LIST =  (ADDRESS = (PROTOCOL = TCP)(HOST = {0})(PORT = 1521))) (CONNECT_DATA =(SID = {1}) (SERVER = DEDICATED) ));User Id={2};Password={3};";
        /// <summary>
        /// 通用Oralce连接字符串(胖连接)
        /// </summary>
        public static string commonOracleDataBaseConnectionStr2 = @"Data Source={0};User Id = {1};Password = {2}";
        /// <summary>
        /// 通用Access连接字符串
        /// </summary>
        public static string commonAccessDataBaseConnectionStr1 = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};User Id={1};Password={2};";

        /// <summary>
        /// 通用SqlServer连接字符串
        /// </summary>
        public static string commonSqlServerConnectionStr1 = @"Data Source = {0};Initial Catalog = {1};User Id = {2};Password = {3}";


        /// <summary>
        /// 测试Oracle数据库连接(瘦连接)
        /// </summary>
        /// <param name="Host"></param>
        /// <param name="SID"></param>
        /// <param name="UserName"></param>
        /// <param name="UserPassword"></param>
        /// <returns></returns>
        public bool TestOracleConnection1(string Host, string SID, string UserName, string UserPassword)
        {
            IDbProvider provider = null;
            try
            {
                provider = new OracleProvider(string.Format(commonOracleDataBaseConnectionStr1, Host, SID, UserName, UserPassword));

                if (provider.Connection.State == ConnectionState.Closed)
                    provider.Open();
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
                //return false;
            }
            finally
            {
                if (provider != null)
                {
                    if (provider.Connection.State != ConnectionState.Closed)
                        provider.Close();
                    provider.Dispose();
                }
            }
        }
        /// <summary>
        /// 测试Oracle数据库连接(胖连接)
        /// </summary>
        /// <param name="DataSource"></param>
        /// <param name="UserName"></param>
        /// <param name="UserPassword"></param>
        /// <returns></returns>
        public bool TestOracleConnection2(string DataSource,  string UserName, string UserPassword)
        {
            IDbProvider provider = null;
            try
            {
                provider = new OracleProvider(string.Format(commonOracleDataBaseConnectionStr2, DataSource, UserName, UserPassword));

                if (provider.Connection.State == ConnectionState.Closed)
                    provider.Open();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (provider != null)
                {
                    if (provider.Connection.State != ConnectionState.Closed)
                        provider.Close();
                    provider.Dispose();
                }
            }
        }
        /// <summary>
        /// 测试SqlServer数据库连接
        /// </summary>
        /// <param name="DataSource"></param>
        /// <param name="Catalog"></param>
        /// <param name="UserName"></param>
        /// <param name="UserPassword"></param>
        /// <returns></returns>
        public bool TestSqlServerConnection1(string DataSource,string Catalog,string UserName, string UserPassword)
        {
            IDbProvider provider = null;
            try
            {
                provider = new SQLServerProvider(string.Format(commonSqlServerConnectionStr1, DataSource,Catalog, UserName, UserPassword));

                if (provider.Connection.State == ConnectionState.Closed)
                    provider.Open();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (provider != null)
                {
                    if (provider.Connection.State != ConnectionState.Closed)
                        provider.Close();
                    provider.Dispose();
                }
            }
        }

        #region IMG 库连接配置
        private string m_IMGconnectionstring = string.Empty;
        /// <summary>
        /// IMG库(IMG)连接串
        /// </summary>
        public string IMGconnectionstring
        {
            get
            {
                return m_IMGconnectionstring;
            }
            set { m_IMGconnectionstring = value; m_IMGContext = new OracleContext(m_IMGconnectionstring); }
        }

        private IDbGUIDOperator m_IMGContext = null;
        /// <summary>
        /// IMG数据库(IMG)操作上下文
        /// </summary>
        public IDbGUIDOperator IMGContext
        {
            get
            {
                if (m_IMGContext == null)
                {
                    m_IMGContext = new OracleContext(IMGconnectionstring);
                }
                return m_IMGContext;
            }
            set { m_IMGContext = value; }
        }

        #endregion

        #region 集体土地所有权数据库连接参数配置
        private string m_SuoYQconnectionstring = string.Empty;
        /// <summary>
        /// 集体土地所有权数据库连接串
        /// </summary>
        public string SuoYQconnectionstring
        {
            get
            {
                return m_SuoYQconnectionstring;
            }
            set { m_SuoYQconnectionstring = value; m_SuoYQContext = new OracleContext(m_SuoYQconnectionstring); }
        }

        private IDbGUIDOperator m_SuoYQContext = null;
        /// <summary>
        /// 集体土地所有权数据库操作上下文
        /// </summary>
        public IDbGUIDOperator SuoYQContext
        {
            get
            {
                if (m_SuoYQContext == null)
                {
                    m_SuoYQContext = new OracleContext(SuoYQconnectionstring);
                }
                return m_SuoYQContext;
            }
            set { m_SuoYQContext = value; }
        }

  

        #endregion

        #region 使用权数据库连接参数配置
        private string m_SYQconnectionstring = string.Empty; //string.Empty和""可以互换使用，只不过string.Empty不分配存储空间，可以方便跨平台
        /// <summary>
        /// 使用权数据库连接串
        /// </summary>
        public string SYQconnectionstring
        {
            get
            {
                if (m_SYQconnectionstring == string.Empty) 
                {
                    List<string> lst = ConfigHelper.GetSYQconnectionstring();
                    if (lst != null && lst.Count == 4)
                        m_SYQconnectionstring = string.Format(commonOracleDataBaseConnectionStr1, lst[0], lst[1], lst[2], lst[3]);

                }
                return m_SYQconnectionstring;
            }
            set { m_SYQconnectionstring = value; m_SYQContext = new OracleContext(m_SYQconnectionstring); }
        }

        private IDbGUIDOperator m_SYQContext = null;
        /// <summary>
        /// 使用权数据库操作上下文
        /// </summary>
        public IDbGUIDOperator SYQContext
        {
            get
            {
                if (m_SYQContext == null)
                {
                    m_SYQContext = new OracleContext(SYQconnectionstring);
                }
                return m_SYQContext;
            }
            set { m_SYQContext = value; }
        }


        #endregion

        #region 不动产登记数据库(estate)连接参数配置
        private string m_Estateconnectionstring = string.Empty;
        /// <summary>
        /// 不动产登记数据库(estate)连接串
        /// </summary>
        public string Estateconnectionstring
        {
            get
            {

                return m_Estateconnectionstring;
            }
            set { m_Estateconnectionstring = value; m_EstateContext = new OracleContext(m_Estateconnectionstring); }
        }

        private IDbGUIDOperator m_EstateContext = null;
        /// <summary>
        /// 不动产登记数据库(estate)操作上下文
        /// </summary>
        public IDbGUIDOperator EstateContext
        {
            get
            {
                if (m_EstateContext == null)
                {
                    m_EstateContext = new OracleContext(Estateconnectionstring);
                }
                return m_EstateContext;
            }
            set { m_EstateContext = value; }
        }
        #endregion

        #region 不动产登记数据库(pfuser)连接参数配置
        private string m_Pfuserconnectionstring = string.Empty;
        /// <summary>
        /// 不动产登记数据库(pfuser)连接串
        /// </summary>
        public string Pfuserconnectionstring
        {
            get
            {

                return m_Pfuserconnectionstring;
            }
            set { m_Pfuserconnectionstring = value; m_PfuserContext = new OracleContext(m_Pfuserconnectionstring); }
        }

       private IDbGUIDOperator m_PfuserContext = null;
        /// <summary>
        /// 不动产登记数据库(pfuser)操作上下文
        /// </summary>
       public IDbGUIDOperator PfuserDbContext
        {
            get
            {
                if (m_PfuserContext == null)
                {
                    m_PfuserContext = new OracleContext(Estateconnectionstring);
                }
                return m_PfuserContext;
            }
            set { m_PfuserContext = value; }
        }

        #endregion

       #region 不动产登记数据库(dzgt40)连接参数配置
       private string m_Dzgt40connectionstring = string.Empty;
       /// <summary>
       /// 不动产登记数据库(pfuser)连接串
       /// </summary>
       public string Dzgt40connectionstring
       {
           get
           {

               return m_Dzgt40connectionstring;
           }
           set { m_Dzgt40connectionstring = value; m_Dzgt40Context = new OracleContext(m_Dzgt40connectionstring); }
       }

       private IDbGUIDOperator m_Dzgt40Context = null;
       /// <summary>
       /// 不动产登记数据库(pfuser)操作上下文
       /// </summary>
       public IDbGUIDOperator Dzgt40Context
       {
           get
           {
               if (m_Dzgt40Context == null)
               {
                   m_Dzgt40Context = new OracleContext(Dzgt40connectionstring);
               }
               return m_Dzgt40Context;
           }
           set { m_Dzgt40Context = value; }
       }

       #endregion

       #region 德州房产库连接配置
       //DZFCconnectionstring
        private string m_DZFCconnectionstring = String.Empty;
        /// <summary>
        /// 当前德州房产数据库连接
        /// </summary>
        public string DZFCconnectionstring
        {
            get
            {
                if (m_DZFCconnectionstring == string.Empty)
                {


                   //this.m_DZFCconnectionstring = AppConfigHelper.GetSettings("DZFCconnectionstring");

                }
                return this.m_DZFCconnectionstring;
            }
            set
            {

                this.m_DZFCconnectionstring = value;
            }
        }
        private IDbGUIDOperator dzfcContext = null;
        /// <summary>
        /// 德州房产数据库操作上下文
        /// </summary>
        public IDbGUIDOperator DZFCDbContext
        {
            get
            {
                if (this.dzfcContext == null)
                {
                    this.dzfcContext = new SQLServerContext(this.DZFCconnectionstring);
                }
                return this.dzfcContext;
            }
            set { this.dzfcContext = value; }
        }
        #endregion

        #region 不动产存量数据汇交



        private string estatehjMDBConnectionString = String.Empty;
        /// <summary>
        /// 不动产存量数据汇交Access数据库连接字符串
        /// </summary>
        public string EstateHJMDBConnectionString
        {
            get
            {
                return this.estatehjMDBConnectionString;
            }
            set
            {
                this.estatehjMDBConnectionString = string.Format(commonAccessDataBaseConnectionStr1, value, "admin", "");
                this.estatehjMDBDbContext = new OLEDBContext(this.estatehjMDBConnectionString);
            }
        }

        private IDbGUIDOperator estatehjMDBDbContext = null;
        /// <summary>
        /// 不动产存量数据汇交Access数据库操作上下文(必须先给EstateHJMDBConnectionString赋值才能使用)
        /// </summary>
        public IDbGUIDOperator EstateHJMDBDbContext
        { 
            get
            {
                return this.estatehjMDBDbContext;
            }            
        }


        private string estatehjEstateconnectionstring = string.Empty;
        /// <summary>
        /// 不动产存量数据汇交estate库连接串
        /// </summary>
        public string EstateHJEstateconnectionstring
        {
            get
            {
                return estatehjEstateconnectionstring;
            }
            set { 
                estatehjEstateconnectionstring = value;
                estatehjEstateContext = new OracleContext(estatehjEstateconnectionstring);
            
            }
        }

        private IDbGUIDOperator estatehjEstateContext = null;
        /// <summary>
        /// 不动产存量数据汇交estate库操作上下文(必须先给EstateHJEstateconnectionstring赋值才能使用)
        /// </summary>
        public IDbGUIDOperator EstateHJContext
        {
            get
            {
                return estatehjEstateContext;
            }            
        }

        #endregion
    }

    public class ConfigHelper
    {
        /// <summary>
        /// 配置文件Config.xml路径
        /// </summary>
        public static readonly string configFilePath = System.Windows.Forms.Application.StartupPath + "/Config.xml";
        public static  void showConfigFilePath()
        {
            MessageBox.Show(configFilePath);
        }
        /// <summary>
        /// 从Config.xml获取集体土地所有权数据库连接参数配置
        /// </summary>
        /// <returns></returns>
        public static List<string> GetSuoYQconnectionstring() //GetSYQconnectionstring
        {
            List<string> lst = new List<string>();
            try
            {
                if (File.Exists(configFilePath))
                {
                    XElement root = XElement.Load(configFilePath);
                    XElement SuoYQ = root.Element("SuoYQConvert").Element("ConnectionConfig").Element("SuoYQ");
                    if (SuoYQ != null)
                    {
                        lst.Add(SuoYQ.Attribute("HOST").Value);
                        lst.Add(SuoYQ.Attribute("SID").Value);
                        lst.Add(SuoYQ.Attribute("UserName").Value);
                        lst.Add(SuoYQ.Attribute("UserPassword").Value);

                    }
                }
            }
            catch 
            {
                
            }
            return lst;
        }

        /// <summary>
        /// 从Config.xml获取土地使用权数据库连接参数配置
        /// </summary>
        /// <returns></returns>
        public static List<string> GetSYQconnectionstring()
        {
            List<string> lst = new List<string>();
            try
            {
                if (File.Exists(configFilePath))
                {
                    XElement root = XElement.Load(configFilePath);
                    XElement SuoYQ = root.Element("SYQConvert").Element("ConnectionConfig").Element("SYQ");
                    if (SuoYQ != null)
                    {
                        lst.Add(SuoYQ.Attribute("HOST").Value);
                        lst.Add(SuoYQ.Attribute("SID").Value);
                        lst.Add(SuoYQ.Attribute("UserName").Value);
                        lst.Add(SuoYQ.Attribute("UserPassword").Value);

                    }
                }
            }
            catch
            {

            }
            return lst;
        }
        /// <summary>
        /// 保存集体土地所有权数据库连接参数配置到Config.xml
        /// </summary>
        /// <param name="Host"></param>
        /// <param name="SID"></param>
        /// <param name="UserName"></param>
        /// <param name="UserPassword"></param>
        /// <returns></returns>
        public static bool SaveSuoYQconnectionstring(string Host, string SID, string UserName, string UserPassword)
        {
            try
            {
                if (File.Exists(configFilePath))
                {
                    XElement root = XElement.Load(configFilePath);
                    XElement SuoYQ = root.Element("SuoYQConvert").Element("ConnectionConfig").Element("SuoYQ");
                    if (SuoYQ != null)
                    {
                        SuoYQ.Attribute("HOST").Value = Host;
                        SuoYQ.Attribute("SID").Value = SID;
                        SuoYQ.Attribute("UserName").Value = UserName;
                        SuoYQ.Attribute("UserPassword").Value = UserPassword;
                        root.Save(configFilePath);
                    }
                }
                return true;
            }
            catch 
            {
                return false;
            }
        }

        /// <summary>
        /// 保存土地使用权数据库连接参数配置到Config.xml
        /// </summary>
        /// <param name="Host"></param>
        /// <param name="SID"></param>
        /// <param name="UserName"></param>
        /// <param name="UserPassword"></param>
        /// <returns></returns>
        public static bool SaveSYQconnectionstring(string Host, string SID, string UserName, string UserPassword)
        {
            try
            {
                if (File.Exists(configFilePath))
                {
                    XElement root = XElement.Load(configFilePath);
                    XElement SuoYQ = root.Element("SYQConvert").Element("ConnectionConfig").Element("SYQ");
                    if (SuoYQ != null)
                    {
                        SuoYQ.Attribute("HOST").Value = Host;
                        SuoYQ.Attribute("SID").Value = SID;
                        SuoYQ.Attribute("UserName").Value = UserName;
                        SuoYQ.Attribute("UserPassword").Value = UserPassword;
                        root.Save(configFilePath);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 从Config.xml获取不动产登记数据库(estate)连接参数配置
        /// </summary>
        /// <returns></returns>
        public static List<string> GetEstateconnectionstring()
        {
            List<string> lst = new List<string>();
            try
            {
                if (File.Exists(configFilePath))
                {
                    XElement root = XElement.Load(configFilePath);
                    XElement Estate = root.Element("SuoYQConvert").Element("ConnectionConfig").Element("Estate"); //cc 连接不动产库，用户名和密码是estate
                    
                    if (Estate != null)
                    {
                       
                        lst.Add(Estate.Attribute("HOST").Value);  //ip地址
                        lst.Add(Estate.Attribute("SID").Value);  //数据库名
                        lst.Add(Estate.Attribute("UserName").Value); //用户名
                        lst.Add(Estate.Attribute("UserPassword").Value); //用户密码

                    }
                }
            }
            catch 
            {
                
            }
            return lst;
        }

        /// <summary>
        /// 从Config.xml获取使用权数据转换配置-不动产登记数据库(estate)连接参数配置
        /// </summary>
        /// <returns></returns>
        public static List<string> GetEstateconnectionstringEx()
        {
            List<string> lst = new List<string>();
            try
            {
                if (File.Exists(configFilePath))
                {
                    XElement root = XElement.Load(configFilePath);
                    XElement Estate = root.Element("SYQConvert").Element("ConnectionConfig").Element("Estate");
                    if (Estate != null)
                    {
                        lst.Add(Estate.Attribute("HOST").Value);
                        lst.Add(Estate.Attribute("SID").Value);
                        lst.Add(Estate.Attribute("UserName").Value);
                        lst.Add(Estate.Attribute("UserPassword").Value);

                    }
                }
            }
            catch 
            {
                
            }
            return lst;
        }
        /// <summary>
        /// 保存不动产登记数据库(estate)连接参数配置到Config.xml
        /// </summary>
        /// <param name="Host"></param>
        /// <param name="SID"></param>
        /// <param name="UserName"></param>
        /// <param name="UserPassword"></param>
        /// <returns></returns>
        public static bool SaveEstateconnectionstring(string Host, string SID, string UserName, string UserPassword)
        {         
            try
            {
                if (File.Exists(configFilePath))
                {
                    XElement root = XElement.Load(configFilePath);
                    XElement Estate = root.Element("SuoYQConvert").Element("ConnectionConfig").Element("Estate");
                    if (Estate != null)
                    {
                        Estate.Attribute("HOST").Value = Host;
                        Estate.Attribute("SID").Value = SID;
                        Estate.Attribute("UserName").Value = UserName;
                        Estate.Attribute("UserPassword").Value = UserPassword;
                        root.Save(configFilePath);
                    }
                }
                return true;
            }
            catch 
            {
                return false;
            }
        }
        /// <summary>
        /// 保存使用权数据转换配置-不动产登记数据库(estate)连接参数配置到Config.xml
        /// </summary>
        /// <param name="Host"></param>
        /// <param name="SID"></param>
        /// <param name="UserName"></param>
        /// <param name="UserPassword"></param>
        /// <returns></returns>
        public static bool SaveEstateconnectionstringEx(string Host, string SID, string UserName, string UserPassword)
        {
            try
            {
                if (File.Exists(configFilePath))
                {
                    XElement root = XElement.Load(configFilePath);
                    XElement Estate = root.Element("SYQConvert").Element("ConnectionConfig").Element("Estate");
                    if (Estate != null)
                    {
                        Estate.Attribute("HOST").Value = Host;
                        Estate.Attribute("SID").Value = SID;
                        Estate.Attribute("UserName").Value = UserName;
                        Estate.Attribute("UserPassword").Value = UserPassword;
                        root.Save(configFilePath);
                    }
                }
                return true;
            }
            catch 
            {
                return false;
            }
        }
        /// <summary>
        /// 从Config.xml读取省名称
        /// </summary>
        /// <returns></returns>
        public static string GetSHENG()
        {
            string name = "山东省";
            try
            {
                if (File.Exists(configFilePath))
                {
                    XElement root = XElement.Load(configFilePath);
                    XElement SHENG = root.Element("SuoYQConvert").Element("CommonConfig").Element("SHENG");
                    if (SHENG != null)
                    {
                        name = SHENG.Attribute("Name").Value;
                    }
                }
            }
            catch { }
            return name;
        }
        /// <summary>
        /// 从Config.xml读取使用权数据转换配置-省名称
        /// </summary>
        /// <returns></returns>
        public static string GetSHENGEx()
        {
            string name = "山东省";
            try
            {
                if (File.Exists(configFilePath))
                {
                    XElement root = XElement.Load(configFilePath);
                    XElement SHENG = root.Element("SYQConvert").Element("CommonConfig").Element("SHENG");
                    if (SHENG != null)
                    {
                        name = SHENG.Attribute("Name").Value;
                    }
                }
            }
            catch { }
            return name;
        }
        /// <summary>
        /// 从Config.xml读取市名称
        /// </summary>
        /// <returns></returns>
        public static string GetSHI()
        {
            string name = "德州市";
            try
            {
                if (File.Exists(configFilePath))
                {
                    XElement root = XElement.Load(configFilePath);
                    XElement SHI = root.Element("SuoYQConvert").Element("CommonConfig").Element("SHENG").Element("SHI");
                    if (SHI != null)
                    {
                        name = SHI.Attribute("Name").Value;
                    }
                }
            }
            catch { }
            return name;
        }
        /// <summary>
        /// 从Config.xml读取使用权数据转换配置-市名称
        /// </summary>
        /// <returns></returns>
        public static string GetSHIEx()
        {
            string name = "德州市";
            try
            {
                if (File.Exists(configFilePath))
                {
                    XElement root = XElement.Load(configFilePath);
                    XElement SHI = root.Element("SYQConvert").Element("CommonConfig").Element("SHENG").Element("SHI");
                    if (SHI != null)
                    {
                        name = SHI.Attribute("Name").Value;
                    }
                }
            }
            catch { }
            return name;
        }
        /// <summary>
        /// 从Config.xml获取IMG连接参数配置
        /// </summary>
        /// <returns></returns>
        public static List<string>GetIMGconnectionstring()
        {
            List<string> lst = new List<string>();
            try
            {
                if (File.Exists(configFilePath))
                {
                    XElement root = XElement.Load(configFilePath);
                    XElement Estate = root.Element("SuoYQConvert").Element("ConnectionConfig").Element("IMG");
                    if (Estate != null)
                    {
                        lst.Add(Estate.Attribute("HOST").Value);
                        lst.Add(Estate.Attribute("SID").Value);
                        lst.Add(Estate.Attribute("UserName").Value);
                        lst.Add(Estate.Attribute("UserPassword").Value);

                    }
                }
            }
            catch 
            {
                
            }
            return lst;
        }
        /// <summary>
        /// 从Config.xml获取使用权数据转换配置-IMG连接参数配置
        /// </summary>
        /// <returns></returns>
        public static List<string>GetIMGconnectionstringEx()
        {
            List<string> lst = new List<string>();
            try
            {
                if (File.Exists(configFilePath))
                {
                    XElement root = XElement.Load(configFilePath);
                    XElement Estate = root.Element("SYQConvert").Element("ConnectionConfig").Element("IMG");
                    if (Estate != null)
                    {
                        lst.Add(Estate.Attribute("HOST").Value);
                        lst.Add(Estate.Attribute("SID").Value);
                        lst.Add(Estate.Attribute("UserName").Value);
                        lst.Add(Estate.Attribute("UserPassword").Value);

                    }
                }
            }
            catch 
            {
                
            }
            return lst;
        }
        /// <summary>
        /// 保存IMG连接参数配置到Config.xml
        /// </summary>
        /// <param name="Host"></param>
        /// <param name="SID"></param>
        /// <param name="UserName"></param>
        /// <param name="UserPassword"></param>
        /// <returns></returns>
        public static bool SaveIMGconnectionstring(string Host, string SID, string UserName, string UserPassword)
        {
            try
            {
                if (File.Exists(configFilePath))
                {
                    XElement root = XElement.Load(configFilePath);
                    XElement Estate = root.Element("SuoYQConvert").Element("ConnectionConfig").Element("IMG");
                    if (Estate != null)
                    {
                        Estate.Attribute("HOST").Value = Host;
                        Estate.Attribute("SID").Value = SID;
                        Estate.Attribute("UserName").Value = UserName;
                        Estate.Attribute("UserPassword").Value = UserPassword;
                        root.Save(configFilePath);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 保存使用权数据转换配置-IMG连接参数配置到Config.xml
        /// </summary>
        /// <param name="Host"></param>
        /// <param name="SID"></param>
        /// <param name="UserName"></param>
        /// <param name="UserPassword"></param>
        /// <returns></returns>
        public static bool SaveIMGconnectionstringEx(string Host, string SID, string UserName, string UserPassword)
        {
            try
            {
                if (File.Exists(configFilePath))
                {
                    XElement root = XElement.Load(configFilePath);
                    XElement Estate = root.Element("SYQConvert").Element("ConnectionConfig").Element("IMG");
                    if (Estate != null)
                    {
                        Estate.Attribute("HOST").Value = Host;
                        Estate.Attribute("SID").Value = SID;
                        Estate.Attribute("UserName").Value = UserName;
                        Estate.Attribute("UserPassword").Value = UserPassword;
                        root.Save(configFilePath);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 从Config.xml读取ftp连接方式1
        /// </summary>
        /// <returns></returns>
        public static string GetFtpPath()
        {
            string path = "";
            try
            {
                if(File.Exists(configFilePath))
                {
                    XElement root = XElement.Load(configFilePath);
                    path = root.Element("SuoYQConvert").Element("ConnectionConfig").Element("FtpPath").Value;
                }
            }
            catch 
            {
                
            }

            return path;
        }
        /// <summary>
        /// 从Config.xml读取使用权数据转换配置-ftp连接方式1
        /// </summary>
        /// <returns></returns>
        public static string GetFtpPathEx()
        {
            string path = "";
            try
            {
                if(File.Exists(configFilePath))
                {
                    XElement root = XElement.Load(configFilePath);
                    path = root.Element("SYQConvert").Element("ConnectionConfig").Element("FtpPath").Value;
                }
            }
            catch 
            {
                
            }

            return path;
        }
        /// <summary>
        /// 保存ftp连接方式1到Config.xml
        /// </summary>
        /// <param name="ftpPath"></param>
        /// <returns></returns>
        public static bool SaveFtpPath(string ftpPath)
        {
            try
            {
                if (File.Exists(configFilePath))
                {
                    XElement root = XElement.Load(configFilePath);
                    XElement FtpPath = root.Element("SuoYQConvert").Element("ConnectionConfig").Element("FtpPath");
                    if (FtpPath != null)
                    {
                        FtpPath.Value = ftpPath;
                        root.Save(configFilePath);
                    }
                }
                return true;
            }
            catch 
            {
                return false;
            }
        }
        /// <summary>
        /// 保存使用权数据转换配置-ftp连接方式1到Config.xml
        /// </summary>
        /// <param name="ftpPath"></param>
        /// <returns></returns>
        public static bool SaveFtpPathEx(string ftpPath)
        {
            try
            {
                if (File.Exists(configFilePath))
                {
                    XElement root = XElement.Load(configFilePath);
                    XElement FtpPath = root.Element("SYQConvert").Element("ConnectionConfig").Element("FtpPath");
                    if (FtpPath != null)
                    {
                        FtpPath.Value = ftpPath;
                        root.Save(configFilePath);
                    }
                }
                return true;
            }
            catch 
            {
                return false;
            }
        }
        /// <summary>
        /// 从Config.xml读取ftp连接方式2
        /// </summary>
        /// <returns></returns>
        public static List<string>GetFtpConnectionConfig()
        {
            List<string> lst = new List<string>();
            try
            {
                if(File.Exists(configFilePath))
                {
                    XElement root = XElement.Load(configFilePath);
                    XElement eleFtpConnectionConfig = root.Element("SuoYQConvert").Element("ConnectionConfig").Element("FtpConnectionConfig");
                    lst.Add(eleFtpConnectionConfig.Element("IP").Value);
                    lst.Add(eleFtpConnectionConfig.Element("UserId").Value);
                    lst.Add(eleFtpConnectionConfig.Element("Password").Value);
                }
            }
            catch 
            {
               
            }

            return lst;
        }
        /// <summary>
        /// 从Config.xml读取使用权数据转换配置-ftp连接方式2
        /// </summary>
        /// <returns></returns>
        public static List<string>GetFtpConnectionConfigEx()
        {
            List<string> lst = new List<string>();
            try
            {
                if(File.Exists(configFilePath))
                {
                    XElement root = XElement.Load(configFilePath);
                    XElement eleFtpConnectionConfig = root.Element("SYQConvert").Element("ConnectionConfig").Element("FtpConnectionConfig");
                    lst.Add(eleFtpConnectionConfig.Element("IP").Value);
                    lst.Add(eleFtpConnectionConfig.Element("UserId").Value);
                    lst.Add(eleFtpConnectionConfig.Element("Password").Value);
                }
            }
            catch 
            {
               
            }

            return lst;
        }
        /// <summary>
        /// 保存ftp连接方式2到Config.xml
        /// </summary>
        /// <param name="IP"></param>
        /// <param name="UserId"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public static bool SaveFtpconnectionstring(string IP, string UserId, string Password)
        {
            try
            {
                if (File.Exists(configFilePath))
                {
                    XElement root = XElement.Load(configFilePath);
                    XElement Ftpconnection = root.Element("SuoYQConvert").Element("ConnectionConfig").Element("FtpConnectionConfig");
                    if (Ftpconnection != null)
                    {
                        Ftpconnection.Element("IP").Value = IP;
                        Ftpconnection.Element("UserId").Value = UserId;
                        Ftpconnection.Element("Password").Value = Password;
                        root.Save(configFilePath);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 保存使用权数据转换配置-ftp连接方式2到Config.xml
        /// </summary>
        /// <param name="IP"></param>
        /// <param name="UserId"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public static bool SaveFtpconnectionstringEx(string IP, string UserId, string Password)
        {
            try
            {
                if (File.Exists(configFilePath))
                {
                    XElement root = XElement.Load(configFilePath);
                    XElement Ftpconnection = root.Element("SYQConvert").Element("ConnectionConfig").Element("FtpConnectionConfig");
                    if (Ftpconnection != null)
                    {
                        Ftpconnection.Element("IP").Value = IP;
                        Ftpconnection.Element("UserId").Value = UserId;
                        Ftpconnection.Element("Password").Value = Password;
                        root.Save(configFilePath);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void CreateDefault()
        {
            try
            {

            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}
