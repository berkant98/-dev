using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tc_kimlik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random salla = new Random();
            int[] a = new int[12];
            for (int t = 0; t < 50; t++)
            {
                string tc = "";
                for (int k = 1; k < 12; k++)
                {
                    if (k == 1)
                    {
                        a[k] = salla.Next(1, 10);
                        tc = tc + a[k];
                        k++;
                    }

                    a[k] = salla.Next(0, 10);
                    tc = tc + a[k];

                }

                int kontrol1, kontrol2;
                a[10] = ((a[1] + a[3] + a[5] + a[7] + a[9]) * 7 - (+a[2] + a[4] + a[6] + a[8])) % 10;
                a[11] = (a[1] + a[2] + a[3] + a[4] + a[5] + a[6] + a[7] + a[8] + a[9] + a[10]) % 10;

                listBox1.Items.Add(tc);
                
            }

            listBox2.Items.Add(listBox1.Items.Count);

        }

    }
}
