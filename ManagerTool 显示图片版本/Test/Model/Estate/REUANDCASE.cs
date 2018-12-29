using SmartMap.DataClient.Entity;
using SmartMap.DataClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataConvert.Business
{
    #region REUANDCASE
    /// <summary>
    ///  (REUANDCASE)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "REUANDCASE", PrimaryKey = "REALEUNUM")]
    public class REUANDCASE : IEntity
    {

        private string _rEALEUNUM = String.Empty;
        private string _cASENUM = String.Empty;
        private decimal _tRADEPRICE;
        private decimal _eVAAMOUNT;
        private decimal _pLEAMOUNT;
        private string _pLERANGE = String.Empty;
        private string _oRGCARDNUM = String.Empty;
        private string _iD = String.Empty;

        public REUANDCASE()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "REALEUNUM", TableName = "REUANDCASE")]
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
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "CASENUM", TableName = "REUANDCASE")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "TRADEPRICE", TableName = "REUANDCASE")]
        public decimal TRADEPRICE
        {
            get { return _tRADEPRICE; }
            set
            {
                _tRADEPRICE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "EVAAMOUNT", TableName = "REUANDCASE")]
        public decimal EVAAMOUNT
        {
            get { return _eVAAMOUNT; }
            set
            {
                _eVAAMOUNT = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "PLEAMOUNT", TableName = "REUANDCASE")]
        public decimal PLEAMOUNT
        {
            get { return _pLEAMOUNT; }
            set
            {
                _pLEAMOUNT = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PLERANGE", TableName = "REUANDCASE")]
        public string PLERANGE
        {
            get { return _pLERANGE; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _pLERANGE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "ORGCARDNUM", TableName = "REUANDCASE")]
        public string ORGCARDNUM
        {
            get { return _oRGCARDNUM; }
            set
            {
                if (value != null && value.Trim().Length > 60)
                    value = value.Trim().Substring(0, 60);

                _oRGCARDNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "ID", TableName = "REUANDCASE")] //如果要在表里面插入字段，则FieldName的名字必须和表中的字段名一样，否则插入不了，这里用的是反射的原理
        public string ID
        {
            get { return _iD; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _iD = value;

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
