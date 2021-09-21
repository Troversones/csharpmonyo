using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19._21
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            int r2 = r.Next(1,60);
            
            timer1.Enabled = true;
            progressBar1.Maximum = r2;
            timer1.Start();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double osztottszam = progressBar1.Maximum / 2;

            if (progressBar1.Value != progressBar1.Maximum)
            {
                progressBar1.Value++;
                if (progressBar1.Value >= osztottszam && progressBar1.Value < progressBar1.Maximum)
                {
                    Image yellow = new Bitmap(@"Z:\13.c\c#\lampasarga.png");
                    pictureBox1.Image = yellow;
                    label1.Text = "Készülj";
                }
                else if(progressBar1.Value == progressBar1.Maximum)
                {
                    Image green = new Bitmap(@"Z:\13.c\c#\lampazold.png");
                    pictureBox1.Image = green;
                    label1.Text = "Indulj";
                }
            }
            else
            {
                timer1.Stop();
                
                MessageBox.Show("Less go");                
            }
        }
    }
}
