using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }

            public char i;
            public double num1, num2, num3;
            public double memory = 0;
        

        //
        void symbol(object sender)
            {
                Button btn = (Button)sender;
                i = Convert.ToChar(btn.Text);
                num1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
            }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
                textBox1.Text += 7;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
                textBox1.Text += 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
                textBox1.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
                textBox1.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
                textBox1.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
                textBox1.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
                textBox1.Text += 6;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
                textBox1.Text += 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0,";
            }
            else
            {
                textBox1.Text += ",";
            }
            button11.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
                textBox1.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
                textBox1.Text += 9;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                TextBox tb = (TextBox)sender;
                if (e.KeyChar != ',' || tb.Text.IndexOf(",") != -1)
                {
                    e.Handled = true;
                }
            }
            double a;
            a = double.Parse(textBox1.Text);
            if(a%1>0)
            {
                button11.Enabled = false;
            }
            else
            {
                button11.Enabled = true;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                double a;
                a = double.Parse(textBox1.Text);
                textBox1.Text = (a * (-1)).ToString();
            }
            else
            {
                textBox1.Text = "0";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            symbol(sender);
            button11.Enabled = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            symbol(sender);
            button11.Enabled = true;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            symbol(sender);
            button11.Enabled = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            symbol(sender);
            button11.Enabled = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case '+':
                    num2 = double.Parse(textBox1.Text);
                    num3 = num1 + num2;
                    textBox1.Text = num3.ToString();
                    break;
                case '-':
                    num2 = double.Parse(textBox1.Text);
                    num3 = num1 - num2;
                    textBox1.Text = num3.ToString();
                    break;
                case '/':
                    num2 = double.Parse(textBox1.Text);
                    num3 = num1 / num2;
                    textBox1.Text = num3.ToString();
                    break;
                case '*':
                    num2 = double.Parse(textBox1.Text);
                    num3 = num1 * num2;
                    textBox1.Text = num3.ToString();
                    break;
                case '^':
                    num2 = double.Parse(textBox1.Text);
                    num3 = Math.Pow(num1, num2);
                    textBox1.Text = num3.ToString();
                    break;
            }
            double a;
            a=double.Parse(textBox1.Text);
            if (a % 1 > 0)
            {
                button11.Enabled = false;
            }
            else 
            {
                button11.Enabled = true;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            symbol(sender);
            button11.Enabled = true; 
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void закритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            button11.Enabled = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
                {
                    double a;
                    a = double.Parse(textBox1.Text);
                    textBox1.Text = (a * (-1)).ToString();
                }
                else
                {
                    textBox1.Text = "0";
                          
            }
            
        }

        private void авторПрограмиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор програми Тарасенко Андрій Володимирович 2014", "Заголовок",
MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
