using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2zad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rad1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rad2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            float m, k;
           
            if (float.TryParse(textBox1.Text, out m))
            {
                if (checkBox1.Checked && checkBox2.Checked)
                {
                    MessageBox.Show("błąd", "błąd", MessageBoxButtons.OK);
                }
                else if (checkBox1.Checked)
                {
                    m = float.Parse(textBox1.Text);
                    lbl3.Text = (m - 100).ToString();
                }
                else if (checkBox2.Checked && rad1.Checked)
                {
                    m = float.Parse(textBox1.Text);
                    k = m * 80 / 100;
                    lbl3.Text = k.ToString();
                }
                else if (checkBox2.Checked && rad2.Checked)
                {
                    m = float.Parse(textBox1.Text);
                    k = m * 95 / 100;
                    lbl3.Text = k.ToString();
                }

            }
        }

        
    }
}
