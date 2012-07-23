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


using BE_XML_DataGrid_POC;


namespace BE_XML_DataGrid_POC.Tests
{
    public class TestService
    {
        #region private members
        ServiceReferenceDB.ServiceClient serviceClient;

        #endregion

        #region constructor

        public TestService()
        {
            try
            {
                serviceClient = new ServiceReferenceDB.ServiceClient();
            }
            catch (Exception e)
            {
                MessageBox.Show("service init failed with : " + e.Message);

            }

        }
        #endregion



        #region Method Test
        public bool TestMethodTest()
        {

            serviceClient.TestCompleted += new EventHandler<ServiceReferenceDB.TestCompletedEventArgs>(serviceClient_TestCompleted);
            serviceClient.TestAsync();

            return true;

        }

        void serviceClient_TestCompleted(object sender, ServiceReferenceDB.TestCompletedEventArgs e)
        {
            if (e.Result != "OK") MessageBox.Show("TestMethodTest   failed");
        }

        #endregion

        #region Method GetTableFromDB
        public bool TestMethodGetTableFromDB()
        {
            serviceClient.GetTableFromDBCompleted += new EventHandler<ServiceReferenceDB.GetTableFromDBCompletedEventArgs>(serviceClient_GetTableFromDBCompleted);
            serviceClient.GetTableFromDBAsync("select first name from Products");
            return true;
        }

        void serviceClient_GetTableFromDBCompleted(object sender, ServiceReferenceDB.GetTableFromDBCompletedEventArgs e)
        {
            if (e.Result.XmlQuerryResult != "OK") MessageBox.Show("GetTableFromDB   failed");
        }
        #endregion

    }
}
