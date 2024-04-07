﻿using System;
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
    public partial class HeadMain : Form
    {
        public HeadMain()
        {
            InitializeComponent();
        }

        public string Login_Username { get; private set; }

        public void RecieveUsername(string Login_Username)
        {
            this.Login_Username = Login_Username;
        }

        private void HeadMain_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void viewMySocietiesBtn_Click(object sender, EventArgs e)
        {

        }

        private void LoadSocietiesData()
        {
            //dataGridView1 = new DataGridView();
            string query = @"
                    select S.society_id, S.society_name from Society S inner join Head H on H.society_id = S.society_id where H.username = '" + this.Login_Username + "'; ";
            dataGridView2.DataSource = DbUtils.GetDataTable(query);
        }

        private void HeadMain_Shown(object sender, EventArgs e)
        {
            LoadSocietiesData();
        }


        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var currRow = senderGrid.Rows[e.RowIndex];
                //MessageBox.Show(currRow.Cells["society_id"].Value.ToString());
                AssignTasks assignTasks = new AssignTasks();
                assignTasks.SetSocietyId(Convert.ToInt32(currRow.Cells["society_id"].Value));
                assignTasks.Show();
            }
        }
    }
}
