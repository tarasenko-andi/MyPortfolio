using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ХрестикиНол1к1
{
    public partial class Form1 : Form
    {
        int[] Mass = new int[9];
        int Flag;
        Image img = Image.FromFile("p.png");
        Image img1 = Image.FromFile("x.gif");
        Image img2 = Image.FromFile("o.gif");

        public Form1()
        {
            InitializeComponent();
        }

        private void гравціToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            textBox2.Visible = true;
            button2.Visible = false;
            button1.Visible = true;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            label1.Text = "Введіть ім'я 1-го гравця";
            label2.Text = "Введіть ім'я 2-го гравця";
        }

        private void закритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Check()
        {
            if ((Mass[0] ==1 && Mass[1]==1 && Mass[2]==1) || (Mass[0] ==2&& Mass[1]==2&&Mass[2]==2))
            {
                if (Mass[0] == 1)
                {
                 //   winner = Mass[0];
                    pictureBox10.Visible = true;
                    DialogResult result = MessageBox.Show("Гравець:" + textBox1.Text + " переміг Гравця:" + textBox2.Text + "\n" + "Бажаєте повторити?", "Вітаю з перемогою!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.No) //Если нажал нет
                    {
                        panel2.Visible = true;
                        pictureBox10.Visible = false;
                    }

                    if (result == DialogResult.Yes) //Если нажал Да
                    {
                        pictureBox1.Image = img;
                        pictureBox2.Image = img;
                        pictureBox3.Image = img;
                        pictureBox4.Image = img;
                        pictureBox5.Image = img;
                        pictureBox6.Image = img;
                        pictureBox7.Image = img;
                        pictureBox8.Image = img;
                        pictureBox9.Image = img;
                        Flag = 1;
                        for (int i = 0; i < 9; i++)
                            Mass[i] = 0;
                        pictureBox10.Visible = false;
                    }
                }
                if (Mass[0] == 2)
                {
                    pictureBox10.Visible = true;
                    DialogResult result = MessageBox.Show("Гравець:" + textBox2.Text + " переміг Гравця:" + textBox1.Text + "\n" + "Бажаєте повторити?", "Вітаю з перемогою!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.No) //Если нажал нет
                    {
                        panel2.Visible = true;
                    }

                    if (result == DialogResult.Yes) //Если нажал Да
                    {
                        pictureBox1.Image = img;
                        pictureBox2.Image = img;
                        pictureBox3.Image = img;
                        pictureBox4.Image = img;
                        pictureBox5.Image = img;
                        pictureBox6.Image = img;
                        pictureBox7.Image = img;
                        pictureBox8.Image = img;
                        pictureBox9.Image = img;
                        Flag = 1;
                        for (int i = 0; i < 9; i++)
                            Mass[i] = 0;
                    }
                }
            }
            if ((Mass[0] == 1 && Mass[4] == 1 && Mass[8] == 1) || (Mass[0] == 2 && Mass[4] == 2 && Mass[8] == 2))
            {
                if (Mass[0] == 1)
                {
                    pictureBox11.Visible = true;
                    DialogResult result = MessageBox.Show("Гравець:" + textBox1.Text + " переміг Гравця:" + textBox2.Text + "\n" + "Бажаєте повторити?", "Вітаю з перемогою!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.No) //Если нажал нет
                    {
                        panel2.Visible = true;
                    }

                    if (result == DialogResult.Yes) //Если нажал Да
                    {
                        pictureBox1.Image = img;
                        pictureBox2.Image = img;
                        pictureBox3.Image = img;
                        pictureBox4.Image = img;
                        pictureBox5.Image = img;
                        pictureBox6.Image = img;
                        pictureBox7.Image = img;
                        pictureBox8.Image = img;
                        pictureBox9.Image = img;
                        Flag = 1;
                        for (int i = 0; i < 9; i++)
                            Mass[i] = 0;
                    }
                }
                if (Mass[0] == 2)
                {
                    pictureBox11.Visible = true;
                    DialogResult result = MessageBox.Show("Гравець:" + textBox2.Text + " переміг Гравця:" + textBox1.Text + "\n" + "Бажаєте повторити?", "Вітаю з перемогою!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.No) //Если нажал нет
                    {
                        panel2.Visible = true;
                    }

                    if (result == DialogResult.Yes) //Если нажал Да
                    {
                        pictureBox1.Image = img;
                        pictureBox2.Image = img;
                        pictureBox3.Image = img;
                        pictureBox4.Image = img;
                        pictureBox5.Image = img;
                        pictureBox6.Image = img;
                        pictureBox7.Image = img;
                        pictureBox8.Image = img;
                        pictureBox9.Image = img;
                        Flag = 1;
                        for (int i = 0; i < 9; i++)
                            Mass[i] = 0;
                    }
                }
            }
            if ((Mass[0] == 1 && Mass[3] == 1 && Mass[6] == 1) || (Mass[0] == 2 && Mass[3] == 2 && Mass[6] == 2))
            {
                if (Mass[0] == 1)
                {
                    DialogResult result = MessageBox.Show("Гравець:" + textBox1.Text + " переміг Гравця:" + textBox2.Text + "\n" + "Бажаєте повторити?", "Вітаю з перемогою!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.No) //Если нажал нет
                    {
                        panel2.Visible = true;
                    }

                    if (result == DialogResult.Yes) //Если нажал Да
                    {
                        pictureBox1.Image = img;
                        pictureBox2.Image = img;
                        pictureBox3.Image = img;
                        pictureBox4.Image = img;
                        pictureBox5.Image = img;
                        pictureBox6.Image = img;
                        pictureBox7.Image = img;
                        pictureBox8.Image = img;
                        pictureBox9.Image = img;
                        Flag = 1;
                        for (int i = 0; i < 9; i++)
                            Mass[i] = 0;
                    }
                }
                if (Mass[0] == 2)
                {
                    DialogResult result = MessageBox.Show("Гравець:" + textBox2.Text + " переміг Гравця:" + textBox1.Text + "\n" + "Бажаєте повторити?", "Вітаю з перемогою!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.No) //Если нажал нет
                    {
                        panel2.Visible = true;
                    }

                    if (result == DialogResult.Yes) //Если нажал Да
                    {
                        pictureBox1.Image = img;
                        pictureBox2.Image = img;
                        pictureBox3.Image = img;
                        pictureBox4.Image = img;
                        pictureBox5.Image = img;
                        pictureBox6.Image = img;
                        pictureBox7.Image = img;
                        pictureBox8.Image = img;
                        pictureBox9.Image = img;
                        Flag = 1;
                        for (int i = 0; i < 9; i++)
                            Mass[i] = 0;
                    }
                }
            }
            if ((Mass[3] == 1 && Mass[4] == 1 && Mass[5] == 1) || (Mass[3] == 2 && Mass[4] == 2 && Mass[5] == 2))
            {
                if (Mass[3] == 1)
                {
                    DialogResult result = MessageBox.Show("Гравець:" + textBox1.Text + " переміг Гравця:" + textBox2.Text + "\n" + "Бажаєте повторити?", "Вітаю з перемогою!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.No) //Если нажал нет
                    {
                        panel2.Visible = true;
                    }

                    if (result == DialogResult.Yes) //Если нажал Да
                    {
                        pictureBox1.Image = img;
                        pictureBox2.Image = img;
                        pictureBox3.Image = img;
                        pictureBox4.Image = img;
                        pictureBox5.Image = img;
                        pictureBox6.Image = img;
                        pictureBox7.Image = img;
                        pictureBox8.Image = img;
                        pictureBox9.Image = img;
                        Flag = 1;
                        for (int i = 0; i < 9; i++)
                            Mass[i] = 0;
                    }
                }
                if (Mass[3] == 2)
                {
                    DialogResult result = MessageBox.Show("Гравець:" + textBox2.Text + " переміг Гравця:" + textBox1.Text + "\n" + "Бажаєте повторити?", "Вітаю з перемогою!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.No) //Если нажал нет
                    {
                        panel2.Visible = true;
                    }

                    if (result == DialogResult.Yes) //Если нажал Да
                    {
                        pictureBox1.Image = img;
                        pictureBox2.Image = img;
                        pictureBox3.Image = img;
                        pictureBox4.Image = img;
                        pictureBox5.Image = img;
                        pictureBox6.Image = img;
                        pictureBox7.Image = img;
                        pictureBox8.Image = img;
                        pictureBox9.Image = img;
                        Flag = 1;
                        for (int i = 0; i < 9; i++)
                            Mass[i] = 0;
                    }
                }
            }
            if ((Mass[6] == 1 && Mass[7] == 1 && Mass[8] == 1) || (Mass[6] == 2 && Mass[7] == 2 && Mass[8] == 2))
            {
                if (Mass[6] == 1)
                {
                    DialogResult result = MessageBox.Show("Гравець:" + textBox1.Text + " переміг Гравця:" + textBox2.Text + "\n" + "Бажаєте повторити?", "Вітаю з перемогою!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.No) //Если нажал нет
                    {
                        panel2.Visible = true;
                    }

                    if (result == DialogResult.Yes) //Если нажал Да
                    {
                        pictureBox1.Image = img;
                        pictureBox2.Image = img;
                        pictureBox3.Image = img;
                        pictureBox4.Image = img;
                        pictureBox5.Image = img;
                        pictureBox6.Image = img;
                        pictureBox7.Image = img;
                        pictureBox8.Image = img;
                        pictureBox9.Image = img;
                        Flag = 1;
                        for (int i = 0; i < 9; i++)
                            Mass[i] = 0;
                    }
                }
                if (Mass[6] == 2)
                {
                    DialogResult result = MessageBox.Show("Гравець:" + textBox2.Text + " переміг Гравця:" + textBox1.Text + "\n" + "Бажаєте повторити?", "Вітаю з перемогою!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.No) //Если нажал нет
                    {
                        panel2.Visible = true;
                    }

                    if (result == DialogResult.Yes) //Если нажал Да
                    {
                        pictureBox1.Image = img;
                        pictureBox2.Image = img;
                        pictureBox3.Image = img;
                        pictureBox4.Image = img;
                        pictureBox5.Image = img;
                        pictureBox6.Image = img;
                        pictureBox7.Image = img;
                        pictureBox8.Image = img;
                        pictureBox9.Image = img;
                        Flag = 1;
                        for (int i = 0; i < 9; i++)
                            Mass[i] = 0;
                    }
                }
            }
            if ((Mass[1] == 1 && Mass[4] == 1 && Mass[7] == 1) || (Mass[1] == 2 && Mass[4] == 2 && Mass[7] == 2))
            {
                if (Mass[1] == 1)
                {
                    DialogResult result = MessageBox.Show("Гравець:" + textBox1.Text + " переміг Гравця:" + textBox2.Text + "\n" + "Бажаєте повторити?", "Вітаю з перемогою!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.No) //Если нажал нет
                    {
                        panel2.Visible = true;
                    }

                    if (result == DialogResult.Yes) //Если нажал Да
                    {
                        pictureBox1.Image = img;
                        pictureBox2.Image = img;
                        pictureBox3.Image = img;
                        pictureBox4.Image = img;
                        pictureBox5.Image = img;
                        pictureBox6.Image = img;
                        pictureBox7.Image = img;
                        pictureBox8.Image = img;
                        pictureBox9.Image = img;
                        Flag = 1;
                        for (int i = 0; i < 9; i++)
                            Mass[i] = 0;
                    }
                }
                if (Mass[1] == 2)
                {
                    DialogResult result = MessageBox.Show("Гравець:" + textBox2.Text + " переміг Гравця:" + textBox1.Text + "\n" + "Бажаєте повторити?", "Вітаю з перемогою!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.No) //Если нажал нет
                    {
                        panel2.Visible = true;
                    }

                    if (result == DialogResult.Yes) //Если нажал Да
                    {
                        pictureBox1.Image = img;
                        pictureBox2.Image = img;
                        pictureBox3.Image = img;
                        pictureBox4.Image = img;
                        pictureBox5.Image = img;
                        pictureBox6.Image = img;
                        pictureBox7.Image = img;
                        pictureBox8.Image = img;
                        pictureBox9.Image = img;
                        Flag = 1;
                        for (int i = 0; i < 9; i++)
                            Mass[i] = 0;
                    }
                }
            }
            if ((Mass[2] == 1 && Mass[5] == 1 && Mass[8] == 1) || (Mass[2] == 2 && Mass[5] == 2 && Mass[8] == 2))
            {
                if (Mass[2] == 1)
                {
                    DialogResult result = MessageBox.Show("Гравець:" + textBox1.Text + " переміг Гравця:" + textBox2.Text + "\n" + "Бажаєте повторити?", "Вітаю з перемогою!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.No) //Если нажал нет
                    {
                        panel2.Visible = true;
                    }

                    if (result == DialogResult.Yes) //Если нажал Да
                    {
                        pictureBox1.Image = img;
                        pictureBox2.Image = img;
                        pictureBox3.Image = img;
                        pictureBox4.Image = img;
                        pictureBox5.Image = img;
                        pictureBox6.Image = img;
                        pictureBox7.Image = img;
                        pictureBox8.Image = img;
                        pictureBox9.Image = img;
                        Flag = 1;
                        for (int i = 0; i < 9; i++)
                            Mass[i] = 0;
                    }
                }
                if (Mass[2] == 2)
                {
                    DialogResult result = MessageBox.Show("Гравець:" + textBox2.Text + " переміг Гравця:" + textBox1.Text + "\n" + "Бажаєте повторити?", "Вітаю з перемогою!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.No) //Если нажал нет
                    {
                        panel2.Visible = true;
                    }

                    if (result == DialogResult.Yes) //Если нажал Да
                    {
                        pictureBox1.Image = img;
                        pictureBox2.Image = img;
                        pictureBox3.Image = img;
                        pictureBox4.Image = img;
                        pictureBox5.Image = img;
                        pictureBox6.Image = img;
                        pictureBox7.Image = img;
                        pictureBox8.Image = img;
                        pictureBox9.Image = img;
                        Flag = 1;
                        for (int i = 0; i < 9; i++)
                            Mass[i] = 0;
                    }
                }
            }
            if ((Mass[2] == 1 && Mass[4] == 1 && Mass[6] == 1) || (Mass[2] == 2 && Mass[4] == 2 && Mass[6] == 2))
            {
                if (Mass[2] == 1)
                {
                    DialogResult result = MessageBox.Show("Гравець:" + textBox1.Text + " переміг Гравця:" + textBox2.Text + "\n" + "Бажаєте повторити?", "Вітаю з перемогою!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.No) //Если нажал нет
                    {
                        panel2.Visible = true;
                    }

                    if (result == DialogResult.Yes) //Если нажал Да
                    {
                        pictureBox1.Image = img;
                        pictureBox2.Image = img;
                        pictureBox3.Image = img;
                        pictureBox4.Image = img;
                        pictureBox5.Image = img;
                        pictureBox6.Image = img;
                        pictureBox7.Image = img;
                        pictureBox8.Image = img;
                        pictureBox9.Image = img;
                        Flag = 1;
                        for (int i = 0; i < 9; i++)
                            Mass[i] = 0;
                    }
                }
                if (Mass[2] == 2)
                {
                    DialogResult result = MessageBox.Show("Гравець:" + textBox2.Text + " переміг Гравця:" + textBox1.Text + "\n" + "Бажаєте повторити?", "Вітаю з перемогою!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.No) //Если нажал нет
                    {
                        panel2.Visible = true;
                    }

                    if (result == DialogResult.Yes) //Если нажал Да
                    {
                        pictureBox1.Image = img;
                        pictureBox2.Image = img;
                        pictureBox3.Image = img;
                        pictureBox4.Image = img;
                        pictureBox5.Image = img;
                        pictureBox6.Image = img;
                        pictureBox7.Image = img;
                        pictureBox8.Image = img;
                        pictureBox9.Image = img;
                        Flag = 1;
                        for (int i = 0; i < 9; i++)
                            Mass[i] = 0;
                    }
                }
            }
            else 
                if(Mass[0]!=0&&Mass[1]!=0&&Mass[2]!=0&&Mass[3]!=0&&Mass[4]!=0&&Mass[5]!=0&&Mass[6]!=0&&Mass[7]!=0&&Mass[8]!=0)
            {
                DialogResult result = MessageBox.Show("Нічия" + "\n" + "Бажаєте повторити?", "Нічия", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.No) //Если нажал нет
                {
                    panel2.Visible = true;
                }

                if (result == DialogResult.Yes) //Если нажал Да
                {
                    pictureBox1.Image = img;
                    pictureBox2.Image = img;
                    pictureBox3.Image = img;
                    pictureBox4.Image = img;
                    pictureBox5.Image = img;
                    pictureBox6.Image = img;
                    pictureBox7.Image = img;
                    pictureBox8.Image = img;
                    pictureBox9.Image = img;
                    Flag = 1;
                    for (int i = 0; i < 9; i++)
                        Mass[i] = 0;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Flag == 1)
            {
                if (radioButton1.Checked) 
                { 
                    Flag = 3;
                    Mass[0] = 1;
                    pictureBox1.Image = img1;
                }
                label3.Text = "Ходить:" + textBox1.Text;
                if (Mass[0] == 0)
                {
                    
                    Flag = 2;
                    Mass[0] = 1;
                    pictureBox1.Image = img1;
                }
            }
            if(Flag==2)
            {
                label3.Text = "Ходить:" + textBox2.Text;
                if (Mass[0] == 0)
                {
                    Flag = 1;
                    Mass[0] = 2;
                    pictureBox1.Image = img2;
                }
            }
            Check();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           if (Flag == 1)
            {
                if (radioButton1.Checked)
                {
                    Flag = 3;
                    Mass[1] = 1;
                    pictureBox2.Image = img1;
                }
                label3.Text = "Ходить:" + textBox1.Text;
                if (Mass[1] == 0)
                {
                    Flag = 2;
                    Mass[1] = 1;
                    pictureBox2.Image = img1;
                }
            }
            if (Flag == 2)
            {
                label3.Text = "Ходить:" + textBox2.Text;
                if (Mass[1] == 0)
                {
                    Flag = 1;
                    Mass[1] = 2;
                    pictureBox2.Image = img2;
                }
            }
            Check();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Flag == 1)
            {
                label3.Text = "Ходить:" + textBox1.Text;
                if (Mass[2] == 0)
                {
                    Flag = 2;
                    Mass[2] = 1;
                    pictureBox3.Image = img1;
                }
            }
            if (Flag == 2)
            {
                label3.Text = "Ходить:" + textBox2.Text;
                if (Mass[2] == 0)
                {
                    Flag = 1;
                    Mass[2] = 2;
                    pictureBox3.Image = img2;
                }
            }
            Check();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (Flag == 1)
            {
                label3.Text = "Ходить:" + textBox1.Text;
                if (Mass[3] == 0)
                {
                    Flag = 2;
                    Mass[3] = 1;
                    pictureBox6.Image = img1;
                }
            }
            if (Flag == 2)
            {
                label3.Text = "Ходить:" + textBox2.Text;
                if (Mass[3] == 0)
                {
                    Flag = 1;
                    Mass[3] = 2;
                    pictureBox6.Image = img2;
                }
            }
            Check();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (Flag == 1)
            {    
                label3.Text = "Ходить:" + textBox2.Text;
                            if (Mass[4] == 0)
                {
                    Flag = 2;
                    Mass[4] = 1;
                    pictureBox5.Image = img1;
                }
            }
            if (Flag == 2)
            {
                label3.Text = "Ходить:" + textBox2.Text;
                if (Mass[4] == 0)
                {
                    Flag = 1;
                    Mass[4] = 2;
                    pictureBox5.Image = img2;
                }
            }
            Check();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (Flag == 1)
            {
                label3.Text = "Ходить:" + textBox1.Text;
                if (Mass[5] == 0)
                {
                    Flag = 2;
                    Mass[5] = 1;
                    pictureBox4.Image = img1;
                }
            }
            if (Flag == 2)
            {
                label3.Text = "Ходить:" + textBox2.Text;
                if (Mass[5] == 0)
                {
                    Flag = 1;
                    Mass[5] = 2;
                    pictureBox4.Image = img2;
                }
            }
            Check();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (Flag == 1)
            {
                label3.Text = "Ходить:" + textBox1.Text;
                if (Mass[6] == 0)
                {
                    Flag = 2;
                    Mass[6] = 1;
                    pictureBox9.Image = img1;
                }
            }
            if (Flag == 2)
            {
                label3.Text = "Ходить:" + textBox2.Text;
                if (Mass[6] == 0)
                {
                    Flag = 1;
                    Mass[6] = 2;
                    pictureBox9.Image = img2;
                }
            }
            Check();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (Flag == 1)
            {
                label3.Text = "Ходить:" + textBox1.Text;
                if (Mass[7] == 0)
                {
                    Flag = 2;
                    Mass[7] = 1;
                    pictureBox8.Image = img1;
                }
            }
            if (Flag == 2)
            {
                label3.Text = "Ходить:" + textBox2.Text;
                if (Mass[7] == 0)
                {
                    Flag = 1;
                    Mass[7] = 2;
                    pictureBox8.Image = img2;
                }
            }
            Check();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (Flag == 1)
            {
                label3.Text = "Ходить:" + textBox1.Text;
                if (Mass[8] == 0)
                {
                    Flag = 2;
                    Mass[8] = 1;
                    pictureBox7.Image = img1;
                }
            }
            if (Flag == 2)
            {
                label3.Text = "Ходить:" + textBox2.Text;
                if (Mass[8] == 0)
                {
                    Flag = 1;
                    Mass[8] = 2;
                    pictureBox7.Image = img2;
                }
            }
            Check();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = img;
            pictureBox2.Image = img;
            pictureBox3.Image = img;
            pictureBox4.Image = img;
            pictureBox5.Image = img;
            pictureBox6.Image = img;
            pictureBox7.Image = img;
            pictureBox8.Image = img;
            pictureBox9.Image = img;
        }

        private void гравецьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            textBox2.Visible = false;
            button2.Visible = true;
            button1.Visible = false;
            label1.Text = "Введіть ім'я гравця";
            label2.Text = "Виберіть рівень складності";
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = img;
            pictureBox2.Image = img;
            pictureBox3.Image = img;
            pictureBox4.Image = img;
            pictureBox5.Image = img;
            pictureBox6.Image = img;
            pictureBox7.Image = img;
            pictureBox8.Image = img;
            pictureBox9.Image = img;
            for (int i = 0; i < 9; i++)
                Mass[i] = 0;
            Flag = 1;
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = img;
            pictureBox2.Image = img;
            pictureBox3.Image = img;
            pictureBox4.Image = img;
            pictureBox5.Image = img;
            pictureBox6.Image = img;
            pictureBox7.Image = img;
            pictureBox8.Image = img;
            pictureBox9.Image = img;
            Flag = 1;
            for (int i = 0; i < 9; i++)
                Mass[i] = 0;
            panel1.Visible = false;
            label3.Text = "Ходить:" + textBox1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            textBox2.Visible = true;
            button2.Visible = false;
            button1.Visible = true;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            label1.Text = "Введіть ім'я 1-го гравця";
            label2.Text = "Введіть ім'я 2-го гравця";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
