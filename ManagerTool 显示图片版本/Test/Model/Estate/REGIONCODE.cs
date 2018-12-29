using SmartMap.DataClient.Entity;
using SmartMap.DataClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataConvert.Business
{
    #region REGIONCODE
    /// <summary>
    ///  (REGIONCODE)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "REGIONCODE", PrimaryKey = "REGIONCODENUM")]
    public class REGIONCODE : IEntity
    {

        private string _rEGIONCODENUM = String.Empty;
        private string _pROVINCENAME = String.Empty;
        private string _pROVINCEWORD = String.Empty;
        private string _cITYNAME = String.Empty;
        private string _cOUNTYNAME = String.Empty;
        private string _rEGORGWORD = String.Empty;
        private string _rEGORGNAME = String.Empty;
        private decimal _iSCOUNTRYAUTH;

        public REGIONCODE()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "REGIONCODENUM", TableName = "REGIONCODE")]
        public string REGIONCODENUM
        {
            get { return _rEGIONCODENUM; }
            set
            {
                if (value != null && value.Trim().Length > 6)
                    value = value.Trim().Substring(0, 6);

                _rEGIONCODENUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PROVINCENAME", TableName = "REGIONCODE")]
        public string PROVINCENAME
        {
            get { return _pROVINCENAME; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _pROVINCENAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PROVINCEWORD", TableName = "REGIONCODE")]
        public string PROVINCEWORD
        {
            get { return _pROVINCEWORD; }
            set
            {
                if (value != null && value.Trim().Length > 10)
                    value = value.Trim().Substring(0, 10);

                _pROVINCEWORD = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CITYNAME", TableName = "REGIONCODE")]
        public string CITYNAME
        {
            get { return _cITYNAME; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _cITYNAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "COUNTYNAME", TableName = "REGIONCODE")]
        public string COUNTYNAME
        {
            get { return _cOUNTYNAME; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _cOUNTYNAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REGORGWORD", TableName = "REGIONCODE")]
        public string REGORGWORD
        {
            get { return _rEGORGWORD; }
            set
            {
                if (value != null && value.Trim().Length > 10)
                    value = value.Trim().Substring(0, 10);

                _rEGORGWORD = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REGORGNAME", TableName = "REGIONCODE")]
        public string REGORGNAME
        {
            get { return _rEGORGNAME; }
            set
            {
                if (value != null && value.Trim().Length > 32)
                    value = value.Trim().Substring(0, 32);

                _rEGORGNAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "ISCOUNTRYAUTH", TableName = "REGIONCODE")]
        public decimal ISCOUNTRYAUTH
        {
            get { return _iSCOUNTRYAUTH; }
            set
            {
                _iSCOUNTRYAUTH = value;

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
