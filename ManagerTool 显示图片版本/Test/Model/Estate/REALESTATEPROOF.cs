using SmartMap.DataClient.Entity;
using SmartMap.DataClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataConvert.Business
{
    #region REALESTATEPROOF
    /// <summary>
    ///  不动产登记证明
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "REALESTATEPROOF", PrimaryKey = "REALESTPROOFID")]
    public class REALESTATEPROOF : IEntity
    {

        private string _rEALESTPROOFID = String.Empty;
        private string _cASENUM = String.Empty;
        private string _rEALEUNUM = String.Empty;
        private string _rEALESTATEPROOFNUM = String.Empty;
        private string _pRINTNUM = String.Empty;
        private string _rEGORGWORD = String.Empty;
        private string _yEARNUM = String.Empty;
        private string _rEGORGNAME = String.Empty;
        private string _pROOFNUM = String.Empty;
        private string _pROOFTHING = String.Empty;
        private string _oBLIGEENAME = String.Empty;
        private string _oBLIGORNAME = String.Empty;
        private string _rEALESTLOCATION = String.Empty;
        private string _pROOFOTHERS = String.Empty;
        private string _pROOFMEMO = String.Empty;
        private decimal _pROOFSTATE;
        private string _mAKECARDMAN = String.Empty;
        private DateTime _mAKECARDDATE;

        public REALESTATEPROOF()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "REALESTPROOFID", TableName = "REALESTATEPROOF")]
        public string REALESTPROOFID
        {
            get { return _rEALESTPROOFID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _rEALESTPROOFID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CASENUM", TableName = "REALESTATEPROOF")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REALEUNUM", TableName = "REALESTATEPROOF")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REALESTATEPROOFNUM", TableName = "REALESTATEPROOF")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PRINTNUM", TableName = "REALESTATEPROOF")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REGORGWORD", TableName = "REALESTATEPROOF")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "YEARNUM", TableName = "REALESTATEPROOF")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REGORGNAME", TableName = "REALESTATEPROOF")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PROOFNUM", TableName = "REALESTATEPROOF")]
        public string PROOFNUM
        {
            get { return _pROOFNUM; }
            set
            {
                if (value != null && value.Trim().Length > 13)
                    value = value.Trim().Substring(0, 13);

                _pROOFNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PROOFTHING", TableName = "REALESTATEPROOF")]
        public string PROOFTHING
        {
            get { return _pROOFTHING; }
            set
            {
                if (value != null && value.Trim().Length > 330)
                    value = value.Trim().Substring(0, 330);

                _pROOFTHING = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "OBLIGEENAME", TableName = "REALESTATEPROOF")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "OBLIGORNAME", TableName = "REALESTATEPROOF")]
        public string OBLIGORNAME
        {
            get { return _oBLIGORNAME; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _oBLIGORNAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REALESTLOCATION", TableName = "REALESTATEPROOF")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PROOFOTHERS", TableName = "REALESTATEPROOF")]
        public string PROOFOTHERS
        {
            get { return _pROOFOTHERS; }
            set
            {
                if (value != null && value.Trim().Length > 200)
                    value = value.Trim().Substring(0, 200);

                _pROOFOTHERS = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PROOFMEMO", TableName = "REALESTATEPROOF")]
        public string PROOFMEMO
        {
            get { return _pROOFMEMO; }
            set
            {
                if (value != null && value.Trim().Length > 200)
                    value = value.Trim().Substring(0, 200);

                _pROOFMEMO = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "PROOFSTATE", TableName = "REALESTATEPROOF")]
        public decimal PROOFSTATE
        {
            get { return _pROOFSTATE; }
            set
            {
                _pROOFSTATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "MAKECARDMAN", TableName = "REALESTATEPROOF")]
        public string MAKECARDMAN
        {
            get { return _mAKECARDMAN; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _mAKECARDMAN = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "MAKECARDDATE", TableName = "REALESTATEPROOF")]
        public DateTime MAKECARDDATE
        {
            get { return _mAKECARDDATE; }
            set
            {
                _mAKECARDDATE = value;

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
