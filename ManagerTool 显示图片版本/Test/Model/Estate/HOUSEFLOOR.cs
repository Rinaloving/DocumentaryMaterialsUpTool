
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
    #region HOUSEFLOOR
    /// <summary>
    ///  (HOUSEFLOOR)
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "HOUSEFLOOR", PrimaryKey = "HOUSEFLOORID")]
    public class HOUSEFLOOR : IEntity
    {

        private string _hOUSEFLOORID = String.Empty;
        private string _gISBLDNUM = String.Empty;
        private string _fLOORNUM = String.Empty;
        private decimal _fACTFLONUM;
        private string _nAMEFLONUM = String.Empty;
        private decimal _fLOBLDAREA;
        private decimal _fLOROOMAREA;
        private decimal _fLOBALAREA;
        private decimal _fLOPUBAREA;
        private decimal _fLOSHAAREA;
        private decimal _fLOHALFWALLAREA;
        private decimal _fLOHEIGHT;
        private decimal _fLOGISAREA;

        public HOUSEFLOOR()
        {
        }




        #region Public Properties


        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "HOUSEFLOORID", TableName = "HOUSEFLOOR")]
        public string HOUSEFLOORID
        {
            get { return _hOUSEFLOORID; }
            set
            {
                if (value != null && value.Trim().Length > 36)
                    value = value.Trim().Substring(0, 36);

                _hOUSEFLOORID = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "GISBLDNUM", TableName = "HOUSEFLOOR")]
        public string GISBLDNUM
        {
            get { return _gISBLDNUM; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _gISBLDNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "FLOORNUM", TableName = "HOUSEFLOOR")]
        public string FLOORNUM
        {
            get { return _fLOORNUM; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _fLOORNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "FACTFLONUM", TableName = "HOUSEFLOOR")]
        public decimal FACTFLONUM
        {
            get { return _fACTFLONUM; }
            set
            {
                _fACTFLONUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "NAMEFLONUM", TableName = "HOUSEFLOOR")]
        public string NAMEFLONUM
        {
            get { return _nAMEFLONUM; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _nAMEFLONUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "FLOBLDAREA", TableName = "HOUSEFLOOR")]
        public decimal FLOBLDAREA
        {
            get { return _fLOBLDAREA; }
            set
            {
                _fLOBLDAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "FLOROOMAREA", TableName = "HOUSEFLOOR")]
        public decimal FLOROOMAREA
        {
            get { return _fLOROOMAREA; }
            set
            {
                _fLOROOMAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "FLOBALAREA", TableName = "HOUSEFLOOR")]
        public decimal FLOBALAREA
        {
            get { return _fLOBALAREA; }
            set
            {
                _fLOBALAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "FLOPUBAREA", TableName = "HOUSEFLOOR")]
        public decimal FLOPUBAREA
        {
            get { return _fLOPUBAREA; }
            set
            {
                _fLOPUBAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "FLOSHAAREA", TableName = "HOUSEFLOOR")]
        public decimal FLOSHAAREA
        {
            get { return _fLOSHAAREA; }
            set
            {
                _fLOSHAAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "FLOHALFWALLAREA", TableName = "HOUSEFLOOR")]
        public decimal FLOHALFWALLAREA
        {
            get { return _fLOHALFWALLAREA; }
            set
            {
                _fLOHALFWALLAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "FLOHEIGHT", TableName = "HOUSEFLOOR")]
        public decimal FLOHEIGHT
        {
            get { return _fLOHEIGHT; }
            set
            {
                _fLOHEIGHT = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "FLOGISAREA", TableName = "HOUSEFLOOR")]
        public decimal FLOGISAREA
        {
            get { return _fLOGISAREA; }
            set
            {
                _fLOGISAREA = value;

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

