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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 xd = new Form2();
            xd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetValueForText1 = textBox1.Text;
            SetValueForText2 = textBox2.Text;
            SetValueForText3 = textBox3.Text;
            Form3 xd2 = new Form3();
            xd2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
