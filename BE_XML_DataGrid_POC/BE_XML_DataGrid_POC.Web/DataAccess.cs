using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Text;
using System.IO;
using System.Data.SqlClient;



namespace BE_XML_DataGrid_POC.Web
{
    public class DataAccess
    {
        //This is your database connection:
        static string connectionString = "Initial Catalog=northwind;Data Source=(local);Integrated Security=SSPI;";
        //connecting to DB
        static SqlConnection cn = new SqlConnection(connectionString);


        // This is your table to hold the result set:
        static DataTable dataTable;


        /// <summary>
        /// Gets the result in xml format from db
        /// </summary>
        /// <param name="sCommand">sql statement to be exceuted
        /// </param>
        /// <returns>Result object(entries in xml format + column names and types)</returns>
        public static SQLResult getResult(string sCommand)
        {
            // sCommand = "SELECT TOP 10 Lastname FROM Employees ORDER BY EmployeeID";
            SqlDataAdapter da = new SqlDataAdapter(sCommand, cn);

            try
            {
                cn.Open();
                dataTable = new DataTable();
                // Fill the data table with select statement's query results:
                int recordsAffected = da.Fill(dataTable);

                if (recordsAffected > 0)
                {
                    string querryResultsXML;
                    //     Dictionary<string, Type> listColumns = new Dictionary<string, Type>();
                    //List<string> listColumns = new List<string>();
                    //List<string> listTypes = new List<string>();

                    List<ColumnType> listColumns = new List<ColumnType>();

                    querryResultsXML = ConvertDataTableToXML(dataTable);

                    // listColumns = GetColumnsAndTypes(dataTable);
                    //listColumns = GetColumnNames(dataTable);
                    //listTypes = GetColumnTypes(dataTable);
                    listColumns = GetColumns(dataTable);


                    SQLResult ret = new SQLResult(querryResultsXML, listColumns );
                    return ret;

                }
            }
            catch (SqlException e)
            {
                string msg = "";
                for (int i = 0; i < e.Errors.Count; i++)
                {
                    msg += "Error #" + i + " Message: " + e.Errors[i].Message + "\n";
                }
                System.Console.WriteLine(msg);
                return null;
            }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }

            }
            return null;
        }


        /// <summary>
        /// Extract the column names and types from a datatable
        /// </summary>
        /// <param name="dataTable">DataTable object</param>
        /// <returns>Dictionary object with the name and type of objects</returns>
        
        private static List<ColumnType> GetColumns(DataTable dataTable)
        {
            DataColumnCollection dcc = dataTable.Columns;
            List<ColumnType> ret = new List<ColumnType>();
            foreach (DataColumn dc in dcc)
            {
                ret.Add( new ColumnType(dc.ColumnName,dc.DataType.AssemblyQualifiedName));
            }
            return ret;
        }

        

      

        /// <summary>
        /// Converts DataTable to XML
        /// </summary>
        /// <param name="dtBuildSQL">DataTable object</param>
        /// <returns>columns from the DataTable object in XML file </returns>
        private static string ConvertDataTableToXML(DataTable dtBuildSQL)
        {
            DataSet dsBuildSQL = new DataSet();
            StringBuilder sbSQL;
            StringWriter swSQL;
            string XMLformat;

            sbSQL = new StringBuilder();
            swSQL = new StringWriter(sbSQL);
            dsBuildSQL.Merge(dtBuildSQL, true, MissingSchemaAction.AddWithKey);
            dsBuildSQL.Tables[0].TableName = "Result";
            foreach (DataColumn col in dsBuildSQL.Tables[0].Columns)
            {
                col.ColumnMapping = MappingType.Attribute;
            }

            dsBuildSQL.WriteXml(swSQL, XmlWriteMode.IgnoreSchema);
            XMLformat = sbSQL.ToString();
            return XMLformat;
        }
    }

}