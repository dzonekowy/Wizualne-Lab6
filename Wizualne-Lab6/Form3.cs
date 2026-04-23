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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int i = -100;
        int m = 0;

        public void createButton(int x, int y)
        {
            for(int j = 0; j < y; j++)
            {
                for(int k = 0; k < x; k++)
                {
                    Button btn = new Button();
                    btn.Location = new Point(100 + i, m);
                    btn.BackColor = System.Drawing.Color.Red;
                    btn.ForeColor = System.Drawing.Color.Yellow;
                    btn.Text = "Tabel";
                    btn.Click += new EventHandler(btn_Click);
                    btn.Size = new Size(100, 100);
                    panel1.Controls.Add(btn);
                    i += 100;
                }
                i = -100;
                m += 100;
            }
            i = x * 100;
        }

        public void changePanelSize()
        {
            int value = 0;
            int hei = 0;
            if (i == 0)
            {
                value = 1;
            }
            else
            {
                value = i / 100;
            }

            if(m == 0)
            {
                hei = 1;
            }
            else
            {
                hei = m / 100;
            }
            panel1.Size = new Size(100 * value + 100, 100 * hei + 100);

            label1.Location = new Point(230, 100 * hei + 50);

        }

        void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("me");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
