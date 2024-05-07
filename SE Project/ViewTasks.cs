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
    public partial class ViewTasks : Form
    {
        private string userName;
        private int selectedTask;

        public ViewTasks()
        {
            InitializeComponent();
        }

        public void SetUserName(string userName)
        {
            this.userName = userName;

        }

        public void SetSelectedTask(int selectedTask)
        {
            this.selectedTask = selectedTask;
        }

        private void LoadTasksData()
        {
            string query = @"
                    select distinct T.task_id, S.society_name, T.task_description, CASE when task_status = 0 then 'Incomplete' else 'Complete' end
	        as Status from Task T inner join Society S on T.society_id = S.society_id where T.student_username = '" + this.userName + "'; ";
            dataGridView1.DataSource = DbUtils.GetDataTable(query);
        }

        private void AddButton()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Mark Done";
            dataGridView1.Columns.Add(buttonColumn);
            buttonColumn.Text = "...";
        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ViewTasks_Shown_1(object sender, EventArgs e)
        {
            LoadTasksData();
            AddButton();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var currRow = senderGrid.Rows[e.RowIndex];
                SetSelectedTask(Convert.ToInt32(currRow.Cells["task_id"].Value));
                var query = "UPDATE Task SET task_status = 1 WHERE task_id = @update";
                var cm1 = new SqlCommand(query);
                cm1.Parameters.AddWithValue("@update", this.selectedTask);
                DbUtils.Insert(cm1);
                MessageBox.Show("Marked Done!");
                LoadTasksData();
            }
        }
    }
}
