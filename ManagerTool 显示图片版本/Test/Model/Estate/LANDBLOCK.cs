using SmartMap.DataClient.Entity;
using SmartMap.DataClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataConvert.Business
{
    #region LANDBLOCK
    /// <summary>
    ///  (LANDBLOCK)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "LANDBLOCK", PrimaryKey = "LANDBLOCKID")]
    public class LANDBLOCK : IEntity
    {

        private string _lANDBLOCKID = String.Empty;
        private string _lANDBLOCKNEWID = String.Empty;
        private string _rEALEUNUM = String.Empty;
        private string _lBNUM = String.Empty;
        private string _oLDLANDNUM = String.Empty;
        private string _rEALESTTYPE = String.Empty;
        private string _aREAUNIT = String.Empty;
        private string _lBLOCATION = String.Empty;
        private decimal _lBAREA;
        private string _lBPURPOSE = String.Empty;
        private string _lBRANK = String.Empty;
        private decimal _lBPRICE;
        private string _rIGHTTYPE = String.Empty;
        private string _rIGHTPROPERTY = String.Empty;
        private string _rIGHTSETMODE = String.Empty;
        private decimal _cUBAGERATE;
        private decimal _bUILDDENSITY;
        private decimal _bUILDMAXHEIGHT;
        private DateTime _uSEBEGINDATE;
        private DateTime _uSEENDDATE;
        private string _cADASTRENUM = String.Empty;
        private string _mAPSHEETNUM = String.Empty;
        private string _aROUNDNORTH = String.Empty;
        private string _aROUNDEAST = String.Empty;
        private string _aROUNDSOUTH = String.Empty;
        private string _aROUNDWEST = String.Empty;
        private decimal _fARMAREA;
        private decimal _fURROWAREA;
        private decimal _fORESTAREA;
        private decimal _gRASSAREA;
        private decimal _oTHERAREA;
        private decimal _cONSTRUCTAREA;
        private decimal _uNUSEAREA;
        private string _lBDESC = String.Empty;
        private decimal _lBSTATE;
        private decimal _pLESTATE;
        private decimal _pROSTATE;
        private decimal _lIMSTATE;
        private decimal _dOSTATE;

        public LANDBLOCK()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "LANDBLOCKID", TableName = "LANDBLOCK")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "LANDBLOCKNEWID", TableName = "LANDBLOCK")]
        public string LANDBLOCKNEWID
        {
            get { return _lANDBLOCKNEWID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _lANDBLOCKNEWID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REALEUNUM", TableName = "LANDBLOCK")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "LBNUM", TableName = "LANDBLOCK")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "OLDLANDNUM", TableName = "LANDBLOCK")]
        public string OLDLANDNUM
        {
            get { return _oLDLANDNUM; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _oLDLANDNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REALESTTYPE", TableName = "LANDBLOCK")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "AREAUNIT", TableName = "LANDBLOCK")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "LBLOCATION", TableName = "LANDBLOCK")]
        public string LBLOCATION
        {
            get { return _lBLOCATION; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _lBLOCATION = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "LBAREA", TableName = "LANDBLOCK")]
        public decimal LBAREA
        {
            get { return _lBAREA; }
            set
            {
                _lBAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "LBPURPOSE", TableName = "LANDBLOCK")]
        public string LBPURPOSE
        {
            get { return _lBPURPOSE; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _lBPURPOSE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "LBRANK", TableName = "LANDBLOCK")]
        public string LBRANK
        {
            get { return _lBRANK; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _lBRANK = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "LBPRICE", TableName = "LANDBLOCK")]
        public decimal LBPRICE
        {
            get { return _lBPRICE; }
            set
            {
                _lBPRICE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "RIGHTTYPE", TableName = "LANDBLOCK")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "RIGHTPROPERTY", TableName = "LANDBLOCK")]
        public string RIGHTPROPERTY
        {
            get { return _rIGHTPROPERTY; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _rIGHTPROPERTY = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "RIGHTSETMODE", TableName = "LANDBLOCK")]
        public string RIGHTSETMODE
        {
            get { return _rIGHTSETMODE; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _rIGHTSETMODE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "CUBAGERATE", FieldName = "CUBAGERATE", TableName = "LANDBLOCK")]
        public decimal CUBAGERATE
        {
            get { return _cUBAGERATE; }
            set
            {
                _cUBAGERATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "BUILDDENSITY", FieldName = "BUILDDENSITY", TableName = "LANDBLOCK")]
        public decimal BUILDDENSITY
        {
            get { return _bUILDDENSITY; }
            set
            {
                _bUILDDENSITY = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "BUILDMAXHEIGHT", FieldName = "BUILDMAXHEIGHT", TableName = "LANDBLOCK")]
        public decimal BUILDMAXHEIGHT
        {
            get { return _bUILDMAXHEIGHT; }
            set
            {
                _bUILDMAXHEIGHT = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "USEBEGINDATE", TableName = "LANDBLOCK")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "USEENDDATE", TableName = "LANDBLOCK")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CADASTRENUM", TableName = "LANDBLOCK")]
        public string CADASTRENUM
        {
            get { return _cADASTRENUM; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _cADASTRENUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "MAPSHEETNUM", TableName = "LANDBLOCK")]
        public string MAPSHEETNUM
        {
            get { return _mAPSHEETNUM; }
            set
            {
                if (value != null && value.Trim().Length > 200)
                    value = value.Trim().Substring(0, 200);

                _mAPSHEETNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "AROUNDNORTH", TableName = "LANDBLOCK")]
        public string AROUNDNORTH
        {
            get { return _aROUNDNORTH; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _aROUNDNORTH = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "AROUNDEAST", TableName = "LANDBLOCK")]
        public string AROUNDEAST
        {
            get { return _aROUNDEAST; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _aROUNDEAST = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "AROUNDSOUTH", TableName = "LANDBLOCK")]
        public string AROUNDSOUTH
        {
            get { return _aROUNDSOUTH; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _aROUNDSOUTH = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "AROUNDWEST", TableName = "LANDBLOCK")]
        public string AROUNDWEST
        {
            get { return _aROUNDWEST; }
            set
            {
                if (value != null && value.Trim().Length > 200)
                    value = value.Trim().Substring(0, 200);

                _aROUNDWEST = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "FARMAREA", TableName = "LANDBLOCK")]
        public decimal FARMAREA
        {
            get { return _fARMAREA; }
            set
            {
                _fARMAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "FURROWAREA", TableName = "LANDBLOCK")]
        public decimal FURROWAREA
        {
            get { return _fURROWAREA; }
            set
            {
                _fURROWAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "FORESTAREA", TableName = "LANDBLOCK")]
        public decimal FORESTAREA
        {
            get { return _fORESTAREA; }
            set
            {
                _fORESTAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "GRASSAREA", TableName = "LANDBLOCK")]
        public decimal GRASSAREA
        {
            get { return _gRASSAREA; }
            set
            {
                _gRASSAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "OTHERAREA", TableName = "LANDBLOCK")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "CONSTRUCTAREA", TableName = "LANDBLOCK")]
        public decimal CONSTRUCTAREA
        {
            get { return _cONSTRUCTAREA; }
            set
            {
                _cONSTRUCTAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "UNUSEAREA", TableName = "LANDBLOCK")]
        public decimal UNUSEAREA
        {
            get { return _uNUSEAREA; }
            set
            {
                _uNUSEAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "LBDESC", TableName = "LANDBLOCK")]
        public string LBDESC
        {
            get { return _lBDESC; }
            set
            {
                if (value != null && value.Trim().Length > 4000)
                    value = value.Trim().Substring(0, 4000);

                _lBDESC = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "LBSTATE", TableName = "LANDBLOCK")]
        public decimal LBSTATE
        {
            get { return _lBSTATE; }
            set
            {
                _lBSTATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "PLESTATE", TableName = "LANDBLOCK")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "PROSTATE", TableName = "LANDBLOCK")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "LIMSTATE", TableName = "LANDBLOCK")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "DOSTATE", TableName = "LANDBLOCK")]
        public decimal DOSTATE
        {
            get { return _dOSTATE; }
            set
            {
                _dOSTATE = value;

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
