using SmartMap.DataClient.Entity;
using SmartMap.DataClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataConvert.Business
{
    #region REGBOOKLIST
    /// <summary>
    ///  登记簿权利目录
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "REGBOOKLIST", PrimaryKey = "REGBOOKLISTID")]
    public class REGBOOKLIST : IEntity
    {

        private string _rEGBOOKLISTID = String.Empty;
        private string _rEALEUNUM = String.Empty;
        private string _lBNUM = String.Empty;
        private decimal _oRDERNUM;
        private string _rEALESTTYPE = String.Empty;
        private string _iNSHEETNUM = String.Empty;
        private string _lISTREMARK = String.Empty;
        private string _lANDRIGHTINFO = String.Empty;
        private string _lANDPAGENUM = String.Empty;
        private string _pLEPAGENUM = String.Empty;
        private string _eASPAGENUM = String.Empty;
        private string _pREPAGENUM = String.Empty;
        private string _dISPAGENUM = String.Empty;
        private string _sEAPAGENUM = String.Empty;
        private decimal _iNFOSTATE;

        public REGBOOKLIST()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "REGBOOKLISTID", TableName = "REGBOOKLIST")]
        public string REGBOOKLISTID
        {
            get { return _rEGBOOKLISTID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _rEGBOOKLISTID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REALEUNUM", TableName = "REGBOOKLIST")]
        public string REALEUNUM
        {
            get { return _rEALEUNUM; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _rEALEUNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "LBNUM", TableName = "REGBOOKLIST")]
        public string LBNUM
        {
            get { return _lBNUM; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _lBNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "ORDERNUM", TableName = "REGBOOKLIST")]
        public decimal ORDERNUM
        {
            get { return _oRDERNUM; }
            set
            {
                _oRDERNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REALESTTYPE", TableName = "REGBOOKLIST")]
        public string REALESTTYPE
        {
            get { return _rEALESTTYPE; }
            set
            {
                if (value != null && value.Trim().Length > 40)
                    value = value.Trim().Substring(0, 40);

                _rEALESTTYPE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "INSHEETNUM", TableName = "REGBOOKLIST")]
        public string INSHEETNUM
        {
            get { return _iNSHEETNUM; }
            set
            {
                if (value != null && value.Trim().Length > 10)
                    value = value.Trim().Substring(0, 10);

                _iNSHEETNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "LISTREMARK", TableName = "REGBOOKLIST")]
        public string LISTREMARK
        {
            get { return _lISTREMARK; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _lISTREMARK = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "LANDRIGHTINFO", TableName = "REGBOOKLIST")]
        public string LANDRIGHTINFO
        {
            get { return _lANDRIGHTINFO; }
            set
            {
                if (value != null && value.Trim().Length > 40)
                    value = value.Trim().Substring(0, 40);

                _lANDRIGHTINFO = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "LANDPAGENUM", TableName = "REGBOOKLIST")]
        public string LANDPAGENUM
        {
            get { return _lANDPAGENUM; }
            set
            {
                if (value != null && value.Trim().Length > 10)
                    value = value.Trim().Substring(0, 10);

                _lANDPAGENUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PLEPAGENUM", TableName = "REGBOOKLIST")]
        public string PLEPAGENUM
        {
            get { return _pLEPAGENUM; }
            set
            {
                if (value != null && value.Trim().Length > 10)
                    value = value.Trim().Substring(0, 10);

                _pLEPAGENUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "EASPAGENUM", TableName = "REGBOOKLIST")]
        public string EASPAGENUM
        {
            get { return _eASPAGENUM; }
            set
            {
                if (value != null && value.Trim().Length > 10)
                    value = value.Trim().Substring(0, 10);

                _eASPAGENUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PREPAGENUM", TableName = "REGBOOKLIST")]
        public string PREPAGENUM
        {
            get { return _pREPAGENUM; }
            set
            {
                if (value != null && value.Trim().Length > 10)
                    value = value.Trim().Substring(0, 10);

                _pREPAGENUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "DISPAGENUM", TableName = "REGBOOKLIST")]
        public string DISPAGENUM
        {
            get { return _dISPAGENUM; }
            set
            {
                if (value != null && value.Trim().Length > 10)
                    value = value.Trim().Substring(0, 10);

                _dISPAGENUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "SEAPAGENUM", TableName = "REGBOOKLIST")]
        public string SEAPAGENUM
        {
            get { return _sEAPAGENUM; }
            set
            {
                if (value != null && value.Trim().Length > 10)
                    value = value.Trim().Substring(0, 10);

                _sEAPAGENUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "INFOSTATE", TableName = "REGBOOKLIST")]
        public decimal INFOSTATE
        {
            get { return _iNFOSTATE; }
            set
            {
                _iNFOSTATE = value;

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
