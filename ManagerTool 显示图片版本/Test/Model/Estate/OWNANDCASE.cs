using SmartMap.DataClient.Entity;
using SmartMap.DataClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataConvert.Business
{
    #region OWNANDCASE
    /// <summary>
    ///  物主和案件
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "OWNANDCASE", PrimaryKey = "OWNERSID")]
    public class OWNANDCASE : IEntity
    {

        private string _oWNERSID = String.Empty;
        private string _cASENUM = String.Empty;
        private string _cERTIFICATEID = String.Empty;
        private string _oWNPROXYID = String.Empty;
        private string _cERPROXYID = String.Empty;
        private decimal _oWNCASETYPE;
        private decimal _sHAREMODE;
        private decimal _sHARERATE;

        public OWNANDCASE()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "OWNERSID", TableName = "OWNANDCASE")]
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
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "CASENUM", TableName = "OWNANDCASE")]
        public string CASENUM
        {
            get { return _cASENUM; }
            set
            {
                if (value != null && value.Trim().Length > 32)
                    value = value.Trim().Substring(0, 32);

                _cASENUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "CERTIFICATEID", TableName = "OWNANDCASE")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "OWNPROXYID", TableName = "OWNANDCASE")]
        public string OWNPROXYID
        {
            get { return _oWNPROXYID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _oWNPROXYID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CERPROXYID", TableName = "OWNANDCASE")]
        public string CERPROXYID
        {
            get { return _cERPROXYID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _cERPROXYID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "number", FieldName = "OWNCASETYPE", TableName = "OWNANDCASE")]
        public decimal OWNCASETYPE
        {
            get { return _oWNCASETYPE; }
            set
            {
                _oWNCASETYPE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "SHAREMODE", TableName = "OWNANDCASE")]
        public decimal SHAREMODE
        {
            get { return _sHAREMODE; }
            set
            {
                _sHAREMODE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "SHARERATE", TableName = "OWNANDCASE")]
        public decimal SHARERATE
        {
            get { return _sHARERATE; }
            set
            {
                _sHARERATE = value;

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
