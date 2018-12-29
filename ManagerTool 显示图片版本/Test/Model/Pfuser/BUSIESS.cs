
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
    #region BUSIESS
    /// <summary>
    ///  (BUSIESS)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (pfuser)", TableName = "BUSIESS", PrimaryKey = "BUSIESS_ID")]
    public class BUSIESS : IEntity
    {

        private decimal _bUSIESS_ID;
        private decimal _bUS_BUSIESS_ID;
        private decimal _eXECUTE_TIME;
        private string _bUSIESS_NAME = String.Empty;
        private string _bUSIESS_DESC = String.Empty;
        private string _bUSIESS_CODE = String.Empty;
        private decimal _bSORTNUM;

        public BUSIESS()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "number", FieldName = "BUSIESS_ID", TableName = "BUSIESS")]
        public decimal BUSIESS_ID
        {
            get { return _bUSIESS_ID; }
            set
            {
                _bUSIESS_ID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "BUS_BUSIESS_ID", TableName = "BUSIESS")]
        public decimal BUS_BUSIESS_ID
        {
            get { return _bUS_BUSIESS_ID; }
            set
            {
                _bUS_BUSIESS_ID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "EXECUTE_TIME", TableName = "BUSIESS")]
        public decimal EXECUTE_TIME
        {
            get { return _eXECUTE_TIME; }
            set
            {
                _eXECUTE_TIME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "BUSIESS_NAME", TableName = "BUSIESS")]
        public string BUSIESS_NAME
        {
            get { return _bUSIESS_NAME; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _bUSIESS_NAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "BUSIESS_DESC", TableName = "BUSIESS")]
        public string BUSIESS_DESC
        {
            get { return _bUSIESS_DESC; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _bUSIESS_DESC = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "BUSIESS_CODE", TableName = "BUSIESS")]
        public string BUSIESS_CODE
        {
            get { return _bUSIESS_CODE; }
            set
            {
                if (value != null && value.Trim().Length > 16)
                    value = value.Trim().Substring(0, 16);

                _bUSIESS_CODE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "BSORTNUM", TableName = "BUSIESS")]
        public decimal BSORTNUM
        {
            get { return _bSORTNUM; }
            set
            {
                _bSORTNUM = value;

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

