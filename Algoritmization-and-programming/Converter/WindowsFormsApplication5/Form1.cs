using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((textBox1.Text != ",") &&
                (textBox1.TextLength > 0) &&
                (comboBox2.SelectedIndex != -1)
                )
                button1.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (
                (textBox1.Text !=",")      &&
                (textBox1.Text.Length > 0) &&
                (textBox1.SelectedIndex != -1) &&
                (textBox2.SelectedIndex != -1)
                )
                button1.Enabled = true;
            else button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double USD_UA = 9;
            double EUR_UA = 11;
            double result = 0;
            result = Convert.ToSingle(textBox1.Text);
            if (!(comboBox2.SelectedIndex == comboBox2.SelectedIndex)
            {switch (comboBox1.SelectedIndex)
            {
                case 0: result = result*USD_UA; break;
                case 2: result = result*EUR_UA ; break;
             }
                switch (comboBox2.SelectedIndex)
                {
                     case 0: result = result*USD_UA; break;
                     case 2: result = result*EUR_UA ; break; 
                }
             }
            textBox2.Text = result.ToString();
        }
       private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.Items.Add("USD");
            comboBox1.Items.Add("UAH");
            comboBox1.Items.Add("EUR");
            comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox2.Items.Add("USD");
            comboBox2.Items.Add("UAH");
            comboBox2.Items.Add("EUR");
            button1.Enabled = false;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                if (!(e.KeyChar.ToString() == "," && textBox1.Text.IndexOf(",") == -1))
                {
                    e.Handled = true;
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((textBox1.Text != ",") &&
                (textBox1.TextLength > 0) &&
                (comboBox1.SelectedIndex != -1)
                )
                button1.Enabled = true;
        }
    }

}