using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace shutdown
{
    public partial class Form1 : Form
    {
        public int a;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a = Int32.Parse(textBox1.Text);
            }
            finally
            {
                if (checkedListBox1.SelectedIndex == 0)
                {
                    System.Diagnostics.Process.Start("cmd.exe", "/c shutdown /s /t " + a);
                }
                if (checkedListBox1.SelectedIndex == 1)
                {
                    System.Diagnostics.Process.Start("cmd.exe", "/c shutdown /s /t " + a * 60);
                }
                if (checkedListBox1.SelectedIndex == 2)
                {
                    System.Diagnostics.Process.Start("cmd.exe", "/c shutdown /s /t " + a * 3600);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
