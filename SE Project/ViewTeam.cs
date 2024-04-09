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

        public ViewTeam()
        {
            InitializeComponent();
        }

        private void addTeamBtn_Click(object sender, EventArgs e)
        {
            AddNewMember addNewMember = new AddNewMember();
            addNewMember.Show();
        }
        public void setEventId(int id)
        {
            this.event_id = id;
        }
    }
}
