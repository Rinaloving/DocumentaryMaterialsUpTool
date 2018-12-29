
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
    #region PROCESS
    /// <summary>
    ///  (PROCESS)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (pfuser)", TableName = "PROCESS", PrimaryKey = "PROC_ID")]
    public class PROCESS : IEntity
    {

        private decimal _pROC_ID;
        private decimal _bUSIESS_ID;
        private string _pROCESS_NAME = String.Empty;
        private decimal _eXECUTE_TIME;
        private decimal _pRE_LENGTH;
        private string _pRE_NO = String.Empty;
        private decimal _cURNO;
        private string _pROCESS_DESC = String.Empty;
        private byte[] _pROC_ENTITY;
        private decimal _iSVALID;
        private decimal _iSFLOW;
        private decimal _pSORTNUM;
        private string _bUSRULENAME = String.Empty;
        private string _bUSSTATELIST = String.Empty;
        private decimal _pRIORITY;
        private string _cASEFORM = String.Empty;
        private string _aPPNAME = String.Empty;
        private string _pROC_CODE = String.Empty;
        private decimal _cODERULE;

        public PROCESS()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "number", FieldName = "PROC_ID", TableName = "PROCESS")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = false, FieldType = "number", FieldName = "BUSIESS_ID", TableName = "PROCESS")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PROCESS_NAME", TableName = "PROCESS")]
        public string PROCESS_NAME
        {
            get { return _pROCESS_NAME; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _pROCESS_NAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "EXECUTE_TIME", TableName = "PROCESS")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "PRE_LENGTH", TableName = "PROCESS")]
        public decimal PRE_LENGTH
        {
            get { return _pRE_LENGTH; }
            set
            {
                _pRE_LENGTH = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PRE_NO", TableName = "PROCESS")]
        public string PRE_NO
        {
            get { return _pRE_NO; }
            set
            {
                if (value != null && value.Trim().Length > 32)
                    value = value.Trim().Substring(0, 32);

                _pRE_NO = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "CURNO", TableName = "PROCESS")]
        public decimal CURNO
        {
            get { return _cURNO; }
            set
            {
                _cURNO = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PROCESS_DESC", TableName = "PROCESS")]
        public string PROCESS_DESC
        {
            get { return _pROCESS_DESC; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _pROCESS_DESC = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "byte[]", FieldName = "PROC_ENTITY", TableName = "PROCESS")]
        public byte[] PROC_ENTITY
        {
            get { return _pROC_ENTITY; }
            set
            {
                _pROC_ENTITY = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "ISVALID", TableName = "PROCESS")]
        public decimal ISVALID
        {
            get { return _iSVALID; }
            set
            {
                _iSVALID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "ISFLOW", TableName = "PROCESS")]
        public decimal ISFLOW
        {
            get { return _iSFLOW; }
            set
            {
                _iSFLOW = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "PSORTNUM", TableName = "PROCESS")]
        public decimal PSORTNUM
        {
            get { return _pSORTNUM; }
            set
            {
                _pSORTNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "BUSRULENAME", TableName = "PROCESS")]
        public string BUSRULENAME
        {
            get { return _bUSRULENAME; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _bUSRULENAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "BUSSTATELIST", TableName = "PROCESS")]
        public string BUSSTATELIST
        {
            get { return _bUSSTATELIST; }
            set
            {
                if (value != null && value.Trim().Length > 255)
                    value = value.Trim().Substring(0, 255);

                _bUSSTATELIST = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "PRIORITY", TableName = "PROCESS")]
        public decimal PRIORITY
        {
            get { return _pRIORITY; }
            set
            {
                _pRIORITY = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CASEFORM", TableName = "PROCESS")]
        public string CASEFORM
        {
            get { return _cASEFORM; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _cASEFORM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "APPNAME", TableName = "PROCESS")]
        public string APPNAME
        {
            get { return _aPPNAME; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _aPPNAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PROC_CODE", TableName = "PROCESS")]
        public string PROC_CODE
        {
            get { return _pROC_CODE; }
            set
            {
                if (value != null && value.Trim().Length > 16)
                    value = value.Trim().Substring(0, 16);

                _pROC_CODE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "CODERULE", TableName = "PROCESS")]
        public decimal CODERULE
        {
            get { return _cODERULE; }
            set
            {
                _cODERULE = value;

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

