using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int CountArithmeticProgressions(double[] sequence)
        {
            int count = 0;
            int length = sequence.Length;

            for (int i = 0; i < length - 2; i++)
            {
                double difference = sequence[i + 1] - sequence[i];

                for (int j = i + 2; j < length; j++)
                {
                    if (sequence[j] - sequence[j - 1] == difference)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return count;
        }

        void showNumbers(double[] sequence)
        {
            dataGridView1.ColumnCount = 1;

            dataGridView1.Columns[0].Name = "Numbers";

            foreach (double value in sequence)
            {
                dataGridView1.Rows.Add(value);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double[] sequence = { 1.5, 2.0, 2.5, 3.0, 3.5, 4.0 };

            int count = CountArithmeticProgressions(sequence);

            showNumbers(sequence);

            MessageBox.Show("Кількість пар, утворюючих арифметичну прогресію: " + count);
        }
    }
}
