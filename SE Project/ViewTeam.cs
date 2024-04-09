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
    public partial class ViewTeam : Form
    {
        private int event_id;
        private int society_id;
        private string userName;

        public ViewTeam()
        {
            InitializeComponent();
        }

        public void SetUserName(string userName)
        {
            this.userName = userName;

        }

        private void addTeamBtn_Click(object sender, EventArgs e)
        {
            var query = "INSERT INTO Event_Student (event_id, username) VALUES (@event_id, @username)";

            var cm1 = new SqlCommand(query);
            cm1.Parameters.AddWithValue("@event_id", this.event_id);
            cm1.Parameters.AddWithValue("@username", cmbStudents.SelectedValue.ToString());
            DbUtils.Insert(cm1);
            MessageBox.Show("Member Added.");
            LoadEventStudentList();
            LoadStudentList();
        }
        public void setEventId(int id)
        {
            this.event_id = id;
        }

        public void setSocietyId(int id)
        {
            this.society_id = id;
        }

        private void LoadEventStudentList()
        {
            var query = "select U.first_name + ' ' +  U.last_name as StudentName, U.username as StudentId, Ev.society_id from  Users U " +
                "inner join Event_Student E on E.username = U.username inner join Event ev on e.event_id = ev.event_id where E.event_id = '" + this.event_id + "' and  U.role = 'student'";
            dataGridView2.DataSource = DbUtils.GetDataTable(query);
        }

        private void AddButton()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Assign Task";
            dataGridView2.Columns.Add(buttonColumn);
            buttonColumn.Text = "...";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadStudentList()
        {
            var query = "select U.first_name + ' ' +  U.last_name as StudentName, U.username as StudentId, S.society_name, s.society_id from Users U " +
                "inner join Membership M on U.username = M.username inner join Society S on M.society_id = S.society_id where U.role = 'student'" +
                " and S.society_id = '" + this.society_id + "' and U.username not in (select U.username as StudentId from  Users U inner join Event_Student E on E.username = U.username" +
                " where E.event_id = '" + this.event_id + "');";
            cmbStudents.DataSource = DbUtils.GetDataTable(query);
        }

        private void ViewTeam_Shown(object sender, EventArgs e)
        {
            LoadEventStudentList();
            LoadStudentList();
            AddButton();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var currRow = senderGrid.Rows[e.RowIndex];
                MessageBox.Show(currRow.Cells["society_id"].Value.ToString());
                AssignTasks assignTasks = new AssignTasks();
                assignTasks.SetSocietyId(Convert.ToInt32(currRow.Cells["society_id"].Value));
                assignTasks.SetUserName(userName);
                assignTasks.setEventId(event_id);
                assignTasks.Show();
            }
        }
    }
}
