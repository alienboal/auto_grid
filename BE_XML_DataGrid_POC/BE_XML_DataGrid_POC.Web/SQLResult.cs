

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
        private Dictionary<string, Type> tableColumns;

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


        [DataMember(Name = "TableColumns")]
        public Dictionary<string, Type> TableColumns
        {
            get
            {
                return tableColumns;
            }
            set
            {
            }
        }

#endregion

        #region constructor

        public SQLResult(string p_xmlQuerryResult, Dictionary<string, Type> p_tableColumns)
        {
            xmlQuerryResult = p_xmlQuerryResult;
            tableColumns = p_tableColumns;

        }

        #endregion
    }
}