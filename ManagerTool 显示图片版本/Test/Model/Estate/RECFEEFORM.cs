
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
    #region RECFEEFORM
    /// <summary>
    ///  (RECFEEFORM)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "RECFEEFORM", PrimaryKey = "CASENUM")]
    public class RECFEEFORM : IEntity
    {

        private string _cASENUM = String.Empty;
        private string _cOUNTMAN = String.Empty;
        private DateTime _cOUNTDATE;
        private string _rECFEEMAN = String.Empty;
        private DateTime _rECFEEDATE;
        private string _rECFEEORG = String.Empty;
        private decimal _fEESUM;
        private string _rECFEEDESC = String.Empty;

        public RECFEEFORM()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "CASENUM", TableName = "RECFEEFORM")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "COUNTMAN", TableName = "RECFEEFORM")]
        public string COUNTMAN
        {
            get { return _cOUNTMAN; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _cOUNTMAN = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "COUNTDATE", TableName = "RECFEEFORM")]
        public DateTime COUNTDATE
        {
            get { return _cOUNTDATE; }
            set
            {
                _cOUNTDATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "RECFEEMAN", TableName = "RECFEEFORM")]
        public string RECFEEMAN
        {
            get { return _rECFEEMAN; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _rECFEEMAN = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "RECFEEDATE", TableName = "RECFEEFORM")]
        public DateTime RECFEEDATE
        {
            get { return _rECFEEDATE; }
            set
            {
                _rECFEEDATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "RECFEEORG", TableName = "RECFEEFORM")]
        public string RECFEEORG
        {
            get { return _rECFEEORG; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _rECFEEORG = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "FEESUM", TableName = "RECFEEFORM")]
        public decimal FEESUM
        {
            get { return _fEESUM; }
            set
            {
                _fEESUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "RECFEEDESC", TableName = "RECFEEFORM")]
        public string RECFEEDESC
        {
            get { return _rECFEEDESC; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _rECFEEDESC = value;

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

