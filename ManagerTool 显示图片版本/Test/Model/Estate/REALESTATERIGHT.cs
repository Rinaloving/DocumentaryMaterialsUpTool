using SmartMap.DataClient.Entity;
using SmartMap.DataClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataConvert.Business
{
    #region REALESTATERIGHT
    /// <summary>
    ///  (REALESTATERIGHT)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "REALESTATERIGHT", PrimaryKey = "REALESTRIGHTID")]
    public class REALESTATERIGHT : IEntity
    {

        private string _rEALESTRIGHTID = String.Empty;
        private string _cASENUM = String.Empty;
        private decimal _rIGHTPAGENUM;
        private string _rEALEUNUM = String.Empty;
        private string _rEALESTCARDID = String.Empty;
        private string _oBLIGEENAME = String.Empty;
        private string _sHARESTATUS = String.Empty;
        private string _rEALESTLOCATION = String.Empty;
        private string _rIGHTTYPE = String.Empty;
        private string _rIGHTPROPERTY = String.Empty;
        private string _rEALESTUSE = String.Empty;
        private string _rEALESTAREA = String.Empty;
        private string _uSETIME = String.Empty;
        private string _rITHTREMARK = String.Empty;
        private string _rIGHTOTHERS = String.Empty;
        private string _rIGHTMEMO = String.Empty;
        private decimal _rIGHTSTATE;
        private string _mAKECARDMAN = String.Empty;
        private DateTime _mAKECARDDATE;

        public REALESTATERIGHT()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "REALESTRIGHTID", TableName = "REALESTATERIGHT")]
        public string REALESTRIGHTID
        {
            get { return _rEALESTRIGHTID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _rEALESTRIGHTID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CASENUM", TableName = "REALESTATERIGHT")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "RIGHTPAGENUM", TableName = "REALESTATERIGHT")]
        public decimal RIGHTPAGENUM
        {
            get { return _rIGHTPAGENUM; }
            set
            {
                _rIGHTPAGENUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REALEUNUM", TableName = "REALESTATERIGHT")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REALESTCARDID", TableName = "REALESTATERIGHT")]
        public string REALESTCARDID
        {
            get { return _rEALESTCARDID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _rEALESTCARDID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "OBLIGEENAME", TableName = "REALESTATERIGHT")]
        public string OBLIGEENAME
        {
            get { return _oBLIGEENAME; }
            set
            {
                if (value != null && value.Trim().Length > 400)
                    value = value.Trim().Substring(0, 400);

                _oBLIGEENAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "SHARESTATUS", TableName = "REALESTATERIGHT")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REALESTLOCATION", TableName = "REALESTATERIGHT")]
        public string REALESTLOCATION
        {
            get { return _rEALESTLOCATION; }
            set
            {
                if (value != null && value.Trim().Length > 200)
                    value = value.Trim().Substring(0, 200);

                _rEALESTLOCATION = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "RIGHTTYPE", TableName = "REALESTATERIGHT")]
        public string RIGHTTYPE
        {
            get { return _rIGHTTYPE; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _rIGHTTYPE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "RIGHTPROPERTY", TableName = "REALESTATERIGHT")]
        public string RIGHTPROPERTY
        {
            get { return _rIGHTPROPERTY; }
            set
            {
                if (value != null && value.Trim().Length > 40)
                    value = value.Trim().Substring(0, 40);

                _rIGHTPROPERTY = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REALESTUSE", TableName = "REALESTATERIGHT")]
        public string REALESTUSE
        {
            get { return _rEALESTUSE; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _rEALESTUSE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REALESTAREA", TableName = "REALESTATERIGHT")]
        public string REALESTAREA
        {
            get { return _rEALESTAREA; }
            set
            {
                if (value != null && value.Trim().Length > 250)
                    value = value.Trim().Substring(0, 250);

                _rEALESTAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "USETIME", TableName = "REALESTATERIGHT")]
        public string USETIME
        {
            get { return _uSETIME; }
            set
            {
                if (value != null && value.Trim().Length > 250)
                    value = value.Trim().Substring(0, 250);

                _uSETIME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "RITHTREMARK", TableName = "REALESTATERIGHT")]
        public string RITHTREMARK
        {
            get { return _rITHTREMARK; }
            set
            {
                if (value != null && value.Trim().Length > 500)
                    value = value.Trim().Substring(0, 500);

                _rITHTREMARK = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "RIGHTOTHERS", TableName = "REALESTATERIGHT")]
        public string RIGHTOTHERS
        {
            get { return _rIGHTOTHERS; }
            set
            {
                if (value != null && value.Trim().Length > 1000)
                    value = value.Trim().Substring(0, 1000);

                _rIGHTOTHERS = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "RIGHTMEMO", TableName = "REALESTATERIGHT")]
        public string RIGHTMEMO
        {
            get { return _rIGHTMEMO; }
            set
            {
                if (value != null && value.Trim().Length > 500)
                    value = value.Trim().Substring(0, 500);

                _rIGHTMEMO = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "RIGHTSTATE", TableName = "REALESTATERIGHT")]
        public decimal RIGHTSTATE
        {
            get { return _rIGHTSTATE; }
            set
            {
                _rIGHTSTATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "MAKECARDMAN", TableName = "REALESTATERIGHT")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "MAKECARDDATE", TableName = "REALESTATERIGHT")]
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
