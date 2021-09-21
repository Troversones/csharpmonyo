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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.SetValueForText1;
            label2.Text = Form1.SetValueForText2;
            label3.Text = Form1.SetValueForText3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
