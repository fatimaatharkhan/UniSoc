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
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        public string Login_Username { get; private set; }

        public void RecieveUsername(string Login_Username)
        {
            this.Login_Username = Login_Username;
        }

        private void AddSocietyBtn_Click(object sender, EventArgs e)
        {
            AddSociety addSociety = new AddSociety(this);
            addSociety.RecieveUsername(Login_Username);
            addSociety.Show();
            this.Hide();

        }

        private void RemoveSocietyBtn_Click(object sender, EventArgs e)
        {
            RemoveSociety removeSociety = new RemoveSociety(this);
            removeSociety.RecieveUsername(Login_Username);
            removeSociety.Show();
            this.Hide();
        }

        private void ChangeHeadBtn_Click(object sender, EventArgs e)
        {
            ChangeHead changehead = new ChangeHead(this);
            changehead.RecieveUsername(Login_Username);
            changehead.Show();
            this.Hide();
        }

        private void RemoveStudentsBtn_Click(object sender, EventArgs e)
        {
            RemoveStudent removeStudent = new RemoveStudent(this);
            removeStudent.RecieveUsername(Login_Username);
            removeStudent.Show();
            this.Hide();
        }
    }
}
