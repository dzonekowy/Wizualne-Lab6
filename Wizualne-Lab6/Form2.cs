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
        public int xVal = 3;
        public int yVal = 4;
        public int hyrVal = 1;
        public int szVal = 2;
        public int krokVal = 0;
        public int timeVal = 37;

        public Form2()
        {
            InitializeComponent();
            numericUpDown1.Value = xVal;
            numericUpDown2.Value = yVal;
            numericUpDown3.Value = hyrVal;
            numericUpDown4.Value = szVal;
            numericUpDown5.Value = timeVal;
            numericUpDown6.Value = krokVal;
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
            xVal = (int)numericUpDown1.Value;
            yVal = (int)numericUpDown2.Value;
            hyrVal = (int)numericUpDown3.Value;
            szVal = (int)numericUpDown4.Value;
            timeVal = (int)numericUpDown5.Value;
            krokVal = (int)numericUpDown6.Value;

            this.Hide();
            Form1 form1 = new Form1(xVal, yVal, hyrVal, szVal, timeVal, krokVal);
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
    }
}
