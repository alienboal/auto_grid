using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BE_XML_DataGrid_POC.Web
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string Test();

        [OperationContract]
        SQLResult GetTableFromDB(string p_sqlQuerry);
    }
}
