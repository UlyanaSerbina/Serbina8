using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car { Num = "м152мв134", Age = 5 });
            cars.Add(new Car { Num = "М976мм55", Age = 13 });
            cars.Add(new Car { Num = "В067ав199", Age = 1 });
            cars.Add(new Car { Num = "к133та70", Age = 7 });

            carsList.DisplayMember = "Num"; // будет показываться свойство FIO
            carsList.ValueMember = "Age"; // Будет возвращаться значение свойства Age
            carsList.DataSource = cars;
            //carsList.SelectedIndex = 0; // будет выбрана первая строка
        }

        private void carsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int curItem = carsList.SelectedIndex;
            //object selectedItem = ;
            //string = 
            //Car p = ;
            MessageBox.Show("Age: " + (carsList.SelectedItem as Car).Age);
            return; // заканчиваем работу метода
        }
    }
}
