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
using BE_XML_DataGrid_POC.ServiceReferenceDB;
using BE_XML_DataGrid_POC.Persistance;

namespace BE_XML_DataGrid_POC.Tests
{
    public class TestTypeCreator
    {

        #region private members

        List<ColumnType> listOfProperties;

        #endregion

        #region constructor

        public TestTypeCreator()
        {

            listOfProperties = new List<ColumnType>();

            ColumnType ct = new ColumnType();
            ct.Name = "name";
            ct.Type = typeof(string).AssemblyQualifiedName;

            listOfProperties.Add(ct);
        }

        #endregion
         
        #region test methods

        /// <summary>
        /// Tests the entire class TypeCreator
        /// </summary>
        /// <returns>Result of test</returns>
        public bool TestClass()
        {
            TypeCreator typeCreator = new TypeCreator(listOfProperties);


            if (typeCreator.NewClassType.GetProperty("name").PropertyType.AssemblyQualifiedName == typeof(String).AssemblyQualifiedName)
                return true;
            return false;
        }

        #endregion
         
    }
}
