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
    public partial class AssignTasks : Form
    {
        private int societyId;

        public AssignTasks()
        {
            InitializeComponent();
        }

        public void SetSocietyId(int societyId)
        {
            this.societyId = societyId;
        }

        private void AssignTasks_Load(object sender, EventArgs e)
        {

        }


        private void LoadStudentList()
        {
            var query = "Select first_name + ' ' + last_name as StudentName, u.userName as StudentId from Users u inner join Membership m on m.username = u.username where u.role = 'student' and m.society_id = '" + this.societyId + "' and m.status = 1";
            comboBox1.DataSource = DbUtils.GetDataTable(query);


        }

        private void AssignTasks_Shown(object sender, EventArgs e)
        {
            LoadStudentList();
        }
    }
}
