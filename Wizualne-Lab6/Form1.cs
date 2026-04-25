namespace Wizualne_Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int xVal = 3;
        int yVal = 4;
        int hyrVal = 1;
        int szVal = 2;
        int krokVal = 0;
        int timeVal = 37;

        public Form1(int x, int y, int hyr, int sz, int time, int krok)
        {
            InitializeComponent();

            this.xVal = x;
            this.yVal = y;
            this.hyrVal = hyr;
            this.szVal = sz;
            this.krokVal = krok;
            this.timeVal = time;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
            form3.createButton(xVal, yVal, hyrVal, szVal, timeVal, krokVal);

            form3.changePanelSize();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }
    }
}
