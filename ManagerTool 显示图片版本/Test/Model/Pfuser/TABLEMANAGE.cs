using System;
using System.Collections;
using SmartMap.DataClient.Model;
using SmartMap.DataClient.Entity;

namespace DataConvert.Business
{
    #region TABLEMANAGE
    /// <summary>
    ///  (TABLEMANAGE)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (pfuser)", TableName = "TABLEMANAGE")]
    public class TABLEMANAGE : IEntity
    {

        private string _tABLENAME = String.Empty;
        private decimal _tABLECURENTID;
        private string _tABLEMANAGEDDSC = String.Empty;

        public TABLEMANAGE()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "TABLENAME", TableName = "TABLEMANAGE")]
        public string TABLENAME
        {
            get { return _tABLENAME; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _tABLENAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = false, FieldType = "number", FieldName = "TABLECURENTID", TableName = "TABLEMANAGE")]
        public decimal TABLECURENTID
        {
            get { return _tABLECURENTID; }
            set
            {
                _tABLECURENTID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "TABLEMANAGEDDSC", TableName = "TABLEMANAGE")]
        public string TABLEMANAGEDDSC
        {
            get { return _tABLEMANAGEDDSC; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _tABLEMANAGEDDSC = value;

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

