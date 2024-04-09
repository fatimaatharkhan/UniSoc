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
    public partial class AdminViewEvents : Form
    {
        public AdminViewEvents()
        {
            InitializeComponent();
        }

        private void LoadEventsData()
        {
            string query = @"
                    select S.society_name as Society, E.event_name as Name, CONCAT(LEFT(E.event_description, 60), '...') 
                     as Description from Event E inner join Society S on E.society_id = S.society_id";
            dataGridView1.DataSource = DbUtils.GetDataTable(query);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void AdminViewEvents_Shown(object sender, EventArgs e)
        {
            LoadEventsData();
        }
    }
}
