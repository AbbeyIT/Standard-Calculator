using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Standard_Calculator
{
    public partial class StandardCalcu : Form
    {
        double firstNumber;
        string Operator;
        public StandardCalcu()
        {
            InitializeComponent();
        }

        private void StandardCalcu_Load(object sender, EventArgs e)
        {

        }
        private void btn1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear button
            textBox1.Clear();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            //dot button
            textBox1.Text = textBox1.Text + ".";
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            //plus button
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operator = "+";
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            //minus button
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operator = "-";
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            //times button
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operator = "*";
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            //divide button
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operator = "/";
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            //equal button
            double secondNumber;
            double result;

            secondNumber = Convert.ToDouble(textBox1.Text);

            if (Operator == "+")
            {
                result = (firstNumber + secondNumber);
                textBox1.Text = Convert.ToString(result);
                firstNumber = result;
            }
            if (Operator == "-")
            {
                result = (firstNumber - secondNumber);
                textBox1.Text = Convert.ToString(result);
                firstNumber = result;
            }
            if (Operator == "*")
            {
                result = (firstNumber * secondNumber);
                textBox1.Text = Convert.ToString(result);
                firstNumber = result;
            }
            if (Operator == "/")
            {
                result = (firstNumber / secondNumber);
                textBox1.Text = Convert.ToString(result);
                firstNumber = result;
            }
        }
    }
}
