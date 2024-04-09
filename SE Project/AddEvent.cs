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
    public partial class AddEvent : Form
    {
        public AddEvent()
        {
            InitializeComponent();
        }

        private void LoadEventList()
        {
            var query = "select society_id as ID, society_name as Name from Society";
            cmbSocieties.DataSource = DbUtils.GetDataTable(query);

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var query = "INSERT INTO Event (society_id, event_name, event_description) VALUES (@SocietyId, @event_name, @event_desc)";

            var cm1 = new SqlCommand(query);
            cm1.Parameters.AddWithValue("@SocietyId", cmbSocieties.SelectedValue);
            cm1.Parameters.AddWithValue("@event_name", txtEventName.Text);
            cm1.Parameters.AddWithValue("@event_desc", txtEventDesc.Text);
            DbUtils.Insert(cm1);
            MessageBox.Show("Event Added!");
            this.Close();
        }

        private void cmbSocieties_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddEvent_Shown(object sender, EventArgs e)
        {
            LoadEventList();
        }
    }
}
