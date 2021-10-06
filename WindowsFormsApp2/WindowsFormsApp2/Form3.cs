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

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Bitmap bg = new Bitmap(@"Z:\13.c\c#\első projekt\cart.png");
            Bitmap bg2 = new Bitmap(@"Z:\13.c\c#\első projekt\back.jfif");
            Bitmap bg3 = new Bitmap(@"Z:\13.c\c#\első projekt\purchase.png");
            button2.BackgroundImage = bg3;
            this.BackgroundImage = bg;
            button1.BackgroundImage = bg2;
            lbl_ar.Text = Form2.ar;
            lbl_evjarat.Text = Form2.evjarat;
            lbl_marka.Text = Form2.marka;
            lbl_uzemanyag.Text = Form2.uzemanyag;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 xd = new Form2();
            xd.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Kérlek töltsd ki az üres mezőket!");
            }
            else if (textBox2.Text.Contains("/") == false)
            {
                MessageBox.Show("Használj / jelet a lejárati dátum mezőnél!");
            }
            else
            {
                string file = File.ReadAllText("blokk.txt");
                StreamWriter iro = new StreamWriter("blokk.txt");
                iro.Write(file);
                iro.WriteLine("----- Termékleírás -----");
                iro.WriteLine("Márka: " + lbl_marka.Text);
                iro.WriteLine("Ár: " + lbl_ar.Text);
                iro.WriteLine("Évjárat: " + lbl_evjarat.Text);
                iro.WriteLine("Üzemanyag: " + lbl_uzemanyag.Text);
                iro.WriteLine("----- Személyes adatok -----");
                iro.WriteLine("Számlaszám: " + textBox1.Text);
                iro.WriteLine("Lejárati Dátum: " + textBox2.Text);
                iro.WriteLine("Postai Kód: " + textBox3.Text);
                iro.WriteLine("Tulajdonos neve: " + textBox4.Text);
                iro.WriteLine("Lakcím: " + textBox5.Text);
                iro.WriteLine("Vásárlás pontos dátuma: " + DateTime.Now);
                iro.WriteLine("-------------------------------------");
                iro.Close();
                MessageBox.Show("Köszönjük a vásárlást! A blokk létre lett hozva.");
                this.Close();
            }
        }
    }
}
