using SmartMap.DataClient.Entity;
using SmartMap.DataClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataConvert.Business
{
    #region REALESTATECARD
    /// <summary>
    ///  (REALESTATECARD)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "REALESTATECARD", PrimaryKey = "REALESTCARDID")]
    public class REALESTATECARD : IEntity
    {

        private string _rEALESTCARDID = String.Empty;
        private string _rEALESTATECARDNUM = String.Empty;
        private string _pRINTNUM = String.Empty;
        private string _rEGORGWORD = String.Empty;
        private string _yEARNUM = String.Empty;
        private string _rEGORGNAME = String.Empty;
        private string _cARDNUM = String.Empty;
        private decimal _cARDTYPE;

        public REALESTATECARD()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "REALESTCARDID", TableName = "REALESTATECARD")]
        public string REALESTCARDID
        {
            get { return _rEALESTCARDID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _rEALESTCARDID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REALESTATECARDNUM", TableName = "REALESTATECARD")]
        public string REALESTATECARDNUM
        {
            get { return _rEALESTATECARDNUM; }
            set
            {
                if (value != null && value.Trim().Length > 60)
                    value = value.Trim().Substring(0, 60);

                _rEALESTATECARDNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PRINTNUM", TableName = "REALESTATECARD")]
        public string PRINTNUM
        {
            get { return _pRINTNUM; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _pRINTNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REGORGWORD", TableName = "REALESTATECARD")]
        public string REGORGWORD
        {
            get { return _rEGORGWORD; }
            set
            {
                if (value != null && value.Trim().Length > 10)
                    value = value.Trim().Substring(0, 10);

                _rEGORGWORD = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "YEARNUM", TableName = "REALESTATECARD")]
        public string YEARNUM
        {
            get { return _yEARNUM; }
            set
            {
                if (value != null && value.Trim().Length > 12)
                    value = value.Trim().Substring(0, 12);

                _yEARNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REGORGNAME", TableName = "REALESTATECARD")]
        public string REGORGNAME
        {
            get { return _rEGORGNAME; }
            set
            {
                if (value != null && value.Trim().Length > 32)
                    value = value.Trim().Substring(0, 32);

                _rEGORGNAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CARDNUM", TableName = "REALESTATECARD")]
        public string CARDNUM
        {
            get { return _cARDNUM; }
            set
            {
                if (value != null && value.Trim().Length > 13)
                    value = value.Trim().Substring(0, 13);

                _cARDNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "CARDTYPE", TableName = "REALESTATECARD")]
        public decimal CARDTYPE
        {
            get { return _cARDTYPE; }
            set
            {
                _cARDTYPE = value;

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
