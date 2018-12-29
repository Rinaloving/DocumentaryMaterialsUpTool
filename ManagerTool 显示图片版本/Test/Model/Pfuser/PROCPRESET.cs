
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
    #region PROCPRESET
    /// <summary>
    ///  (PROCPRESET)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (pfuser)", TableName = "PROCPRESET", PrimaryKey = "PROCPRESETID")]
    public class PROCPRESET : IEntity
    {

        private decimal _pROCPRESETID;
        private decimal _pROC_ID;
        private string _cHEOPINION = String.Empty;
        private string _aUDOPINION = String.Empty;
        private string _aPROPINION = String.Empty;
        private string _cHEOPINION2 = String.Empty;
        private string _cHEOPINION3 = String.Empty;
        private string _cHEOPINION4 = String.Empty;

        public PROCPRESET()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "number", FieldName = "PROCPRESETID", TableName = "PROCPRESET")]
        public decimal PROCPRESETID
        {
            get { return _pROCPRESETID; }
            set
            {
                _pROCPRESETID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = false, FieldType = "number", FieldName = "PROC_ID", TableName = "PROCPRESET")]
        public decimal PROC_ID
        {
            get { return _pROC_ID; }
            set
            {
                _pROC_ID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CHEOPINION", TableName = "PROCPRESET")]
        public string CHEOPINION
        {
            get { return _cHEOPINION; }
            set
            {
                if (value != null && value.Trim().Length > 500)
                    value = value.Trim().Substring(0, 500);

                _cHEOPINION = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "AUDOPINION", TableName = "PROCPRESET")]
        public string AUDOPINION
        {
            get { return _aUDOPINION; }
            set
            {
                if (value != null && value.Trim().Length > 200)
                    value = value.Trim().Substring(0, 200);

                _aUDOPINION = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "APROPINION", TableName = "PROCPRESET")]
        public string APROPINION
        {
            get { return _aPROPINION; }
            set
            {
                if (value != null && value.Trim().Length > 200)
                    value = value.Trim().Substring(0, 200);

                _aPROPINION = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CHEOPINION2", TableName = "PROCPRESET")]
        public string CHEOPINION2
        {
            get { return _cHEOPINION2; }
            set
            {
                if (value != null && value.Trim().Length > 320)
                    value = value.Trim().Substring(0, 320);

                _cHEOPINION2 = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CHEOPINION3", TableName = "PROCPRESET")]
        public string CHEOPINION3
        {
            get { return _cHEOPINION3; }
            set
            {
                if (value != null && value.Trim().Length > 320)
                    value = value.Trim().Substring(0, 320);

                _cHEOPINION3 = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CHEOPINION4", TableName = "PROCPRESET")]
        public string CHEOPINION4
        {
            get { return _cHEOPINION4; }
            set
            {
                if (value != null && value.Trim().Length > 320)
                    value = value.Trim().Substring(0, 320);

                _cHEOPINION4 = value;

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

