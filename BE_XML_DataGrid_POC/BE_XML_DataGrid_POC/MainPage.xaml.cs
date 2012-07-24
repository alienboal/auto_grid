using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;


using BE_XML_DataGrid_POC.BusinessLogic;
namespace BE_XML_DataGrid_POC
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();


        }

        private void btnLoadFile_Click(object sender, RoutedEventArgs e)
        {


            Driver driver = Driver.GetInstance();




            // run tests
            driver.RunTests();
        }
    }
}
