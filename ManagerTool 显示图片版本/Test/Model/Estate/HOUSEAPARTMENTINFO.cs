using SmartMap.DataClient.Entity;
using SmartMap.DataClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataConvert.Business
{
    #region HOUSEAPARTMENTINFO
    /// <summary>
    ///  (HOUSEAPARTMENTINFO)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "HOUSEAPARTMENTINFO", PrimaryKey = "HOUSEAPARTMENTINFOID")]
    public class HOUSEAPARTMENTINFO : IEntity
    {

        private string _hOUSEAPARTMENTINFOID = String.Empty;
        private string _rEALEUNUM = String.Empty;
        private string _cASENUM = String.Empty;
        private string _hOUSELANDLOCATION = String.Empty;
        private string _oBLIGEENAME = String.Empty;
        private string _cERTYPE = String.Empty;
        private string _cERNUM = String.Empty;
        private string _sHARESTATUS = String.Empty;
        private string _oBLIGEETYPE = String.Empty;
        private string _rEGISTERTYPE = String.Empty;
        private string _rIGHTTYPE = String.Empty;
        private string _rEGISTERCAUSE = String.Empty;
        private string _lANDUSEMAN = String.Empty;
        private decimal _oWNLANDAREA;
        private decimal _sHARELANDAREA;
        private DateTime _uSEBEGINDATE;
        private DateTime _uSEENDDATE;
        private decimal _tRADEPRICE;
        private string _pLANUSE = String.Empty;
        private string _bLDPROPERTY = String.Empty;
        private string _bUILDSTRUCT = String.Empty;
        private decimal _iNFLOORNUM;
        private decimal _fLOORCOUNT;
        private decimal _bUILDAREA;
        private decimal _rOOMAREA;
        private decimal _sHAREAREA;
        private DateTime _bLDFINISHDATE;
        private string _rEALESTATECARDNUM = String.Empty;
        private DateTime _rEGISTERDATE;
        private string _rEGISTERMAN = String.Empty;
        private string _iNFOMEMO = String.Empty;
        private decimal _iNFOSTATE;

        public HOUSEAPARTMENTINFO()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "HOUSEAPARTMENTINFOID", TableName = "HOUSEAPARTMENTINFO")]
        public string HOUSEAPARTMENTINFOID
        {
            get { return _hOUSEAPARTMENTINFOID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _hOUSEAPARTMENTINFOID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REALEUNUM", TableName = "HOUSEAPARTMENTINFO")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CASENUM", TableName = "HOUSEAPARTMENTINFO")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "HOUSELANDLOCATION", TableName = "HOUSEAPARTMENTINFO")]
        public string HOUSELANDLOCATION
        {
            get { return _hOUSELANDLOCATION; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _hOUSELANDLOCATION = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "OBLIGEENAME", TableName = "HOUSEAPARTMENTINFO")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CERTYPE", TableName = "HOUSEAPARTMENTINFO")]
        public string CERTYPE
        {
            get { return _cERTYPE; }
            set
            {
                if (value != null && value.Trim().Length > 200)
                    value = value.Trim().Substring(0, 200);

                _cERTYPE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CERNUM", TableName = "HOUSEAPARTMENTINFO")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "SHARESTATUS", TableName = "HOUSEAPARTMENTINFO")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "OBLIGEETYPE", TableName = "HOUSEAPARTMENTINFO")]
        public string OBLIGEETYPE
        {
            get { return _oBLIGEETYPE; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _oBLIGEETYPE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REGISTERTYPE", TableName = "HOUSEAPARTMENTINFO")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "RIGHTTYPE", TableName = "HOUSEAPARTMENTINFO")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REGISTERCAUSE", TableName = "HOUSEAPARTMENTINFO")]
        public string REGISTERCAUSE
        {
            get { return _rEGISTERCAUSE; }
            set
            {
                if (value != null && value.Trim().Length > 1000)
                    value = value.Trim().Substring(0, 1000);

                _rEGISTERCAUSE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "LANDUSEMAN", TableName = "HOUSEAPARTMENTINFO")]
        public string LANDUSEMAN
        {
            get { return _lANDUSEMAN; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _lANDUSEMAN = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "OWNLANDAREA", TableName = "HOUSEAPARTMENTINFO")]
        public decimal OWNLANDAREA
        {
            get { return _oWNLANDAREA; }
            set
            {
                _oWNLANDAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "SHARELANDAREA", TableName = "HOUSEAPARTMENTINFO")]
        public decimal SHARELANDAREA
        {
            get { return _sHARELANDAREA; }
            set
            {
                _sHARELANDAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "USEBEGINDATE", TableName = "HOUSEAPARTMENTINFO")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "USEENDDATE", TableName = "HOUSEAPARTMENTINFO")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "TRADEPRICE", TableName = "HOUSEAPARTMENTINFO")]
        public decimal TRADEPRICE
        {
            get { return _tRADEPRICE; }
            set
            {
                _tRADEPRICE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PLANUSE", TableName = "HOUSEAPARTMENTINFO")]
        public string PLANUSE
        {
            get { return _pLANUSE; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _pLANUSE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "BLDPROPERTY", TableName = "HOUSEAPARTMENTINFO")]
        public string BLDPROPERTY
        {
            get { return _bLDPROPERTY; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _bLDPROPERTY = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "BUILDSTRUCT", TableName = "HOUSEAPARTMENTINFO")]
        public string BUILDSTRUCT
        {
            get { return _bUILDSTRUCT; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _bUILDSTRUCT = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "INFLOORNUM", TableName = "HOUSEAPARTMENTINFO")]
        public decimal INFLOORNUM
        {
            get { return _iNFLOORNUM; }
            set
            {
                _iNFLOORNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "FLOORCOUNT", TableName = "HOUSEAPARTMENTINFO")]
        public decimal FLOORCOUNT
        {
            get { return _fLOORCOUNT; }
            set
            {
                _fLOORCOUNT = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "BUILDAREA", TableName = "HOUSEAPARTMENTINFO")]
        public decimal BUILDAREA
        {
            get { return _bUILDAREA; }
            set
            {
                _bUILDAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "ROOMAREA", TableName = "HOUSEAPARTMENTINFO")]
        public decimal ROOMAREA
        {
            get { return _rOOMAREA; }
            set
            {
                _rOOMAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "SHAREAREA", TableName = "HOUSEAPARTMENTINFO")]
        public decimal SHAREAREA
        {
            get { return _sHAREAREA; }
            set
            {
                _sHAREAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "BLDFINISHDATE", TableName = "HOUSEAPARTMENTINFO")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REALESTATECARDNUM", TableName = "HOUSEAPARTMENTINFO")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "REGISTERDATE", TableName = "HOUSEAPARTMENTINFO")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REGISTERMAN", TableName = "HOUSEAPARTMENTINFO")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "INFOMEMO", TableName = "HOUSEAPARTMENTINFO")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "INFOSTATE", TableName = "HOUSEAPARTMENTINFO")]
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
