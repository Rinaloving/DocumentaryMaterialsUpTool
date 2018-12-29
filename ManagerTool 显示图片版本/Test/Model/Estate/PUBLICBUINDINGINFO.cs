
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
    #region PUBLICBUINDINGINFO
    /// <summary>
    ///  (PUBLICBUINDINGINFO)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "PUBLICBUINDINGINFO", PrimaryKey = "PUBLICBUINDINGINFOID")]
    public class PUBLICBUINDINGINFO : IEntity
    {

        private string _pUBLICBUINDINGINFOID = String.Empty;
        private string _rEALEUNUM = String.Empty;
        private string _cASENUM = String.Empty;
        private string _pUBLICOWNERNAME = String.Empty;
        private string _rIGHTTYPE = String.Empty;
        private string _bUILDINGNUM = String.Empty;
        private string _bUILDINGNAME = String.Empty;
        private decimal _bUILDINGCOUNT;
        private decimal _bUILDINGAREA;
        private decimal _sHARELANDAREA;
        private DateTime _rEGISTERDATE;
        private string _rEGISTERMAN = String.Empty;
        private string _iNFOMEMO = String.Empty;
        private decimal _iNFOSTATE;

        public PUBLICBUINDINGINFO()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "PUBLICBUINDINGINFOID", TableName = "PUBLICBUINDINGINFO")]
        public string PUBLICBUINDINGINFOID
        {
            get { return _pUBLICBUINDINGINFOID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _pUBLICBUINDINGINFOID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REALEUNUM", TableName = "PUBLICBUINDINGINFO")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CASENUM", TableName = "PUBLICBUINDINGINFO")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PUBLICOWNERNAME", TableName = "PUBLICBUINDINGINFO")]
        public string PUBLICOWNERNAME
        {
            get { return _pUBLICOWNERNAME; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _pUBLICOWNERNAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "RIGHTTYPE", TableName = "PUBLICBUINDINGINFO")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "BUILDINGNUM", TableName = "PUBLICBUINDINGINFO")]
        public string BUILDINGNUM
        {
            get { return _bUILDINGNUM; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _bUILDINGNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "BUILDINGNAME", TableName = "PUBLICBUINDINGINFO")]
        public string BUILDINGNAME
        {
            get { return _bUILDINGNAME; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _bUILDINGNAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "BUILDINGCOUNT", TableName = "PUBLICBUINDINGINFO")]
        public decimal BUILDINGCOUNT
        {
            get { return _bUILDINGCOUNT; }
            set
            {
                _bUILDINGCOUNT = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "BUILDINGAREA", TableName = "PUBLICBUINDINGINFO")]
        public decimal BUILDINGAREA
        {
            get { return _bUILDINGAREA; }
            set
            {
                _bUILDINGAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "SHARELANDAREA", TableName = "PUBLICBUINDINGINFO")]
        public decimal SHARELANDAREA
        {
            get { return _sHARELANDAREA; }
            set
            {
                _sHARELANDAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "REGISTERDATE", TableName = "PUBLICBUINDINGINFO")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REGISTERMAN", TableName = "PUBLICBUINDINGINFO")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "INFOMEMO", TableName = "PUBLICBUINDINGINFO")]
        public string INFOMEMO
        {
            get { return _iNFOMEMO; }
            set
            {
                if (value != null && value.Trim().Length > 250)
                    value = value.Trim().Substring(0, 250);

                _iNFOMEMO = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "INFOSTATE", TableName = "PUBLICBUINDINGINFO")]
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

