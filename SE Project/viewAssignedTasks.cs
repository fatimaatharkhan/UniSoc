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
    public partial class viewAssignedTasks : Form
    {
        private string userName;

        public viewAssignedTasks()
        {
            InitializeComponent();
        }

        public void SetUserName(string userName)
        {
            this.userName = userName;

        }

        private void LoadTasksData()
        {
            string query = @"
                    select distinct T.task_id, S.society_name, T.task_description, CASE when task_status = 0 then 'Incomplete' else 'Complete' end
	        as Status from Task T inner join Society S on T.society_id = S.society_id where T.head_username = '" + this.userName + "'; ";
            dataGridView1.DataSource = DbUtils.GetDataTable(query);
        }

        private void viewAssignedTasks_Shown(object sender, EventArgs e)
        {
            LoadTasksData();
        }
    }
}
