
using SmartMap.DataClient.Entity;
using SmartMap.DataClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataConvert.Business
{
    #region CERTIFICATE
    /// <summary>
    ///  (CERTIFICATE)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "CERTIFICATE", PrimaryKey = "CERTIFICATEID")]
    public class CERTIFICATE : IEntity
    {

        private string _cERTIFICATEID = String.Empty;
        private string _cERTIFICATENEWID = String.Empty;
        private string _oWNERSID = String.Empty;
        private string _cERNUM = String.Empty;
        private string _cERTYPE = String.Empty;
        private decimal _cERSTATE;
        private string _iMAGEPATH = String.Empty;
        private DateTime _vALIDDATE;
        private string _cERDESC = String.Empty;

        public CERTIFICATE()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "CERTIFICATEID", TableName = "CERTIFICATE")]
        public string CERTIFICATEID
        {
            get { return _cERTIFICATEID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _cERTIFICATEID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CERTIFICATENEWID", TableName = "CERTIFICATE")]
        public string CERTIFICATENEWID
        {
            get { return _cERTIFICATENEWID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _cERTIFICATENEWID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "OWNERSID", TableName = "CERTIFICATE")]
        public string OWNERSID
        {
            get { return _oWNERSID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _oWNERSID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CERNUM", TableName = "CERTIFICATE")]
        public string CERNUM
        {
            get { return _cERNUM; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _cERNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CERTYPE", TableName = "CERTIFICATE")]
        public string CERTYPE
        {
            get { return _cERTYPE; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _cERTYPE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "CERSTATE", TableName = "CERTIFICATE")]
        public decimal CERSTATE
        {
            get { return _cERSTATE; }
            set
            {
                _cERSTATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "IMAGEPATH", TableName = "CERTIFICATE")]
        public string IMAGEPATH
        {
            get { return _iMAGEPATH; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _iMAGEPATH = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "VALIDDATE", TableName = "CERTIFICATE")]
        public DateTime VALIDDATE
        {
            get { return _vALIDDATE; }
            set
            {
                _vALIDDATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CERDESC", TableName = "CERTIFICATE")]
        public string CERDESC
        {
            get { return _cERDESC; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _cERDESC = value;

            }
        }

        private OWNERS m_OWNERS = null;
        /// <summary>
        /// 物主信息
        /// </summary>
        public OWNERS ObjOWNERS 
        { 
            get
            {
                if(m_OWNERS==null)
                {
                    m_OWNERS = SystemHandler.Instance.EstateContext.GetEntity<OWNERS>("OWNERSID", OWNERSID);
                }
                return m_OWNERS;
            }
        }
        #endregion

        #region IDisposable 成员
        /// <summary>
        /// 对象释放
        /// </summary>
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion

    }
    #endregion
}
