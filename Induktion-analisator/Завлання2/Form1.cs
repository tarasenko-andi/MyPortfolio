using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Завлання2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == "")) || (textBox6.Text == "")))
            {
                double L1, L2, L3, L4, L5, n, F, m, b1, b2, b3, b4, b5, z1, z2, z3, z4, z5, I1, I2, I3, I4, I5, U, f;
                U = System.Convert.ToDouble(textBox6.Text);
                n = System.Convert.ToDouble(textBox1.Text);
                F = System.Convert.ToDouble(textBox2.Text);
                f = System.Convert.ToDouble(textBox3.Text);
                b1 = System.Convert.ToDouble(textBox4.Text);
                b2 = System.Convert.ToDouble(textBox5.Text);
                b3 = System.Convert.ToDouble(textBox7.Text);
                b4 = System.Convert.ToDouble(textBox8.Text);
                b5 = System.Convert.ToDouble(textBox9.Text);
                F = F / 1000000;

                L1 = ((Math.Pow(n, 2) * F * 1.02)) / b1;
                label3.Text = L1.ToString();
                L2 = ((Math.Pow(n, 2) * F * 1.02)) / b2;
                label28.Text = L2.ToString();
                L3 = ((Math.Pow(n, 2) * F * 1.02)) / b3;
                label32.Text = L3.ToString();
                L4 = ((Math.Pow(n, 2) * F * 1.02)) / b4;
                label36.Text = L4.ToString();
                L5 = ((Math.Pow(n, 2) * F * 1.02)) / b5;
                label27.Text = L5.ToString();

                z1 = 2 * Math.PI * f * L1;
                z1 = Math.Round(z1, 1);
                label7.Text = z1.ToString();

                z2 = 2 * Math.PI * f* L2;
                z2 = Math.Round(z2, 1);
                label29.Text = z2.ToString();

                z3 = 2 * Math.PI * f * L3;
                z3 = Math.Round(z3, 1);
                label33.Text = z3.ToString();

                z4 = 2 * Math.PI * f * L4;
                z4 = Math.Round(z4, 1);
                label37.Text = z4.ToString();

                z5 = 2 * Math.PI * f * L5;
                z5 = Math.Round(z5, 1);
                label31.Text = z5.ToString();

                I1 = U / z1;
                I1 = Math.Round(I1, 6);
                label10.Text = I1.ToString();
                
                I2 = U / z2;
                I2 = Math.Round(I2, 5);
                label30.Text = I2.ToString();
                
                I3 = U / z3;
                I3 = Math.Round(I3, 5);
                label34.Text = I3.ToString();
                
                I4 = U / z4;
                I4 = Math.Round(I4, 5);
                label38.Text = I4.ToString();
                
                I5 = U / z5;
                I5 = Math.Round(I5, 5);
                label35.Text = I5.ToString();
                

                
                    chart1.Series[0].Points.Clear(); // очищаємо графік
                    chart1.Series[0].Points.AddXY(b1, I1);

                    chart1.Series[1].Points.Clear();// очищаємо графік
                    chart1.Series[1].Points.AddXY(b2, I2);

                    chart1.Series[2].Points.Clear(); // очищаємо графік
                    chart1.Series[2].Points.AddXY(b3, I3);

                    chart1.Series[3].Points.Clear(); // очищаємо графік
                    chart1.Series[3].Points.AddXY(b4, I4);

                    chart1.Series[4].Points.Clear(); // очищаємо графік
                    chart1.Series[4].Points.AddXY(b5, I5);
               
             }

            else
            {
                MessageBox.Show("Помилка вихідних даних.\n" +
                    "Не введені необхідні дані.",
                    "Індуктивий датчик", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                if (!(e.KeyChar.ToString() == "," && textBox4.Text.IndexOf(",") == -1))
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

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для користування програмою введіть відповідні дані у відповідні поля.\nУ поля n=, F=, m=, b=, U= потрібноввести дані з таблиці данних заданої викладачем", "Як користуватися", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор програми Тарасенко Андрій Володимирович - студент Луцького Національного Технічного Університету. Тел:0666528167, Електронна пошта anditarasenko@gmail.com", "Про програму", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}