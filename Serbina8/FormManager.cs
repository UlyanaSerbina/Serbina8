﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serbina8.EF;

namespace Serbina8
{
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormManager_Load(object sender, EventArgs e)
        {

            Model1 model1 = new Model1();
            labelNames.Text = FormAutorization.Enter_Users.First_Name + " " + FormAutorization.Enter_Users.Second_Name;
            labelRole.Text = model1.Roles.First(x => x.ID == FormAutorization.Enter_Users.RoleID).Name;
            pictureBox2.Image = Image.FromFile(@"Photo\" + FormAutorization.Enter_Users.Pictures);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
