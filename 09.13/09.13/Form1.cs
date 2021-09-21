using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _09._13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int kek = 0;
        public static string nev = "";
        private void button1_Click(object sender, EventArgs e)
        {
            
            nev = textBox1.Text;
            
            label1.Visible = false;
            label2.Visible = false;
            button1.Visible = false;
            label6.Visible = false;
            textBox1.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            progressBar1.Visible = true;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 2000;
            progressBar1.Maximum = 60;
            timer1.Tick += new EventHandler(timer1_Tick);
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            checkBox3.Visible = true;
            textBox2.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            button2.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label13.Text = "60 mp";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {



            
            if (progressBar1.Value != 60)
            {
                progressBar1.Value++;
                
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Lejárt az idő, elégtelen.xd");
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                textBox2.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                progressBar1.Visible = false;
                this.Close();
            }
            
            kek = progressBar1.Maximum - progressBar1.Value;
            label13.Text = kek.ToString() + " mp";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            int pontszam = 0;
            if (checkBox2.Checked == true && checkBox1.Checked == true)
            {
                
            }
            else if(checkBox3.Checked == true){
                pontszam++;
            }

            if (textBox2.Text == "UPDATE")
            {
                pontszam++;
            }

            if (radioButton2.Checked == true)
            {
                pontszam++;
            }
            if (pontszam == 3)
            {
                label11.Text = "5";
            }
            else if(pontszam == 2)
            {
                label11.Text = "3";
            }
            else
            {
                label11.Text = "1";
            }
            label2.Visible = false;
            button1.Visible = false;
            label6.Visible = false;
            textBox1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            progressBar1.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            textBox2.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            button2.Visible = false;
            label1.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label9.Text = nev;
            label1.Text = pontszam.ToString();
            button3.Visible = true;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string szar = File.ReadAllText("eredmenyek.txt");
            StreamWriter olv = new StreamWriter("eredmenyek.txt");
            olv.Write(szar);
            olv.WriteLine("Pontszám: " + label1.Text);
            olv.WriteLine("Név: " + label9.Text);
            olv.WriteLine("Jegy: " + label11.Text);
            olv.WriteLine("Dátum: " + DateTime.Now);
            olv.Close();
            MessageBox.Show("Köszönjük hogy kitöltötted!");
            this.Close();
        }
    }
}
