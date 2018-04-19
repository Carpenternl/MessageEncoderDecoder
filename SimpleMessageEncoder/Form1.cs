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
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string[] Filetext = File.ReadAllLines(openFileDialog1.FileName);
            for (int i = 0; i < Filetext.Length; i++)
            {
                textBox1.Text += Filetext[i];
            }
        }

        private void encodeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string[] lines = textBox1.Lines;
            textBox1.Clear();
            File.WriteAllLines(saveFileDialog1.FileName, lines);
        }
    }
}
