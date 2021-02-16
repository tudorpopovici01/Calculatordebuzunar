using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatordebuzunar
{
    public partial class Form1 : Form
    {
        public string A;
        public string N1;
        public bool n2;
        public Form1()
        {
            n2 = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (n2)
            {
                n2 = false;
                textBox1.Text = "0";
            }
            Button B = (Button)sender;
            if(textBox1.Text == "0")
            textBox1.Text = B.Text;
            else
                textBox1.Text = textBox1.Text + B.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            A = B.Text;
            N1 = textBox1.Text;
            n2 = true;

        }

        private void button24_Click(object sender, EventArgs e)
        {
            double an1, an2, rez;
            rez = 0;
            an1 = Convert.ToDouble(N1);
            an2 = Convert.ToDouble(textBox1.Text);
            if (A == "+")
            {
                rez = an1 + an2;
            }
            if (A == "-")
            {
                rez = an1 - an2;
            }
            if (A == "*")
            {
                rez = an1 * an2;
            }
            if (A == "÷")
            {
                rez = an1 / an2;
            }
            if (A == "%")
            {
                rez = an1*an2/100;
            }
            A = "=";
            n2 = true;
            textBox1.Text = rez.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double an, rez;
            an = Convert.ToDouble(textBox1.Text);
            rez = Math.Sqrt(an);
            textBox1.Text = rez.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double an, rez;
            an = Convert.ToDouble(textBox1.Text);
            rez = Math.Pow(an,2);
            textBox1.Text = rez.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double an, rez;
            an = Convert.ToDouble(textBox1.Text);
            rez = 1/an;
            textBox1.Text = rez.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double an, rez;
            an = Convert.ToDouble(textBox1.Text);
            rez = -an;
            textBox1.Text = rez.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Contains(","))
                textBox1.Text = textBox1.Text + ",";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "")
                textBox1.Text = "0";
        }
    }
}
