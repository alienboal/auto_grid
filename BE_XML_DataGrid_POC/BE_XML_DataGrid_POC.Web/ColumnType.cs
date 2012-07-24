using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Runtime.Serialization;

namespace BE_XML_DataGrid_POC.Web
{

    [DataContract(Name = "ColumnType", Namespace = "BE_XML_DataGrid")]

    public class ColumnType
    {

        #region private methods

        private string _name;
        private string _type;

        #endregion


        #region properties

        [DataMember(Name = "Name")]
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
            }
        }

        [DataMember(Name = "Type")]
        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
            }
        }

        #endregion


        #region constructor
        public ColumnType(string p_name, string p_type)
        {
            _name = p_name;
            _type = p_type;
        }

        #endregion
    }
}