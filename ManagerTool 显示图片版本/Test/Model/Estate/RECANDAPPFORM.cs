using SmartMap.DataClient.Entity;
using SmartMap.DataClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataConvert.Business
{
    #region RECANDAPPFORM
    /// <summary>
    ///  收件申请表
    /// </summary>
    [TableAttribute(Description = "", DatabaseName = "orcl (estate)", TableName = "RECANDAPPFORM", PrimaryKey = "CASENUM")]
    public class RECANDAPPFORM : IEntity
    {

        private string _cASENUM = String.Empty;
        private string _bUSTYPE = String.Empty;
        private string _bUSCODE = String.Empty;
        private string _sUBBUSCODE = String.Empty;
        private string _rECNUM = String.Empty;
        private DateTime _rECDATE;
        private string _rECMAN = String.Empty;
        private string _cOUNTUNIT = String.Empty;
        private string _rIGHTTYPE = String.Empty;
        private string _rEGISTERTYPE = String.Empty;
        private string _rEGISTERCAUSE = String.Empty;
        private string _oBLIGEENAME = String.Empty;
        private string _oBLIGORNAME = String.Empty;
        private string _rEALESTLOCATION = String.Empty;
        private string _oRGREALESTCARDNUM = String.Empty;
        private string _pLEMODE = String.Empty;
        private decimal _eVAAMOUNT;
        private decimal _pLEAMOUNT;
        private string _pLERANGE = String.Empty;
        private DateTime _pLEBEGINDATE;
        private DateTime _pLEENDDATE;
        private string _eASLOCATION = String.Empty;
        private string _eASREALESTUNITNUM = String.Empty;
        private decimal _aPPCARDTYPE;
        private decimal _aPPHOLDMODE;
        private decimal _tRADEPRICE;
        private string _iNFOMODE = String.Empty;
        private string _sURFORMNUM = String.Empty;
        private string _aPPLIDESC = String.Empty;
        private decimal _pLEAMOUNTNUM;
        private decimal _pLEAMOUNTSEQ;
        private decimal _pLEAMOUNTAREA;
        private string _rEGISTERPROOF1 = String.Empty;
        private string _rEGISTERPROOF2 = String.Empty;
        private string _rEGISTERPROOF3 = String.Empty;
        private string _rEGISTERPROOF4 = String.Empty;
        private string _rEGISTERPROOF5 = String.Empty;
        private string _rEGISTERPROOF6 = String.Empty;

        public RECANDAPPFORM()
        {
        }




        #region Public Properties


        /// <summary>
        /// 案件编号
        /// </summary>
        [ColumnAttribute(Description = "", IsPrimaryKey = true, AutoIncrement = false, Nullable = false, FieldType = "nvarchar2", FieldName = "CASENUM", TableName = "RECANDAPPFORM")]
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
        /// 业务类型
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "BUSTYPE", TableName = "RECANDAPPFORM")]
        public string BUSTYPE
        {
            get { return _bUSTYPE; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _bUSTYPE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "BUSCODE", TableName = "RECANDAPPFORM")]
        public string BUSCODE
        {
            get { return _bUSCODE; }
            set
            {
                if (value != null && value.Trim().Length > 200)
                    value = value.Trim().Substring(0, 200);

                _bUSCODE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "SUBBUSCODE", TableName = "RECANDAPPFORM")]
        public string SUBBUSCODE
        {
            get { return _sUBBUSCODE; }
            set
            {
                if (value != null && value.Trim().Length > 200)
                    value = value.Trim().Substring(0, 200);

                _sUBBUSCODE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "RECNUM", TableName = "RECANDAPPFORM")]
        public string RECNUM
        {
            get { return _rECNUM; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _rECNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "RECDATE", TableName = "RECANDAPPFORM")]
        public DateTime RECDATE
        {
            get { return _rECDATE; }
            set
            {
                _rECDATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "RECMAN", TableName = "RECANDAPPFORM")]
        public string RECMAN
        {
            get { return _rECMAN; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _rECMAN = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "COUNTUNIT", TableName = "RECANDAPPFORM")]
        public string COUNTUNIT
        {
            get { return _cOUNTUNIT; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _cOUNTUNIT = value;

            }
        }

        /// <summary>
        /// 权利类型
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "RIGHTTYPE", TableName = "RECANDAPPFORM")]
        public string RIGHTTYPE
        {
            get { return _rIGHTTYPE; }
            set
            {
                if (value != null && value.Trim().Length > 40)
                    value = value.Trim().Substring(0, 40);

                _rIGHTTYPE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REGISTERTYPE", TableName = "RECANDAPPFORM")]
        public string REGISTERTYPE
        {
            get { return _rEGISTERTYPE; }
            set
            {
                if (value != null && value.Trim().Length > 30)
                    value = value.Trim().Substring(0, 30);

                _rEGISTERTYPE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REGISTERCAUSE", TableName = "RECANDAPPFORM")]
        public string REGISTERCAUSE
        {
            get { return _rEGISTERCAUSE; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _rEGISTERCAUSE = value;

            }
        }

        /// <summary>
        /// 权利人姓名
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "OBLIGEENAME", TableName = "RECANDAPPFORM")]
        public string OBLIGEENAME
        {
            get { return _oBLIGEENAME; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _oBLIGEENAME = value;

            }
        }

        /// <summary>
        /// 义务人姓名
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "OBLIGORNAME", TableName = "RECANDAPPFORM")]
        public string OBLIGORNAME
        {
            get { return _oBLIGORNAME; }
            set
            {
                if (value != null && value.Trim().Length > 50)
                    value = value.Trim().Substring(0, 50);

                _oBLIGORNAME = value;

            }
        }

        /// <summary>
        /// 不动产坐落
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REALESTLOCATION", TableName = "RECANDAPPFORM")]
        public string REALESTLOCATION
        {
            get { return _rEALESTLOCATION; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _rEALESTLOCATION = value;

            }
        }

        /// <summary>
        /// 原不动产证书号
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "ORGREALESTCARDNUM", TableName = "RECANDAPPFORM")]
        public string ORGREALESTCARDNUM
        {
            get { return _oRGREALESTCARDNUM; }
            set
            {
                if (value != null && value.Trim().Length > 60)
                    value = value.Trim().Substring(0, 60);

                _oRGREALESTCARDNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PLEMODE", TableName = "RECANDAPPFORM")]
        public string PLEMODE
        {
            get { return _pLEMODE; }
            set
            {
                if (value != null && value.Trim().Length > 20)
                    value = value.Trim().Substring(0, 20);

                _pLEMODE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "EVAAMOUNT", TableName = "RECANDAPPFORM")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "PLEAMOUNT", TableName = "RECANDAPPFORM")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "PLERANGE", TableName = "RECANDAPPFORM")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "PLEBEGINDATE", TableName = "RECANDAPPFORM")]
        public DateTime PLEBEGINDATE
        {
            get { return _pLEBEGINDATE; }
            set
            {
                _pLEBEGINDATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "date", FieldName = "PLEENDDATE", TableName = "RECANDAPPFORM")]
        public DateTime PLEENDDATE
        {
            get { return _pLEENDDATE; }
            set
            {
                _pLEENDDATE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "EASLOCATION", TableName = "RECANDAPPFORM")]
        public string EASLOCATION
        {
            get { return _eASLOCATION; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _eASLOCATION = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "EASREALESTUNITNUM", TableName = "RECANDAPPFORM")]
        public string EASREALESTUNITNUM
        {
            get { return _eASREALESTUNITNUM; }
            set
            {
                if (value != null && value.Trim().Length > 32)
                    value = value.Trim().Substring(0, 32);

                _eASREALESTUNITNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "APPCARDTYPE", TableName = "RECANDAPPFORM")]
        public decimal APPCARDTYPE
        {
            get { return _aPPCARDTYPE; }
            set
            {
                _aPPCARDTYPE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "APPHOLDMODE", TableName = "RECANDAPPFORM")]
        public decimal APPHOLDMODE
        {
            get { return _aPPHOLDMODE; }
            set
            {
                _aPPHOLDMODE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "TRADEPRICE", TableName = "RECANDAPPFORM")]
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
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "INFOMODE", TableName = "RECANDAPPFORM")]
        public string INFOMODE
        {
            get { return _iNFOMODE; }
            set
            {
                if (value != null && value.Trim().Length > 10)
                    value = value.Trim().Substring(0, 10);

                _iNFOMODE = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "SURFORMNUM", TableName = "RECANDAPPFORM")]
        public string SURFORMNUM
        {
            get { return _sURFORMNUM; }
            set
            {
                if (value != null && value.Trim().Length > 32)
                    value = value.Trim().Substring(0, 32);

                _sURFORMNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "APPLIDESC", TableName = "RECANDAPPFORM")]
        public string APPLIDESC
        {
            get { return _aPPLIDESC; }
            set
            {
                if (value != null && value.Trim().Length > 4000)
                    value = value.Trim().Substring(0, 4000);

                _aPPLIDESC = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "PLEAMOUNTNUM", TableName = "RECANDAPPFORM")]
        public decimal PLEAMOUNTNUM
        {
            get { return _pLEAMOUNTNUM; }
            set
            {
                _pLEAMOUNTNUM = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "PLEAMOUNTSEQ", TableName = "RECANDAPPFORM")]
        public decimal PLEAMOUNTSEQ
        {
            get { return _pLEAMOUNTSEQ; }
            set
            {
                _pLEAMOUNTSEQ = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "number", FieldName = "PLEAMOUNTAREA", TableName = "RECANDAPPFORM")]
        public decimal PLEAMOUNTAREA
        {
            get { return _pLEAMOUNTAREA; }
            set
            {
                _pLEAMOUNTAREA = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REGISTERPROOF1", TableName = "RECANDAPPFORM")]
        public string REGISTERPROOF1
        {
            get { return _rEGISTERPROOF1; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _rEGISTERPROOF1 = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REGISTERPROOF2", TableName = "RECANDAPPFORM")]
        public string REGISTERPROOF2
        {
            get { return _rEGISTERPROOF2; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _rEGISTERPROOF2 = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REGISTERPROOF3", TableName = "RECANDAPPFORM")]
        public string REGISTERPROOF3
        {
            get { return _rEGISTERPROOF3; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _rEGISTERPROOF3 = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REGISTERPROOF4", TableName = "RECANDAPPFORM")]
        public string REGISTERPROOF4
        {
            get { return _rEGISTERPROOF4; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _rEGISTERPROOF4 = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REGISTERPROOF5", TableName = "RECANDAPPFORM")]
        public string REGISTERPROOF5
        {
            get { return _rEGISTERPROOF5; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _rEGISTERPROOF5 = value;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ColumnAttribute(Description = "", AutoIncrement = false, Nullable = true, FieldType = "nvarchar2", FieldName = "REGISTERPROOF6", TableName = "RECANDAPPFORM")]
        public string REGISTERPROOF6
        {
            get { return _rEGISTERPROOF6; }
            set
            {
                if (value != null && value.Trim().Length > 100)
                    value = value.Trim().Substring(0, 100);

                _rEGISTERPROOF6 = value;

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
