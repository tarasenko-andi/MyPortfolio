using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Green_Caper
{
    public partial class Green_Caper : Form
    {
        public Green_Caper()
        {
            InitializeComponent();
        }

        private void Green_Caper_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                if (!(e.KeyChar.ToString() == "," && textBox1.Text.IndexOf(",") == -1))
                {
                    e.Handled = true;
                }
            }
        }
        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                if (!(e.KeyChar.ToString() == "," && textBox2.Text.IndexOf(",") == -1))
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox4_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                if (!(e.KeyChar.ToString() == "," && textBox4.Text.IndexOf(",") == -1))
                {
                    e.Handled = true;
                }
            }
        }

        private void закритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void проАвтораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор програми Тарасенко Андрій Володимирович", "Про програму", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void правилаКористуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Програма призначена для підрахунку першої ставки і ставки, яка іде після програної, з розрахунком на кофіцієнт частини банку, яку хоче виграти користувач.","Про програму", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double k, suma, k2, vsv, suma2;

            try
            {
                k = System.Convert.ToDouble(textBox1.Text);
                suma = System.Convert.ToDouble(textBox2.Text);
                k2 = System.Convert.ToDouble(textBox4.Text);

                if (k >= 1.1 & k2 <= 0.5 & k2 >= 0)
                {

                    vsv = (suma + k2 * suma) / (1 - 1 / k - 1 / k * k2);
                    suma2 = vsv / k;

                    label6.Text = suma2.ToString();
                    label8.Text = vsv.ToString();
                }
                else
                    MessageBox.Show("Помилка вихідних даних.\n" +
                        "Введені дані не відповідають формату.",
                        "Green Caper", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            catch
            {
                if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox4.Text == ""))
                    MessageBox.Show("Помилка вихідних даних.\n" +
                            "Потрібно ввести данні в усі поля.",
                            "Green Caper", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double k, suma, k2, ps;

            try
            {
                k = System.Convert.ToDouble(textBox5.Text);
                suma = System.Convert.ToDouble(textBox3.Text);
                k2 = System.Convert.ToDouble(textBox6.Text);

                if (k >= 1.1 & k2 >= 0)
                {

                    ps = (suma+(suma*k2)) / k;
                    
                    label17.Text = ps.ToString();
                    textBox2.Text = ps.ToString();
                    textBox8.Text = ps.ToString();
                }
                else
                    MessageBox.Show("Помилка вихідних даних.\n" +
                        "Введені дані не відповідають формату.",
                        "Green Caper", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            catch
            {
                if ((textBox3.Text == "") || (textBox5.Text == "") || (textBox6.Text == ""))
                    MessageBox.Show("Помилка вихідних даних.\n" +
                            "Потрібно ввести данні в усі поля.",
                            "Green Caper", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                if (!(e.KeyChar.ToString() == "," && textBox5.Text.IndexOf(",") == -1))
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                if (!(e.KeyChar.ToString() == "," && textBox3.Text.IndexOf(",") == -1))
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                if (!(e.KeyChar.ToString() == "," && textBox6.Text.IndexOf(",") == -1))
                {
                    e.Handled = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double k, suma, suma2, vsv;

            try
            {
                k = System.Convert.ToDouble(textBox7.Text);
                suma = System.Convert.ToDouble(textBox8.Text);
                suma2 = System.Convert.ToDouble(textBox9.Text);

                if (k >= 1.1)
                {

                    vsv = (suma + suma2) / k;
                    
                    label25.Text = vsv.ToString();
                }
                else
                    MessageBox.Show("Помилка вихідних даних.\n" +
                        "Введені дані не відповідають формату.",
                        "Green Caper", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            catch
            {
                if ((textBox7.Text == "") || (textBox8.Text == "") || (textBox9.Text == ""))
                    MessageBox.Show("Помилка вихідних даних.\n" +
                            "Потрібно ввести данні в усі поля.",
                            "Green Caper", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
        }
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                if (!(e.KeyChar.ToString() == "," && textBox7.Text.IndexOf(",") == -1))
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                if (!(e.KeyChar.ToString() == "," && textBox8.Text.IndexOf(",") == -1))
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                if (!(e.KeyChar.ToString() == "," && textBox9.Text.IndexOf(",") == -1))
                {
                    e.Handled = true;
                }
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void WebBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
