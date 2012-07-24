

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace BE_XML_DataGrid_POC.Web
{

    [DataContract(Name = "SQLResult", Namespace = "BE_XML_DataGrid")]

    public class SQLResult
    {
        #region private members

        private string xmlQuerryResult; 
        private List<ColumnType> columns;
        #endregion

        #region properties

        [DataMember(Name = "XmlQuerryResult")]
        public string XmlQuerryResult
        {
            get
            {
                return xmlQuerryResult;
            }
            set
            {
            }
        }
         

        [DataMember(Name = "Columns")]
        public List<ColumnType> Columns
        {
            get
            {
                return columns;
            }
            set
            {
            }
        }

        #endregion

        #region constructor

         
        public SQLResult(string p_xmlQuerryResult, List<ColumnType> p_columns )
        {
            xmlQuerryResult = p_xmlQuerryResult;
            columns = p_columns; 

        }

        #endregion
    }
}