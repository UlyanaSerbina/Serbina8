using System;
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
    public partial class FormSeller : Form
    {
        public FormSeller()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormSeller_Load(object sender, EventArgs e)
        {

            Model1 model1 = new Model1();
            labelNames.Text = FormAutorization.Enter_Users.First_Name + " " + FormAutorization.Enter_Users.Second_Name;
            labelRole.Text = model1.Roles.First(x => x.ID == FormAutorization.Enter_Users.RoleID).Name;
            pictureBox3.Image = Image.FromFile(@"Photo\" + FormAutorization.Enter_Users.Pictures);
        }
    }
}
