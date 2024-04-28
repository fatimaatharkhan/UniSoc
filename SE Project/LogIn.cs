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

                // Password validation flags
                bool validLength = pw.Length > 5 && pw.Length < 50;
                bool hasSpecialChar = false;
                bool hasLowerCase = false;
                bool hasUpperCase = false;
                bool hasNumber = false;
                bool hasSpace = false;

                // Check password for validity
                foreach (char c in pw)
                {
                    if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
                    {
                        hasSpecialChar = true;
                    }
                    if (char.IsLower(c))
                    {
                        hasLowerCase = true;
                    }
                    if (char.IsUpper(c))
                    {
                        hasUpperCase = true;
                    }
                    if (char.IsNumber(c))
                    {
                        hasNumber = true;
                    }
                    if (char.IsWhiteSpace(c))
                    {
                        hasSpace = true;
                    }
                }

                // Error message
                string errorMessage = "Password must:\n";
                if (!validLength)
                {
                    errorMessage += "- Be between 6 and 49 characters long.\n";
                }
                if (!hasSpecialChar)
                {
                    errorMessage += "- Contain at least one special character.\n";
                    errorMessage += "Special characters include: !\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~\n";
                }
                if (!hasLowerCase)
                {
                    errorMessage += "- Contain at least one lowercase letter.\n";
                }
                if (!hasUpperCase)
                {
                    errorMessage += "- Contain at least one uppercase letter.\n";
                }
                if (!hasNumber)
                {
                    errorMessage += "- Contain at least one number.\n";
                }
                if (hasSpace)
                {
                    errorMessage += "- Not contain any spaces.\n";
                }

                // Display error message if any
                if (!validLength || !hasSpecialChar || !hasLowerCase || !hasUpperCase || !hasNumber || hasSpace)
                {
                    MessageBox.Show(errorMessage, "Password Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the function if password is invalid
                }

                // Proceed with database query if password is valid
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
                                    HeadMain HeadHome = new HeadMain();
                                    HeadHome.RecieveUsername(un);
                                    HeadHome.Show();
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
