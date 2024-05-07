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
    public partial class ViewMySociety : Form
    {
        public ViewMySociety()
        {
            InitializeComponent();
        }

        public string Login_Username { get; private set; }

        public void RecieveUsername(string Login_Username)
        {
            this.Login_Username = Login_Username;
        }

        private void PopulateDataGridView()
        {
            string connectionString = "Data Source=G4CE-1080\\SQLEXPRESS;Initial Catalog=UniSoc;Encrypt=false;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                            SELECT 
                                s.society_name,
                                s.Capacity,
                                h.username AS Head_Username,
                                m.status
                            FROM 
                                Society s
                            JOIN 
                                Membership m ON s.society_id = m.society_id
                            JOIN 
                                Users u ON m.username = u.username
                            JOIN
                                Head h ON s.society_id = h.society_id
                            WHERE 
                                u.username = @Login_Username;
                            ";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Login_Username", this.Login_Username);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    dataGridView1.DataSource = null; // Clear existing data binding
                    dataGridView1.Columns.Clear();   // Clear existing columns

                    DataGridViewButtonColumn leaveButtonColumn = new DataGridViewButtonColumn();
                    leaveButtonColumn.Name = "LeaveSociety";
                    leaveButtonColumn.HeaderText = "Leave Society";
                    leaveButtonColumn.Text = "Leave Society";
                    leaveButtonColumn.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(leaveButtonColumn);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["LeaveSociety"].Index)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to leave this society?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string societyName = dataGridView1.Rows[e.RowIndex].Cells["society_name"].Value.ToString();
                    RemoveUserFromSociety(societyName);
                }
            }
        }

        private void RemoveUserFromSociety(string societyName)
        {
            string connectionString = "Data Source=G4CE-1080\\SQLEXPRESS;Initial Catalog=UniSoc;Encrypt=false;Integrated Security=True"; // Update with your actual connection string
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Membership WHERE username = @Login_Username AND society_id = (SELECT society_id FROM Society WHERE society_name = @SocietyName)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Login_Username", this.Login_Username);
                    cmd.Parameters.AddWithValue("@SocietyName", societyName);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("You have been successfully removed from the society.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PopulateDataGridView(); // Refresh the DataGridView after user leaves the society
                    }
                    else
                    {
                        MessageBox.Show("Failed to leave the society.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }



        private void ViewMySociety_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        
    }
}

