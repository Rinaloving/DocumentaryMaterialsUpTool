
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
    #region STRUOWNERINFO
    /// <summary>
    ///  (STRUOWNERINFO)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "STRUOWNERINFO", PrimaryKey = "STRUOWNERINFOID")]
    public class STRUOWNERINFO : IEntity
    {

        private string _sTRUOWNERINFOID = String.Empty;
        private string _rEALEUNUM = String.Empty;
        private string _cASENUM = String.Empty;
        private string _oBLIGEENAME = String.Empty;
        private string _cERTYPE = String.Empty;
        private string _cERNUM = String.Empty;
        private string _sHARESTATUS = String.Empty;
        private string _rEGISTERTYPE = String.Empty;
        private string _rIGHTTYPE = String.Empty;
        private string _rEGISTERCAUSE = String.Empty;
        private string _sTRULOCATION = String.Empty;
        private string _uSEMANNAME = String.Empty;
        private decimal _uSERIGHTAREA;
        private DateTime _uSEBEGINDATE;
        private DateTime _uSEENDDATE;
        private string _sTRUTYPE = String.Empty;
        private string _sTRUPLANUSE = String.Empty;
        private decimal _sTRUAREA;
        private DateTime _bLDFINISHDATE;
        private string _rEALESTATECARDNUM = String.Empty;
        private DateTime _rEGISTERDATE;
        private string _rEGISTERMAN = String.Empty;
        private string _iNFOMEMO = String.Empty;
        private decimal _iNFOSTATE;

        public STRUOWNERINFO()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "STRUOWNERINFOID", TableName = "STRUOWNERINFO")]
        public string STRUOWNERINFOID
        {
            get { return _sTRUOWNERINFOID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _sTRUOWNERINFOID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REALEUNUM", TableName = "STRUOWNERINFO")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CASENUM", TableName = "STRUOWNERINFO")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "OBLIGEENAME", TableName = "STRUOWNERINFO")]
        public string OBLIGEENAME
        {
            get { return _oBLIGEENAME; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _oBLIGEENAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CERTYPE", TableName = "STRUOWNERINFO")]
        public string CERTYPE
        {
            get { return _cERTYPE; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _cERTYPE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CERNUM", TableName = "STRUOWNERINFO")]
        public string CERNUM
        {
            get { return _cERNUM; }
            set
            {
                if (value != null && value.Trim().Length > 40)
                    value = value.Trim().Substring(0, 40);

                _cERNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "SHARESTATUS", TableName = "STRUOWNERINFO")]
        public string SHARESTATUS
        {
            get { return _sHARESTATUS; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _sHARESTATUS = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REGISTERTYPE", TableName = "STRUOWNERINFO")]
        public string REGISTERTYPE
        {
            get { return _rEGISTERTYPE; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _rEGISTERTYPE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "RIGHTTYPE", TableName = "STRUOWNERINFO")]
        public string RIGHTTYPE
        {
            get { return _rIGHTTYPE; }
            set
            {
                if (value != null && value.Trim().Length > 40)
                    value = value.Trim().Substring(0, 40);

                _rIGHTTYPE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REGISTERCAUSE", TableName = "STRUOWNERINFO")]
        public string REGISTERCAUSE
        {
            get { return _rEGISTERCAUSE; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _rEGISTERCAUSE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "STRULOCATION", TableName = "STRUOWNERINFO")]
        public string STRULOCATION
        {
            get { return _sTRULOCATION; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _sTRULOCATION = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "USEMANNAME", TableName = "STRUOWNERINFO")]
        public string USEMANNAME
        {
            get { return _uSEMANNAME; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _uSEMANNAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "USERIGHTAREA", TableName = "STRUOWNERINFO")]
        public decimal USERIGHTAREA
        {
            get { return _uSERIGHTAREA; }
            set
            {
                _uSERIGHTAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "USEBEGINDATE", TableName = "STRUOWNERINFO")]
        public DateTime USEBEGINDATE
        {
            get { return _uSEBEGINDATE; }
            set
            {
                _uSEBEGINDATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "USEENDDATE", TableName = "STRUOWNERINFO")]
        public DateTime USEENDDATE
        {
            get { return _uSEENDDATE; }
            set
            {
                _uSEENDDATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "STRUTYPE", TableName = "STRUOWNERINFO")]
        public string STRUTYPE
        {
            get { return _sTRUTYPE; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _sTRUTYPE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "STRUPLANUSE", TableName = "STRUOWNERINFO")]
        public string STRUPLANUSE
        {
            get { return _sTRUPLANUSE; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _sTRUPLANUSE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "STRUAREA", TableName = "STRUOWNERINFO")]
        public decimal STRUAREA
        {
            get { return _sTRUAREA; }
            set
            {
                _sTRUAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "BLDFINISHDATE", TableName = "STRUOWNERINFO")]
        public DateTime BLDFINISHDATE
        {
            get { return _bLDFINISHDATE; }
            set
            {
                _bLDFINISHDATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REALESTATECARDNUM", TableName = "STRUOWNERINFO")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "REGISTERDATE", TableName = "STRUOWNERINFO")]
        public DateTime REGISTERDATE
        {
            get { return _rEGISTERDATE; }
            set
            {
                _rEGISTERDATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REGISTERMAN", TableName = "STRUOWNERINFO")]
        public string REGISTERMAN
        {
            get { return _rEGISTERMAN; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _rEGISTERMAN = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "INFOMEMO", TableName = "STRUOWNERINFO")]
        public string INFOMEMO
        {
            get { return _iNFOMEMO; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _iNFOMEMO = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "INFOSTATE", TableName = "STRUOWNERINFO")]
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

