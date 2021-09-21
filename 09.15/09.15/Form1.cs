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

namespace _09._15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text).ToString();
            comboBox2.Items.Add(textBox1.Text).ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader kugi = new StreamReader("konyvek.txt");
            while (!kugi.EndOfStream)
            {
                string s = kugi.ReadLine();
                string[] d = s.Split(';');
                comboBox1.Items.Add(d[0]);
                comboBox1.Items.Add(d[1]);
                comboBox1.Items.Add(d[2]);
                comboBox2.Items.Add(d[0]);
                comboBox2.Items.Add(d[1]);
                comboBox2.Items.Add(d[2]);

            }
            Image xd = new Bitmap(@"Z:\13.c\c#\09.15(1).jpg");
            this.BackgroundImage = xd;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            comboBox1.Visible = true;
            button1.Visible = true;
            button3.Visible = true;
            button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            comboBox1.Visible = false;
            button1.Visible = false;
            button3.Visible = false;
            button2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime xdd = DateTime.Now.AddDays(30);
            string kek = xdd.ToString("yyyy-MM-dd");
            string szer = File.ReadAllText("kolcsonzes.txt");
            StreamWriter iro = new StreamWriter("kolcsonzes.txt");
            iro.Write(szer);
            iro.WriteLine("Kölcsönzött könyv: " + comboBox2.Text);
            iro.WriteLine("Kölcsönzés ideje: " + DateTime.Now);
            iro.WriteLine("Kölcsönzés határideje:  " + kek);
            iro.WriteLine("--------------------------------------");
            iro.Close();

            MessageBox.Show("A(z) " + comboBox2.Text + " könyvet kölcsönözted ki, \r\n amit " + kek + "-re kell visszahoznod.");
            this.Close();
        }
    }
}
