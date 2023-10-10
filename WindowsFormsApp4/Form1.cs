using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x;
            bool tryX = Double.TryParse(textBox1.Text, out x);
            double y;
            bool tryY = Double.TryParse(textBox2.Text, out y);

            try
            {
                if (!tryX && !tryY)
                {
                    throw new CastException("X и Y не могут быть преобразованы в числа");
                }
                if (!tryX)
                {
                    throw new CastException("Х не может быть преобразован в число");
                }
                if (!tryY)
                {
                    throw new CastException("У не может быть преобразован в число");
                }

                double answer = (5 * x - 3 * y) * 2;
                label6.Text = answer.ToString();
            } 
            catch (CastException ex)
            {
                MessageBox.Show(ex.Message);
            }
            object dw = new object();
            dw = 3;
            string ss = true ? String.Empty : string.Empty;
        }
    }

    public class CastException : Exception
    {
        public CastException(String Message) : base(Message) { }
    } 
}
