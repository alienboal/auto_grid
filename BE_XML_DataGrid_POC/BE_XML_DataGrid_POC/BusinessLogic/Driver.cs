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
using System.IO;
using BE_XML_DataGrid_POC.Persistance;

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
            errorFlag = false;
        }
        #endregion

        #region private members

        private bool errorFlag;
        private Config config;
        
        #endregion

        
        #region methods

        #region File IO
        /// <summary>
        /// Opens a 
        /// </summary>
        public void ReadConfigurations()
        {
            //get adress of config xml
            FileInfo XMLfileInfo = FileIO.OpenFile();

            //read xml file  
            if (XMLfileInfo != null)
            {
                Stream stream = XMLfileInfo.OpenRead();
                //convert xml file to object
                config = Converter.XMLToClasses(stream);

                stream.Close();

              

                //get Querry
                //create Grid

            }
            else
            {
                errorFlag = true;
                MessageBox.Show("You haven't selected anything");
            }
            
        }
        #endregion







        #region tests



        public void RunTests()
        {

            TestDriver testDriver = new TestDriver();

            testDriver.TestAll();
        }
        #endregion
        #endregion
    }
}
