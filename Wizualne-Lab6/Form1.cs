namespace Wizualne_Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x = 3;
        int y = 4;
        int hyr = 1;
        int sz = 0;
        int time = 37;

        public Form1(int x, int y, int hyr, int sz, int time)
        {
            InitializeComponent();

            this.x = x;
            this.y = y;
            this.hyr = hyr;
            this.sz = sz;
            this.time = time;
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
            form3.createButton(x, y);

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
            this.Close();
        }
    }
}
