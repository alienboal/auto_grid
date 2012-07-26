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
using BE_XML_DataGrid_POC.ServiceReferenceDB;
using System.Collections.Generic;

namespace BE_XML_DataGrid_POC.Tests
{
    public class TestFactory
    {

        #region private members

        Factory factory;

        #endregion


        #region constructor

        public TestFactory()
        {
            List<ColumnType> listOfProperties = new List<ColumnType>();

            ColumnType ct = new ColumnType();
            ct.Name = "name";
            ct.Type = typeof(string).AssemblyQualifiedName;
            listOfProperties.Add(ct);
            factory = Factory.GetInstance(listOfProperties);
        }

        #endregion


        #region test methods

        /// <summary>
        /// Tests the creatObjectOfRType method from Factory class
        /// </summary>
        /// <returns>Result of test</returns>
        public bool TestCreateObjectOfRType()
        {

            object newObj = factory.CreateObjectOfRType();
            //does not create proper object
            if (newObj.GetType().GetProperty("name").PropertyType.AssemblyQualifiedName == typeof(String).AssemblyQualifiedName)
                return true;
            return false;
        }
        /// <summary>
        /// Tests a list of type runtime type(test just if type is correct)
        /// </summary>
        /// <returns>Result of test</returns>
        public bool TestCreateListOfRType()
        {
            object newObj = factory.CreateListOfRType();
            if (newObj.GetType().AssemblyQualifiedName.Contains("TableType") == true)
                return true;
            return false;
        }

        #endregion
    }
}
