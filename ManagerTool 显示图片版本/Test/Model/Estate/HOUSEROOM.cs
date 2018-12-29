using SmartMap.DataClient.Entity;
using SmartMap.DataClient.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataConvert.Business
{
    #region HOUSEROOM
    /// <summary>
    ///  (HOUSEROOM)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "HOUSEROOM", PrimaryKey = "HOUSEROOMID")]
    public class HOUSEROOM : IEntity
    {

        private string _hOUSEROOMID = String.Empty;
        private string _hOUSEFLOORID = String.Empty;
        private string _hOUSEROOMNEWID = String.Empty;
        private string _rEALEUNUM = String.Empty;
        private string _bUILDINGID = String.Empty;
        private string _hRNUM = String.Empty;
        private string _gISBLDNUM = String.Empty;
        private string _bLDNUM = String.Empty;
        private string _fLOORNUM = String.Empty;
        private decimal _rOOMNUM;
        private string _rOOMNAME = String.Empty;
        private string _rOOMLOCATION = String.Empty;
        private decimal _bUILDAREA;
        private decimal _rOOMAREA;
        private decimal _sHAREAREA;
        private string _aREAUNIT = String.Empty;
        private decimal _fACTINFLO;
        private string _rOOMMODE = String.Empty;
        private string _rOOMSTRUCT = String.Empty;
        private string _hOUSETYPE = String.Empty;
        private string _hOUSEPROPERTY = String.Empty;
        private string _hRUSE = String.Empty;
        private string _hRUSE2 = String.Empty;
        private string _hRUSE3 = String.Empty;
        private decimal _pREBUILDAREA;
        private decimal _pREROOMAREA;
        private decimal _pRESHAREAREA;
        private decimal _pREBLDUNDAREA;
        private decimal _pREOTHERAREA;
        private decimal _pRESHARERATE;
        private decimal _bLDUNDAREA;
        private decimal _oTHERAREA;
        private decimal _sHARERATE;
        private decimal _pUBLANDAREA;
        private decimal _oWNLANDAREA;
        private decimal _sHARELANDAREA;
        private decimal _iSPUBLIC;
        private decimal _iSSUBROOM;
        private decimal _rOOMSTATE;
        private decimal _sALESTATE;
        private decimal _pLESTATE;
        private decimal _pROSTATE;
        private decimal _lIMSTATE;
        private string _hRDESC = String.Empty;
        private decimal _dOSTATE;
        private string _hOUSEINROOMID = String.Empty;

        public HOUSEROOM()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "HOUSEROOMID", TableName = "HOUSEROOM")]
        public string HOUSEROOMID
        {
            get { return _hOUSEROOMID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _hOUSEROOMID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "HOUSEFLOORID", TableName = "HOUSEROOM")]
        public string HOUSEFLOORID
        {
            get { return _hOUSEFLOORID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _hOUSEFLOORID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "HOUSEROOMNEWID", TableName = "HOUSEROOM")]
        public string HOUSEROOMNEWID
        {
            get { return _hOUSEROOMNEWID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _hOUSEROOMNEWID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REALEUNUM", TableName = "HOUSEROOM")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "BUILDINGID", TableName = "HOUSEROOM")]
        public string BUILDINGID
        {
            get { return _bUILDINGID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _bUILDINGID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "HRNUM", TableName = "HOUSEROOM")]
        public string HRNUM
        {
            get { return _hRNUM; }
            set
            {
                if (value != null && value.Trim().Length > 26)
                    value = value.Trim().Substring(0, 26);

                _hRNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "GISBLDNUM", TableName = "HOUSEROOM")]
        public string GISBLDNUM
        {
            get { return _gISBLDNUM; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _gISBLDNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "BLDNUM", TableName = "HOUSEROOM")]
        public string BLDNUM
        {
            get { return _bLDNUM; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _bLDNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "FLOORNUM", TableName = "HOUSEROOM")]
        public string FLOORNUM
        {
            get { return _fLOORNUM; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _fLOORNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "ROOMNUM", TableName = "HOUSEROOM")]
        public decimal ROOMNUM
        {
            get { return _rOOMNUM; }
            set
            {
                _rOOMNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "ROOMNAME", TableName = "HOUSEROOM")]
        public string ROOMNAME
        {
            get { return _rOOMNAME; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _rOOMNAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "ROOMLOCATION", TableName = "HOUSEROOM")]
        public string ROOMLOCATION
        {
            get { return _rOOMLOCATION; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _rOOMLOCATION = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "BUILDAREA", TableName = "HOUSEROOM")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "ROOMAREA", TableName = "HOUSEROOM")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "SHAREAREA", TableName = "HOUSEROOM")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "AREAUNIT", TableName = "HOUSEROOM")]
        public string AREAUNIT
        {
            get { return _aREAUNIT; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _aREAUNIT = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "FACTINFLO", FieldName = "FACTINFLO", TableName = "HOUSEROOM")]
        public decimal FACTINFLO
        {
            get { return _fACTINFLO; }
            set
            {
                _fACTINFLO = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "ROOMMODE", TableName = "HOUSEROOM")]
        public string ROOMMODE
        {
            get { return _rOOMMODE; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _rOOMMODE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "ROOMSTRUCT", TableName = "HOUSEROOM")]
        public string ROOMSTRUCT
        {
            get { return _rOOMSTRUCT; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _rOOMSTRUCT = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "HOUSETYPE", TableName = "HOUSEROOM")]
        public string HOUSETYPE
        {
            get { return _hOUSETYPE; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _hOUSETYPE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "HOUSEPROPERTY", TableName = "HOUSEROOM")]
        public string HOUSEPROPERTY
        {
            get { return _hOUSEPROPERTY; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _hOUSEPROPERTY = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "HRUSE", TableName = "HOUSEROOM")]
        public string HRUSE
        {
            get { return _hRUSE; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _hRUSE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "HRUSE2", TableName = "HOUSEROOM")]
        public string HRUSE2
        {
            get { return _hRUSE2; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _hRUSE2 = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "HRUSE3", TableName = "HOUSEROOM")]
        public string HRUSE3
        {
            get { return _hRUSE3; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _hRUSE3 = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "PREBUILDAREA", TableName = "HOUSEROOM")]
        public decimal PREBUILDAREA
        {
            get { return _pREBUILDAREA; }
            set
            {
                _pREBUILDAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "PREROOMAREA", TableName = "HOUSEROOM")]
        public decimal PREROOMAREA
        {
            get { return _pREROOMAREA; }
            set
            {
                _pREROOMAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "PRESHAREAREA", TableName = "HOUSEROOM")]
        public decimal PRESHAREAREA
        {
            get { return _pRESHAREAREA; }
            set
            {
                _pRESHAREAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "PREBLDUNDAREA", TableName = "HOUSEROOM")]
        public decimal PREBLDUNDAREA
        {
            get { return _pREBLDUNDAREA; }
            set
            {
                _pREBLDUNDAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "PREOTHERAREA", TableName = "HOUSEROOM")]
        public decimal PREOTHERAREA
        {
            get { return _pREOTHERAREA; }
            set
            {
                _pREOTHERAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "PRESHARERATE", TableName = "HOUSEROOM")]
        public decimal PRESHARERATE
        {
            get { return _pRESHARERATE; }
            set
            {
                _pRESHARERATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "BLDUNDAREA", TableName = "HOUSEROOM")]
        public decimal BLDUNDAREA
        {
            get { return _bLDUNDAREA; }
            set
            {
                _bLDUNDAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "OTHERAREA", TableName = "HOUSEROOM")]
        public decimal OTHERAREA
        {
            get { return _oTHERAREA; }
            set
            {
                _oTHERAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "SHARERATE", TableName = "HOUSEROOM")]
        public decimal SHARERATE
        {
            get { return _sHARERATE; }
            set
            {
                _sHARERATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "PUBLANDAREA", TableName = "HOUSEROOM")]
        public decimal PUBLANDAREA
        {
            get { return _pUBLANDAREA; }
            set
            {
                _pUBLANDAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "OWNLANDAREA", TableName = "HOUSEROOM")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "SHARELANDAREA", TableName = "HOUSEROOM")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "ISPUBLIC", TableName = "HOUSEROOM")]
        public decimal ISPUBLIC
        {
            get { return _iSPUBLIC; }
            set
            {
                _iSPUBLIC = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "ISSUBROOM", TableName = "HOUSEROOM")]
        public decimal ISSUBROOM
        {
            get { return _iSSUBROOM; }
            set
            {
                _iSSUBROOM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "ROOMSTATE", TableName = "HOUSEROOM")]
        public decimal ROOMSTATE
        {
            get { return _rOOMSTATE; }
            set
            {
                _rOOMSTATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "SALESTATE", TableName = "HOUSEROOM")]
        public decimal SALESTATE
        {
            get { return _sALESTATE; }
            set
            {
                _sALESTATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "PLESTATE", TableName = "HOUSEROOM")]
        public decimal PLESTATE
        {
            get { return _pLESTATE; }
            set
            {
                _pLESTATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "PROSTATE", TableName = "HOUSEROOM")]
        public decimal PROSTATE
        {
            get { return _pROSTATE; }
            set
            {
                _pROSTATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "LIMSTATE", TableName = "HOUSEROOM")]
        public decimal LIMSTATE
        {
            get { return _lIMSTATE; }
            set
            {
                _lIMSTATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "HRDESC", TableName = "HOUSEROOM")]
        public string HRDESC
        {
            get { return _hRDESC; }
            set
            {
                if (value != null && value.Trim().Length > 4000)
                    value = value.Trim().Substring(0, 4000);

                _hRDESC = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "DOSTATE", TableName = "HOUSEROOM")]
        public decimal DOSTATE
        {
            get { return _dOSTATE; }
            set
            {
                _dOSTATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "HOUSEINROOMID", TableName = "HOUSEROOM")]
        public string HOUSEINROOMID
        {
            get { return _hOUSEINROOMID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _hOUSEINROOMID = value;

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
