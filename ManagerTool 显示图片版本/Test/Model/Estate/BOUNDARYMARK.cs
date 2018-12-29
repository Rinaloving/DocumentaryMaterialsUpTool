
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
    #region BOUNDARYMARK
    /// <summary>
    ///  (BOUNDARYMARK)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "BOUNDARYMARK", PrimaryKey = "BOUNDARYMARKID")]
    public class BOUNDARYMARK : IEntity
    {

        private string _bOUNDARYMARKID = String.Empty;
        private string _lANDSURVERYID = String.Empty;
        private string _bMPOINTNUM = String.Empty;
        private string _bMPOINTTYPE = String.Empty;
        private decimal _bMDISTANCE;
        private string _bMLINETYPE = String.Empty;
        private string _bMLINEPLACE = String.Empty;
        private string _bMDESC = String.Empty;

        public BOUNDARYMARK()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "BOUNDARYMARKID", TableName = "BOUNDARYMARK")]
        public string BOUNDARYMARKID
        {
            get { return _bOUNDARYMARKID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _bOUNDARYMARKID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "LANDSURVERYID", TableName = "BOUNDARYMARK")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "BMPOINTNUM", TableName = "BOUNDARYMARK")]
        public string BMPOINTNUM
        {
            get { return _bMPOINTNUM; }
            set
            {
                if (value != null && value.Trim().Length > 10)
                    value = value.Trim().Substring(0, 10);

                _bMPOINTNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "BMPOINTTYPE", TableName = "BOUNDARYMARK")]
        public string BMPOINTTYPE
        {
            get { return _bMPOINTTYPE; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _bMPOINTTYPE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "BMDISTANCE", TableName = "BOUNDARYMARK")]
        public decimal BMDISTANCE
        {
            get { return _bMDISTANCE; }
            set
            {
                _bMDISTANCE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "BMLINETYPE", TableName = "BOUNDARYMARK")]
        public string BMLINETYPE
        {
            get { return _bMLINETYPE; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _bMLINETYPE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "BMLINEPLACE", TableName = "BOUNDARYMARK")]
        public string BMLINEPLACE
        {
            get { return _bMLINEPLACE; }
            set
            {
                if (value != null && value.Trim().Length > 10)
                    value = value.Trim().Substring(0, 10);

                _bMLINEPLACE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "BMDESC", TableName = "BOUNDARYMARK")]
        public string BMDESC
        {
            get { return _bMDESC; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _bMDESC = value;

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

