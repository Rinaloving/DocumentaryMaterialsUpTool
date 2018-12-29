
using SmartMap.DataClient.Entity;
using SmartMap.DataClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataConvert.Business
{
    #region OWNERS
    /// <summary>
    ///  (OWNERS)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "OWNERS", PrimaryKey = "OWNERSID")]
    public class OWNERS : IEntity
    {

        private string _oWNERSID = String.Empty;
        private string _mANOWNERSID = String.Empty;
        private string _oWNERSNEWID = String.Empty;
        private string _oWNNAME = String.Empty;
        private string _oWNTYPE = String.Empty;
        private string _oWNPHONE = String.Empty;
        private string _oWNADDRESS = String.Empty;
        private decimal _oWNSTATE;
        private string _eNTMANAGER = String.Empty;
        private string _pOSTCODE = String.Empty;
        private string _eLEMAIL = String.Empty;
        private string _oWNSEX = String.Empty;
        private string _wORKCORP = String.Empty;
        private string _oWNDESC = String.Empty;

        public OWNERS()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "OWNERSID", TableName = "OWNERS")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "MANOWNERSID", TableName = "OWNERS")]
        public string MANOWNERSID
        {
            get { return _mANOWNERSID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _mANOWNERSID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "OWNERSNEWID", TableName = "OWNERS")]
        public string OWNERSNEWID
        {
            get { return _oWNERSNEWID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _oWNERSNEWID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "OWNNAME", TableName = "OWNERS")]
        public string OWNNAME
        {
            get { return _oWNNAME; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _oWNNAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "OWNTYPE", TableName = "OWNERS")]
        public string OWNTYPE
        {
            get { return _oWNTYPE; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _oWNTYPE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "OWNPHONE", TableName = "OWNERS")]
        public string OWNPHONE
        {
            get { return _oWNPHONE; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _oWNPHONE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "OWNADDRESS", TableName = "OWNERS")]
        public string OWNADDRESS
        {
            get { return _oWNADDRESS; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _oWNADDRESS = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "OWNSTATE", TableName = "OWNERS")]
        public decimal OWNSTATE
        {
            get { return _oWNSTATE; }
            set
            {
                _oWNSTATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "ENTMANAGER", TableName = "OWNERS")]
        public string ENTMANAGER
        {
            get { return _eNTMANAGER; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _eNTMANAGER = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "POSTCODE", TableName = "OWNERS")]
        public string POSTCODE
        {
            get { return _pOSTCODE; }
            set
            {
                if (value != null && value.Trim().Length > 10)
                    value = value.Trim().Substring(0, 10);

                _pOSTCODE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "ELEMAIL", TableName = "OWNERS")]
        public string ELEMAIL
        {
            get { return _eLEMAIL; }
            set
            {
                if (value != null && value.Trim().Length > 32)
                    value = value.Trim().Substring(0, 32);

                _eLEMAIL = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "OWNSEX", TableName = "OWNERS")]
        public string OWNSEX
        {
            get { return _oWNSEX; }
            set
            {
                if (value != null && value.Trim().Length > 6)
                    value = value.Trim().Substring(0, 6);

                _oWNSEX = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "WORKCORP", TableName = "OWNERS")]
        public string WORKCORP
        {
            get { return _wORKCORP; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _wORKCORP = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "OWNDESC", TableName = "OWNERS")]
        public string OWNDESC
        {
            get { return _oWNDESC; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _oWNDESC = value;

            }
        }
        private CERTIFICATE m_CERTIFICATE = null;
        /// <summary>
        /// 证件信息
        /// </summary>
        public CERTIFICATE ObjCERTIFICATE
        {
            get
            {
                if(m_CERTIFICATE==null)
                {
                    m_CERTIFICATE = SystemHandler.Instance.EstateContext.GetEntity<CERTIFICATE>("OWNERSID", OWNERSID);
                }
                return m_CERTIFICATE;
            } 
            set
            {
                m_CERTIFICATE = value;
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
