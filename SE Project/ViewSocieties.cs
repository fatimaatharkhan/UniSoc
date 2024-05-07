using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Project
{
    public partial class ViewSocieties : Form
    {
        public ViewSocieties()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=G4CE-1080\\SQLEXPRESS;Initial Catalog=UniSoc;Integrated Security=True;Encrypt=False";
        public string Login_Username { get; private set; }

        public void RecieveUsername(string Login_Username)
        {
            this.Login_Username = Login_Username;
        }

        private void DisplaySocieties()
        {
            // SQL query to select every society and its head's name
            string query = "SELECT s.society_id, s.society_name, s.Capacity, u.first_name + ' ' + u.last_name AS HeadName " +
                           "FROM Society s " +
                           "INNER JOIN Head h ON s.society_id = h.society_id " +
                           "INNER JOIN Users u ON h.username = u.username";

            try
            {
                // Create a SqlConnection using the connection string
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Create a SqlDataAdapter with the query and connection
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    // Create a new DataTable to hold the results
                    DataTable dt = new DataTable();

                    // Fill the DataTable with the results from the query
                    adapter.Fill(dt);

                    // Set the DataGridView's DataSource to the DataTable
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during database operations
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void ViewSocieties_Load(object sender, EventArgs e)
        {
            DisplaySocieties();
        }
    }
}
