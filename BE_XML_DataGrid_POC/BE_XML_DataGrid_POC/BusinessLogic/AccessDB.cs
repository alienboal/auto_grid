using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

using BE_XML_DataGrid_POC.ServiceReferenceDB;
 

namespace BE_XML_DataGrid_POC.BusinessLogic
{
    public class AccessDB
    {
         ServiceClient serviceClient;
        public AccessDB()
        {
            serviceClient = new ServiceReferenceDB.ServiceClient();

        }


        public SQLResult GetEntries(string sqlCommand)
        {

            return new SQLResult();
        }
    }
}
