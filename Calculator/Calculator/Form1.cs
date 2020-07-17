using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;        //String storing user input
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result=0.0;
      
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
           // this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += 6;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += 7;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += 8;
        }

        private void button10_Click(object sender, EventArgs e)
        {
           // this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += 9;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            this.textBox1.Text += operation;
            input = string.Empty;


        }

        private void button12_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            this.textBox1.Text += operation;
            input = string.Empty;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            this.textBox1.Text += operation;
            input = string.Empty;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            this.textBox1.Text += operation;
            input = string.Empty;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                this.textBox1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                this.textBox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                this.textBox1.Text = result.ToString();

            }
            else if (operation == '/')
            {
                result = num1 / num2;
                this.textBox1.Text = result.ToString();
            }
            else if (operation == '2')
            {
                result = num2 * num2;
                this.textBox1.Text = result.ToString();
            }
            else if(operation == '3')
            {
                result = num2 * num2 * num2;
                this.textBox1.Text = result.ToString();
            }
            else if(operation== '√')
            {
                result = Math.Sqrt(num2);
                this.textBox1.Text = result.ToString();
            }
            else if (operation == 't')
            {
                double n = 3.0;
                result = Math.Pow(num2, (1/n));
                this.textBox1.Text = result.ToString();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            /*if (textBox1.Text != string.Empty)
            {
                int txtlength = textBox1.Text.Length;
                if (txtlength != 1)
                {
                    textBox1.Text = textBox1.Text.Remove(txtlength - 1);
                }
                else
                {
                    textBox1.Text = "";
                }
            }*/
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "^2";
            operation = '2';
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "^3";
            operation = '3';
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "√";
            operation = '√';
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "3√";
            operation = 't';
        }
    }
}
