using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double f = Convert.ToDouble(textBox3.Text);
            double x = Math.Pow(Math.Cos(a + Math.Pow(b, 2)), 3) * Math.Sqrt((Math.Pow(f, Math.Pow(a, 2) - 13.4)) /
(Math.Pow(a + b, 3)));
            textBox4.Text = "Значение выражения равно: " + x.ToString();
        }
    }
}
