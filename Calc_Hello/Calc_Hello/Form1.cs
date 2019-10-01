using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_Hello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            calc.Text += "1";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            calc.Text += "2";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            calc.Text += "3";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            calc.Text += "4";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            calc.Text += "5";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            calc.Text += "6";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            calc.Text += "7";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            calc.Text += "8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            calc.Text += "9";
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            calc.Text += "0";
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            calc.Text += "+";
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            calc.Text += "-";
        }
        public char[] Calcs = new char[4];
        public string[] calculator;
        private void Button13_Click(object sender, EventArgs e)
        {
            Calcs[0] = '-';
            Calcs[1] = '+';
            Calcs[2] = '*';
            Calcs[3] = '/';
            calculator = calc.Text.Split(Calcs);
            if (calc.Text.Contains("+") == true)
                calc.Text = $"{ Convert.ToInt32(calculator[0]) + Convert.ToInt32(calculator[1])}";
            if (calc.Text.Contains("-") == true)
                calc.Text = $"{ Convert.ToInt32(calculator[0]) - Convert.ToInt32(calculator[1])}";
            if (calc.Text.Contains("*") == true)
                calc.Text = $"{ Convert.ToInt32(calculator[0]) * Convert.ToInt32(calculator[1])}";
            if (calc.Text.Contains("/") == true)
                calc.Text = $"{ Convert.ToInt32(calculator[0]) / Convert.ToInt32(calculator[1])}";
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            calc.Text += "*";
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            calc.Text += "/";
        }
    }
}
