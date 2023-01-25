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
            Button btn1 = (Button)sender;
            StringBuilder inputTextString = new StringBuilder(inputText.Text);
            if (!inputTextString[0].Equals('0'))
            {
                inputTextString.Append(btn1.Text.ToString());
                inputText.Text = inputTextString.ToString();
            }
            else
            {   
                inputTextString.Clear();
                inputTextString.Append(btn1.Text.ToString());
                inputText.Text = inputTextString.ToString();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button btn2 = (Button)sender;
            StringBuilder inputTextString = new StringBuilder(inputText.Text);
            if (!inputTextString[0].Equals('0'))
            {
                inputTextString.Append(btn2.Text.ToString());
                inputText.Text = inputTextString.ToString();
            }
            else
            {
                inputTextString.Clear();
                inputTextString.Append(btn2.Text.ToString());
                inputText.Text = inputTextString.ToString();
            }
        }

        private void additionBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button btn3 = (Button)sender;
            StringBuilder inputTextString = new StringBuilder(inputText.Text);
            if (!inputTextString[0].Equals('0'))
            {
                inputTextString.Append(btn3.Text.ToString());
                inputText.Text = inputTextString.ToString();
            }
            else
            {
                inputTextString.Clear();
                inputTextString.Append(btn3.Text.ToString());
                inputText.Text = inputTextString.ToString();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button btn4 = (Button)sender;
            StringBuilder inputTextString = new StringBuilder(inputText.Text);
            if (!inputTextString[0].Equals('0'))
            {
                inputTextString.Append(btn4.Text.ToString());
                inputText.Text = inputTextString.ToString();
            }
            else
            {
                inputTextString.Clear();
                inputTextString.Append(btn4.Text.ToString());
                inputText.Text = inputTextString.ToString();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button btn5 = (Button)sender;
            StringBuilder inputTextString = new StringBuilder(inputText.Text);
            if (!inputTextString[0].Equals('0'))
            {
                inputTextString.Append(btn5.Text.ToString());
                inputText.Text = inputTextString.ToString();
            }
            else
            {
                inputTextString.Clear();
                inputTextString.Append(btn5.Text.ToString());
                inputText.Text = inputTextString.ToString();
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button btn6 = (Button)sender;
            StringBuilder inputTextString = new StringBuilder(inputText.Text);
            if (!inputTextString[0].Equals('0'))
            {
                inputTextString.Append(btn6.Text.ToString());
                inputText.Text = inputTextString.ToString();
            }
            else
            {
                inputTextString.Clear();
                inputTextString.Append(btn6.Text.ToString());
                inputText.Text = inputTextString.ToString();
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button btn7 = (Button)sender;
            StringBuilder inputTextString = new StringBuilder(inputText.Text);
            if (!inputTextString[0].Equals('0'))
            {
                inputTextString.Append(btn7.Text.ToString());
                inputText.Text = inputTextString.ToString();
            }
            else
            {
                inputTextString.Clear();
                inputTextString.Append(btn7.Text.ToString());
                inputText.Text = inputTextString.ToString();
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button btn8 = (Button)sender;
            StringBuilder inputTextString = new StringBuilder(inputText.Text);
            if (!inputTextString[0].Equals('0'))
            {
                inputTextString.Append(btn8.Text.ToString());
                inputText.Text = inputTextString.ToString();
            }
            else
            {
                inputTextString.Clear();
                inputTextString.Append(btn8.Text.ToString());
                inputText.Text = inputTextString.ToString();
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button btn9 = (Button)sender;
            StringBuilder inputTextString = new StringBuilder(inputText.Text);
            if (!inputTextString[0].Equals('0'))
            {
                inputTextString.Append(btn9.Text.ToString());
                inputText.Text = inputTextString.ToString();
            }
            else
            {
                inputTextString.Clear();
                inputTextString.Append(btn9.Text.ToString());
                inputText.Text = inputTextString.ToString();
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            Button btnZero = (Button)sender;
            StringBuilder inputTextString = new StringBuilder(inputText.Text);
            if (!inputTextString[0].Equals('0'))
            {
                inputTextString.Append(btnZero.Text.ToString());
                inputText.Text = inputTextString.ToString();
            }
            else
            {
                inputTextString.Clear();
                inputTextString.Append(btnZero.Text.ToString());
                inputText.Text = inputTextString.ToString();
            }
        }

       
    }
}
