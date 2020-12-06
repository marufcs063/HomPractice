using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ADONetExample
{
    class Program
    {

        private const string CONNECTION_STRING = "Server=DESKTOP-VDK0HA6\\MARUF;Database=CSharp;User Id = marufcs063; Password=basar0191.;";
        private static SqlConnection _sqlConnection;

        static void Main(string[] args)
        {
            _sqlConnection = new SqlConnection(CONNECTION_STRING);


            #region Execution
            
            var insertSql = "insert into Person (Name, Age, Address) values('Habib', 42, 'Barishal, Bangladesh')";
            var updateSql = "update Person set Name = 'Mahfuz', Age = 14, Address = 'Sylhet, Bangladesh' where id = 4";
            var deleteSql = "delete from Person where id = 1";
            Write(insertSql);
            Write(updateSql);
            Write(deleteSql);
            
            var result = Read("Person");
            foreach (var row in result)
            {
                foreach (var col in row)
                {
                    Console.WriteLine($"{col.Key} -> {col.Value}");
                }
                Console.WriteLine(new string('=', 7));
            }

            /*
            var dataSet = ReadTable("Person");
            for (var i = 0; i < dataSet.Tables.Count; i++)
            {
                for (var j = 0; j < dataSet.Tables[i].Rows.Count; j++)
                {
                    for (var k = 0; k < dataSet.Tables[i].Columns.Count; k++)
                    {
                        Console.WriteLine($"{dataSet.Tables[i].Rows[j][k]} -> {dataSet.Tables[i].Rows[j][k]}");
                    }
                }
            }
            */
            #endregion

            _sqlConnection.Dispose();
        }

        public static void Write(string sql)
        {
            try
            {
                if (_sqlConnection.State != System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Open();
                }

                using var command = new SqlCommand(sql, _sqlConnection);
                command.ExecuteNonQuery();
                return;
            }
            catch (SqlException se)
            {
                Console.WriteLine("There was a database error: " + se.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was an unknown error: " + ex.Message);
            }
            finally
            {
                if (_sqlConnection?.State != ConnectionState.Closed)
                    _sqlConnection?.Close();
            }
        }

        public static IList<IDictionary<string, object>> Read(string tableName)
        {
            var result = new List<IDictionary<string, object>>();
            var query = "Select * from " + tableName;

            try
            {
                if (_sqlConnection.State != System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Open();
                }

                using var command = new SqlCommand(query, _sqlConnection);
                using var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var row = new Dictionary<string, object>();
                    for (var i = 0; i < reader.FieldCount; i++)
                    {
                        row.Add(reader.GetName(i), reader.GetValue(i));
                    }
                    result.Add(row);
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine("There was a database error: " + se.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was an unknown error: " + ex.Message);
            }
            finally
            {
                _sqlConnection?.Close();
            }

            return result;
        }

        public static DataSet ReadTable(string tableName)
        {
            var dataSet = new DataSet();

            var query = "Select * from " + tableName;

            try
            {
                if (_sqlConnection.State != System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Open();
                }

                var dataTable = new DataTable("Person");
                dataTable.Columns.Add(new DataColumn("Name"));
                dataTable.Columns.Add(new DataColumn("Age"));
                dataTable.Columns.Add(new DataColumn("Address"));

                dataSet.Tables.Add(dataTable);

                var adapter = new SqlDataAdapter(query, _sqlConnection);
                adapter.Fill(dataSet);

                /*
                 *  var dataRow = dataTable.NewRow();
                    dataRow["Name"] = "jalaluddin";
                    dataTable.Rows.Add(dataRow);
                    adapter.Update(dataSet);
                 */

            }
            catch (SqlException se)
            {
                Console.WriteLine("There was a database error: " + se.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was an unknown error: " + ex.Message);
            }
            finally
            {
                _sqlConnection?.Close();
            }

            return dataSet;
        }
    }
}
