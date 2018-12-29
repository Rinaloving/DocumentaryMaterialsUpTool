
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
    #region RECDATA
    /// <summary>
    ///  (RECDATA)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "RECDATA", PrimaryKey = "RECDATAID")]
    public class RECDATA : IEntity
    {

        private string _rECDATAID = String.Empty;
        private string _cASENUM = String.Empty;
        private string _dATANO = String.Empty;
        private string _dATANAME = String.Empty;
        private string _dATATYPES = String.Empty;
        private decimal _lOTNUM;
        private DateTime _rECDATE;
        private decimal _iSRECVEIVE;
        private decimal _iSMUST;
        private decimal _iSRENEW;
        private decimal _pAGENUM;
        private decimal _sTARTPAGE;
        private string _sTOREPATH = String.Empty;
        private decimal _iSRETURN;

        public RECDATA()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "RECDATAID", TableName = "RECDATA")]
        public string RECDATAID
        {
            get { return _rECDATAID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _rECDATAID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CASENUM", TableName = "RECDATA")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "DATANO", TableName = "RECDATA")]
        public string DATANO
        {
            get { return _dATANO; }
            set
            {
                if (value != null && value.Trim().Length > 6)
                    value = value.Trim().Substring(0, 6);

                _dATANO = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "DATANAME", TableName = "RECDATA")]
        public string DATANAME
        {
            get { return _dATANAME; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _dATANAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "DATATYPES", TableName = "RECDATA")]
        public string DATATYPES
        {
            get { return _dATATYPES; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _dATATYPES = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "LOTNUM", TableName = "RECDATA")]
        public decimal LOTNUM
        {
            get { return _lOTNUM; }
            set
            {
                _lOTNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "RECDATE", TableName = "RECDATA")]
        public DateTime RECDATE
        {
            get { return _rECDATE; }
            set
            {
                _rECDATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "ISRECVEIVE", TableName = "RECDATA")]
        public decimal ISRECVEIVE
        {
            get { return _iSRECVEIVE; }
            set
            {
                _iSRECVEIVE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "ISMUST", TableName = "RECDATA")]
        public decimal ISMUST
        {
            get { return _iSMUST; }
            set
            {
                _iSMUST = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "ISRENEW", TableName = "RECDATA")]
        public decimal ISRENEW
        {
            get { return _iSRENEW; }
            set
            {
                _iSRENEW = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "PAGENUM", TableName = "RECDATA")]
        public decimal PAGENUM
        {
            get { return _pAGENUM; }
            set
            {
                _pAGENUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "STARTPAGE", TableName = "RECDATA")]
        public decimal STARTPAGE
        {
            get { return _sTARTPAGE; }
            set
            {
                _sTARTPAGE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "STOREPATH", TableName = "RECDATA")]
        public string STOREPATH
        {
            get { return _sTOREPATH; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _sTOREPATH = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "ISRETURN", TableName = "RECDATA")]
        public decimal ISRETURN
        {
            get { return _iSRETURN; }
            set
            {
                _iSRETURN = value;

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

