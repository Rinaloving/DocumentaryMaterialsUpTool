using SmartMap.DataClient.Entity;
using SmartMap.DataClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataConvert.Business
{
    #region REALESTATEUNIT
    /// <summary>
    ///  (REALESTATEUNIT)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "REALESTATEUNIT", PrimaryKey = "REALEUNUM")]
    public class REALESTATEUNIT : IEntity
    {

        private string _rEALEUNUM = String.Empty;
        private string _rEALEUNEWNUM = String.Empty;
        private decimal _rEALEUTYPE;
        private decimal _rEALEUSTATE;

        public REALESTATEUNIT()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "REALEUNUM", TableName = "REALESTATEUNIT")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REALEUNEWNUM", TableName = "REALESTATEUNIT")]
        public string REALEUNEWNUM
        {
            get { return _rEALEUNEWNUM; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _rEALEUNEWNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "REALEUTYPE", TableName = "REALESTATEUNIT")]
        public decimal REALEUTYPE
        {
            get { return _rEALEUTYPE; }
            set
            {
                _rEALEUTYPE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "REALEUSTATE", TableName = "REALESTATEUNIT")]
        public decimal REALEUSTATE
        {
            get { return _rEALEUSTATE; }
            set
            {
                _rEALEUSTATE = value;

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
