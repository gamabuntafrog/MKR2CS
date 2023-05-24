using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRK2._2
{
    public partial class Form1 : Form
    {
        public struct Zavod
        {
            public string surname;
            public int workshopNumber;
            public string position;
            public double experience;
            public double salary;

            public Zavod(string _surname, int _workshopNumber, string _position, double _experience, double _salary)
            {
                surname = _surname;
                workshopNumber = _workshopNumber;
                position = _position;
                experience = _experience;
                salary = _salary;
            }
        }

        List<Zavod> zavod = new List<Zavod>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            zavod.Add(new Zavod("Kyrylenko", 3, "Director", 30, 1000));
            zavod.Add(new Zavod("Hal", 2, "Worker", 10, 400));
            zavod.Add(new Zavod("Novikova", 2, "Worker", 6, 400));
            zavod.Add(new Zavod("Dzyobak", 1, "Worker", 4, 300));
            zavod.Add(new Zavod("SomeSurname", 5, "Worker", 1, 250));

            DataTable table = new DataTable();
            table.Columns.Add("surname", typeof(string));
            table.Columns.Add("workshopNumber", typeof(int));
            table.Columns.Add("position", typeof(string));
            table.Columns.Add("experience", typeof(double));
            table.Columns.Add("salary", typeof(double));

            for (int i = 0; i < zavod.Count; i++)
            {
                table.Rows.Add(zavod[i].surname, zavod[i].workshopNumber, zavod[i].position, zavod[i].experience, zavod[i].salary);

            }

            dataGridView1.DataSource = table;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Zavod worker = zavod.Find(x => x.surname == textBox1.Text);

            surnameLabel.Text = "Surname: " + worker.surname;
            workshopNumberLabel.Text = "WorkshopNumber: " + worker.workshopNumber.ToString();
            positionLabel.Text = "Position: " + worker.position;
            expirienceLabel.Text = "Experience: " + worker.experience.ToString();
            salaryLabel.Text = "Salary: " + worker.salary.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            averageSalaryLabel.Text = zavod.Average(x => x.salary).ToString();
        }
    }
}
