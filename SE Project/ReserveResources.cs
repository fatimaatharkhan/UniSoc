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
    public partial class ReserveResources : Form
    {
        private string connectionString = "Data Source=DESKTOP-DG0T52K\\SQLEXPRESS;Initial Catalog=UniSoc;Encrypt=false;Integrated Security=True";
        public ReserveResources()
        {
            InitializeComponent();
        }
        public string Login_Username { get; private set; }

        public void SetUsername(string login_Username)
        {
            this.Login_Username = login_Username;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private int GetSocietyIdByUsername()
        {
            string username = this.Login_Username;
            int societyId = -1; // Default value if not found
            string connectionString = "Data Source=G4CE-1080\\SQLEXPRESS;Initial Catalog=UniSoc;Encrypt=false;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT society_id FROM Head WHERE username = @username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        societyId = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving society ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return societyId;
        }

        private void ReserveBtn_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value.Date;
            TimeSpan startTime = TimeSpan.Parse(StartMaskedTextBox1.Text);
            TimeSpan endTime = TimeSpan.Parse(EndMaskedTextBox2.Text);
            string resourceType = comboBox1.SelectedItem.ToString();

            string connectionString = "Data Source=G4CE-1080\\SQLEXPRESS;Initial Catalog=UniSoc;Encrypt=false;Integrated Security=True";

            string sqlQuery = @"
            IF EXISTS (
                SELECT 1
                FROM Reserved_Resources
                WHERE resource_date = @SelectedDate
                AND resource_type = @ResourceType
                AND (
                    (@StartTime >= start_time AND @StartTime < stop_time) OR
                    (@EndTime > start_time AND @EndTime <= stop_time) OR
                    (@StartTime <= start_time AND @EndTime >= stop_time)
                )
            )
            SELECT 0 AS IsAvailable
            ELSE
            SELECT 1 AS IsAvailable;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@SelectedDate", selectedDate);
                    command.Parameters.AddWithValue("@ResourceType", resourceType);
                    command.Parameters.AddWithValue("@StartTime", startTime);
                    command.Parameters.AddWithValue("@EndTime", endTime);

                    try
                    {
                        connection.Open();
                        int isAvailable = (int)command.ExecuteScalar();

                        if (isAvailable == 1)
                        {
                            string insertQuery = @"
                            INSERT INTO Reserved_Resources (start_time, stop_time, resource_date, resource_type, head_username, society_id)
                            VALUES (@StartTime, @EndTime, @SelectedDate, @ResourceType, @HeadUsername, @SocietyId)";

                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@StartTime", startTime);
                                insertCommand.Parameters.AddWithValue("@EndTime", endTime);
                                insertCommand.Parameters.AddWithValue("@SelectedDate", selectedDate);
                                insertCommand.Parameters.AddWithValue("@ResourceType", resourceType);
                                insertCommand.Parameters.AddWithValue("@HeadUsername", Login_Username);
                                insertCommand.Parameters.AddWithValue("@SocietyId", GetSocietyIdByUsername());

                                int rowsAffected = insertCommand.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Resource reserved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Failed to reserve resource.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Resource is not available at the selected time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


    }
}
