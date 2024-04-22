using SE_Project.Properties;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Data.SqlTypes;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SE_Project
{
    public partial class LogIn : Form
    {
        private string connectionString = "Data Source=G4CE-1080\\SQLEXPRESS;Initial Catalog=UniSoc;Encrypt=false;Integrated Security=True";

        public LogIn()
        {
            InitializeComponent();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string un = UsernameTxtbox.Text;
                string pw = PasswordTxtbox.Text;
                string role = ""; // Initialize role variable
                string query = "SELECT username, password, role FROM Users WHERE username = @Username AND password = @Password";

                using (SqlCommand cm = new SqlCommand(query, conn))
                {
                    cm.Parameters.AddWithValue("@Username", un);
                    cm.Parameters.AddWithValue("@Password", pw);

                    using (SqlDataReader reader = cm.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve role from the database
                            role = reader["role"].ToString();
                            MessageBox.Show("Welcome '" + un + "' with role '" + role + "'");

                            // Use switch case to open different forms based on role
                            switch (role.ToLower()) // Using ToLower to ensure the comparison is case-insensitive
                            {
                                case "admin":
                                    AdminMain adminHome = new AdminMain();
                                    adminHome.RecieveUsername(un);
                                    adminHome.Show();
                                    this.Hide();
                                    break;
                                case "student":
                                    StudentMain studentHome = new StudentMain();
                                    studentHome.RecieveUsername(un);
                                    studentHome.Show();
                                    this.Hide();
                                    break;
                                case "head":
                                    HeadMain teacherHome = new HeadMain();
                                    teacherHome.RecieveUsername(un);
                                    teacherHome.Show();
                                    this.Hide();
                                    break;
                                default:
                                    MessageBox.Show("Role not recognized. Access denied.");
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nice try, buddy");
                        }
                    }
                }
            }
        }

        private void BackToMainBtn_Click(object sender, EventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
