using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orai_09._09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label7.Text = "Beetlejuice was one \r\n of the strongest super saiyan's,\r\n but he retired and without his\r\n power you decieded to fight him\r\n once and for all.";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Image myimage2 = new Bitmap(@"Z:\Képek\maxresdefaultwp.jpg");
            Image myimage4 = new Bitmap(@"Z:\Képek\sddefault.jpg");
            Image myimage5 = new Bitmap(@"Z:\Képek\kekw.png");
            Image myimage6 = new Bitmap(@"Z:\Képek\eminem.jpg");
            Image myimage7 = new Bitmap(@"Z:\Képek\supersaiyan.jfif");
            labelhp.Text = trackBar1.Value.ToString();
            if (trackBar1.Value <= 0)
            {
                labeldifficult.Text = "None";
                this.BackgroundImage = myimage4;
                this.pictureBox1.Image = myimage7;
            }
            else if(trackBar1.Value >= 1 && trackBar1.Value < 5)
            {
                labeldifficult.Text = "Easy";
                this.BackgroundImage = myimage2;
                this.pictureBox1.Image = myimage5;
            }
            else if (trackBar1.Value >= 5 && trackBar1.Value < 7)
            {
                labeldifficult.Text = "Medium";
                this.BackgroundImage = myimage2;
            }
            else if (trackBar1.Value >= 7 && trackBar1.Value < 10)
            {
                labeldifficult.Text = "Hard";
                this.BackgroundImage = myimage2;
            }
            else if (trackBar1.Value == 10)
            {
                labeldifficult.Text = "Madman";
                Image myimage3 = new Bitmap(@"Z:\Képek\P1000854.jfif");
                this.BackgroundImage = myimage3;
                this.pictureBox1.Image = myimage6;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Image myimage = new Bitmap(@"Z:\Képek\sddefault.jpg");
            this.BackgroundImage = myimage;
        }
    }
}
