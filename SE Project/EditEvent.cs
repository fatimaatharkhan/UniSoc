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
    public partial class EditEvent : Form
    {
        private int eventId;
        private string eventName;
        private string eventDesc;

        public EditEvent()
        {
            InitializeComponent();
            setTextboxes();
        }

        public void setEvent_id(int id)
        {
            this.eventId = id;
        }

        public void setEventName(string eventName)
        {
            this.eventName = eventName;
        }

        public void setEventDesc(string eventDesc)
        {
            this.eventDesc = eventDesc;
        }

        private void label4_Click(object sender, EventArgs e)
        {


        }

        private void setTextboxes()
        {
            DataTable dataTable = new DataTable();
            string query = @"
                    select event_name, event_description from Event where event_id = " + this.eventId + ";";
            dataTable = DbUtils.GetDataTable(query);
            if (dataTable.Rows.Count > 0)
            {
                this.eventName = dataTable.Rows[0]["event_name"].ToString();
                this.eventDesc = dataTable.Rows[0]["event_description"].ToString();
                txtEventName.Text = this.eventName;
                txtEventDesc.Text = this.eventDesc;
            }
        }

        private void txtEventName_TextChanged(object sender, EventArgs e)
        {
           //var query = @"
           //     UPDATE Event 
           //     SET event_name = @NewEventName
           //     WHERE event_id = @EventId;";
           // var cm1 = new SqlCommand(query);
           // cm1.Parameters.AddWithValue("@NewEventName", txtEventName.Text);
           // cm1.Parameters.AddWithValue("@EventId", this.eventId);
           // DbUtils.Insert(cm1);
        }

        private void EditEvent_Shown(object sender, EventArgs e)
        {
            setTextboxes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = @"
                UPDATE Event 
                SET event_name = @NewEventName, event_description = @NewEventDescription
                WHERE event_id = @EventId;";
            var cm1 = new SqlCommand(query);
            cm1.Parameters.AddWithValue("@NewEventName", txtEventName.Text);
            cm1.Parameters.AddWithValue("@NewEventDescription", txtEventDesc.Text);
            cm1.Parameters.AddWithValue("@EventId", this.eventId);
            DbUtils.Insert(cm1);
            MessageBox.Show("Event Edited!");
        }

        private void EditEvent_Activated(object sender, EventArgs e)
        {

        }

        private void txtEventDesc_TextChanged(object sender, EventArgs e)
        {
        //    var query = @"
        //        UPDATE Event 
        //        SET event_description = @NewEventDescription
        //        WHERE event_id = @EventId;";
        //    var cm1 = new SqlCommand(query);
        //    cm1.Parameters.AddWithValue("@NewEventDescription", txtEventDesc.Text);
        //    cm1.Parameters.AddWithValue("@EventId", this.eventId);
        //    DbUtils.Insert(cm1);
        }
    }
}
