using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox2.Text);
            double b = Convert.ToDouble(textBox3.Text);
            double c = Convert.ToDouble(textBox4.Text);
            double Xнач = Convert.ToDouble(textBox5.Text);
            double Xкон = Convert.ToDouble(textBox6.Text);
            double dx = Convert.ToDouble(textBox7.Text);
            for (double x = Xнач; x <= Xкон; x += dx)
            {
                double result;

                if (x < 5 && b != 0)
                {
                    result = -a * x * x * b;
                }
                else if (x > 5 && c == 0)
                {
                    result = (x - a) / x;
                }
                else
                {
                    result = -x / c;
                }

                if ((int)a % 2 == 1 || (int)b % 2 == 1 || (int)c % 2 == 1)
                {
                    textBox1.Text = Convert.ToString(result);
                }
                else
                {
                    textBox1.Text = Convert.ToString(result);
                }
            }
        }
    }
}
        
