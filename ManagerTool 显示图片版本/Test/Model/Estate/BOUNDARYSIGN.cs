
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
    #region BOUNDARYSIGN
    /// <summary>
    ///  (BOUNDARYSIGN)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "BOUNDARYSIGN", PrimaryKey = "BOUNDARYSIGNID")]
    public class BOUNDARYSIGN : IEntity
    {

        private string _bOUNDARYSIGNID = String.Empty;
        private string _lANDSURVERYID = String.Empty;
        private string _bEGINPOINTNUM = String.Empty;
        private string _mIDPOINTNUM = String.Empty;
        private string _eNDPOINTNUM = String.Empty;
        private string _nEARSTATUS = String.Empty;
        private string _nEARMANSIGN = String.Empty;
        private string _tHISMANSIGN = String.Empty;
        private DateTime _sIGNDATE;

        public BOUNDARYSIGN()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "BOUNDARYSIGNID", TableName = "BOUNDARYSIGN")]
        public string BOUNDARYSIGNID
        {
            get { return _bOUNDARYSIGNID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _bOUNDARYSIGNID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "LANDSURVERYID", TableName = "BOUNDARYSIGN")]
        public string LANDSURVERYID
        {
            get { return _lANDSURVERYID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _lANDSURVERYID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "BEGINPOINTNUM", TableName = "BOUNDARYSIGN")]
        public string BEGINPOINTNUM
        {
            get { return _bEGINPOINTNUM; }
            set
            {
                if (value != null && value.Trim().Length > 10)
                    value = value.Trim().Substring(0, 10);

                _bEGINPOINTNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "MIDPOINTNUM", TableName = "BOUNDARYSIGN")]
        public string MIDPOINTNUM
        {
            get { return _mIDPOINTNUM; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _mIDPOINTNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "ENDPOINTNUM", TableName = "BOUNDARYSIGN")]
        public string ENDPOINTNUM
        {
            get { return _eNDPOINTNUM; }
            set
            {
                if (value != null && value.Trim().Length > 10)
                    value = value.Trim().Substring(0, 10);

                _eNDPOINTNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "NEARSTATUS", TableName = "BOUNDARYSIGN")]
        public string NEARSTATUS
        {
            get { return _nEARSTATUS; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _nEARSTATUS = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "NEARMANSIGN", TableName = "BOUNDARYSIGN")]
        public string NEARMANSIGN
        {
            get { return _nEARMANSIGN; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _nEARMANSIGN = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "THISMANSIGN", TableName = "BOUNDARYSIGN")]
        public string THISMANSIGN
        {
            get { return _tHISMANSIGN; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _tHISMANSIGN = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "SIGNDATE", TableName = "BOUNDARYSIGN")]
        public DateTime SIGNDATE
        {
            get { return _sIGNDATE; }
            set
            {
                _sIGNDATE = value;

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

