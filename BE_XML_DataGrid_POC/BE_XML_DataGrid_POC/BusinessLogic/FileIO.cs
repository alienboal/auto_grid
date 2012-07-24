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

namespace BE_XML_DataGrid_POC.BusinessLogic
{

    public class FileIO
    {
        /// <summary>
        /// !!must use multithreding for background work
        /// </summary>
        /// <returns></returns>
        public static FileInfo OpenFile()
        {
            FileInfo ret = null;

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            open.FilterIndex = 1;
           
            open.Multiselect = false;

            bool? openClicked = open.ShowDialog();
            if (openClicked == true)
            {

                ret = open.File;
               
            }

            return ret;
        }
        /// <summary>
        /// !DO NOT FORGET TO CLOSE THE STREAM
        /// </summary>
        /// <returns></returns>
        public static Stream SaveFile()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            save.FilterIndex = 1;

            bool? saveClicked = save.ShowDialog();

            if (saveClicked == true)
            {
                System.IO.Stream stream = save.OpenFile();
                return stream;

            }
            return null;
        }


    }
}
