using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    
    public partial class Form1 : Form
    {
        public static string administrator = "DANIXD";
        public static string administratorpass = "SAMSUNG";
        public static bool admin;
        public static string felhasznalo;
        public static string jelszo;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Adj meg egy felhasználónevet!");
                }
                else if(textBox2.Text == "")
                {
                    MessageBox.Show("Adj meg egy jelszavat!");
                }
            }
            else
            {
                if (textBox1.Text == administrator && textBox2.Text == administratorpass)
                {
                    admin = true;
                }
                else
                {
                    admin = false;
                }
                felhasznalo = textBox1.Text;
                jelszo = textBox2.Text;
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap bg = new Bitmap(@"Z:\13.c\c#\első projekt\administration.jpg");
            Bitmap bg2 = new Bitmap(@"Z:\13.c\c#\első projekt\close.jfif");
            Bitmap btn = new Bitmap(@"Z:\13.c\c#\első projekt\login.png");
            button1.BackgroundImage = btn;
            button2.BackgroundImage = bg2;
            this.BackgroundImage = bg;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
