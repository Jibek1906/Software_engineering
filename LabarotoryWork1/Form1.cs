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

namespace LabarotoryWork1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            string Operation = textBox3.Text;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);

            switch (Operation)
            {
                case "+":
                    c = a + b;
                    break;
                case "-":
                    c = a - b;
                    break;
                case "*":
                    c = a * b;
                    break;
                case "/":
                    if (b != 0)
                    {
                        c = a / b;
                    }
                    else
                    {
                        textBox4.Text = "Error: Division by zero";
                        return; 
                    }
                    break;
                default:
                   
                    textBox4.Text = "Error: Invalid operation";
                    return;
            }

            textBox4.Text = c.ToString();
        }
    }
}
