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

using BE_XML_DataGrid_POC.ServiceReferenceDB;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Linq;
using BE_XML_DataGrid_POC.Persistance;
using System.ComponentModel;
using System.Globalization;
using Microsoft.CSharp.RuntimeBinder;

namespace BE_XML_DataGrid_POC.BusinessLogic.GridView
{
    public class GridCreator
    {
        Dictionary<string, Type> columnTypes;
        SQLResult sqlResult;
        object entries;
        Factory factory;
        DataGrid dgDataGrid;
       
        public GridCreator(SQLResult p_sqlResult, DataGrid dgDataGrid1)
        {
            dgDataGrid = dgDataGrid1;
            sqlResult = p_sqlResult;
            ReadTypes();
            CreateNewType();
            ReadXML();
            ////why not work
            dynamic dEntries;
            dEntries = entries;
            dgDataGrid.ItemsSource = dEntries;
        }

        private void ReadTypes()
        {
            columnTypes = new Dictionary<string, Type>();

            foreach (ColumnType item in sqlResult.Columns)
            {
                columnTypes.Add(item.Name, Type.GetType(item.Type));
            }
        }



        private void CreateNewType()
        {
            factory = Factory.GetInstance(sqlResult.Columns);
        }

        private void ReadXML()
        {
            StringReader sr = new StringReader(sqlResult.XmlQuerryResult);

            XElement xmlElem = XElement.Load(sr);
            var elList = from c in xmlElem.Elements("Result")
                         select c;

            entries = factory.CreateListOfRType();
            foreach (XElement el in elList)
            {


                object line = factory.CreateObjectOfRType();

                foreach (ColumnType column in sqlResult.Columns)
                {
                    object castedObject;
                    castedObject = CastObject(el.Attribute(column.Name).Value, columnTypes[column.Name]);
                    factory.SetProperty(line, column.Name, castedObject);

                }
                factory.AddToList(entries, line);

            }

            //    PutEntries();
        }


        /// <summary>
        /// Changes the type of the object it receives to the type specified
        /// </summary>
        /// <param name="valueToConvertFrom">value to be converted</param>
        /// <param name="type">the new type</param>
        /// <returns></returns>
        private object CastObject(string valueToConvertFrom, Type type)
        {
            if (type.Name == "String")
                return valueToConvertFrom;
            var convertible = valueToConvertFrom as IConvertible;
            return convertible.ToType(type, CultureInfo.InvariantCulture);


        }


        private object CastObject(object valueToConvertFrom, Type type)
        {
          
            var convertible = valueToConvertFrom as IConvertible;
            return convertible.ToType(type, CultureInfo.InvariantCulture);


        }
    }
}
