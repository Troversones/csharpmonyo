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
    public partial class Form2 : Form
    {
        public static string marka, uzemanyag, ar, evjarat;
        
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string felhasznalo = Form1.felhasznalo;
            string jelszo = Form1.jelszo;
            bool admin = Form1.admin;
            Bitmap btn2 = new Bitmap(@"Z:\13.c\c#\első projekt\back.jfif");
            Bitmap btn = new Bitmap(@"Z:\13.c\c#\első projekt\cartbtn.jpg");
            Bitmap bg = new Bitmap(@"Z:\13.c\c#\első projekt\chrome.jpg");
            Bitmap bg2 = new Bitmap(@"Z:\13.c\c#\első projekt\blue.jpg");
            button1.BackgroundImage = btn2;
            this.BackgroundImage = admin == true ? bg : bg2;
            button6.BackgroundImage = btn;
            label2.Text = admin == true ? "Jogosultság: Admin" : "Jogosultság: Felhasználó";
            label1.Text = "Felhasználó: " + felhasznalo;
            if (admin == true)
            {
                dataGridView1.AllowUserToOrderColumns = true;
                dataGridView1.AllowUserToAddRows = true;
                dataGridView1.AllowUserToDeleteRows = true;
                dataGridView1.AllowUserToResizeColumns = true;
                dataGridView1.AllowUserToResizeRows = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
            }
            
            var lines = File.ReadAllLines("data.txt");
            if (lines.Count() > 0)
            {
                foreach (var columnName in lines.FirstOrDefault()
                    .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    dataGridView1.Columns.Add(columnName, columnName);
                }
                foreach (var cellValues in lines.Skip(1))
                {
                    var cellArray = cellValues
                        .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    if (cellArray.Length == dataGridView1.Columns.Count)
                        dataGridView1.Rows.Add(cellArray);
                }
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 xd = new Form1();
            xd.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string xd = File.ReadAllText("data.txt");
            StreamWriter iro = new StreamWriter("data.txt");
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Adj meg értéket az üres mezőben");
            }
            else
            {
                string x1 = textBox1.Text;
                string x2 = textBox2.Text;
                string x3 = textBox3.Text;
                string x4 = textBox4.Text;
                string x5 = textBox5.Text;
                iro.Write(xd);
                iro.WriteLine(x1 + ";" + x2 + ";" + x3 + ";" + x4 + ";" + x5 + ";");
                iro.Close();
                dataGridView1.Rows.Add(x1, x2, x3, x4, x5);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Adj meg értéket az üres mezőben");
            }
            else if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.SelectedRows[0].Cells[0].Value = textBox1.Text;
                dataGridView1.SelectedRows[0].Cells[1].Value = textBox2.Text;
                dataGridView1.SelectedRows[0].Cells[2].Value = textBox3.Text;
                dataGridView1.SelectedRows[0].Cells[3].Value = textBox4.Text;
                dataGridView1.SelectedRows[0].Cells[4].Value = textBox5.Text;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 k = new Form3();
            k.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            marka = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            uzemanyag = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            ar = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            evjarat = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
