
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
    #region ARCHIVEITEM
    /// <summary>
    ///  (ARCHIVEITEM)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "ARCHIVEITEM", PrimaryKey = "CASENUM")]
    public class ARCHIVEITEM : IEntity
    {

        private string _cASENUM = String.Empty;
        private string _bUSTYPE = String.Empty;
        private string _bUSCODE = String.Empty;
        private string _sUBBUSCODE = String.Empty;
        private string _aUTHCARDNUM = String.Empty;
        private string _rEALESTLOCATION = String.Empty;
        private string _fONDSNUM = String.Empty;
        private string _cATALOGNUM = String.Empty;
        private string _cLASSNUM = String.Empty;
        private string _vOLUMENUM = String.Empty;
        private decimal _pIECECOUNT;
        private decimal _pAGECOUNT;
        private string _sECURITYLEVEL = String.Empty;
        private string _kEEPTERM = String.Empty;
        private string _aRCHIVEMAN = String.Empty;
        private DateTime _aRCHIVEDATE;
        private string _aRCHIVEDESC = String.Empty;
        private string _aRCBOXID = String.Empty;
        private string _aRCTYPEID = String.Empty;
        private string _kEEPPLACE = String.Empty;
        private decimal _iNFOSTATE;

        public ARCHIVEITEM()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "CASENUM", TableName = "ARCHIVEITEM")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "BUSTYPE", TableName = "ARCHIVEITEM")]
        public string BUSTYPE
        {
            get { return _bUSTYPE; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _bUSTYPE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "BUSCODE", TableName = "ARCHIVEITEM")]
        public string BUSCODE
        {
            get { return _bUSCODE; }
            set
            {
                if (value != null && value.Trim().Length > 10)
                    value = value.Trim().Substring(0, 10);

                _bUSCODE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "SUBBUSCODE", TableName = "ARCHIVEITEM")]
        public string SUBBUSCODE
        {
            get { return _sUBBUSCODE; }
            set
            {
                if (value != null && value.Trim().Length > 10)
                    value = value.Trim().Substring(0, 10);

                _sUBBUSCODE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "AUTHCARDNUM", TableName = "ARCHIVEITEM")]
        public string AUTHCARDNUM
        {
            get { return _aUTHCARDNUM; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _aUTHCARDNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REALESTLOCATION", TableName = "ARCHIVEITEM")]
        public string REALESTLOCATION
        {
            get { return _rEALESTLOCATION; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _rEALESTLOCATION = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "FONDSNUM", TableName = "ARCHIVEITEM")]
        public string FONDSNUM
        {
            get { return _fONDSNUM; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _fONDSNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CATALOGNUM", TableName = "ARCHIVEITEM")]
        public string CATALOGNUM
        {
            get { return _cATALOGNUM; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _cATALOGNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CLASSNUM", TableName = "ARCHIVEITEM")]
        public string CLASSNUM
        {
            get { return _cLASSNUM; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _cLASSNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "VOLUMENUM", TableName = "ARCHIVEITEM")]
        public string VOLUMENUM
        {
            get { return _vOLUMENUM; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _vOLUMENUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "PIECECOUNT", TableName = "ARCHIVEITEM")]
        public decimal PIECECOUNT
        {
            get { return _pIECECOUNT; }
            set
            {
                _pIECECOUNT = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "PAGECOUNT", TableName = "ARCHIVEITEM")]
        public decimal PAGECOUNT
        {
            get { return _pAGECOUNT; }
            set
            {
                _pAGECOUNT = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "SECURITYLEVEL", TableName = "ARCHIVEITEM")]
        public string SECURITYLEVEL
        {
            get { return _sECURITYLEVEL; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _sECURITYLEVEL = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "KEEPTERM", TableName = "ARCHIVEITEM")]
        public string KEEPTERM
        {
            get { return _kEEPTERM; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _kEEPTERM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "ARCHIVEMAN", TableName = "ARCHIVEITEM")]
        public string ARCHIVEMAN
        {
            get { return _aRCHIVEMAN; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _aRCHIVEMAN = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "ARCHIVEDATE", TableName = "ARCHIVEITEM")]
        public DateTime ARCHIVEDATE
        {
            get { return _aRCHIVEDATE; }
            set
            {
                _aRCHIVEDATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "ARCHIVEDESC", TableName = "ARCHIVEITEM")]
        public string ARCHIVEDESC
        {
            get { return _aRCHIVEDESC; }
            set
            {
                if (value != null && value.Trim().Length > 2000)
                    value = value.Trim().Substring(0, 2000);

                _aRCHIVEDESC = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "ARCBOXID", TableName = "ARCHIVEITEM")]
        public string ARCBOXID
        {
            get { return _aRCBOXID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _aRCBOXID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "ARCTYPEID", TableName = "ARCHIVEITEM")]
        public string ARCTYPEID
        {
            get { return _aRCTYPEID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _aRCTYPEID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "KEEPPLACE", TableName = "ARCHIVEITEM")]
        public string KEEPPLACE
        {
            get { return _kEEPPLACE; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _kEEPPLACE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "INFOSTATE", TableName = "ARCHIVEITEM")]
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

