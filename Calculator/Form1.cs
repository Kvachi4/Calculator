using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
           listBox1.Items.Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int btn1 = 1;
            listBox1.Items.Add(btn1);  
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int btn2 = 2;
            listBox1.Items.Add(btn2);
        }

        private void additionBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int btn3 = 3;
            listBox1.Items.Add(btn3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int btn4 = 4;
            listBox1.Items.Add(btn4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            int btn6 = 6;
            listBox1.Items.Add(btn6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            int btn7 = 7;
            listBox1.Items.Add(btn7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            int btn8 = 8;
            listBox1.Items.Add(btn8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            int btn9 = 9;
            listBox1.Items.Add(btn9);
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            int btnZero = 0;
            listBox1.Items.Add(btnZero);
        }

       
    }
}
