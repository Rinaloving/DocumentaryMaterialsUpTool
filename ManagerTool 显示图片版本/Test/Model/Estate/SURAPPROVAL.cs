
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
    #region SURAPPROVAL
    /// <summary>
    ///  (SURAPPROVAL)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "SURAPPROVAL", PrimaryKey = "SURAPPROVALID")]
    public class SURAPPROVAL : IEntity
    {

        private string _sURAPPROVALID = String.Empty;
        private string _lANDSURVERYID = String.Empty;
        private string _sURVERYMEMO = String.Empty;
        private string _sURVERYMAN = String.Empty;
        private DateTime _sURVERYDATE;
        private string _mEASUREMEMO = String.Empty;
        private string _mEASUREMAN = String.Empty;
        private DateTime _mEASUREDATE;
        private string _aUDITMEMO = String.Empty;
        private string _aUDITMAN = String.Empty;
        private DateTime _aUDITDATE;

        public SURAPPROVAL()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "SURAPPROVALID", TableName = "SURAPPROVAL")]
        public string SURAPPROVALID
        {
            get { return _sURAPPROVALID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _sURAPPROVALID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "LANDSURVERYID", TableName = "SURAPPROVAL")]
        public string LANDSURVERYID
        {
            get { return _lANDSURVERYID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _lANDSURVERYID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "SURVERYMEMO", TableName = "SURAPPROVAL")]
        public string SURVERYMEMO
        {
            get { return _sURVERYMEMO; }
            set
            {
                if (value != null && value.Trim().Length > 300)
                    value = value.Trim().Substring(0, 300);

                _sURVERYMEMO = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "SURVERYMAN", TableName = "SURAPPROVAL")]
        public string SURVERYMAN
        {
            get { return _sURVERYMAN; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _sURVERYMAN = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "SURVERYDATE", TableName = "SURAPPROVAL")]
        public DateTime SURVERYDATE
        {
            get { return _sURVERYDATE; }
            set
            {
                _sURVERYDATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "MEASUREMEMO", TableName = "SURAPPROVAL")]
        public string MEASUREMEMO
        {
            get { return _mEASUREMEMO; }
            set
            {
                if (value != null && value.Trim().Length > 300)
                    value = value.Trim().Substring(0, 300);

                _mEASUREMEMO = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "MEASUREMAN", TableName = "SURAPPROVAL")]
        public string MEASUREMAN
        {
            get { return _mEASUREMAN; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _mEASUREMAN = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "MEASUREDATE", TableName = "SURAPPROVAL")]
        public DateTime MEASUREDATE
        {
            get { return _mEASUREDATE; }
            set
            {
                _mEASUREDATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "AUDITMEMO", TableName = "SURAPPROVAL")]
        public string AUDITMEMO
        {
            get { return _aUDITMEMO; }
            set
            {
                if (value != null && value.Trim().Length > 200)
                    value = value.Trim().Substring(0, 200);

                _aUDITMEMO = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "AUDITMAN", TableName = "SURAPPROVAL")]
        public string AUDITMAN
        {
            get { return _aUDITMAN; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _aUDITMAN = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "AUDITDATE", TableName = "SURAPPROVAL")]
        public DateTime AUDITDATE
        {
            get { return _aUDITDATE; }
            set
            {
                _aUDITDATE = value;

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

