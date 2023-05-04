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
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Email { get; set; }
            public string[] Interests { get; set; }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "John", Age = 25, Email = "john@example.com", Interests = new string[] { "Coding", "Gaming", "Music" } },
                new Person { Name = "Emily", Age = 30, Email = "emily@example.com", Interests = new string[] { "Hiking", "Photography", "Cooking" } },
                new Person { Name = "Michael", Age = 20, Email = "michael@example.com", Interests = new string[] { "Sports", "Traveling", "Reading" } }
            };
            var coders = people.Where(p => p.Interests.Contains("Coding"));
            var result = string.Join(Environment.NewLine, coders.Select(p => $"{p.Name} ({p.Age})"));

            txtResult.Text = result;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "John", Age = 25, Email = "john@example.com", Interests = new string[] { "Coding", "Gaming", "Music" } },
                new Person { Name = "Emily", Age = 30, Email = "emily@example.com", Interests = new string[] { "Hiking", "Photography", "Cooking" } },
                new Person { Name = "Michael", Age = 20, Email = "michael@example.com", Interests = new string[] { "Sports", "Traveling", "Reading" } }
            };

            var sortedPeople = people.OrderBy(p => p.Name);
            var result = string.Join(Environment.NewLine, sortedPeople.Select(p => $"{p.Name} ({p.Age})"));

            txtResult.Text = result;
        }
    }
}
