
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
    #region HOUSEPRJBLDINFO
    /// <summary>
    ///  (HOUSEPRJBLDINFO)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "HOUSEPRJBLDINFO", PrimaryKey = "HOUSEPRJBLDINFOID")]
    public class HOUSEPRJBLDINFO : IEntity
    {

        private string _hOUSEPRJBLDINFOID = String.Empty;
        private string _hOUSEBUILDINGINFOID = String.Empty;
        private string _pROJECTNAME = String.Empty;
        private string _bLDNUM = String.Empty;
        private decimal _bUILDAREA;
        private string _bUILDSTRUCT = String.Empty;
        private decimal _fLOORCOUNT;
        private string _pLANUSE = String.Empty;
        private DateTime _bLDFINISHDATE;
        private decimal _rOOMCOUNT;

        public HOUSEPRJBLDINFO()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "HOUSEPRJBLDINFOID", TableName = "HOUSEPRJBLDINFO")]
        public string HOUSEPRJBLDINFOID
        {
            get { return _hOUSEPRJBLDINFOID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _hOUSEPRJBLDINFOID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "HOUSEBUILDINGINFOID", TableName = "HOUSEPRJBLDINFO")]
        public string HOUSEBUILDINGINFOID
        {
            get { return _hOUSEBUILDINGINFOID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _hOUSEBUILDINGINFOID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PROJECTNAME", TableName = "HOUSEPRJBLDINFO")]
        public string PROJECTNAME
        {
            get { return _pROJECTNAME; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _pROJECTNAME = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "BLDNUM", TableName = "HOUSEPRJBLDINFO")]
        public string BLDNUM
        {
            get { return _bLDNUM; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _bLDNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "BUILDAREA", TableName = "HOUSEPRJBLDINFO")]
        public decimal BUILDAREA
        {
            get { return _bUILDAREA; }
            set
            {
                _bUILDAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "BUILDSTRUCT", TableName = "HOUSEPRJBLDINFO")]
        public string BUILDSTRUCT
        {
            get { return _bUILDSTRUCT; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _bUILDSTRUCT = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "FLOORCOUNT", TableName = "HOUSEPRJBLDINFO")]
        public decimal FLOORCOUNT
        {
            get { return _fLOORCOUNT; }
            set
            {
                _fLOORCOUNT = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PLANUSE", TableName = "HOUSEPRJBLDINFO")]
        public string PLANUSE
        {
            get { return _pLANUSE; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _pLANUSE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "BLDFINISHDATE", TableName = "HOUSEPRJBLDINFO")]
        public DateTime BLDFINISHDATE
        {
            get { return _bLDFINISHDATE; }
            set
            {
                _bLDFINISHDATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "ROOMCOUNT", TableName = "HOUSEPRJBLDINFO")]
        public decimal ROOMCOUNT
        {
            get { return _rOOMCOUNT; }
            set
            {
                _rOOMCOUNT = value;

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

