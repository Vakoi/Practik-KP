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
        int Factorial(int n)
        {
            int f = 1;
            if (n == 0)
            {
                return 1;
            }
            for (int i = 1; i <= n; i++)
            {
                f *= i;
            }
            return f;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double v = 0.001;

            double sum = 0;
            double term = 1;
            double pref = 0;
            int n = 0;

            while (Math.Abs(term + pref) >= v)
            {
                pref = term;
                sum += term; // Добавляем текущий член ряда к сумме
                n++; // Увеличиваем счетчик количества слагаемых

                // Вычисляем следущий член ряда (-1)^(n-1) * x^(2n) / ((2*n)!)
                term = Math.Pow(-1, n - 1) * Math.Pow(x, 2 * n) / Factorial(2 * n - 1);
            }
            textBox2.Text = $"Значение функций F({x}) с точностью {v} равно: {sum}";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
