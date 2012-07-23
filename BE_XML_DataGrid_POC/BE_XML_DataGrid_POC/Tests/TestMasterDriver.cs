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
using System.Collections.Generic;

namespace BE_XML_DataGrid_POC.Tests
{
    public class TestMasterDriver
    {

        #region private members

        TestService testService;

        Dictionary<string, bool> testResults;

        #endregion

        #region constructor
        
        public TestMasterDriver()
        {

            #region Init test modules

            testService = new TestService();

            #endregion


            testResults = new Dictionary<string, bool>();
        }
        #endregion

        #region main
        public void TestAll()
        {
            #region test service

            testResults.Add("Service -m- Test ", testService.TestMethodTest());
            testResults.Add("Service -m- GetTableFromDB ", testService.TestMethodGetTableFromDB());


            #endregion
        }

        #endregion

    }
}
