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
    public partial class ReportGenerate : Form
    {
        public ReportGenerate()
        {
            InitializeComponent();
        }

        public string Login_Username { get; private set; }

        public void SetUsername(string login_Username)
        {
            this.Login_Username = login_Username;
        }

        private void PopulateDataGridView()
        {
            string connectionString = "Data Source=G4CE-1080\\SQLEXPRESS;Initial Catalog=UniSoc;Encrypt=false;Integrated Security=True"; // Update with your actual connection string
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                                    SELECT 
                        s.society_name,
                        e.event_name,
                        e.event_description,
                        h.username AS head_username,
                        t.student_username,
                        t.task_description,
                        t.task_status,
                        r.resource_type,
                        r.start_time,
                        r.stop_time
                    FROM 
                        Head h
                    JOIN 
                        Society s ON h.society_id = s.society_id
                    JOIN 
                        Event e ON s.society_id = e.society_id
                    LEFT JOIN 
                        Task t ON e.event_id = t.event_id AND h.username = t.head_username
                    LEFT JOIN 
                        Reserved_Resources r ON s.society_id = r.society_id
                    WHERE 
                        h.username = @Login_Username;
            ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Login_Username", this.Login_Username); // Ensure you have a way to get this value
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
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

        private void ReportGenerate_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }
    }
}
