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

using System.Xml.Serialization;

namespace BE_XML_DataGrid_POC.Persistance
{
    public class Config
    {

        [XmlElement("TableConfig")]
        public TableConfig tableConfig
        { get; set; }

        [XmlElement("DBConfig")]
        public DBConfig dbConfig
        { get; set; }

        public Config()
        {
            tableConfig = new TableConfig();
            dbConfig = new DBConfig();

        }
    }
}