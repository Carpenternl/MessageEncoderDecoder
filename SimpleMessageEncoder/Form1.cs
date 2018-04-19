using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleMessageEncoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void decodeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "textfiles (*.txt) |"; 
            openFileDialog1.ShowDialog();
            string[] Filetext = File.ReadAllLines(openFileDialog1.FileName);
            for (int i = 0; i < Filetext.Length; i++)
            {
                textBox1.Text += Filetext[i];
            }
        }
    }
}
