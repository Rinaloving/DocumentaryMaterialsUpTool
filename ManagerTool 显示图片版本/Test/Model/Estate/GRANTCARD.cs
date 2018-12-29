
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
    #region GRANTCARD
    /// <summary>
    ///  (GRANTCARD)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "GRANTCARD", PrimaryKey = "GRANTCARDID")]
    public class GRANTCARD : IEntity
    {

        private string _gRANTCARDID = String.Empty;
        private string _oWNERSID = String.Empty;
        private string _cERTIFICATEID = String.Empty;
        private string _cASENUM = String.Empty;
        private string _cARDNAME = String.Empty;
        private string _gRACARDMAN = String.Empty;
        private DateTime _gRACARDDATE;
        private decimal _gRACARD;
        private string _cARDNUM = String.Empty;
        private string _rECCARDMAN = String.Empty;
        private string _gRACARDDESC = String.Empty;

        public GRANTCARD()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "GRANTCARDID", TableName = "GRANTCARD")]
        public string GRANTCARDID
        {
            get { return _gRANTCARDID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _gRANTCARDID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "OWNERSID", TableName = "GRANTCARD")]
        public string OWNERSID
        {
            get { return _oWNERSID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _oWNERSID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CERTIFICATEID", TableName = "GRANTCARD")]
        public string CERTIFICATEID
        {
            get { return _cERTIFICATEID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _cERTIFICATEID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CASENUM", TableName = "GRANTCARD")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CARDNAME", TableName = "GRANTCARD")]
        public string CARDNAME
        {
            get { return _cARDNAME; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _cARDNAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "GRACARDMAN", TableName = "GRANTCARD")]
        public string GRACARDMAN
        {
            get { return _gRACARDMAN; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _gRACARDMAN = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "GRACARDDATE", TableName = "GRANTCARD")]
        public DateTime GRACARDDATE
        {
            get { return _gRACARDDATE; }
            set
            {
                _gRACARDDATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "GRACARD", TableName = "GRANTCARD")]
        public decimal GRACARD
        {
            get { return _gRACARD; }
            set
            {
                _gRACARD = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CARDNUM", TableName = "GRANTCARD")]
        public string CARDNUM
        {
            get { return _cARDNUM; }
            set
            {
                if (value != null && value.Trim().Length > 60)
                    value = value.Trim().Substring(0, 60);

                _cARDNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "RECCARDMAN", TableName = "GRANTCARD")]
        public string RECCARDMAN
        {
            get { return _rECCARDMAN; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _rECCARDMAN = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "GRACARDDESC", TableName = "GRANTCARD")]
        public string GRACARDDESC
        {
            get { return _gRACARDDESC; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _gRACARDDESC = value;

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

