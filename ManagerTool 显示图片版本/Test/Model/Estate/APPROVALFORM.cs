using SmartMap.DataClient.Entity;
using SmartMap.DataClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataConvert.Business
{
    #region APPROVALFORM
    /// <summary>
    ///  审批表
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "APPROVALFORM", PrimaryKey = "CASENUM")]
    public class APPROVALFORM : IEntity
    {

        private string _cASENUM = String.Empty;
        private string _cHENAME = String.Empty;
        private string _cHESIGN = String.Empty;
        private string _cHEOPINION = String.Empty;
        private DateTime _cHEDATE;
        private string _aUDNAME = String.Empty;
        private string _aUDSIGN = String.Empty;
        private string _aUDOPINION = String.Empty;
        private DateTime _aUDDATE;
        private string _aPRNAME = String.Empty;
        private string _aPRSIGN = String.Empty;
        private string _aPROPINION = String.Empty;
        private DateTime _aPRDATE;
        private string _aPPRODESC = String.Empty;
        private string _cHENAME2 = String.Empty;
        private string _cHESIGN2 = String.Empty;
        private string _cHEOPINION2 = String.Empty;
        private DateTime _cHEDATE2;

        public APPROVALFORM()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "CASENUM", TableName = "APPROVALFORM")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CHENAME", TableName = "APPROVALFORM")]
        public string CHENAME
        {
            get { return _cHENAME; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _cHENAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CHESIGN", TableName = "APPROVALFORM")]
        public string CHESIGN
        {
            get { return _cHESIGN; }
            set
            {
                if (value != null && value.Trim().Length > 32)
                    value = value.Trim().Substring(0, 32);

                _cHESIGN = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CHEOPINION", TableName = "APPROVALFORM")]
        public string CHEOPINION
        {
            get { return _cHEOPINION; }
            set
            {
                if (value != null && value.Trim().Length > 650)
                    value = value.Trim().Substring(0, 650);

                _cHEOPINION = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "CHEDATE", TableName = "APPROVALFORM")]
        public DateTime CHEDATE
        {
            get { return _cHEDATE; }
            set
            {
                _cHEDATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "AUDNAME", TableName = "APPROVALFORM")]
        public string AUDNAME
        {
            get { return _aUDNAME; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _aUDNAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "AUDSIGN", TableName = "APPROVALFORM")]
        public string AUDSIGN
        {
            get { return _aUDSIGN; }
            set
            {
                if (value != null && value.Trim().Length > 32)
                    value = value.Trim().Substring(0, 32);

                _aUDSIGN = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "AUDOPINION", TableName = "APPROVALFORM")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "AUDDATE", TableName = "APPROVALFORM")]
        public DateTime AUDDATE
        {
            get { return _aUDDATE; }
            set
            {
                _aUDDATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "APRNAME", TableName = "APPROVALFORM")]
        public string APRNAME
        {
            get { return _aPRNAME; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _aPRNAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "APRSIGN", TableName = "APPROVALFORM")]
        public string APRSIGN
        {
            get { return _aPRSIGN; }
            set
            {
                if (value != null && value.Trim().Length > 32)
                    value = value.Trim().Substring(0, 32);

                _aPRSIGN = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "APROPINION", TableName = "APPROVALFORM")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "APRDATE", TableName = "APPROVALFORM")]
        public DateTime APRDATE
        {
            get { return _aPRDATE; }
            set
            {
                _aPRDATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "APPRODESC", TableName = "APPROVALFORM")]
        public string APPRODESC
        {
            get { return _aPPRODESC; }
            set
            {
                if (value != null && value.Trim().Length > 4000)
                    value = value.Trim().Substring(0, 4000);

                _aPPRODESC = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CHENAME2", TableName = "APPROVALFORM")]
        public string CHENAME2
        {
            get { return _cHENAME2; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _cHENAME2 = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CHESIGN2", TableName = "APPROVALFORM")]
        public string CHESIGN2
        {
            get { return _cHESIGN2; }
            set
            {
                if (value != null && value.Trim().Length > 32)
                    value = value.Trim().Substring(0, 32);

                _cHESIGN2 = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CHEOPINION2", TableName = "APPROVALFORM")]
        public string CHEOPINION2
        {
            get { return _cHEOPINION2; }
            set
            {
                if (value != null && value.Trim().Length > 350)
                    value = value.Trim().Substring(0, 350);

                _cHEOPINION2 = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "CHEDATE2", TableName = "APPROVALFORM")]
        public DateTime CHEDATE2
        {
            get { return _cHEDATE2; }
            set
            {
                _cHEDATE2 = value;

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
