﻿using Microsoft.Data.SqlClient;
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
    public partial class ChangeHead : Form
    {
        private string connectionString = "Data Source=G4CE-1080\\SQLEXPRESS;Initial Catalog=UniSoc;Integrated Security=True;Encrypt=False";
        private AdminMain adminMain;
        public ChangeHead()
        {
            InitializeComponent();
        }

        public ChangeHead(AdminMain adminMain)
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


                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = DbUtils.GetDataTable(query);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur
                MessageBox.Show("Error loading society data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeHeadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string societyName = SocietyNameTxtbox.Text.Trim();
                string newHeadUsername = unTxtbox.Text.Trim();

                // Check if the society name or new head username is empty
                if (string.IsNullOrEmpty(societyName) || string.IsNullOrEmpty(newHeadUsername))
                {
                    MessageBox.Show("Please enter a society name and a new head username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the society exists
                bool societyExists = CheckSocietyExists(societyName);

                if (societyExists)
                {
                    // Check if the new head username is valid
                    bool isValidUsername = CheckValidUsername(newHeadUsername);

                    if (!isValidUsername)
                    {
                        MessageBox.Show("Please enter a valid username for the new head.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Update the head of the society
                    UpdateHead(societyName, newHeadUsername);
                    MessageBox.Show("Head changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private bool CheckValidUsername(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE username = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
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

        private string GetCurrentHead(string societyName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT username FROM Head WHERE society_id = (SELECT society_id FROM Society WHERE society_name = @SocietyName)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SocietyName", societyName);

                    object result = command.ExecuteScalar();
                    return result == DBNull.Value ? null : result.ToString();
                }
            }
        }
        private void UpdateHead(string societyName, string newHeadUsername)
        {
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();

            //    string query = @"
            //UPDATE Head
            //SET username = @NewHeadUsername
            //WHERE society_id = (SELECT society_id FROM Society WHERE society_name = @SocietyName)";

            //    using (SqlCommand command = new SqlCommand(query, connection))
            //    {
            //        command.Parameters.AddWithValue("@NewHeadUsername", newHeadUsername);
            //        command.Parameters.AddWithValue("@SocietyName", societyName);
            //        command.ExecuteNonQuery();
            //    }
            //}

            var query = "SELECT COUNT(*) FROM Task WHERE student_username = '@NewHeadUsername';";
            var cm1 = new SqlCommand(query);

            int x = DbUtils.DataExists(cm1);
            if (x == 0) {
                query = @" UPDATE Head SET username = @NewHeadUsername WHERE society_id = (SELECT society_id FROM Society WHERE society_name = @SocietyName)";
                var cm2 = new SqlCommand(query);
                cm2.Parameters.AddWithValue("@NewHeadUsername", newHeadUsername);
                cm2.Parameters.AddWithValue("@SocietyName", societyName);
                DbUtils.Insert(cm2);
            }
            else
            {
                MessageBox.Show("The Student you want to make the head has tasks assigned to them. Please delete those tasks before proceeding.");
            }
        }

        private void ChangeHead_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancel the form closing event to prevent immediate closing

            adminMain.Show(); // Show the AdminMain form
            this.Hide(); // Hide the AddSociety form
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
