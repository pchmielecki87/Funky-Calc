using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        private decimal Dana1=0;
        private int Znak = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text=="Wynik")
                label1.Text = "";
            label1.Text += "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Dana1 = Convert.ToDecimal(label1.Text);
            label1.Text = "+";
            Znak = 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Wynik" || label1.Text == "+" || label1.Text == "-" || label1.Text == "*" || label1.Text == "/")
                label1.Text = "";
            label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Wynik" || label1.Text == "+" || label1.Text == "-" || label1.Text == "*" || label1.Text == "/")
                label1.Text = "";
            label1.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Wynik" || label1.Text == "+" || label1.Text == "-" || label1.Text == "*" || label1.Text == "/")
                label1.Text = "";
            label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Wynik" || label1.Text == "+" || label1.Text == "-" || label1.Text == "*" || label1.Text == "/")
                label1.Text = "";
            label1.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Wynik" || label1.Text == "+" || label1.Text == "-" || label1.Text == "*" || label1.Text == "/")
                label1.Text = "";
            label1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Wynik" || label1.Text == "+" || label1.Text == "-" || label1.Text == "*" || label1.Text == "/")
                label1.Text = "";
            label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Wynik" || label1.Text == "+" || label1.Text == "-" || label1.Text == "*" || label1.Text == "/")
                label1.Text = "";
            label1.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Wynik" || label1.Text == "+" || label1.Text == "-" || label1.Text == "*" || label1.Text == "/")
                label1.Text = "";
            label1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Wynik" || label1.Text == "+" || label1.Text == "-" || label1.Text == "*" || label1.Text == "/")
                label1.Text = "";
            label1.Text += "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Dana1 = Convert.ToDecimal(label1.Text);
            label1.Text = "-";
            Znak = 2;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Dana1 = Convert.ToDecimal(label1.Text);
            label1.Text = "*";
            Znak = 3;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Dana1 = Convert.ToDecimal(label1.Text);
            label1.Text = "/";
            Znak = 4;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            decimal Dana2 = Convert.ToDecimal(label1.Text);
            switch(Znak)
            {
                case 1: label1.Text = (Dana1.ToString() + "+" + Dana2.ToString() + "=" + (Dana1 + Dana2).ToString());
                    break;
                case 2:
                    label1.Text = (Dana1.ToString() + "-" + Dana2.ToString() + "=" + (Dana1 - Dana2).ToString());
                    break;
                case 3:
                    label1.Text = (Dana1.ToString() + "*" + Dana2.ToString() + "=" + (Dana1 * Dana2).ToString());
                    break;
                case 4:
                    if (Dana2 == 0)
                        label1.Text = "Blad. Nie mozna dzielic przez zero!";
                    else
                        label1.Text = (Dana1.ToString() + "/" + Dana2.ToString() + "=" + (Dana1 / Dana2).ToString());
                    break;
            }
        }

        private void UstawDane(decimal wartosc)
        {
            Dana1 = wartosc;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if(label1.Text!="")
            label1.Text = label1.Text.Remove(label1.Text.Length -1);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        //plus_minus
        private void button18_Click(object sender, EventArgs e)
        {
            if (label1.Text.StartsWith("-"))
                label1.Text = label1.Text.Substring(1);
            if (!string.IsNullOrEmpty(label1.Text) && decimal.Parse(label1.Text) != 0)
                label1.Text = "-" + label1.Text;
        }

        //kropka
        private void button19_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
                label1.Text = "0.";
            if (label1.Text != "")
                label1.Text += ".";
        }
    }
}
