using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2zad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (rad4.Checked)
            {               
                textBox1.Font = new Font(this.textBox1.Font.Name, this.textBox1.Font.Size, FontStyle.Bold);
            }
            else if (rad5.Checked)
            {
                textBox1.Font = new Font(this.textBox1.Font.Name, this.textBox1.Font.Size, FontStyle.Italic);
            }
            else if (rad6.Checked)
            {
                textBox1.Font = new Font(this.textBox1.Font.Name, this.textBox1.Font.Size, FontStyle.Underline);
            }
            if (rad7.Checked)
            {
                textBox1.ForeColor = Color.Red;
            }
            if (rad8.Checked)
            {
                textBox1.ForeColor = Color.Blue;
            }
            if (rad9.Checked)
            {                
                textBox1.ForeColor = Color.Orange;
            }
            if (rad1.Checked)
            {
                textBox1.Font = new Font("arial", 10);
            }
            if (rad2.Checked)
            {
                textBox1.Font = new Font("arial", 12);
            }
            if (rad3.Checked)
            {
                textBox1.Font = new Font("arial", 14);
            }
        }
    }
}
