
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
    #region OTHERRIGHTINFO
    /// <summary>
    ///  (OTHERRIGHTINFO)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "OTHERRIGHTINFO", PrimaryKey = "OTHERRIGHTINFOID")]
    public class OTHERRIGHTINFO : IEntity
    {

        private string _oTHERRIGHTINFOID = String.Empty;
        private string _cASENUM = String.Empty;
        private string _rEALEUNUM = String.Empty;
        private string _oBLIGEENAME = String.Empty;
        private string _cERTYPE = String.Empty;
        private string _cERNUM = String.Empty;
        private string _sHARESTATUS = String.Empty;
        private string _rEGISTERTYPE = String.Empty;
        private string _rIGHTTYPE = String.Empty;
        private string _rEGISTERCAUSE = String.Empty;
        private DateTime _uSEBEGINDATE;
        private DateTime _uSEENDDATE;
        private string _gETWATERMODE = String.Empty;
        private string _wATERORGTYPE = String.Empty;
        private decimal _wATERVOLUME;
        private string _wATERUSE = String.Empty;
        private decimal _eXPLOREAREA;
        private string _tAKINGMINE = String.Empty;
        private string _tAKINGMODE = String.Empty;
        private string _pRODUCESCOPE = String.Empty;
        private string _rEALESTATECARDNUM = String.Empty;
        private DateTime _rEGISTERDATE;
        private string _rEGISTERMAN = String.Empty;
        private string _iNFOMEMO = String.Empty;
        private decimal _iNFOSTATE;

        public OTHERRIGHTINFO()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "OTHERRIGHTINFOID", TableName = "OTHERRIGHTINFO")]
        public string OTHERRIGHTINFOID
        {
            get { return _oTHERRIGHTINFOID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _oTHERRIGHTINFOID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CASENUM", TableName = "OTHERRIGHTINFO")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REALEUNUM", TableName = "OTHERRIGHTINFO")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "OBLIGEENAME", TableName = "OTHERRIGHTINFO")]
        public string OBLIGEENAME
        {
            get { return _oBLIGEENAME; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _oBLIGEENAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CERTYPE", TableName = "OTHERRIGHTINFO")]
        public string CERTYPE
        {
            get { return _cERTYPE; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _cERTYPE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CERNUM", TableName = "OTHERRIGHTINFO")]
        public string CERNUM
        {
            get { return _cERNUM; }
            set
            {
                if (value != null && value.Trim().Length > 40)
                    value = value.Trim().Substring(0, 40);

                _cERNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "SHARESTATUS", TableName = "OTHERRIGHTINFO")]
        public string SHARESTATUS
        {
            get { return _sHARESTATUS; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _sHARESTATUS = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REGISTERTYPE", TableName = "OTHERRIGHTINFO")]
        public string REGISTERTYPE
        {
            get { return _rEGISTERTYPE; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _rEGISTERTYPE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "RIGHTTYPE", TableName = "OTHERRIGHTINFO")]
        public string RIGHTTYPE
        {
            get { return _rIGHTTYPE; }
            set
            {
                if (value != null && value.Trim().Length > 40)
                    value = value.Trim().Substring(0, 40);

                _rIGHTTYPE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REGISTERCAUSE", TableName = "OTHERRIGHTINFO")]
        public string REGISTERCAUSE
        {
            get { return _rEGISTERCAUSE; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _rEGISTERCAUSE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "USEBEGINDATE", TableName = "OTHERRIGHTINFO")]
        public DateTime USEBEGINDATE
        {
            get { return _uSEBEGINDATE; }
            set
            {
                _uSEBEGINDATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "USEENDDATE", TableName = "OTHERRIGHTINFO")]
        public DateTime USEENDDATE
        {
            get { return _uSEENDDATE; }
            set
            {
                _uSEENDDATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "GETWATERMODE", TableName = "OTHERRIGHTINFO")]
        public string GETWATERMODE
        {
            get { return _gETWATERMODE; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _gETWATERMODE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "WATERORGTYPE", TableName = "OTHERRIGHTINFO")]
        public string WATERORGTYPE
        {
            get { return _wATERORGTYPE; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _wATERORGTYPE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "WATERVOLUME", TableName = "OTHERRIGHTINFO")]
        public decimal WATERVOLUME
        {
            get { return _wATERVOLUME; }
            set
            {
                _wATERVOLUME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "WATERUSE", TableName = "OTHERRIGHTINFO")]
        public string WATERUSE
        {
            get { return _wATERUSE; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _wATERUSE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "EXPLOREAREA", TableName = "OTHERRIGHTINFO")]
        public decimal EXPLOREAREA
        {
            get { return _eXPLOREAREA; }
            set
            {
                _eXPLOREAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "TAKINGMINE", TableName = "OTHERRIGHTINFO")]
        public string TAKINGMINE
        {
            get { return _tAKINGMINE; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _tAKINGMINE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "TAKINGMODE", TableName = "OTHERRIGHTINFO")]
        public string TAKINGMODE
        {
            get { return _tAKINGMODE; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _tAKINGMODE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PRODUCESCOPE", TableName = "OTHERRIGHTINFO")]
        public string PRODUCESCOPE
        {
            get { return _pRODUCESCOPE; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _pRODUCESCOPE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REALESTATECARDNUM", TableName = "OTHERRIGHTINFO")]
        public string REALESTATECARDNUM
        {
            get { return _rEALESTATECARDNUM; }
            set
            {
                if (value != null && value.Trim().Length > 60)
                    value = value.Trim().Substring(0, 60);

                _rEALESTATECARDNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "REGISTERDATE", TableName = "OTHERRIGHTINFO")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REGISTERMAN", TableName = "OTHERRIGHTINFO")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "INFOMEMO", TableName = "OTHERRIGHTINFO")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "INFOSTATE", TableName = "OTHERRIGHTINFO")]
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

