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
    public partial class StudentMain : Form
    {
        public StudentMain()
        {
            InitializeComponent();
        }

        public string Login_Username { get; private set; }

        public void RecieveUsername(string Login_Username)
        {
            this.Login_Username = Login_Username;
        }

        private void StudentMain_Load(object sender, EventArgs e)
        {

        }
    }
}
