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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputString = textBox1.Text;
            string[] words = inputString.Split(' ');
            int maxDigits = 0;
            List<string> maxDigitWords = new List<string>();

            foreach (string word in words)
            {
                int digitCount = 0;

                foreach (char c in word)
                {
                    if (char.IsDigit(c))
                    {
                        digitCount++;
                    }
                }

                if (digitCount > maxDigits)
                {
                    maxDigits = digitCount;
                    maxDigitWords.Clear();
                    maxDigitWords.Add(word);
                }
                else if (digitCount == maxDigits)
                {
                    maxDigitWords.Add(word);
                }
            }

            richTextBox1.Text = ($"Максимальное количество цифр: {maxDigits}" +
                $"\nКоличество слов с максимальным количеством цифр: {maxDigitWords.Count}" +
                $"\nСлова с максимальным количеством цифр: {string.Join(", ", maxDigitWords)}");
        }
    }
}
