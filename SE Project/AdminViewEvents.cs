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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SE_Project
{
    public partial class AdminViewEvents : Form
    {
        public AdminViewEvents()
        {
            InitializeComponent();
        }

        private void LoadEventsData()
        {
            string query = @"
                    select S.society_name as Society, E.event_id as Event_Id, E.event_name as Name, CONCAT(LEFT(E.event_description, 30), '...') 
                     as Description from Event E inner join Society S on E.society_id = S.society_id";
            dataGridView1.DataSource = DbUtils.GetDataTable(query);
        }

        private void AddButton()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "Delete";
            buttonColumn.HeaderText = "Delete";
            dataGridView1.Columns.Add(buttonColumn);
            buttonColumn.Text = "...";
        }

        private void AddEditButton()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "Edit";
            buttonColumn.HeaderText = "Edit";
            dataGridView1.Columns.Add(buttonColumn);
            buttonColumn.Text = "...";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && ((DataGridViewButtonColumn)senderGrid.Columns[e.ColumnIndex]).Name == "Delete" && e.RowIndex >= 0)
            {
                var currRow = senderGrid.Rows[e.RowIndex];
                var query = "Delete from Event where event_id = @EventId";

                var cm1 = new SqlCommand(query);
                cm1.Parameters.AddWithValue("@EventId", Convert.ToInt32(currRow.Cells["Event_Id"].Value));
                DbUtils.Insert(cm1);
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && ((DataGridViewButtonColumn)senderGrid.Columns[e.ColumnIndex]).Name == "Edit" && e.RowIndex >= 0)
            {
                var currRow = senderGrid.Rows[e.RowIndex];
                EditEvent editEvent = new EditEvent();
                editEvent.setEvent_id(Convert.ToInt32(currRow.Cells["Event_Id"].Value));
                editEvent.Show();
            }
            LoadEventsData();
        }

        private void AdminViewEvents_Shown(object sender, EventArgs e)
        {
            LoadEventsData();
            AddButton();
            AddEditButton();
        }

        private void AdminViewEvents_Activated(object sender, EventArgs e)
        {
            LoadEventsData();
        }
    }
}
