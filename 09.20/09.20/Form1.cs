using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09._20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Image xd = new Bitmap(@"Z:\13.c\c#\0robux.jpg");
            this.BackgroundImage = xd;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image lit = new Bitmap(@"Z:\13.c\c#\L I T.png");
            pictureBox1.Image = lit;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
            progressBar1.Maximum = 30;
            timer1.Tick += new EventHandler(timer1_Tick);
            DateTime xdd = DateTime.Now.AddSeconds(progressBar1.Maximum);
            string kek = xdd.ToString("T");
            label4.Visible = true;
            label4.Text = "Ekkor lesz kész: " + kek;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Kenyér")
            {
                Image kenyer = new Bitmap(@"Z:\13.c\c#\breadd.jpg");
                pictureBox2.Image = kenyer;
                label3.Text = "Kenyér";
            }
            else if(comboBox1.SelectedItem.ToString() == "Zsömle")
            {
                Image zsomle = new Bitmap(@"Z:\13.c\c#\bund.jfif");
                pictureBox2.Image = zsomle;
                label3.Text = "Zsemle";
            }
            else if (comboBox1.SelectedItem.ToString() == "Kalács")
            {
                Image kalacs = new Bitmap(@"Z:\13.c\c#\fonottkalacsd.jpg");
                pictureBox2.Image = kalacs;
                label3.Text = "Fonott kalács";
            }
            else if (comboBox1.SelectedItem.ToString() == "Csirke")
            {
                Image csirke = new Bitmap(@"Z:\13.c\c#\csirked.jpg");
                pictureBox2.Image = csirke;
                label3.Text = "Csirke";
            }
            else if (comboBox1.SelectedItem.ToString() == "Rakott krumpli")
            {
                Image krumpli = new Bitmap(@"Z:\13.c\c#\rakott.jpg");
                pictureBox2.Image = krumpli;
                label3.Text = "Rakott krumpli";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 30)
            {
                progressBar1.Value++;
            }
            else
            {
                label2.Visible = true;
                timer1.Stop();
                if (comboBox1.SelectedItem.ToString() == "Kenyér")
                {
                    Image kenyer = new Bitmap(@"Z:\13.c\c#\kenyerkesz.jpg");
                    pictureBox2.Image = kenyer;
                }
                else if (comboBox1.SelectedItem.ToString() == "Zsömle")
                {
                    Image zsomle = new Bitmap(@"Z:\13.c\c#\zsemlekesz.jfif");
                    pictureBox2.Image = zsomle;
                }
                else if (comboBox1.SelectedItem.ToString() == "Kalács")
                {
                    Image kalacs = new Bitmap(@"Z:\13.c\c#\fonottkesz.jpg");
                    pictureBox2.Image = kalacs;
                }
                else if (comboBox1.SelectedItem.ToString() == "Csirke")
                {
                    Image csirke = new Bitmap(@"Z:\13.c\c#\csirkekesz.jpg");
                    pictureBox2.Image = csirke;
                }
                else if (comboBox1.SelectedItem.ToString() == "Rakott krumpli")
                {
                    Image krumpli = new Bitmap(@"Z:\13.c\c#\rakottkesz.jpeg");
                    pictureBox2.Image = krumpli;
                }
                MessageBox.Show("Kész van a kiválaszott ételed \r\n Ez van tedd zsebre.");
                this.Close();
            }

            
        }
    }
}
