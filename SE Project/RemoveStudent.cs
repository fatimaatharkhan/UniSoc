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
    public partial class RemoveStudent : Form
    {
        private string connectionString = "Data Source=G4CE-1080\\SQLEXPRESS;Initial Catalog=UniSoc;Encrypt=false;Integrated Security=True";
        private AdminMain adminMain;

        public RemoveStudent()
        {
            InitializeComponent(); 
            LoadSocietiesData();
        }

        public RemoveStudent(AdminMain adminMain)
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
                        DataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur
                MessageBox.Show("Error loading society data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void RemoveStudentBtn_Click(object sender, EventArgs e)
        {
            string societyName = SocietyNameTxtbox.Text;
            string username = unTxtbox.Text;

            // Check if the society name and username are provided
            if (!string.IsNullOrEmpty(societyName) && !string.IsNullOrEmpty(username))
            {
                // Check if the society exists
                bool societyExists = CheckSocietyExists(societyName);
                if (societyExists)
                {
                    // Check if the user exists
                    bool userExists = CheckUserExists(username);
                    if (userExists)
                    {
                        // Check if the user is a member of the specified society with status 1
                        int isMember = CheckMembershipStatus(username, societyName);
                        if (isMember == 1)
                        {
                            // Remove the entry from the membership table
                            RemoveMembership(username, societyName);
                            MessageBox.Show("Membership removed successfully.");
                            PopulateDataGridView(societyName);
                        }
                        else if (isMember == 0)
                        {
                            // Remove the entry from the membership table
                            RemoveMembership(username, societyName);
                            MessageBox.Show("Membership removed successfully. Even though Status was 0");
                            PopulateDataGridView(societyName);
                        }
                        else
                        {
                            MessageBox.Show("The user is not a member of the specified society.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The provided username does not exist.");
                    }
                }
                else
                {
                    MessageBox.Show("The provided society name does not exist.");
                }
            }
            else
            {
                MessageBox.Show("Please provide both the society name and the username.");
            }
        }

        // Method to check if the society exists
        private bool CheckSocietyExists(string societyName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Society WHERE society_name = @SocietyName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SocietyName", societyName);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        // Method to check if the user exists
        private bool CheckUserExists(string username)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE username = @Username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        // Method to check the membership status of the user in the specified society
        private int CheckMembershipStatus(string username, string societyName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT status FROM Membership " +
                               "WHERE username = @Username AND society_id = (SELECT society_id FROM Society WHERE society_name = @SocietyName)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@SocietyName", societyName);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return -1; // Indicates no record found
                    }
                }
            }
        }

        // Method to remove the entry from the membership table
        private void RemoveMembership(string username, string societyName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Membership " +
                               "WHERE username = @Username AND society_id = (SELECT society_id FROM Society WHERE society_name = @SocietyName)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@SocietyName", societyName);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void RemoveStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancel the form closing event to prevent immediate closing

            adminMain.Show(); // Show the AdminMain form
            this.Hide(); // Hide the AddSociety form
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string societyName = SocietyNameTxtbox.Text;

            // Check if the society name is provided
            if (!string.IsNullOrEmpty(societyName))
            {
                // Check if the society exists
                bool societyExists = CheckSocietyExists(societyName);
                if (societyExists)
                {
                    // Populate DataGridView1 with members and head of the specified society
                    PopulateDataGridView(societyName);
                }
                else
                {
                    MessageBox.Show("The provided society name does not exist.");
                }
            }
            else
            {
                MessageBox.Show("Please provide the society name.");
            }
        }

        // Method to populate DataGridView1 with members and head of the specified society
        private void PopulateDataGridView(string societyName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT M.status, U.username, U.first_name, U.last_name, U.role " +
               "FROM Users U " +
               "INNER JOIN Membership M ON U.username = M.username " +
               "INNER JOIN Society S ON M.society_id = S.society_id " +
               "WHERE S.society_name = @SocietyName " +
               "UNION " +
               "SELECT '1' AS status, H.username, U.first_name, U.last_name, 'Head' AS role " +
               "FROM Head H " +
               "INNER JOIN Users U ON H.username = U.username " +
               "INNER JOIN Society S ON H.society_id = S.society_id " +
               "WHERE S.society_name = @SocietyName";



                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SocietyName", societyName);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    DataGridView1.DataSource = dataTable;
                    DataGridView1.Columns[0].ReadOnly = true;
                }
            }
        }
    }
}

