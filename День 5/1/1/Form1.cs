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

        private void задание1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Задание_1 = new Form2();
            Задание_1.Show();
        }

        private void задание2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 Задание_2 = new Form3();
            Задание_2.Show();
        }

        private void задание3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 Задание_3 = new Form4();
            Задание_3.Show();
        }

        private void задание4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 Задание_4 = new Form5();
            Задание_4.Show();
        }
    }
}
