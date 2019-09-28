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
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.Items.Add("HUF");
            comboBox1.Items.Add("TRL");
            comboBox1.Items.Add("SGD");
            comboBox1.Items.Add("UAH");
            comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox2.Items.Add("HUF");
            comboBox2.Items.Add("TRL");
            comboBox2.Items.Add("SGD");
            comboBox2.Items.Add("UAH");
            button1.Enabled = true;
            comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox3.Items.Add("Re");
            comboBox3.Items.Add("K");
            comboBox3.Items.Add("F");
            comboBox3.Items.Add("С");
            comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox4.Items.Add("Re");
            comboBox4.Items.Add("K");
            comboBox4.Items.Add("F");
            comboBox4.Items.Add("С");
            button2.Enabled = true;
            comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox5.Items.Add("Kg");
            comboBox5.Items.Add("T");
            comboBox5.Items.Add("G");
            comboBox5.Items.Add("Mg");
            comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox6.Items.Add("Kg");
            comboBox6.Items.Add("T");
            comboBox6.Items.Add("G");
            comboBox6.Items.Add("Mg");
            button3.Enabled = true;
            comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox7.Items.Add("K2");
            comboBox7.Items.Add("Cm2");
            comboBox7.Items.Add("mm2");
            comboBox7.Items.Add("M2");
            comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox8.Items.Add("K2");
            comboBox8.Items.Add("Cm2");
            comboBox8.Items.Add("mm2");
            comboBox8.Items.Add("M2");
            button4.Enabled = true;
        }
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                if (!(e.KeyChar.ToString() == "," && textBox1.Text.IndexOf(",") == -1))
                {
                    e.Handled = true;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            double HUF = 41.3947 / 1000;
            double TRL = 420.9677 / 100;
            double SGD = 731.1053 / 100;
            double result = 0;
            try
            {
                result = Convert.ToSingle(textBox1.Text);
                if (!(comboBox1.SelectedIndex == comboBox2.SelectedIndex))
                {
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0: result = result * HUF; break;
                        case 1: result = result * TRL; break;
                        case 2: result = result * SGD; break;
                    }
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0: result = result / HUF; break;
                        case 1: result = result / TRL; break;
                        case 2: result = result / SGD; break;
                    }
                }
                textBox2.Text = result.ToString();
            }
            catch
            {
                if ((textBox1.Text == "") || (textBox2.Text == ""))
                {
                    MessageBox.Show("Помика вихідних данних.\n" +
                        "Потрібно ввести дані в обидва поля.",
                        "Конвертер", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Помилка вихідних данних.\n" +
                        "Неправильнийформат данних в  одному з полів",
                        "Конвертер", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            double result = 0;
            double K_С = 274.1;
            double Re_С = 0.8;
          
            try{
            result = Convert.ToSingle(textBox3.Text);
            if (!(comboBox3.SelectedIndex == comboBox4.SelectedIndex))
            {
                switch (comboBox3.SelectedIndex)
                {
                    case 0: result = result * Re_С; break;
                    case 1: result = result + K_С; break;
                    case 2: result = (result - 32) * 5 / 9; break;

                }
                switch (comboBox4.SelectedIndex)
                {
                    case 2: result = 32+ result * 9 / 5; break;
                    case 1: result = result - K_С; break;
                    case 0: result = result / Re_С; break;
                }
            }
            textBox4.Text = result.ToString();
        }
            catch
            {
                if ((textBox1.Text == "") || (textBox2.Text == ""))
                {
                    MessageBox.Show("Помика вихідних данних.\n" +
                        "Потрібно ввести дані в обидва поля.",
                        "Конвертер", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Помилка вихідних данних.\n" +
                        "Неправильнийформат данних в  одному з полів",
                        "Конвертер", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double K = 1;
            double T = 1000;
            double Gm = 0.001;
            double Mg = 0.000001;
            double result = 0;
            try
            {
                result = Convert.ToSingle(textBox6.Text);
                if (!(comboBox5.SelectedIndex == comboBox6.SelectedIndex))
                {
                    switch (comboBox5.SelectedIndex)
                    {
                        case 0: result = result * K; break;
                        case 1: result = result * T; break;
                        case 2: result = result * Gm; break;
                        case 3: result = result * Mg; break;
                    }
                    switch (comboBox6.SelectedIndex)
                    {
                        case 0: result = result / K; break;
                        case 1: result = result / T; break;
                        case 2: result = result / Gm; break;
                        case 3: result = result / Mg; break;

                    }



                }                   
                
            }
            catch
            {
                if ((textBox1.Text == "") || (textBox2.Text == ""))
                {
                    MessageBox.Show("Помика вихідних данних.\n" +
                        "Потрібно ввести дані в обидва поля.",
                        "Конвертер", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Помилка вихідних данних.\n" +
                        "Неправильнийформат данних в  одному з полів",
                        "Конвертер", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            textBox5.Text = result.ToString();
        }


        private void button4_Click(object sender, EventArgs e)
        {
          //  double M2 = 1;
            double K2 = 1000000;
            double Cm2 = 0.0001;
            double mm2 = 0.000001;
            double result = 0;
            try
            {
                result = Convert.ToSingle(textBox7.Text);
                if (!(comboBox7.SelectedIndex == comboBox8.SelectedIndex))
                {
                    switch (comboBox8.SelectedIndex)
                    {
                        case 0: result = result * K2; break;
                        case 1: result = result * Cm2; break;
                        case 2: result = result * mm2; break;
                     //   case 3: result = result * M2; break;
                    }
                    switch (comboBox7.SelectedIndex)
                    {
                        case 0: result = result / K2; break;
                        case 1: result = result / Cm2; break;
                        case 2: result = result / mm2; break;
                 //     case 3: result = result / M2; break;

                    }
                } 
                textBox8.Text = result.ToString();
            }
            catch
            {
                if ((textBox1.Text == "") || (textBox2.Text == ""))
                {
                    MessageBox.Show("Помика вихідних данних.\n" +
                        "Потрібно ввести дані в обидва поля.",
                        "Конвертер", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Помилка вихідних данних.\n" +
                        "Неправильнийформат данних в  одному з полів",
                        "Конвертер", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void авторПрограмиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор програми Тарасенко Андрій Володимирович 2014", "Заголовок",
MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

        private void закритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }     
    }
}