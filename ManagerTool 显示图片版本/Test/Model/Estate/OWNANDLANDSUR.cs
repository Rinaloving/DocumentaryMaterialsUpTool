
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using SmartMap.DataClient.Model;
using SmartMap.DataClient.Entity;

namespace DataConvert.Business
{
    #region OWNANDLANDSUR
    /// <summary>
    ///  (OWNANDLANDSUR)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "OWNANDLANDSUR", PrimaryKey = "OWNERSID")]
    public class OWNANDLANDSUR : IEntity
    {

        private string _oWNERSID = String.Empty;
        private string _cERTIFICATEID = String.Empty;
        private string _lANDSURVERYID = String.Empty;
        private string _oWNPROXYID = String.Empty;
        private string _cERPROXYID = String.Empty;
        private decimal _sHAREMODE;
        private decimal _sHARERATE;

        public OWNANDLANDSUR()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "OWNERSID", TableName = "OWNANDLANDSUR")]
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
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "CERTIFICATEID", TableName = "OWNANDLANDSUR")]
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
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "LANDSURVERYID", TableName = "OWNANDLANDSUR")]
        public string LANDSURVERYID
        {
            get { return _lANDSURVERYID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _lANDSURVERYID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "OWNPROXYID", TableName = "OWNANDLANDSUR")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CERPROXYID", TableName = "OWNANDLANDSUR")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "SHAREMODE", TableName = "OWNANDLANDSUR")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "SHARERATE", TableName = "OWNANDLANDSUR")]
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

