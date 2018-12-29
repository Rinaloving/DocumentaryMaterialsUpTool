using SmartMap.DataClient.Entity;
using SmartMap.DataClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataConvert.Business
{
    #region PLEDGEINFO
    /// <summary>
    ///  (PLEDGEINFO)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "PLEDGEINFO", PrimaryKey = "PLEDGEINFOID")]
    public class PLEDGEINFO : IEntity
    {

        private string _pLEDGEINFOID = String.Empty;
        private string _cASENUM = String.Empty;
        private string _rEALEUNUM = String.Empty;
        private string _pLEREALESTTYPE = String.Empty;
        private string _hYPOTHECA = String.Empty;
        private string _pLEDGOR = String.Empty;
        private string _pLECERTYPE = String.Empty;
        private string _pLECERNUM = String.Empty;
        private string _pLEMODE = String.Empty;
        private string _rEGISTERTYPE = String.Empty;
        private string _rEGISTERCAUSE = String.Empty;
        private string _pLEBLDLOCATION = String.Empty;
        private string _pLERANGE = String.Empty;
        private decimal _pLEAMOUNT;
        private DateTime _pLEBEGINDATE;
        private DateTime _pLEENDDATE;
        private decimal _fACTPLEAMOUNT;
        private string _rEALESTATEPROOFNUM = String.Empty;
        private DateTime _rEGISTERDATE;
        private string _rEGISTERMAN = String.Empty;
        private string _uNREGPLECASENUM = String.Empty;
        private string _uNREGPLECAUSE = String.Empty;
        private DateTime _uNREGISTERDATE;
        private string _uNREGISTERMAN = String.Empty;
        private decimal _pLEORDER;
        private string _iNFOMEMO = String.Empty;
        private decimal _iNFOSTATE;
        private string _mAXAMOUNTFACT = String.Empty;

        public PLEDGEINFO()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "PLEDGEINFOID", TableName = "PLEDGEINFO")]
        public string PLEDGEINFOID
        {
            get { return _pLEDGEINFOID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _pLEDGEINFOID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CASENUM", TableName = "PLEDGEINFO")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REALEUNUM", TableName = "PLEDGEINFO")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PLEREALESTTYPE", TableName = "PLEDGEINFO")]
        public string PLEREALESTTYPE
        {
            get { return _pLEREALESTTYPE; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _pLEREALESTTYPE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "HYPOTHECA", TableName = "PLEDGEINFO")]
        public string HYPOTHECA
        {
            get { return _hYPOTHECA; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _hYPOTHECA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PLEDGOR", TableName = "PLEDGEINFO")]
        public string PLEDGOR
        {
            get { return _pLEDGOR; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _pLEDGOR = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PLECERTYPE", TableName = "PLEDGEINFO")]
        public string PLECERTYPE
        {
            get { return _pLECERTYPE; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _pLECERTYPE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PLECERNUM", TableName = "PLEDGEINFO")]
        public string PLECERNUM
        {
            get { return _pLECERNUM; }
            set
            {
                if (value != null && value.Trim().Length > 40)
                    value = value.Trim().Substring(0, 40);

                _pLECERNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PLEMODE", TableName = "PLEDGEINFO")]
        public string PLEMODE
        {
            get { return _pLEMODE; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _pLEMODE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REGISTERTYPE", TableName = "PLEDGEINFO")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REGISTERCAUSE", TableName = "PLEDGEINFO")]
        public string REGISTERCAUSE
        {
            get { return _rEGISTERCAUSE; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _rEGISTERCAUSE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PLEBLDLOCATION", TableName = "PLEDGEINFO")]
        public string PLEBLDLOCATION
        {
            get { return _pLEBLDLOCATION; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _pLEBLDLOCATION = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PLERANGE", TableName = "PLEDGEINFO")]
        public string PLERANGE
        {
            get { return _pLERANGE; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _pLERANGE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "PLEAMOUNT", TableName = "PLEDGEINFO")]
        public decimal PLEAMOUNT
        {
            get { return _pLEAMOUNT; }
            set
            {
                _pLEAMOUNT = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "PLEBEGINDATE", TableName = "PLEDGEINFO")]
        public DateTime PLEBEGINDATE
        {
            get { return _pLEBEGINDATE; }
            set
            {
                _pLEBEGINDATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "PLEENDDATE", TableName = "PLEDGEINFO")]
        public DateTime PLEENDDATE
        {
            get { return _pLEENDDATE; }
            set
            {
                _pLEENDDATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "FACTPLEAMOUNT", TableName = "PLEDGEINFO")]
        public decimal FACTPLEAMOUNT
        {
            get { return _fACTPLEAMOUNT; }
            set
            {
                _fACTPLEAMOUNT = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REALESTATEPROOFNUM", TableName = "PLEDGEINFO")]
        public string REALESTATEPROOFNUM
        {
            get { return _rEALESTATEPROOFNUM; }
            set
            {
                if (value != null && value.Trim().Length > 60)
                    value = value.Trim().Substring(0, 60);

                _rEALESTATEPROOFNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "REGISTERDATE", TableName = "PLEDGEINFO")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REGISTERMAN", TableName = "PLEDGEINFO")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "UNREGPLECASENUM", TableName = "PLEDGEINFO")]
        public string UNREGPLECASENUM
        {
            get { return _uNREGPLECASENUM; }
            set
            {
                if (value != null && value.Trim().Length > 32)
                    value = value.Trim().Substring(0, 32);

                _uNREGPLECASENUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "UNREGPLECAUSE", TableName = "PLEDGEINFO")]
        public string UNREGPLECAUSE
        {
            get { return _uNREGPLECAUSE; }
            set
            {
                if (value != null && value.Trim().Length > 230)
                    value = value.Trim().Substring(0, 230);

                _uNREGPLECAUSE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "UNREGISTERDATE", TableName = "PLEDGEINFO")]
        public DateTime UNREGISTERDATE
        {
            get { return _uNREGISTERDATE; }
            set
            {
                _uNREGISTERDATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "UNREGISTERMAN", TableName = "PLEDGEINFO")]
        public string UNREGISTERMAN
        {
            get { return _uNREGISTERMAN; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _uNREGISTERMAN = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "PLEORDER", TableName = "PLEDGEINFO")]
        public decimal PLEORDER
        {
            get { return _pLEORDER; }
            set
            {
                _pLEORDER = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "INFOMEMO", TableName = "PLEDGEINFO")]
        public string INFOMEMO
        {
            get { return _iNFOMEMO; }
            set
            {
                if (value != null && value.Trim().Length > 200)
                    value = value.Trim().Substring(0, 200);

                _iNFOMEMO = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "INFOSTATE", TableName = "PLEDGEINFO")]
        public decimal INFOSTATE
        {
            get { return _iNFOSTATE; }
            set
            {
                _iNFOSTATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "MAXAMOUNTFACT", TableName = "PLEDGEINFO")]
        public string MAXAMOUNTFACT
        {
            get { return _mAXAMOUNTFACT; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _mAXAMOUNTFACT = value;

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
