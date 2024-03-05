using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    

    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Focus();         

        }
    
      
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.Title = "Saving files...";

            save.Filter = "Arquivo de texto(*.txt) | *.txt";

            if(save.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            using (StreamWriter writer = new StreamWriter(save.FileName, false))
            {
                writer.WriteLine(richTextBox1.Text);
            }

            
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                OpenFileDialog open = new OpenFileDialog();
                open.Title = "Selecting file...";
                open.Filter = "File of text (*.txt)| *.txt";

            if (open.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

                richTextBox1.Text = File.ReadAllText(open.FileName);
            

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();

            richTextBox1.Font = fontDialog.Font;
        }

        private void colorFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();

            richTextBox1.ForeColor = colorDialog.Color;

           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;
                richTextBox1.BackColor = this.BackColor;
                richTextBox1.ForeColor = this.ForeColor;
                btnClear.BackColor = this.BackColor;
                btnClear.ForeColor = this.ForeColor;
                menuStrip1.BackColor = this.BackColor;
                menuStrip1.ForeColor = this.ForeColor;
            }
            else if(!checkBox1.Checked)
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                richTextBox1.BackColor = this.BackColor;
                richTextBox1.ForeColor = this.ForeColor;
                btnClear.BackColor = this.BackColor;
                btnClear.ForeColor = this.ForeColor;
                menuStrip1.BackColor = this.BackColor;
                menuStrip1.ForeColor = this.ForeColor;
            }
            
        }
    }
}
