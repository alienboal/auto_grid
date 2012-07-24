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


using System.Xml.Serialization;
using BE_XML_DataGrid_POC.Persistance;


namespace BE_XML_DataGrid_POC.BusinessLogic
{
    public class Converter
    {
        public static void ClassesToXML(Stream path, Config table)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Config));
            TextWriter textWriter = new StreamWriter(path);
            serializer.Serialize(textWriter, table);
            textWriter.Close();
        }

        public static Config XMLToClasses(Stream path)
        {

            Config ret = null;

            XmlSerializer deserializer = new XmlSerializer(typeof(Config));
            TextReader textReader = new StreamReader(path);
            ret = (Config)deserializer.Deserialize(textReader);
            textReader.Close();

            return ret;
        }

        public static Config XMLToClasses(string path)
        {

            Config ret = null;

            XmlSerializer deserializer = new XmlSerializer(typeof(Config));
            TextReader textReader = new StreamReader(
                "C:\\Users\\alin.bogdan\\Documents\\Visual Studio 2010\\Projects\\BE\\Proj_GridView\\BE_XML_DataGrid\\BE_XML_DataGrid\\Debug\\" + path);
            ret = (Config)deserializer.Deserialize(textReader);
            textReader.Close();

            return ret;
        }
    }

}
