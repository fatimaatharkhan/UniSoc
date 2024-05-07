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
    public partial class RemoveSociety : Form
    {
        private string connectionString = "Data Source=G4CE-1080\\SQLEXPRESS;Initial Catalog=UniSoc;Integrated Security=True;Encrypt=False";
        private AdminMain adminMain;

        public RemoveSociety()
        {
            InitializeComponent();
            LoadSocietiesData();
        }

        public RemoveSociety(AdminMain adminMain)
        {
            this.adminMain = adminMain;
            InitializeComponent();
            LoadSocietiesData();
        }

        public string Login_Username { get; private set; }

        public void RecieveUsername(string Login_Username)
        {
            this.Login_Username = Login_Username;
        }


        private void LoadSocietiesData()
        {
            try
            {
                // Create a SqlConnection using the connection string
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Define your SQL query to retrieve data about societies and count of members
                    string query = @"
                    SELECT s.society_id, s.society_name, s.Capacity,
                           COUNT(m.username) AS MemberCount,
                           h.username AS HeadUsername,
                           CONCAT(u.first_name, ' ', u.last_name) AS HeadName
                    FROM Society s
                    LEFT JOIN Membership m ON s.society_id = m.society_id
                    LEFT JOIN Head h ON s.society_id = h.society_id
                    LEFT JOIN Users u ON h.username = u.username
                    GROUP BY s.society_id, s.society_name, s.Capacity, h.username, u.first_name, u.last_name
                    ORDER BY s.society_id";

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
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur
                MessageBox.Show("Error loading society data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void RemoveSociety_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancel the form closing event to prevent immediate closing

            adminMain.Show(); // Show the AdminMain form
            this.Hide(); // Hide the AddSociety form
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {

            try
            {
                string societyName = SocietyNameTxtbox.Text.Trim();

                // Check if the society name is empty
                if (string.IsNullOrEmpty(societyName))
                {
                    MessageBox.Show("Please enter a society name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the society exists
                bool societyExists = CheckSocietyExists(societyName);

                if (societyExists)
                {
                    // Remove the society
                    RemoveSocietyFtn(societyName);
                    MessageBox.Show("Society removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reload the page
                    LoadSocietiesData();
                }
                else
                {
                    MessageBox.Show("The specified society does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckSocietyExists(string societyName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Society WHERE society_name = @SocietyName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SocietyName", societyName);

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void RemoveSocietyFtn(string societyName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Society WHERE society_name = @SocietyName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SocietyName", societyName);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void SocietyNameTxtbox_Enter(object sender, EventArgs e)
        {
            if (SocietyNameTxtbox.Text == "Enter Society name here!")
            {
                SocietyNameTxtbox.Text = "";
                SocietyNameTxtbox.ForeColor = Color.Black;
            }
        }

        private void SocietyNameTxtbox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SocietyNameTxtbox.Text))
            {
                SocietyNameTxtbox.Text = "Enter Society name here!";
                SocietyNameTxtbox.ForeColor = Color.Gray;
            }
        }

        private void RemoveSocietyForm_Load(object sender, EventArgs e)
        {
            // Set initial text and color for SocietyNameTxtbox
            SocietyNameTxtbox.Text = "Enter Society name here!";
            SocietyNameTxtbox.ForeColor = Color.Gray;
        }
    }
}
