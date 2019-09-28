using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "")))
            {
                double Rt, T, B, R293R373, T2, a, Rtзад, S;
                R293R373 = System.Convert.ToDouble(textBox1.Text);
                B = 1365 * Math.Log10(R293R373);

                chart1.Series[0].Points.Clear(); // очищаємо графік
                for (T = 293; T <= 373; T += 1) // x = 12…30 з кроком 1
                {
                    Rt = B * Math.Exp((293 - T) / 13.5);
                    // додавання нової точки на графік
                    chart1.Series[0].Points.AddXY(T, Rt);
                }

                T2 = System.Convert.ToDouble(textBox2.Text);
                a = -B / T2;
                label2.Text = a.ToString();

                Rtзад = System.Convert.ToDouble(textBox2.Text);
                S = a * Rtзад;
                label14.Text = S.ToString();
            }
            else
            {
                MessageBox.Show("Помилка вихідних даних.\n" +
                    "Не введені дані в відповідні поля.",
                    "Характеристики терморезистора", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для користування програмою введіть відповідні дані у відповідні поля.\nУ поля R293/R373=, Tзад.=, Rtзад= потрібноввести дані з таблиці данних заданої викладачем", "Як користуватися", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор програми Тарасенко Андрій Володимирович - студент Луцького Національного Технічного Університету. Тел:0666528167, Електронна пошта anditarasenko@gmail.com", "Про програму", MessageBoxButtons.OK, MessageBoxIcon.Question);
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                if (!(e.KeyChar.ToString() == "," && textBox2.Text.IndexOf(",") == -1))
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
    }
}