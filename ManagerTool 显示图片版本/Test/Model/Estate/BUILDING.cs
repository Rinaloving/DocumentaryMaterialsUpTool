using SmartMap.DataClient.Entity;
using SmartMap.DataClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataConvert.Business
{
    #region BUILDING
    /// <summary>
    ///  (BUILDING)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "BUILDING", PrimaryKey = "BUILDINGID")]
    public class BUILDING : IEntity
    {

        private string _bUILDINGID = String.Empty;
        private string _lANDBLOCKID = String.Empty;
        private string _bUILDINGNEWID = String.Empty;
        private string _rEALEUNUM = String.Empty;
        private string _bLDNUM = String.Empty;
        private string _gISBLDNUM = String.Empty;
        private string _pROJECTNAME = String.Empty;
        private string _bLDLOCATION = String.Empty;
        private decimal _bLDTYPE;
        private decimal _bUILDAREA;
        private decimal _pREBUILDAREA;
        private decimal _pREBLDUNDAREA;
        private decimal _bLDUNDAREA;
        private decimal _pREOTHERAREA;
        private decimal _oTHERAREA;
        private string _pLANUSE = String.Empty;
        private string _pLANUSE2 = String.Empty;
        private string _pLANUSE3 = String.Empty;
        private string _bLDPROPERTY = String.Empty;
        private string _bUILDSTRUCT = String.Empty;
        private string _bUILDSTRUCT2 = String.Empty;
        private string _bUILDSTRUCT3 = String.Empty;
        private decimal _fLOORCOUNT;
        private decimal _bLDONFLOCOUNT;
        private decimal _bLDUNDFLOCOUNT;
        private decimal _rOOMCOUNT;
        private DateTime _bLDFINISHDATE;
        private decimal _bLDSTATE;
        private string _bLDDESC = String.Empty;
        private decimal _dOSTATE;
        private decimal _pLESTATE;
        private decimal _pROSTATE;
        private decimal _lIMSTATE;

        public BUILDING()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "BUILDINGID", TableName = "BUILDING")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "LANDBLOCKID", TableName = "BUILDING")]
        public string LANDBLOCKID
        {
            get { return _lANDBLOCKID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _lANDBLOCKID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "BUILDINGNEWID", TableName = "BUILDING")]
        public string BUILDINGNEWID
        {
            get { return _bUILDINGNEWID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _bUILDINGNEWID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REALEUNUM", TableName = "BUILDING")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "BLDNUM", TableName = "BUILDING")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "GISBLDNUM", TableName = "BUILDING")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PROJECTNAME", TableName = "BUILDING")]
        public string PROJECTNAME
        {
            get { return _pROJECTNAME; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _pROJECTNAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "BLDLOCATION", TableName = "BUILDING")]
        public string BLDLOCATION
        {
            get { return _bLDLOCATION; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _bLDLOCATION = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "BLDTYPE", TableName = "BUILDING")]
        public decimal BLDTYPE
        {
            get { return _bLDTYPE; }
            set
            {
                _bLDTYPE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "BUILDAREA", TableName = "BUILDING")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "PREBUILDAREA", TableName = "BUILDING")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "PREBLDUNDAREA", TableName = "BUILDING")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "BLDUNDAREA", TableName = "BUILDING")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "PREOTHERAREA", TableName = "BUILDING")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "OTHERAREA", TableName = "BUILDING")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PLANUSE", TableName = "BUILDING")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PLANUSE2", TableName = "BUILDING")]
        public string PLANUSE2
        {
            get { return _pLANUSE2; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _pLANUSE2 = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PLANUSE3", TableName = "BUILDING")]
        public string PLANUSE3
        {
            get { return _pLANUSE3; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _pLANUSE3 = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "BLDPROPERTY", TableName = "BUILDING")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "BUILDSTRUCT", TableName = "BUILDING")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "BUILDSTRUCT2", TableName = "BUILDING")]
        public string BUILDSTRUCT2
        {
            get { return _bUILDSTRUCT2; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _bUILDSTRUCT2 = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "BUILDSTRUCT3", TableName = "BUILDING")]
        public string BUILDSTRUCT3
        {
            get { return _bUILDSTRUCT3; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _bUILDSTRUCT3 = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "FLOORCOUNT", TableName = "BUILDING")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "BLDONFLOCOUNT", TableName = "BUILDING")]
        public decimal BLDONFLOCOUNT
        {
            get { return _bLDONFLOCOUNT; }
            set
            {
                _bLDONFLOCOUNT = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "BLDUNDFLOCOUNT", TableName = "BUILDING")]
        public decimal BLDUNDFLOCOUNT
        {
            get { return _bLDUNDFLOCOUNT; }
            set
            {
                _bLDUNDFLOCOUNT = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "ROOMCOUNT", TableName = "BUILDING")]
        public decimal ROOMCOUNT
        {
            get { return _rOOMCOUNT; }
            set
            {
                _rOOMCOUNT = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "BLDFINISHDATE", TableName = "BUILDING")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "BLDSTATE", TableName = "BUILDING")]
        public decimal BLDSTATE
        {
            get { return _bLDSTATE; }
            set
            {
                _bLDSTATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "BLDDESC", TableName = "BUILDING")]
        public string BLDDESC
        {
            get { return _bLDDESC; }
            set
            {
                if (value != null && value.Trim().Length > 4000)
                    value = value.Trim().Substring(0, 4000);

                _bLDDESC = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "DOSTATE", TableName = "BUILDING")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "PLESTATE", TableName = "BUILDING")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "PROSTATE", TableName = "BUILDING")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "LIMSTATE", TableName = "BUILDING")]
        public decimal LIMSTATE
        {
            get { return _lIMSTATE; }
            set
            {
                _lIMSTATE = value;

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
