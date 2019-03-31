using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev 5

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a;
        int mod;
        int taban;
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            taban = Convert.ToInt32(textBox2.Text);
            a = Convert.ToInt32(textBox1.Text);
            while (a > taban-1)
            {
                mod = a % taban;
                a = a / taban;
                label1.Text = mod.ToString() + label1.Text;
            }
           label1.Text = a.ToString()+label1.Text;
        }
    }
}
