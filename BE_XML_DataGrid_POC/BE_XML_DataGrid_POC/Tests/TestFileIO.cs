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
using System.IO;
using BE_XML_DataGrid_POC.BusinessLogic;

namespace BE_XML_DataGrid_POC.Tests
{
    public class TestFileIO
    {
        public TestFileIO()
        {

        }

        public bool  TestOpenFile()
        {
            //get adress of config xml
            FileInfo file = FileIO.OpenFile();

            if (file != null)
            {
                
                return true;

 

            }
            else
            {
                 
                MessageBox.Show("Open File failed - or file not selected");
                return false;
            }
        }
    }
}
