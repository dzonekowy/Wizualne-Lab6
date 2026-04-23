using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Wizualne_Lab6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int xVal = (int)numericUpDown1.Value;
            int yVal = (int)numericUpDown2.Value;
            int hyrVal = (int)numericUpDown3.Value;
            int szVal = (int)numericUpDown4.Value;
            int timeVal = (int)numericUpDown5.Value;

            this.Hide();
            Form1 form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
    }
}
