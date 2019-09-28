using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private string fn = string.Empty;
        private bool docChanged = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Font font = fontDialog1.Font;
                this.richTextBox1.Font = font;
            }

        }

        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = string.Empty;
            if (openFileDialog1.ShowDialog() ==
                DialogResult.OK)
            {
                fn = openFileDialog1.FileName;
                this.Text = fn;
                try
                {
                    System.IO.StreamReader sr =
                        new System.IO.StreamReader(fn);
                    textBox1.Text = sr.ReadToEnd();
                    textBox1.SelectionStart = textBox1.TextLength;
                    sr.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Помилка файлу .\n" + exc.ToString(), "MEdit",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);


                }
            }

        }

        private int SaveDocument()
        {
            int result = 0;
            if (fn == string.Empty)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fn = saveFileDialog1.FileName;
                    this.Text = fn;
                }
                else result = -1;
            }
            if (fn != string.Empty)
            {
                try
                {
                    System.IO.FileInfo fi =
                        new System.IO.FileInfo(fn);
                    System.IO.StreamWriter sw = fi.CreateText();
                    sw.Write(textBox1.Text);
                    sw.Close();
                    result = 0;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString(), "NkEdit",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            return result;
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }


        private int SaveAsDocument()
        {
            int result = 0;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fn = saveFileDialog1.FileName;
                this.Text = fn;
            }
            else result = -1;
            if (fn != string.Empty)
            {
                try
                {
                    System.IO.FileInfo fi =
                        new System.IO.FileInfo(fn);
                    System.IO.StreamWriter sw = fi.CreateText();
                    sw.Write(textBox1.Text);
                    sw.Close();
                    result = 0;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString(), "NkEdit",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            return result;
        }

        private void зберегтиЯкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsDocument();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            docChanged = true;
        }

        private void новийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (docChanged)
            {
                DialogResult dr;
                dr = MessageBox.Show(
                    "Зберегти зміни?", "РЕдактор тексту",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);
                switch (dr)
                {
                    case DialogResult.Yes:
                        if (SaveDocument() == 0)
                        {
                            textBox1.Clear();
                            docChanged = false;
                        }
                        break;
                    case DialogResult.No:
                        textBox1.Clear();
                        docChanged = false;
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
        }

        private void розробникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 about = new Form2();
            about.ShowDialog();
        }

        private void проПрограмуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 about = new Form3();
            about.ShowDialog();
        }

        private void вставитиТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1 + Clipboard.GetText();
        }

        private void редагуватиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void виділитиВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void копіюватиВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }

        private void вирізатиВесьТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
            textBox1.Clear();
        }

        private void вирізатиВиділенеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText.Length > 0)
                textBox1.Cut();
        }

        private void копіюватиВиділенеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText.Length > 0)
                textBox1.Cut();
        }

        

        private void fffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s;
            s = richTextBox1.Text;
            string[] w = s.Split('.');
            richTextBox1.Clear();
            foreach (string s1 in w)
            {
                richTextBox1.AppendText(s1 + "." + "\n");
            }
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
       
            
        
    


        
        

        


