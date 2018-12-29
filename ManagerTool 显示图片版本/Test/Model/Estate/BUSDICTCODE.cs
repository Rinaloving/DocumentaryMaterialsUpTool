
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
    #region BUSDICTCODE
    /// <summary>
    ///  (BUSDICTCODE)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "BUSDICTCODE", PrimaryKey = "DICTCODEID")]
    public class BUSDICTCODE : IEntity
    {

        private string _dICTCODEID = String.Empty;
        private string _bUS_DICTCODEID = String.Empty;
        private string _cODENO = String.Empty;
        private string _cODENAME = String.Empty;

        public BUSDICTCODE()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "DICTCODEID", TableName = "BUSDICTCODE")]
        public string DICTCODEID
        {
            get { return _dICTCODEID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _dICTCODEID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "BUS_DICTCODEID", TableName = "BUSDICTCODE")]
        public string BUS_DICTCODEID
        {
            get { return _bUS_DICTCODEID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _bUS_DICTCODEID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CODENO", TableName = "BUSDICTCODE")]
        public string CODENO
        {
            get { return _cODENO; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _cODENO = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "CODENAME", TableName = "BUSDICTCODE")]
        public string CODENAME
        {
            get { return _cODENAME; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _cODENAME = value;

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

