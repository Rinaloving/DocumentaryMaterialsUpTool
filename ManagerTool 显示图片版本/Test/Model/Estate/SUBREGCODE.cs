using SmartMap.DataClient.Entity;
using SmartMap.DataClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataConvert.Business
{
    #region SUBREGCODE
    /// <summary>
    ///  (SUBREGCODE)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "SUBREGCODE", PrimaryKey = "SUBREGCODENUM")]
    public class SUBREGCODE : IEntity
    {

        private string _sUBREGCODENUM = String.Empty;
        private string _rEGIONCODENUM = String.Empty;
        private string _tOWNNAME = String.Empty;
        private string _vILLAGENAME = String.Empty;

        public SUBREGCODE()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "SUBREGCODENUM", TableName = "SUBREGCODE")]
        public string SUBREGCODENUM
        {
            get { return _sUBREGCODENUM; }
            set
            {
                if (value != null && value.Trim().Length > 12)
                    value = value.Trim().Substring(0, 12);

                _sUBREGCODENUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REGIONCODENUM", TableName = "SUBREGCODE")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "TOWNNAME", TableName = "SUBREGCODE")]
        public string TOWNNAME
        {
            get { return _tOWNNAME; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _tOWNNAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "VILLAGENAME", TableName = "SUBREGCODE")]
        public string VILLAGENAME
        {
            get { return _vILLAGENAME; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _vILLAGENAME = value;

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
