using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Calculator : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;
                       
        public Calculator()
        {
            InitializeComponent();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        { 
             textBox1.Clear(); 
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
                     
                textBox1.Text.Remove(textBox1.Text.Length - 1, 1);           
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            StringBuilder inputTextString = new StringBuilder(textBox1.Text);
            inputTextString.Append(btn1.Text.ToString());
            this.textBox1.Text = inputTextString.ToString();
            input = "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            StringBuilder inputTextString = new StringBuilder(textBox1.Text);                                 
            inputTextString.Append(btn2.Text.ToString());
            this.textBox1.Text = inputTextString.ToString();
            input = "2";
        }

        private void additionBtn_Click(object sender, EventArgs e)
        {
            StringBuilder inputTextString = new StringBuilder(textBox1.Text);
            inputTextString.Append(additionBtn.Text.ToString());
            textBox1.Text = inputTextString.ToString();
            operand1 = input;
            operation = '+';
            
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            StringBuilder inputTextString = new StringBuilder(textBox1.Text);    
            inputTextString.Append(btn3.Text.ToString());
            this.textBox1.Text = inputTextString.ToString();
            input = "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            StringBuilder inputTextString = new StringBuilder(textBox1.Text);           
            inputTextString.Append(btn4.Text.ToString());
            this.textBox1.Text = inputTextString.ToString();
            input = "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {            
            StringBuilder inputTextString = new StringBuilder(textBox1.Text);
            inputTextString.Append(btn5.Text.ToString());
            this.textBox1.Text = inputTextString.ToString();
            input = "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            StringBuilder inputTextString = new StringBuilder(textBox1.Text);
            inputTextString.Append(btn6.Text.ToString());
            this.textBox1.Text = inputTextString.ToString();
            input = "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            StringBuilder inputTextString = new StringBuilder(textBox1.Text);
            inputTextString.Append(btn7.Text.ToString());
            this.textBox1.Text = inputTextString.ToString();
            input = "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            StringBuilder inputTextString = new StringBuilder(textBox1.Text);
            inputTextString.Append(btn8.Text.ToString());
            this.textBox1.Text = inputTextString.ToString();
            input = "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {           
            StringBuilder inputTextString = new StringBuilder(textBox1.Text);                
            inputTextString.Append(btn9.Text.ToString());
            this.textBox1.Text = inputTextString.ToString();
            input = "9";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {          
            StringBuilder inputTextString = new StringBuilder(textBox1.Text);        
            inputTextString.Append(btnZero.Text.ToString());
            this.textBox1.Text = inputTextString.ToString();
            input = "0";
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            //StringBuilder inputTextString = new StringBuilder(textBox1.Text);
            

            operand2 = input;
            double n1 = 0.0, n2 = 0.0; 
            double.TryParse(operand1, out n1); 
            double.TryParse(operand2, out n2);
            

            if (operation == '+')
            {
                result = n1 + n2;
                textBox1.Text = result.ToString();
            }
            if (operation == '-')
            {
                result = n1 - n2;
                textBox1.Text = result.ToString();
            }
            if (operation == '/')
            {
                result = n1 / n2;
                textBox1.Text = result.ToString();
            }
            if (operation == '*')
            {
                result = n1 * n2;
                textBox1.Text = result.ToString();
            }
            if (operation == '%')
            {
                result = n1 % n2;
                textBox1.Text = result.ToString();
            }

        }

        private void subtractionBtn_Click(object sender, EventArgs e)
        {
            StringBuilder inputTextString = new StringBuilder(textBox1.Text);
            inputTextString.Append(subtractionBtn.Text.ToString());
            textBox1.Text = inputTextString.ToString();
            operand1 = input;
            operation = '-';
        }

        private void multiplicationBtn_Click(object sender, EventArgs e)
        {
            StringBuilder inputTextString = new StringBuilder(textBox1.Text);
            inputTextString.Append(multiplicationBtn.Text.ToString());
            textBox1.Text = inputTextString.ToString();
            operand1 = input;
            operation = '*';
        }

        private void divisionBtn_Click(object sender, EventArgs e)
        {
            StringBuilder inputTextString = new StringBuilder(textBox1.Text);
            inputTextString.Append(divisionBtn.Text.ToString());
            textBox1.Text = inputTextString.ToString();
            operand1 = input;
            operation = '/';
        }

        private void remainderBtn_Click(object sender, EventArgs e)
        {
            StringBuilder inputTextString = new StringBuilder(textBox1.Text);
            inputTextString.Append(remainderBtn.Text.ToString());
            textBox1.Text = inputTextString.ToString();
            operand1 = input;
            operation = '%';
        }

       
    }
}
