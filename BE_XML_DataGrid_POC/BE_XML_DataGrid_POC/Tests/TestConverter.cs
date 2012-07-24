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
using BE_XML_DataGrid_POC.BusinessLogic;
using System.IO;
using BE_XML_DataGrid_POC.Persistance;

namespace BE_XML_DataGrid_POC.Tests
{
    public class TestConverter
    {
        public TestConverter()
        {

        }

        public bool TestXMLToClasses()
        {
            //get adress of config xml
            FileInfo XMLfileInfo = FileIO.OpenFile();

            //read xml file  
            if (XMLfileInfo != null)
            {
                Stream stream = XMLfileInfo.OpenRead();
                //convert xml file to object
                Config config = Converter.XMLToClasses(stream);
                stream.Close();

                if (config.dbConfig.Query != "") return true;
                else return false;

                //get Querry
                //create Grid

            }
            else
            {
                MessageBox.Show("No file selected");
                return false;
            }
        }
    }
}
