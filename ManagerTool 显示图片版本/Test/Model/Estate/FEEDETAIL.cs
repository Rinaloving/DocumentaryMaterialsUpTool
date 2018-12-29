
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
    #region FEEDETAIL
    /// <summary>
    ///  (FEEDETAIL)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "FEEDETAIL", PrimaryKey = "FEEDETAILID")]
    public class FEEDETAIL : IEntity
    {

        private string _fEEDETAILID = String.Empty;
        private string _cASENUM = String.Empty;
        private string _fEENAME = String.Empty;
        private decimal _iSEXTFEE;
        private decimal _fEEBASE;
        private string _fEETYPE = String.Empty;
        private decimal _rECMONEY;
        private decimal _rECDISMONEY;
        private decimal _fACTMONEY;
        private string _cHARGEMAN = String.Empty;
        private string _fACTCHAMAN = String.Empty;

        public FEEDETAIL()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "FEEDETAILID", TableName = "FEEDETAIL")]
        public string FEEDETAILID
        {
            get { return _fEEDETAILID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _fEEDETAILID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CASENUM", TableName = "FEEDETAIL")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "FEENAME", TableName = "FEEDETAIL")]
        public string FEENAME
        {
            get { return _fEENAME; }
            set
            {
                if (value != null && value.Trim().Length > 40)
                    value = value.Trim().Substring(0, 40);

                _fEENAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "ISEXTFEE", TableName = "FEEDETAIL")]
        public decimal ISEXTFEE
        {
            get { return _iSEXTFEE; }
            set
            {
                _iSEXTFEE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "FEEBASE", TableName = "FEEDETAIL")]
        public decimal FEEBASE
        {
            get { return _fEEBASE; }
            set
            {
                _fEEBASE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "FEETYPE", TableName = "FEEDETAIL")]
        public string FEETYPE
        {
            get { return _fEETYPE; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _fEETYPE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "RECMONEY", TableName = "FEEDETAIL")]
        public decimal RECMONEY
        {
            get { return _rECMONEY; }
            set
            {
                _rECMONEY = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "RECDISMONEY", TableName = "FEEDETAIL")]
        public decimal RECDISMONEY
        {
            get { return _rECDISMONEY; }
            set
            {
                _rECDISMONEY = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "FACTMONEY", TableName = "FEEDETAIL")]
        public decimal FACTMONEY
        {
            get { return _fACTMONEY; }
            set
            {
                _fACTMONEY = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CHARGEMAN", TableName = "FEEDETAIL")]
        public string CHARGEMAN
        {
            get { return _cHARGEMAN; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _cHARGEMAN = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "FACTCHAMAN", TableName = "FEEDETAIL")]
        public string FACTCHAMAN
        {
            get { return _fACTCHAMAN; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _fACTCHAMAN = value;

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

