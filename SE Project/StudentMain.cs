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
    public partial class StudentMain : Form
    {
        public StudentMain()
        {
            InitializeComponent();
        }

        public string Login_Username { get; private set; }

        public void RecieveUsername(string Login_Username)
        {
            this.Login_Username = Login_Username;
        }

        private void StudentMain_Load(object sender, EventArgs e)
        {

        }

        private void viewTasksBtn_Click(object sender, EventArgs e)
        {
            ViewTasks viewTasks = new ViewTasks();
            viewTasks.SetUserName(this.Login_Username);
            viewTasks.Show();
        }

        private void viewSocietyBtn_Click(object sender, EventArgs e)
        {
            ViewSocieties view = new ViewSocieties();
            view.RecieveUsername(Login_Username);
            view.Show();
        }

        private void MySocietiesBtn_Click(object sender, EventArgs e)
        {
            ViewMySociety view = new ViewMySociety();
            view.RecieveUsername(Login_Username);
            view.Show();
        }

        private void MyEventsBtn_Click(object sender, EventArgs e)
        {
            ViewMyEvents view = new ViewMyEvents();
            view.RecieveUsername(Login_Username);
            view.Show();
        }
    }
}
