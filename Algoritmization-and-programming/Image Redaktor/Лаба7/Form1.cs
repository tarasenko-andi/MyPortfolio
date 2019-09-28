using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Лаба7
{
    public partial class Form1 : Form
    {
        private Pen pen = new Pen(Color.Black);
        private Point startPT;
        private int mode;
        private Point movePt;
        private Point nullPt = new Point(int.MaxValue, 0);
        private SolidBrush brush = new SolidBrush(Color.White);
        private int figureMode;
        private bool equalSize;
        private Bitmap oldImage;
        private Font font;

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            pen.StartCap = pen.EndCap = LineCap.Round;
            pen.Alignment = PenAlignment.Inset;
            oldImage = new Bitmap(pictureBox1.Image);
            font = Font.Clone() as Font;
            toolStripComboBox1.SelectedIndex = 1;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            movePt = startPT = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (startPT == nullPt) return;

            switch (toolStripComboBox2.SelectedIndex)
            { 
                case 0:
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                g.DrawLine(pen, startPT, e.Location);
                g.Dispose();
                startPT = e.Location;
                pictureBox1.Invalidate();
            }
            break;
               
                default:
            break;
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int x;
            if (int.TryParse(toolStripComboBox1.Text, out x))
            {
                pen.Width = x;
            }
            else
            {
                pen.Width = 1;
            }
            
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ColorDialog cl = new ColorDialog();
            cl.ShowDialog();
            pen.Color = cl.Color;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (toolStripComboBox2.SelectedIndex)
            {
                case 1:
                    {
                        if (e.Button == MouseButtons.Left)
                        {
                            Graphics g1 = Graphics.FromImage(pictureBox1.Image);
                            g1.DrawLine(pen, startPT, e.Location);
                            g1.Dispose();
                            pictureBox1.Invalidate();
                        }
                    }
                    break;
                
                case 2:
                    {
                        if (e.Button == MouseButtons.Left)
                        {
                            Graphics g1 = Graphics.FromImage(pictureBox1.Image);
                            g1.DrawRectangle(pen, startPT.X, startPT.Y, e.Location.X - startPT.X, e.Location.Y - startPT.Y);
                            g1.Dispose();
                            pictureBox1.Invalidate();
                        }
                    }
                    break;
            }
        }
    }
}