using SmartMap.DataClient.Entity;
using SmartMap.DataClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataConvert.Business
{
    #region SEALUPINFO
    /// <summary>
    ///  (SEALUPINFO)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "SEALUPINFO", PrimaryKey = "SEALUPINFOID")]
    public class SEALUPINFO : IEntity
    {

        private string _sEALUPINFOID = String.Empty;
        private string _rEALEUNUM = String.Empty;
        private string _cASENUM = String.Empty;
        private string _sEAORGNAME = String.Empty;
        private string _sEATYPE = String.Empty;
        private string _sEAFILE = String.Empty;
        private string _sEANUM = String.Empty;
        private DateTime _sEABEGINDATE;
        private DateTime _sEAENDDATE;
        private string _sEARANGE = String.Empty;
        private DateTime _rEGISTERDATE;
        private string _rEGISTERMAN = String.Empty;
        private string _uNREGSEACASENUM = String.Empty;
        private string _uNREGSEAORGNAME = String.Empty;
        private string _uNREGSEAFILE = String.Empty;
        private string _uNREGSEANUM = String.Empty;
        private DateTime _uNREGSEADATE;
        private string _uNREGSEAMAN = String.Empty;
        private decimal _sEAORDER;
        private string _iNFOMEMO = String.Empty;
        private decimal _iNFOSTATE;

        public SEALUPINFO()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "SEALUPINFOID", TableName = "SEALUPINFO")]
        public string SEALUPINFOID
        {
            get { return _sEALUPINFOID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _sEALUPINFOID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REALEUNUM", TableName = "SEALUPINFO")]
        public string REALEUNUM
        {
            get { return _rEALEUNUM; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _rEALEUNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CASENUM", TableName = "SEALUPINFO")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "SEAORGNAME", TableName = "SEALUPINFO")]
        public string SEAORGNAME
        {
            get { return _sEAORGNAME; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _sEAORGNAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "SEATYPE", TableName = "SEALUPINFO")]
        public string SEATYPE
        {
            get { return _sEATYPE; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _sEATYPE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "SEAFILE", TableName = "SEALUPINFO")]
        public string SEAFILE
        {
            get { return _sEAFILE; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _sEAFILE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "SEANUM", TableName = "SEALUPINFO")]
        public string SEANUM
        {
            get { return _sEANUM; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _sEANUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "SEABEGINDATE", TableName = "SEALUPINFO")]
        public DateTime SEABEGINDATE
        {
            get { return _sEABEGINDATE; }
            set
            {
                _sEABEGINDATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "SEAENDDATE", TableName = "SEALUPINFO")]
        public DateTime SEAENDDATE
        {
            get { return _sEAENDDATE; }
            set
            {
                _sEAENDDATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "SEARANGE", TableName = "SEALUPINFO")]
        public string SEARANGE
        {
            get { return _sEARANGE; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _sEARANGE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "REGISTERDATE", TableName = "SEALUPINFO")]
        public DateTime REGISTERDATE
        {
            get { return _rEGISTERDATE; }
            set
            {
                _rEGISTERDATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REGISTERMAN", TableName = "SEALUPINFO")]
        public string REGISTERMAN
        {
            get { return _rEGISTERMAN; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _rEGISTERMAN = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "UNREGSEACASENUM", TableName = "SEALUPINFO")]
        public string UNREGSEACASENUM
        {
            get { return _uNREGSEACASENUM; }
            set
            {
                if (value != null && value.Trim().Length > 32)
                    value = value.Trim().Substring(0, 32);

                _uNREGSEACASENUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "UNREGSEAORGNAME", TableName = "SEALUPINFO")]
        public string UNREGSEAORGNAME
        {
            get { return _uNREGSEAORGNAME; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _uNREGSEAORGNAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "UNREGSEAFILE", TableName = "SEALUPINFO")]
        public string UNREGSEAFILE
        {
            get { return _uNREGSEAFILE; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _uNREGSEAFILE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "UNREGSEANUM", TableName = "SEALUPINFO")]
        public string UNREGSEANUM
        {
            get { return _uNREGSEANUM; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _uNREGSEANUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "UNREGSEADATE", TableName = "SEALUPINFO")]
        public DateTime UNREGSEADATE
        {
            get { return _uNREGSEADATE; }
            set
            {
                _uNREGSEADATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "UNREGSEAMAN", TableName = "SEALUPINFO")]
        public string UNREGSEAMAN
        {
            get { return _uNREGSEAMAN; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _uNREGSEAMAN = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "SEAORDER", TableName = "SEALUPINFO")]
        public decimal SEAORDER
        {
            get { return _sEAORDER; }
            set
            {
                _sEAORDER = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "INFOMEMO", TableName = "SEALUPINFO")]
        public string INFOMEMO
        {
            get { return _iNFOMEMO; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _iNFOMEMO = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "INFOSTATE", TableName = "SEALUPINFO")]
        public decimal INFOSTATE
        {
            get { return _iNFOSTATE; }
            set
            {
                _iNFOSTATE = value;

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
