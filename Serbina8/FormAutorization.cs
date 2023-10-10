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
    public partial class FormAutorization : Form
    {
        public FormAutorization()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormAutorization_Load(object sender, EventArgs e)
        {
             
        }
        public static Users Enter_Users;

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            Enter_Users = null;
            Model1 model1 = new Model1();
            Enter_Users = model1.Users.FirstOrDefault(x => x.Login == textBoxLogin.Text && x.Password == textBoxPassword.Text);
            if (Enter_Users != null)
            {
                switch (Enter_Users.RoleID)
                {
                    case 1:
                        FormManager formManager = new FormManager();
                        formManager.ShowDialog();
                        break;
                    case 2:
                        FormSeller formSeller = new FormSeller();
                        formSeller.ShowDialog();
                        break;
                    case 3:
                        FormDirector formDirector = new FormDirector();
                        formDirector.ShowDialog();
                        break;
                    default: throw new Exception("Роль не найдена!");

                }
            } 
        }
    }
    

}
