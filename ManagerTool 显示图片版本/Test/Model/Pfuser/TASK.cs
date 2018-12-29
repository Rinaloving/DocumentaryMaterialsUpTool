using System;
using System.Collections;
using SmartMap.DataClient.Model;
using SmartMap.DataClient.Entity;

namespace DataConvert.Business
{
    #region TASK
    /// <summary>
    ///  (TASK)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (pfuser)", TableName = "TASK")]
    public class TASK : IEntity
    {

        private decimal _tASK_ID;
        private decimal _aCT_ID;
        private decimal _pROCINSTANCE_ID;
        private decimal _sTAFF_ID;
        private string _aCT_NAME = String.Empty;
        private decimal _tASK_STATUS;
        private DateTime _dATE_CREATED;
        private DateTime _dATE_ACCEPTED;
        private DateTime _dATE_REQUIRE;
        private DateTime _dATE_COMPLETED;
        private string _tASK_DESC = String.Empty;
        private string _oPINION = String.Empty;
        private decimal _dEPTRANGE;

        public TASK()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "number", FieldName = "TASK_ID", TableName = "TASK")]
        public decimal TASK_ID
        {
            get { return _tASK_ID; }
            set
            {
                _tASK_ID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = false, FieldType = "number", FieldName = "ACT_ID", TableName = "TASK")]
        public decimal ACT_ID
        {
            get { return _aCT_ID; }
            set
            {
                _aCT_ID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "PROCINSTANCE_ID", TableName = "TASK")]
        public decimal PROCINSTANCE_ID
        {
            get { return _pROCINSTANCE_ID; }
            set
            {
                _pROCINSTANCE_ID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "STAFF_ID", TableName = "TASK")]
        public decimal STAFF_ID
        {
            get { return _sTAFF_ID; }
            set
            {
                _sTAFF_ID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "ACT_NAME", TableName = "TASK")]
        public string ACT_NAME
        {
            get { return _aCT_NAME; }
            set
            {
                if (value != null && value.Trim().Length > 32)
                    value = value.Trim().Substring(0, 32);

                _aCT_NAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "TASK_STATUS", TableName = "TASK")]
        public decimal TASK_STATUS
        {
            get { return _tASK_STATUS; }
            set
            {
                _tASK_STATUS = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "DATE_CREATED", TableName = "TASK")]
        public DateTime DATE_CREATED
        {
            get { return _dATE_CREATED; }
            set
            {
                _dATE_CREATED = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "DATE_ACCEPTED", TableName = "TASK")]
        public DateTime DATE_ACCEPTED
        {
            get { return _dATE_ACCEPTED; }
            set
            {
                _dATE_ACCEPTED = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "DATE_REQUIRE", TableName = "TASK")]
        public DateTime DATE_REQUIRE
        {
            get { return _dATE_REQUIRE; }
            set
            {
                _dATE_REQUIRE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "DATE_COMPLETED", TableName = "TASK")]
        public DateTime DATE_COMPLETED
        {
            get { return _dATE_COMPLETED; }
            set
            {
                _dATE_COMPLETED = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "TASK_DESC", TableName = "TASK")]
        public string TASK_DESC
        {
            get { return _tASK_DESC; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _tASK_DESC = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "OPINION", TableName = "TASK")]
        public string OPINION
        {
            get { return _oPINION; }
            set
            {
                if (value != null && value.Trim().Length > 500)
                    value = value.Trim().Substring(0, 500);

                _oPINION = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "DEPTRANGE", TableName = "TASK")]
        public decimal DEPTRANGE
        {
            get { return _dEPTRANGE; }
            set
            {
                _dEPTRANGE = value;

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

