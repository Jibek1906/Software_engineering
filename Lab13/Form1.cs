using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private int index = 0;
        private int[] sum = { 2, 1, 1, 1, 2 };
        private string[] s = { "What is C#?", "What is an int?", "What is the foreach operator responsible for?", "How does the conditional if statement work?", "How does an int differ from a short data type?" };
        private string[,] value =
        {
            {"Programming language", "Data type", "DBMS", "This is the name of the processor"},
            {"Data type", "Programming language", "Loop operator", "Conditional operator"},
            {"This operator is a loop that is specially created for a collection", "Programming language", "Data type responsible for integers", "This operator is erroneous"},
            {"One of the branches", "Is executed in a loop", "Control statement", "Based on the condition"},
            {"Size of allocated memory", "Memory representation", "Data type", "Control statement"}
        };

        private int temp = 0;
        private int result = 0;

        void Loaddata(int i)
        {
            if (index >= s.Length) return;
            else
            {
                groupBox1.Text = s[index];
                radioButton1.Text = value[index, 0];
                radioButton2.Text = value[index, 1];
                radioButton3.Text = value[index, 2];
                radioButton4.Text = value[index, 3];
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index >= s.Length) return;

            if (radioButton1.Checked == true)
                temp = 1;
            if (radioButton2.Checked == true)
                temp = 2;
            if (radioButton3.Checked == true)
                temp = 3;
            if (radioButton4.Checked == true)
                temp = 4;

            if (sum[index] == temp) result += 1;
            index++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Loaddata(index); 
            button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Text = "Вы набрали " + result.ToString() + " баллов";
            Loaddata(index);
        }
    }
}
