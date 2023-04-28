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
            Корабль корабль1 = new Авианосец();
            textBox1.AppendText(корабль1.Передвижение() + Environment.NewLine);

            Военный_Корабль корабль2 = new Авианосец();
            textBox1.AppendText(корабль2.Передвижение() + Environment.NewLine);
            textBox1.AppendText(корабль2.Огонь() + Environment.NewLine);
        }
        interface Корабль
    {
        string Передвижение();
    }

    abstract class Военный_Корабль : Корабль
    {
        public string Передвижение()
        {
            return "Корабль плывет";
        }

        public abstract string Огонь();
    }

    class Авианосец : Военный_Корабль
    {
        public override string Огонь()
        {
            return "Запуск самолетов с палубы";
            }
        }
    }
}
