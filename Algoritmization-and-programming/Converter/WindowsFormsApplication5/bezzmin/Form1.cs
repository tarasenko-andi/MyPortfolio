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
            comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox2.Items.Add("HUF");
            comboBox2.Items.Add("TRL");
            comboBox2.Items.Add("SGD");
            button1.Enabled = true;
            comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox3.Items.Add("Re");
            comboBox3.Items.Add("K");
            comboBox3.Items.Add("F");
            comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox4.Items.Add("Re");
            comboBox4.Items.Add("K");
            comboBox4.Items.Add("F");
            button2.Enabled = true;
            comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox5.Items.Add("M");
            comboBox5.Items.Add("K");
            comboBox5.Items.Add("Cm");
            comboBox5.Items.Add("mm");
            comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox6.Items.Add("M");
            comboBox6.Items.Add("K");
            comboBox6.Items.Add("Cm");
            comboBox6.Items.Add("mm");
            button2.Enabled = true;
            comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox7.Items.Add("M2");
            comboBox7.Items.Add("K2");
            comboBox7.Items.Add("Cm2");
            comboBox7.Items.Add("mm2");
            comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox8.Items.Add("M2");
            comboBox8.Items.Add("K2");
            comboBox8.Items.Add("Cm2");
            comboBox8.Items.Add("mm2");
            button2.Enabled = true;
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
                        case 0: result = result * HUF; break;
                        case 1: result = result * TRL; break;
                        case 2: result = result * SGD; break;
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
            double F = 33.8;
            double K = 274.1;
            double Re = 0.8;
            double result = 0;
            try{
            result = Convert.ToSingle(textBox3.Text);
            if (!(comboBox3.SelectedIndex == comboBox4.SelectedIndex))
            {
                switch (comboBox3.SelectedIndex)
                {
                    case 0: result = result + F; break;
                    case 1: result = result + K; break;
                    case 2: result = result * Re; break;
                }
                switch (comboBox4.SelectedIndex)
                {
                    case 0: result = result + F; break;
                    case 1: result = result + K; break;
                    case 2: result = result * Re; break;
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
            if ((textBox3.Text != ",") &&
         (textBox3.TextLength > 0) &&
         (comboBox3.SelectedIndex != -1)
         )
                button2.Enabled = true;
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
            double M = 1;
            double K = 1000;
            double Cm = 0.01;
            double mm = 0.001;
            double result = 0;
            try
            {
                result = Convert.ToSingle(textBox6.Text);
                if (!(comboBox5.SelectedIndex == comboBox6.SelectedIndex))
                {
                    switch (comboBox5.SelectedIndex)
                    {
                        case 0: result = result * M; break;
                        case 1: result = result * K; break;
                        case 2: result = result * Cm; break;
                        case 3: result = result * mm; break;
                    }
                    switch (comboBox6.SelectedIndex)
                    {
                        case 0: result = result * M; break;
                        case 1: result = result * K; break;
                        case 2: result = result * Cm; break;
                        case 3: result = result * mm; break;

                    }


                    textBox5.Text = result.ToString();
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

        }


        private void button4_Click(object sender, EventArgs e)
        {
            double M2 = 1;
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
                        case 0: result = result * M2; break;
                        case 1: result = result * K2; break;
                        case 2: result = result * Cm2; break;
                        case 3: result = result * mm2; break;
                    }
                    switch (comboBox7.SelectedIndex)
                    {
                        case 0: result = result * M2; break;
                        case 1: result = result * K2; break;
                        case 2: result = result * Cm2; break;
                        case 3: result = result * mm2; break;

                    }


                    textBox8.Text = result.ToString();
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