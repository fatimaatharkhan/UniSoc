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
    public partial class AddSociety : Form
    {
        private string connectionString = "Data Source=G4CE-1080\\SQLEXPRESS;Initial Catalog=UniSoc;Integrated Security=True;Encrypt=False";
        private AdminMain adminMain;

        public AddSociety()
        {
            InitializeComponent();
        }

        public AddSociety(AdminMain adminMain)
        {
            this.adminMain = adminMain;
            InitializeComponent();
        }

        public string Login_Username { get; private set; }

        public void RecieveUsername(string Login_Username)
        {
            this.Login_Username = Login_Username;
        }

        private void AddSocietyBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sn = SocietyNameTxtbox.Text;
                string cap = CapacityTxtbox.Text;
                string query = "SELECT * FROM Society WHERE society_name = @SocietyName";

                using (SqlCommand cm = new SqlCommand(query, conn))
                {
                    cm.Parameters.AddWithValue("@SocietyName", sn);
                    using (SqlDataReader reader = cm.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("Society Already Exists! Please choose a different name.");
                        }
                        else
                        {
                            SqlConnection conn1 = new SqlConnection(connectionString);
                            conn1.Open();
                            query = "INSERT INTO Society (society_name, Capacity) VALUES (@SocietyName, @Capacity)";

                            using (SqlCommand cm1 = new SqlCommand(query, conn1))
                            {
                                cm1.Parameters.AddWithValue("@SocietyName", sn);
                                cm1.Parameters.AddWithValue("@Capacity", cap);
                                using (SqlDataReader reader1 = cm1.ExecuteReader())
                                {
                                    MessageBox.Show("Society Created Successfully!");
                                }
                            }
                        }
                    }
                }
            }

        }
        private void AddSociety_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancel the form closing event to prevent immediate closing

            adminMain.Show(); // Show the AdminMain form
            this.Hide(); // Hide the AddSociety form
        }

        private void AddSociety_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SocietyNameTxtbox_TextChanged(object sender, EventArgs e)
        {
        }
    }

}
