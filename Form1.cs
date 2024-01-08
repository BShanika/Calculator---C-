using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num1;
        double num2;
        string option;
        double result;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "7";
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_Result.Clear();
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "8";
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "9";
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "6";
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "1";
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "3";
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "0";
        }

        private void button_Plus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = double.Parse(textBox_Result.Text);
            textBox_Result.Clear();
        }

        private void button_Mins_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = double.Parse(textBox_Result.Text);
            textBox_Result.Clear();
        }

        private void button_Multi_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = double.Parse(textBox_Result.Text);
            textBox_Result.Clear();
        }

        private void button_Divide_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = double.Parse(textBox_Result.Text);
            textBox_Result.Clear();
        }

        private void button_Point_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + ".";
        }

        private void button_Equal_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(textBox_Result.Text);

            if (option.Equals("+"))
                result = num1 + num2;
            if (option.Equals("-"))
                result = num1 - num2;
            if (option.Equals("*"))
                result = num1 * num2;
            if (option.Equals("/"))
                result = num1 / num2;
            textBox_Result.Text = result.ToString();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text.Length > 0)
            {
                textBox_Result.Text = textBox_Result.Text.Remove(textBox_Result.Text.Length - 1);
            }
        }
    }
}

