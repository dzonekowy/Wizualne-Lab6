using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wizualne_Lab6
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            loadData();
        }

        private void loadData()
        {
            if(!File.Exists("data.csv"))
            {
                return;
            }
            var curentDirectory = Directory.GetCurrentDirectory();
            dataGridView1.DataSource = File.ReadAllLines(curentDirectory + "/data.csv")
                .Select(line => line.Split(','))
                .Select(parts => new { Punkty = parts[0], Czas = parts[1] })
                .ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
    }
}
