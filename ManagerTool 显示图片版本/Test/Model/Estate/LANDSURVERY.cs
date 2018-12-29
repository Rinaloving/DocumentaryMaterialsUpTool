
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
    #region LANDSURVERY
    /// <summary>
    ///  (LANDSURVERY)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "LANDSURVERY", PrimaryKey = "LANDSURVERYID")]
    public class LANDSURVERY : IEntity
    {

        private string _lANDSURVERYID = String.Empty;
        private string _lANDSURNUM = String.Empty;
        private string _cASENUM = String.Empty;
        private string _lANDCODE = String.Empty;
        private DateTime _lANDSURDATE;
        private string _lANDSURORG = String.Empty;
        private string _oWNEROBLIGEENAME = String.Empty;
        private string _uSEOBLIGEENAME = String.Empty;
        private string _rIGHTTYPE = String.Empty;
        private string _rIGHTPROPERTY = String.Empty;
        private string _lANDORIGINPROOF = String.Empty;
        private string _lANDLOCATION = String.Empty;
        private string _rIGHTSETMODE = String.Empty;
        private string _cOUNTRYCLASSCODE = String.Empty;
        private string _pRELANDCODE = String.Empty;
        private string _rEALEUNUM = String.Empty;
        private string _mAPSCALE = String.Empty;
        private string _mAPSHEETNUM = String.Empty;
        private string _aROUNDNORTH = String.Empty;
        private string _aROUNDEAST = String.Empty;
        private string _aROUNDSOUTH = String.Empty;
        private string _aROUNDWEST = String.Empty;
        private string _lANDRANK = String.Empty;
        private decimal _lANDPRICE;
        private string _aPPUSENAME = String.Empty;
        private string _aPPUSECODE = String.Empty;
        private string _fACTUSENAME = String.Empty;
        private string _fACTUSECODE = String.Empty;
        private decimal _aPPAREA;
        private decimal _lANDAREA;
        private decimal _bLDOCCUPYAREA;
        private decimal _bLDONTOTALAREA;
        private decimal _bLDUNDTOTALAREA;
        private DateTime _uSEBEGINDATE;
        private DateTime _uSEENDDATE;
        private string _sHAREOBLIGEESTATUS = String.Empty;
        private string _lANDSURDESC = String.Empty;
        private decimal _iNFOSTATE;

        public LANDSURVERY()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "LANDSURVERYID", TableName = "LANDSURVERY")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "LANDSURNUM", TableName = "LANDSURVERY")]
        public string LANDSURNUM
        {
            get { return _lANDSURNUM; }
            set
            {
                if (value != null && value.Trim().Length > 32)
                    value = value.Trim().Substring(0, 32);

                _lANDSURNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CASENUM", TableName = "LANDSURVERY")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "LANDCODE", TableName = "LANDSURVERY")]
        public string LANDCODE
        {
            get { return _lANDCODE; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _lANDCODE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "LANDSURDATE", TableName = "LANDSURVERY")]
        public DateTime LANDSURDATE
        {
            get { return _lANDSURDATE; }
            set
            {
                _lANDSURDATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "LANDSURORG", TableName = "LANDSURVERY")]
        public string LANDSURORG
        {
            get { return _lANDSURORG; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _lANDSURORG = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "OWNEROBLIGEENAME", TableName = "LANDSURVERY")]
        public string OWNEROBLIGEENAME
        {
            get { return _oWNEROBLIGEENAME; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _oWNEROBLIGEENAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "USEOBLIGEENAME", TableName = "LANDSURVERY")]
        public string USEOBLIGEENAME
        {
            get { return _uSEOBLIGEENAME; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _uSEOBLIGEENAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "RIGHTTYPE", TableName = "LANDSURVERY")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "RIGHTPROPERTY", TableName = "LANDSURVERY")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "LANDORIGINPROOF", TableName = "LANDSURVERY")]
        public string LANDORIGINPROOF
        {
            get { return _lANDORIGINPROOF; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _lANDORIGINPROOF = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "LANDLOCATION", TableName = "LANDSURVERY")]
        public string LANDLOCATION
        {
            get { return _lANDLOCATION; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _lANDLOCATION = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "RIGHTSETMODE", TableName = "LANDSURVERY")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "COUNTRYCLASSCODE", TableName = "LANDSURVERY")]
        public string COUNTRYCLASSCODE
        {
            get { return _cOUNTRYCLASSCODE; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _cOUNTRYCLASSCODE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PRELANDCODE", TableName = "LANDSURVERY")]
        public string PRELANDCODE
        {
            get { return _pRELANDCODE; }
            set
            {
                if (value != null && value.Trim().Length > 200)
                    value = value.Trim().Substring(0, 200);

                _pRELANDCODE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REALEUNUM", TableName = "LANDSURVERY")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "MAPSCALE", TableName = "LANDSURVERY")]
        public string MAPSCALE
        {
            get { return _mAPSCALE; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _mAPSCALE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "MAPSHEETNUM", TableName = "LANDSURVERY")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "AROUNDNORTH", TableName = "LANDSURVERY")]
        public string AROUNDNORTH
        {
            get { return _aROUNDNORTH; }
            set
            {
                if (value != null && value.Trim().Length > 300)
                    value = value.Trim().Substring(0, 300);

                _aROUNDNORTH = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "AROUNDEAST", TableName = "LANDSURVERY")]
        public string AROUNDEAST
        {
            get { return _aROUNDEAST; }
            set
            {
                if (value != null && value.Trim().Length > 300)
                    value = value.Trim().Substring(0, 300);

                _aROUNDEAST = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "AROUNDSOUTH", TableName = "LANDSURVERY")]
        public string AROUNDSOUTH
        {
            get { return _aROUNDSOUTH; }
            set
            {
                if (value != null && value.Trim().Length > 300)
                    value = value.Trim().Substring(0, 300);

                _aROUNDSOUTH = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "AROUNDWEST", TableName = "LANDSURVERY")]
        public string AROUNDWEST
        {
            get { return _aROUNDWEST; }
            set
            {
                if (value != null && value.Trim().Length > 300)
                    value = value.Trim().Substring(0, 300);

                _aROUNDWEST = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "LANDRANK", TableName = "LANDSURVERY")]
        public string LANDRANK
        {
            get { return _lANDRANK; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _lANDRANK = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "LANDPRICE", TableName = "LANDSURVERY")]
        public decimal LANDPRICE
        {
            get { return _lANDPRICE; }
            set
            {
                _lANDPRICE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "APPUSENAME", TableName = "LANDSURVERY")]
        public string APPUSENAME
        {
            get { return _aPPUSENAME; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _aPPUSENAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "APPUSECODE", TableName = "LANDSURVERY")]
        public string APPUSECODE
        {
            get { return _aPPUSECODE; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _aPPUSECODE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "FACTUSENAME", TableName = "LANDSURVERY")]
        public string FACTUSENAME
        {
            get { return _fACTUSENAME; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _fACTUSENAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "FACTUSECODE", TableName = "LANDSURVERY")]
        public string FACTUSECODE
        {
            get { return _fACTUSECODE; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _fACTUSECODE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "APPAREA", TableName = "LANDSURVERY")]
        public decimal APPAREA
        {
            get { return _aPPAREA; }
            set
            {
                _aPPAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "LANDAREA", TableName = "LANDSURVERY")]
        public decimal LANDAREA
        {
            get { return _lANDAREA; }
            set
            {
                _lANDAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "BLDOCCUPYAREA", TableName = "LANDSURVERY")]
        public decimal BLDOCCUPYAREA
        {
            get { return _bLDOCCUPYAREA; }
            set
            {
                _bLDOCCUPYAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "BLDONTOTALAREA", TableName = "LANDSURVERY")]
        public decimal BLDONTOTALAREA
        {
            get { return _bLDONTOTALAREA; }
            set
            {
                _bLDONTOTALAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "BLDUNDTOTALAREA", TableName = "LANDSURVERY")]
        public decimal BLDUNDTOTALAREA
        {
            get { return _bLDUNDTOTALAREA; }
            set
            {
                _bLDUNDTOTALAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "USEBEGINDATE", TableName = "LANDSURVERY")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "USEENDDATE", TableName = "LANDSURVERY")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "SHAREOBLIGEESTATUS", TableName = "LANDSURVERY")]
        public string SHAREOBLIGEESTATUS
        {
            get { return _sHAREOBLIGEESTATUS; }
            set
            {
                if (value != null && value.Trim().Length > 500)
                    value = value.Trim().Substring(0, 500);

                _sHAREOBLIGEESTATUS = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "LANDSURDESC", TableName = "LANDSURVERY")]
        public string LANDSURDESC
        {
            get { return _lANDSURDESC; }
            set
            {
                if (value != null && value.Trim().Length > 500)
                    value = value.Trim().Substring(0, 500);

                _lANDSURDESC = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "INFOSTATE", TableName = "LANDSURVERY")]
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

