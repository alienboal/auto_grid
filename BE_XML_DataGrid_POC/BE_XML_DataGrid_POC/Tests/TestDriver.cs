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
    public class TestDriver
    {

        #region private members

        TestService testService;
        TestFileIO testFileIO;
        TestConverter testConverter;
        TestTypeCreator testTypeCreator;
        TestFactory testFactory;
        Dictionary<string, bool> testResults;

        #endregion

        #region constructor

        public TestDriver()
        {

            #region Init test modules

            testService = new TestService();
            testFileIO = new TestFileIO();
            testConverter = new TestConverter();
            testTypeCreator = new TestTypeCreator();
            testFactory = new TestFactory();
            #endregion


            testResults = new Dictionary<string, bool>();
        }
        #endregion

        #region   methods
    
        /// <summary>
        /// Calls all test mthods and shows result
        /// </summary>
        public void TestAll()
        {
            

            testResults.Add("Service -m- Test ", testService.TestMethodTest());
            testResults.Add("Service -m- GetTableFromDB ", testService.TestMethodGetTableFromDB());
            // testResults.Add("FileIO -m- FileOpen", testFileIO.TestOpenFile());                       //good to be commented out when not needed because of thread collision
            // testResults.Add("Converter-m- XMLtoClasses", testConverter.TestXMLToClasses());
            testResults.Add("TypeCreator -m- constructor", testTypeCreator.TestClass());
            testResults.Add("Factory -m- CreateObjectOfRType", testFactory.TestCreateObjectOfRType());
            testResults.Add("Factory -m- CreateListOfRType", testFactory.TestCreateListOfRType());



            ShowResults();
           
        }

        /// <summary>
        /// Shows the test result in a message Box
        /// </summary>
        private void ShowResults()
        {
            string result = "";
            foreach (var item in testResults)
            {
                result = result + item.Key + ":" + item.Value.ToString() + "\r\n";
            }
            MessageBox.Show(result);
        }

        #endregion

    }
}
