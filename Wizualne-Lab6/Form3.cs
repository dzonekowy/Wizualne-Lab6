using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

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

        public void createButton(int x, int y, int hyr, int sz, int time, int krok)
        {
            for(int j = 0; j < y; j++)
            {
                for(int k = 0; k < x; k++)
                {
                    Button btn = new Button();
                    btn.Location = new Point(100 + i, m);
                    btn.Size = new Size(100, 100);
                    btn.Name = "btn" + j + "_" + k;
                    panel1.Controls.Add(btn);
                    i += 100;
                }
                i = -100;
                m += 100;
            }
            i = x * 100;
            game(hyr, sz, time, krok, x, y);
        }

        public void game(int hyr, int sz, int time, int krok, int x, int y)
        {
            int startTime = time;
            int points = 0;
            label2.Text = time.ToString() + "s";
            System.Timers.Timer timer = new System.Timers.Timer(1000);
            timer.Elapsed += (s, e) =>
            {
                time--;
                label2.Invoke((MethodInvoker)(() => label2.Text = time.ToString() + "s"));
                if (time <= 0)
                {
                    timer.Stop();
                    MessageBox.Show("Koniec czasu!");
                }
            };
            timer.Start();

            System.Timers.Timer generate = new System.Timers.Timer(3000);
            generate.Elapsed += (s, e) =>
            {
                int randomValX = new Random().Next(0, x);
                int randomValY = new Random().Next(0, y);
                string directory = Directory.GetCurrentDirectory();
                directory = directory.Replace("\\bin\\Debug\\net8.0-windows", "");

                Button btn = panel1.Controls.Find("btn" + randomValY + "_" + randomValX, true).FirstOrDefault() as Button;
                int randomClick = 0;
                for (int i = 0; i < 100; i++)
                {
                    randomClick = new Random().Next(0, 2);
                    if(randomClick == 0 && hyr != 0)
                    {
                        break;
                    }
                    else if(randomClick == 1 && sz != 0)
                    {
                        break;
                    }
                    else if(randomClick == 2 && krok != 0)
                    {
                        break;
                    }

                }
                if (randomClick == 0 && hyr != 0)
                {
                    System.Timers.Timer timer1 = new System.Timers.Timer(1000);
                    btn.BackgroundImage = Image.FromFile(directory + "/hyrax.jpg");
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.Click += (s2, e2) =>
                    {
                        btn.BackgroundImage = null;
                        points++;
                        hyr--;

                        if (hyr == 0)
                        {
                            timer.Stop();
                            generate.Stop();
                            
                            MessageBox.Show("Wygrałeś!\n Liczba punktów: " + points);
                            int punkty = int.Parse(label2.Text.Replace("s", ""));
                            punkty = startTime - punkty;

                            save(points, punkty.ToString() + "s");

                            Form1 form1 = new Form1();
                            this.Hide();
                            form1.Closed += (s, args) => this.Close();
                            form1.ShowDialog();
                        }
                    };
                    timer1.Elapsed += (s1, e1) =>
                    {
                        btn.BackgroundImage = null;
                        timer1.Stop();
                    };
                    timer1.Start();
                }
                else if (randomClick == 1 && sz != 0)
                {
                    System.Timers.Timer timer2 = new System.Timers.Timer(1000);
                    btn.BackgroundImage = Image.FromFile(directory + "/szop.png");
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.Click += (s3, e3) =>
                    {
                        btn.BackgroundImage = null;
                        points--;
                        sz--;
                    };
                    timer2.Elapsed += (s2, e2) =>
                    {
                        btn.BackgroundImage = null;
                        timer2.Stop();
                    };
                    timer2.Start();
                }
                else if (randomClick == 2 && krok != 0)
                {
                    System.Timers.Timer timer3 = new System.Timers.Timer(1000);
                    btn.BackgroundImage = Image.FromFile(directory + "/krok.png");
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.Click += (s4, e4) =>
                    {
                        krok--;
                        generate.Stop();
                        timer.Stop();
                        MessageBox.Show("Przegrałeś!");

                        Form1 form1 = new Form1();
                        this.Hide();
                        form1.Closed += (s, args) => this.Close();
                        form1.ShowDialog();
                    };
                    timer3.Elapsed += (s3, e3) =>
                    {
                        btn.BackgroundImage = null;
                        timer3.Stop();
                    };
                    timer3.Start();
                }
            };
            generate.Start();
        }

        private void save(int points, string time)
        {
            var curentDirectory = Directory.GetCurrentDirectory();
            
            ExportToCSV(points, time, curentDirectory + "/data.csv");
        }

        private void ExportToCSV(int points, string time, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{points},{time}");
            }
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
            label2.Location = new Point(270, 100 * hei + 50);

            this.Size = new Size(100 * value + 200, 100 * hei + 200);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
