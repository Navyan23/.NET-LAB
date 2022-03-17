using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wnapplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputString, revstr = "";
            int Length;
            inputString = txtInput.Text;
            Length = inputString.Length - 1;
            while (Length >= 0)
            {
                revstr = revstr + inputString[Length];
                Length--;
            }
            MessageBox.Show("Reverse String Is : " + revstr, "Result");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inputString;
            inputString = txtInput.Text;
            MessageBox.Show("The String After Trimming : " + inputString.Trim(), "Result");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string inputString;
            inputString = txtInput.Text;
            inputString = inputString.PadLeft(10, '*');
            inputString = inputString.PadRight(15, '*');
            MessageBox.Show("String After Padding : " + inputString, "Result");
        }

    }
}


