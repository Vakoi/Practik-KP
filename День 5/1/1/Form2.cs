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

namespace _1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputString = textBox1.Text;
            int n = (int)numericUpDown1.Value;

            // Преобразуем входную строку
            string outputString = "";
            for (int i = 0; i < inputString.Length; i++)
            {
                outputString += inputString[i];
                if (i < inputString.Length - 1)
                {
                    outputString += new string('*', n);
                }
            }

            // Выводим результат в текстовое поле
            richTextBox1.Text = outputString;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
