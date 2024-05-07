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
    public partial class ViewMyEvents : Form
    {
        public ViewMyEvents()
        {
            InitializeComponent();
        }

        public string Login_Username { get; private set; }

        public void RecieveUsername(string Login_Username)
        {
            this.Login_Username = Login_Username;
        }

        private void PopulateEventsDataGridView()
        {
            string connectionString = "Data Source=G4CE-1080\\SQLEXPRESS;Initial Catalog=UniSoc;Encrypt=false;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                       SELECT 
                    e.event_name AS EventName,
                    e.event_description AS Description,
                    s.society_name AS Society,
                    e.event_id AS EventID
                FROM 
                    Event e
                INNER JOIN 
                    Society s ON e.society_id = s.society_id
                INNER JOIN 
                    Membership m ON s.society_id = m.society_id
                WHERE 
                    m.username = @Login_Username
                UNION
                SELECT 
                    e.event_name,
                    e.event_description,
                    s.society_name,
                    e.event_id
                FROM 
                    Event e
                JOIN 
                    Event_Student es ON e.event_id = es.event_id
                JOIN 
                    Society s ON e.society_id = s.society_id  -- Ensuring Society table is joined here
                JOIN 
                    Users u ON es.username = u.username
                WHERE 
                    u.username = @Login_Username;
                        ";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Login_Username", Login_Username);

                try
                {
                    conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    dataGridViewEvents.DataSource = dt;
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

        private void ViewMyEvents_Load(object sender, EventArgs e)
        {
            PopulateEventsDataGridView();
        }
    }
}

