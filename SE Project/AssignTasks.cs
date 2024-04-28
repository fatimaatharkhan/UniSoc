using Microsoft.Data.SqlClient;
using System;
using System.Collections;
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
        private string userName;
        private int event_id;

        public string StudentUsername;

        public AssignTasks()
        {
            InitializeComponent();
        }

        public void SetSocietyId(int societyId)
        {
            this.societyId = societyId;
        }
        
        public void setEventId(int id)
        {
            this.event_id = id;
        }

        public void SetUserName(string userName)
        {
            this.userName = userName;
        }

        public void setStudentUsername(string studentUsername)
        {
            this.StudentUsername = studentUsername;
        }

        private void AssignTasks_Load(object sender, EventArgs e)
        {

        }

        private void LoadStudentList()
        {
            var query = "SELECT CONCAT(u.first_name, ' ', u.last_name) AS StudentName, u.userName AS StudentId FROM Users u INNER JOIN Membership m ON u.username = m.username AND m.status = 1 WHERE u.role = 'student' AND m.society_id = " + this.societyId + " AND u.username = '" + this.StudentUsername + "'";

            cmbStudents.DataSource = DbUtils.GetDataTable(query);
        }

        private void AssignTasks_Shown(object sender, EventArgs e)
        {
            LoadStudentList();
        }

        private void assignBtn_Click(object sender, EventArgs e)
        {
            var query = "INSERT INTO Task (society_id, event_id, head_username, student_username, task_description, task_status)" +
                "VALUES (@SocietyId, @eventId, @headusername,@studentusername,@taskdescription,@taskstatus)";

            var cm1 = new SqlCommand(query);
            cm1.Parameters.AddWithValue("@SocietyId", this.societyId);
            cm1.Parameters.AddWithValue("@eventId", this.event_id);
            cm1.Parameters.AddWithValue("@headusername", this.userName);
            cm1.Parameters.AddWithValue("@studentusername", cmbStudents.SelectedValue);
            cm1.Parameters.AddWithValue("@taskdescription", txtTaskDesc.Text);
            cm1.Parameters.AddWithValue("@taskstatus", 0);
            DbUtils.Insert(cm1);
            MessageBox.Show("Task Assigned!");
        }

        private void cmbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
