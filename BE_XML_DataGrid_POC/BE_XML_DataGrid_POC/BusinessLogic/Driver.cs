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

using BE_XML_DataGrid_POC.Tests;

namespace BE_XML_DataGrid_POC.BusinessLogic
{
    public class Driver
    {

        #region singleton
        private static volatile Driver instance;
        private static object syncRoot = new Object();
   
        public static Driver GetInstance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new Driver();
                    }
                }

            }
            return instance;
        }



        private Driver()
        {

        }
        #endregion


        #region methods

        
        public void  RunTests(){
           
            TestMasterDriver testMasterDriver= new TestMasterDriver();

            testMasterDriver.TestAll();
        }

        #endregion
    }
}
