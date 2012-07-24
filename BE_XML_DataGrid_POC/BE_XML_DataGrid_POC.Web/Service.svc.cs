using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BE_XML_DataGrid_POC.Web
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
    public class Service : IService
    {
         
        string IService.Test()
        {
            return "OK";
        }

        SQLResult IService.GetTableFromDB(string p_sqlQuerry)
        {

           SQLResult resultQuerry =DataAccess.getResult(p_sqlQuerry);
           return resultQuerry;
        }
    }
}
