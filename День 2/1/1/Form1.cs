using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double z = 3.25 * 0.0001;
            double u = 5 * Math.Atan(x) - 0.25 * Math.Atan(x) * x + 3 * Math.Abs(x - y) + x * x / Math.Abs(x - y) * z + z * z;
            textBox3.Text = u.ToString();
        }
    }
}
