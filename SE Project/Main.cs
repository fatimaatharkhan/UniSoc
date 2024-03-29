using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SE_Project
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            LogIn l1 = new LogIn();
            this.Hide();
            l1.Show();
        }
    }
}