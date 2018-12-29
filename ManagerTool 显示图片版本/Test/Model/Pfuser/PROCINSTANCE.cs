
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
	#region PROCINSTANCE
	/// <summary>
	///  (PROCINSTANCE)
	/// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (pfuser)", TableName = "PROCINSTANCE" ,PrimaryKey = "PROCINSTANCE_ID")]
	public class PROCINSTANCE:IEntity
	{
		
		private decimal _pROCINSTANCE_ID;
		private decimal _cRESTAFF;
		private decimal _pROC_ID;
		private string _sERIAL_NO = String.Empty;
		private string _eNTITY_ID = String.Empty;
		private string _bUSIESS_NAME = String.Empty;
		private string _pROCESS_NAME = String.Empty;
		private decimal _tASK_STATUS;
		private DateTime _dATE_CREATED;
		private DateTime _dATE_REQUIRE;
		private DateTime _dATE_COMPLETED;
		private decimal _iSVALID;
		private string _pROCINSTANCE_DESC = String.Empty;
		private string _aPPMAN = String.Empty;
		private string _lOCATION = String.Empty;
		private string _aPPNAME = String.Empty;
		private string _aPPMAN2 = String.Empty;
		private decimal _cARDSTATUS;
		private string _pROC_CODE = String.Empty;
		
		public PROCINSTANCE()
		{
		}

		

		
		#region Public Properties

		
        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "",IsPrimaryKey = true,AutoIncrement = false, Nullable = false, FieldType = "number", FieldName = "PROCINSTANCE_ID", TableName = "PROCINSTANCE")]
		public decimal PROCINSTANCE_ID
		{
			get {return _pROCINSTANCE_ID;}
			set {
                    _pROCINSTANCE_ID = value;
            
                }
		}
			
        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "",AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "CRESTAFF", TableName = "PROCINSTANCE")]
		public decimal CRESTAFF
		{
			get {return _cRESTAFF;}
			set {
                    _cRESTAFF = value;
            
                }
		}
			
        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "",AutoIncrement = false, Nullable = false, FieldType = "number", FieldName = "PROC_ID", TableName = "PROCINSTANCE")]
		public decimal PROC_ID
		{
			get {return _pROC_ID;}
			set {
                    _pROC_ID = value;
            
                }
		}
			
        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "",AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "SERIAL_NO", TableName = "PROCINSTANCE")]
		public string SERIAL_NO
		{
			get {return _sERIAL_NO;}
			set {
                                  if (value != null && value.Trim().Length > 32)
                    value = value.Trim().Substring(0, 32);    
                 
                    _sERIAL_NO = value;
            
                }
		}
			
        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "",AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "ENTITY_ID", TableName = "PROCINSTANCE")]
		public string ENTITY_ID
		{
			get {return _eNTITY_ID;}
			set {
                                  if (value != null && value.Trim().Length > 32)
                    value = value.Trim().Substring(0, 32);    
                 
                    _eNTITY_ID = value;
            
                }
		}
			
        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "",AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "BUSIESS_NAME", TableName = "PROCINSTANCE")]
		public string BUSIESS_NAME
		{
			get {return _bUSIESS_NAME;}
			set {
                                  if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);    
                 
                    _bUSIESS_NAME = value;
            
                }
		}
			
        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "",AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PROCESS_NAME", TableName = "PROCINSTANCE")]
		public string PROCESS_NAME
		{
			get {return _pROCESS_NAME;}
			set {
                                  if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);    
                 
                    _pROCESS_NAME = value;
            
                }
		}
			
        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "",AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "TASK_STATUS", TableName = "PROCINSTANCE")]
		public decimal TASK_STATUS
		{
			get {return _tASK_STATUS;}
			set {
                    _tASK_STATUS = value;
            
                }
		}
			
        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "",AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "DATE_CREATED", TableName = "PROCINSTANCE")]
		public DateTime DATE_CREATED
		{
			get {return _dATE_CREATED;}
			set {
                    _dATE_CREATED = value;
            
                }
		}
			
        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "",AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "DATE_REQUIRE", TableName = "PROCINSTANCE")]
		public DateTime DATE_REQUIRE
		{
			get {return _dATE_REQUIRE;}
			set {
                    _dATE_REQUIRE = value;
            
                }
		}
			
        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "",AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "DATE_COMPLETED", TableName = "PROCINSTANCE")]
		public DateTime DATE_COMPLETED
		{
			get {return _dATE_COMPLETED;}
			set {
                    _dATE_COMPLETED = value;
            
                }
		}
			
        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "",AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "ISVALID", TableName = "PROCINSTANCE")]
		public decimal ISVALID
		{
			get {return _iSVALID;}
			set {
                    _iSVALID = value;
            
                }
		}
			
        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "",AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PROCINSTANCE_DESC", TableName = "PROCINSTANCE")]
		public string PROCINSTANCE_DESC
		{
			get {return _pROCINSTANCE_DESC;}
			set {
                                  if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);    
                 
                    _pROCINSTANCE_DESC = value;
            
                }
		}
			
        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "",AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "APPMAN", TableName = "PROCINSTANCE")]
		public string APPMAN
		{
			get {return _aPPMAN;}
			set {
                                  if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);    
                 
                    _aPPMAN = value;
            
                }
		}
			
        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "",AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "LOCATION", TableName = "PROCINSTANCE")]
		public string LOCATION
		{
			get {return _lOCATION;}
			set {
                                  if (value != null && value.Trim().Length > 300)
                    value = value.Trim().Substring(0, 300);    
                 
                    _lOCATION = value;
            
                }
		}
			
        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "",AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "APPNAME", TableName = "PROCINSTANCE")]
		public string APPNAME
		{
			get {return _aPPNAME;}
			set {
                                  if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);    
                 
                    _aPPNAME = value;
            
                }
		}
			
        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "",AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "APPMAN2", TableName = "PROCINSTANCE")]
		public string APPMAN2
		{
			get {return _aPPMAN2;}
			set {
                                  if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);    
                 
                    _aPPMAN2 = value;
            
                }
		}
			
        /// <summary>
        /// 0,无状态
        /// </summary>
        [ColumnAttribute(Description = "",AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "CARDSTATUS", TableName = "PROCINSTANCE")]
		public decimal CARDSTATUS
		{
			get {return _cARDSTATUS;}
			set {
                    _cARDSTATUS = value;
            
                }
		}
			
        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "",AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PROC_CODE", TableName = "PROCINSTANCE")]
		public string PROC_CODE
		{
			get {return _pROC_CODE;}
			set {
                                  if (value != null && value.Trim().Length > 16)
                    value = value.Trim().Substring(0, 16);    
                 
                    _pROC_CODE = value;
            
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

