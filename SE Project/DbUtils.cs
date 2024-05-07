using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Project
{
    public static class DbUtils
    {
        private static string connectionString = "Data Source=G4CE-1080\\SQLEXPRESS;Initial Catalog=UniSoc;Integrated Security=True;Encrypt=False";

        public static DataTable GetDataTable(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Define your SQL query to retrieve data about societies and count of members
                // Create a SqlCommand with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Create a DataTable to store the results
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with the results of the query
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }

                    // Bind the DataTable to the DataGridView
                    return dataTable;
                }

            }

        }

        public static int DataExists(SqlCommand command)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();
                command.Connection = connection;
                var result = command.ExecuteScalar();
                return Convert.ToInt32(result);
            }
        }

        public static void Insert(SqlCommand command)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                command.Connection = connection;
                command.ExecuteNonQuery();

            }
        }
    }
}
