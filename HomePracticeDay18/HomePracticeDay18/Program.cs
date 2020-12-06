using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace HomePracticeDay18
{
    class Program
    {
        private const string CONNECTION_STRING = "Server=DESKTOP-VDK0HA6\\MARUF;Database=Csharpback;User Id = marufcs063;Password=basar0191.;";
        private static SqlConnection _sqlConnection;


        static void Main(string[] args)
        {
            _sqlConnection = new SqlConnection(CONNECTION_STRING);
            #region executation 
            //  var insertSql = "insert into Person (Name, Age, Address) values('Habib', 42, 'Barishal, Bangladesh')";
            // var updateSql = "update Person set Name = 'Mahfuz', Age = 25, Address = 'Tongi, Gazipur' where id = 5";
            // var deleteSql = "delete from Person where id= 6";
            //write(insertSql);
            // write(updateSql);
            //write(deleteSql);
            //Console.WriteLine("Deleted successfully");

            //var result = Read("Person");
            //foreach (var row in result)
            //{
            //    foreach (var col in row)
            //    {
            //        Console.WriteLine($"{col.Key}-> {col.Value}");
            //    }
            //    Console.WriteLine(new string('=', 15));
            //}

            //var dataSet = ReadTable("Person");
            ReadTable("Person");
            //for(var i=0; i<dataSet.Tables.Count;i++)
            //{
            //    for (var j=0;j<dataSet.Tables[i].Rows.Count;j++)
            //    {
            //        for(var k=0;k< dataSet.Tables[i].Columns.Count;k++)
            //        {
            //            Console.WriteLine($"{dataSet.Tables[i].Rows[j][k]} ->{dataSet.Tables[i].Rows[j][k]}");
            //        }
            //    }
            //}

            #endregion
            _sqlConnection.Dispose();

        }

        public static void write(string sql)
        {
            try
            {
                if (_sqlConnection.State != System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Open();
                }

                using var command = new SqlCommand(sql, _sqlConnection);
                command.ExecuteNonQuery();
               
            }
            catch(SqlException se)
            {
                Console.WriteLine("There was a database error");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Thre was an unknown error");
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
            var query = "Select* from " + tableName;

            try
            {
                if (_sqlConnection.State != System.Data.ConnectionState.Open);
                {
                    _sqlConnection.Open();
                }
                using var command = new SqlCommand(query, _sqlConnection);
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var row = new Dictionary<string, object>();
                    for(var i=0; i<reader.FieldCount;i++)
                    {
                        row.Add(reader.GetName(i), reader.GetValue(i));
                    }
                    result.Add(row);
                }
            }
            catch(SqlException se)
            {
                Console.WriteLine("There is a database error: "+ se.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("There is an unknown error: "+ ex.Message);
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
            var query = "Select* from " + tableName;

            try
            {
                if(_sqlConnection.State!=System.Data.ConnectionState.Open)
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

                var dataRow = dataTable.NewRow();
                dataRow["Name"] = "Jalal Uddin";
                dataRow["Age"] = 39;
                dataRow["Address"] = "Dhaka, Bangladesh";
                dataTable.Rows.Add(dataRow);
                adapter.Update(dataSet);
            }

            catch(SqlException se)
            {
                Console.WriteLine("There is a database error "+ se.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("There is an unknown error" + ex.Message);
            }
            finally
            {
                if (_sqlConnection?.State != ConnectionState.Closed)
                    _sqlConnection.Close();

            }
            return dataSet;
        }
    }
}
