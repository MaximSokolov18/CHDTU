using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.label1.Text == "" && this.label2.Text != "")
            {
                this.label2.Text = "";
            }
            this.label1.Text += this.button1.Text; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.label1.Text == "" && this.label2.Text != "")
            {
                this.label2.Text = "";
            }
            this.label1.Text += this.button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.label1.Text == "" && this.label2.Text != "")
            {
                this.label2.Text = "";
            }
            this.label1.Text += this.button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.label1.Text == "" && this.label2.Text != "")
            {
                this.label2.Text = "";
            }
            this.label1.Text += this.button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.label1.Text == "" && this.label2.Text != "")
            {
                this.label2.Text = "";
            }
            this.label1.Text += this.button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.label1.Text == "" && this.label2.Text != "")
            {
                this.label2.Text = "";
            }
            this.label1.Text += this.button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.label1.Text == "" && this.label2.Text != "")
            {
                this.label2.Text = "";
            }
            this.label1.Text += this.button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.label1.Text == "" && this.label2.Text != "")
            {
                this.label2.Text = "";
            }
            this.label1.Text += this.button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (this.label1.Text == "" && this.label2.Text != "")
            {
                this.label2.Text = "";
            }
            this.label1.Text += this.button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string textLabel1 = this.label1.Text;
            this.label1.Text = textLabel1.Remove(textLabel1.Length - 1);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double numLabel1, numLabel2;
            string strLabel1 = this.label1.Text;
            string strLabel2 = this.label2.Text;
            if (strLabel2.Length == 0)
            {
                this.label2.Text = strLabel1;
            }
            else
            {
                char action = strLabel1[0];
                numLabel2 = double.Parse(strLabel2);
                if (action == '*')
                {
                    strLabel1 = strLabel1.Remove(0, 1);
                    numLabel1 = double.Parse(strLabel1);
                    string result = Convert.ToString(numLabel2 * numLabel1);
                    this.label2.Text = result;
                }
                else if (action == '/')
                {
                    strLabel1 = strLabel1.Remove(0, 1);
                    numLabel1 = double.Parse(strLabel1);
                    string result = Convert.ToString(numLabel2 / numLabel1);
                    this.label2.Text = result;
                }
                else if (action == '-')
                {
                    strLabel1 = strLabel1.Remove(0, 1);
                    numLabel1 = double.Parse(strLabel1);
                    string result = Convert.ToString(numLabel2 - numLabel1);
                    this.label2.Text = result; ;
                }
                else if (action == '+')
                {
                    strLabel1 = strLabel1.Remove(0, 1);
                    numLabel1 = double.Parse(strLabel1);
                    string result = Convert.ToString(numLabel2 + numLabel1);
                    this.label2.Text = result;
                }
                else if (action == '^')
                {
                    strLabel1 = strLabel1.Remove(0, 1);
                    numLabel1 = double.Parse(strLabel1);
                    string result = Convert.ToString(Math.Pow(numLabel2, numLabel1));
                    this.label2.Text = result;
                }
            }
            this.label1.Text = this.button15.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double numLabel1, numLabel2;
            string strLabel1 = this.label1.Text;
            string strLabel2 = this.label2.Text;
            if (strLabel2.Length == 0)
            {
                this.label2.Text = strLabel1;
            }
            else
            {
                char action = strLabel1[0];
                numLabel2 = double.Parse(strLabel2);
                if (action == '*')
                {
                    strLabel1 = strLabel1.Remove(0, 1);
                    numLabel1 = double.Parse(strLabel1);
                    string result = Convert.ToString(numLabel2 * numLabel1);
                    this.label2.Text = result;
                }
                else if (action == '/')
                {
                    strLabel1 = strLabel1.Remove(0, 1);
                    numLabel1 = double.Parse(strLabel1);
                    string result = Convert.ToString(numLabel2 / numLabel1);
                    this.label2.Text = result;
                }
                else if (action == '-')
                {
                    strLabel1 = strLabel1.Remove(0, 1);
                    numLabel1 = double.Parse(strLabel1);
                    string result = Convert.ToString(numLabel2 - numLabel1);
                    this.label2.Text = result; ;
                }
                else if (action == '+')
                {
                    strLabel1 = strLabel1.Remove(0, 1);
                    numLabel1 = double.Parse(strLabel1);
                    string result = Convert.ToString(numLabel2 + numLabel1);
                    this.label2.Text = result;
                }
                else if (action == '^')
                {
                    strLabel1 = strLabel1.Remove(0, 1);
                    numLabel1 = double.Parse(strLabel1);
                    string result = Convert.ToString(Math.Pow(numLabel2, numLabel1));
                    this.label2.Text = result;
                }
            }
            this.label1.Text = this.button14.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double numLabel1, numLabel2;
            string strLabel1 = this.label1.Text;
            string strLabel2 = this.label2.Text;
            if (strLabel2.Length == 0)
            {
                this.label2.Text = strLabel1;
            }
            else
            {
                char action = strLabel1[0];
                numLabel2 = double.Parse(strLabel2);
                if (action == '*')
                {
                    strLabel1 = strLabel1.Remove(0, 1);
                    numLabel1 = double.Parse(strLabel1);
                    string result = Convert.ToString(numLabel2 * numLabel1);
                    this.label2.Text = result;
                }
                else if (action == '/')
                {
                    strLabel1 = strLabel1.Remove(0, 1);
                    numLabel1 = double.Parse(strLabel1);
                    string result = Convert.ToString(numLabel2 / numLabel1);
                    this.label2.Text = result;
                }
                else if (action == '-')
                {
                    strLabel1 = strLabel1.Remove(0, 1);
                    numLabel1 = double.Parse(strLabel1);
                    string result = Convert.ToString(numLabel2 - numLabel1);
                    this.label2.Text = result; ;
                }
                else if (action == '+')
                {
                    strLabel1 = strLabel1.Remove(0, 1);
                    numLabel1 = double.Parse(strLabel1);
                    string result = Convert.ToString(numLabel2 + numLabel1);
                    this.label2.Text = result;
                }
                else if (action == '^')
                {
                    strLabel1 = strLabel1.Remove(0, 1);
                    numLabel1 = double.Parse(strLabel1);
                    string result = Convert.ToString(Math.Pow(numLabel2, numLabel1));
                    this.label2.Text = result;
                }
            }
            this.label1.Text = this.button13.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double numLabel1, numLabel2;
            string strLabel1 = this.label1.Text;
            string strLabel2 = this.label2.Text;
            if (strLabel1 == "-" || strLabel1 == "+" || strLabel1 == "*" || strLabel1 == "/" || strLabel1 == "^")
            {
                this.label1.Text += "-";
                return;
            }

            if (strLabel2.Length == 0)
            {
                this.label2.Text = strLabel1;
            }
            else
            {
                char action = strLabel1[0];
                numLabel2 = double.Parse(strLabel2);
                if (action == '*')
                {
                    strLabel1 = strLabel1.Remove(0, 1);
                    numLabel1 = double.Parse(strLabel1);
                    string result = Convert.ToString(numLabel2 * numLabel1);
                    this.label2.Text = result;
                }
                else if (action == '/')
                {
                    strLabel1 = strLabel1.Remove(0, 1);
                    numLabel1 = double.Parse(strLabel1);
                    string result = Convert.ToString(numLabel2 / numLabel1);
                    this.label2.Text = result;
                }
                else if (action == '-')
                {   
                     strLabel1 = strLabel1.Remove(0, 1);
                    numLabel1 = double.Parse(strLabel1);
                    string result = Convert.ToString(numLabel2 - numLabel1);
                    this.label2.Text = result;
                }
                else if (action == '+')
                {
                    strLabel1 = strLabel1.Remove(0, 1);
                    numLabel1 = double.Parse(strLabel1);
                    string result = Convert.ToString(numLabel2 + numLabel1);
                    this.label2.Text = result;
                }
                else if (action == '^')
                {
                    strLabel1 = strLabel1.Remove(0, 1);
                    numLabel1 = double.Parse(strLabel1);
                    string result = Convert.ToString(Math.Pow(numLabel2, numLabel1));
                    this.label2.Text = result;
                }
            }
            this.label1.Text = this.button12.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double numLabel1, numLabel2;
            string strLabel1 = this.label1.Text;
            string strLabel2 = this.label2.Text;
            if (strLabel2.Length == 0)
            {
                this.label2.Text = strLabel1;
            }
            else
            {
                char action = strLabel1[0];
                numLabel2 = double.Parse(strLabel2);
                if (action == '*')
                {
                    strLabel1 = strLabel1.Remove(0, 1);
                    numLabel1 = double.Parse(strLabel1);
                    string result = Convert.ToString(numLabel2 * numLabel1);
                    this.label2.Text = result;
                }
                else if (action == '/')
                {
                    strLabel1 = strLabel1.Remove(0, 1);
                    numLabel1 = double.Parse(strLabel1);
                    string result = Convert.ToString(numLabel2 / numLabel1);
                    this.label2.Text = result;
                }
                else if (action == '-')
                {
                    strLabel1 = strLabel1.Remove(0, 1);
                    numLabel1 = double.Parse(strLabel1);
                    string result = Convert.ToString(numLabel2 - numLabel1);
                    this.label2.Text = result; ;
                }
                else if (action == '+')
                {
                    strLabel1 = strLabel1.Remove(0, 1);
                    numLabel1 = double.Parse(strLabel1);
                    string result = Convert.ToString(numLabel2 + numLabel1);
                    this.label2.Text = result;
                }
                else if (action == '^')
                {
                    strLabel1 = strLabel1.Remove(0, 1);
                    numLabel1 = double.Parse(strLabel1);
                    string result = Convert.ToString(Math.Pow(numLabel2, numLabel1));
                    this.label2.Text = result;
                }
            }
            this.label1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string strLabel1 = this.label1.Text;
            if (strLabel1.Length == 10 || strLabel1 == "")
            {
                return;
            }

            for (int i = 0; i < strLabel1.Length; i++)
            {
                if (strLabel1[i] == '.')
                {
                    return;
                }
            }
            if (strLabel1 == "" && strLabel1 != "")
            {
                this.label2.Text = ""; 
            }
            this.label1.Text = strLabel1 + this.button17.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (this.label1.Text == "" && this.label2.Text != "")
            {
                this.label2.Text = "";
            }
            this.label1.Text += this.button16.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double numLabel1, numLabel2;
            string strLabel1 = this.label1.Text;
            string strLabel2 = this.label2.Text;
            if (strLabel2.Length == 0)
            {
                this.label2.Text = strLabel1;
            }
            else
            {
                char action = strLabel1[0];
                numLabel2 = double.Parse(strLabel2);
                if (action == '*')
                {
                    strLabel1 = strLabel1.Remove(0, 1);
                    numLabel1 = double.Parse(strLabel1);
                    string result = Convert.ToString(numLabel2 * numLabel1);
                    this.label2.Text = result;
                }
                else if (action == '/')
                {
                    strLabel1 = strLabel1.Remove(0, 1);
                    numLabel1 = double.Parse(strLabel1);
                    string result = Convert.ToString(numLabel2 / numLabel1);
                    this.label2.Text = result;
                }
                else if (action == '-')
                {
                    strLabel1 = strLabel1.Remove(0, 1);
                    numLabel1 = double.Parse(strLabel1);
                    string result = Convert.ToString(numLabel2 - numLabel1);
                    this.label2.Text = result;
                }
                else if (action == '+')
                {
                    strLabel1 = strLabel1.Remove(0, 1);
                    numLabel1 = double.Parse(strLabel1);
                    string result = Convert.ToString(numLabel2 + numLabel1);
                    this.label2.Text = result;
                }
                else if (action == '^')
                {
                    strLabel1 = strLabel1.Remove(0, 1);
                    numLabel1 = double.Parse(strLabel1);
                    string result = Convert.ToString(Math.Pow(numLabel2, numLabel1));
                    this.label2.Text = result;
                }
            }
            this.label1.Text = this.button18.Text;
        }
    }
}
