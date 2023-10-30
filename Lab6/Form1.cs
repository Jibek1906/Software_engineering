using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.UseTabStops = true;
            for (int i = 1; i < 20; i++)
            {
                listBox1.Items.Add("Option \t" + i.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                listBox1.Items.Add("Record" + i.ToString());
             
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] sArayItems = {"Excellent", "Good",
            "Satisfactory", "Unsatisfactory"};
            listBox1.Items.Clear();
            for (int i = 0; i < sArayItems.GetLength(0); i++) 
            {
                listBox1.Items.Add(sArayItems[i]);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(1, "Added string");
            listBox1.Items.Insert(4, "Added line2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(new object[] {"Excellent","Good", "Satisfactory", "Unsatisfactory"});
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 1; i < 21; i++)
            {
                listBox1.Items.Add("Straw" + i.ToString());
            }
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox1.SetSelected(0, true);
            listBox1.SetSelected(1, true);
            listBox1.SetSelected(2, true);

            string selectedItems = "Selected Items: ";
            foreach (var itemIndex in listBox1.SelectedIndices)
            {
                selectedItems += listBox1.Items[(int)itemIndex] + ", ";
            }
            MessageBox.Show(selectedItems, "Selected Items");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 1; i < 21; i++)
            {
                listBox1.Items.Add("Straw" + i.ToString());
            }
            listBox1.Sorted = false;
            listBox1.Items.Cast<string>()
                .Select(s => new { Original = s, Value = GetNumericValue(s) })
                .OrderBy(x => x.Value)
                .ToList()
                .ForEach(item => listBox1.Items.Add(item.Original));
        }

        // Function to get the numeric value from a string (safely)
        private int GetNumericValue(string s)
        {
            string numericPart = s.Substring(4); // Assuming the numeric part follows "Straw"
            if (int.TryParse(numericPart, out int value))
            {
                return value;
            }
            return int.MaxValue; // Or some other suitable default value
        }


        private void button8_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex!= -1)
                MessageBox.Show(listBox1.SelectedItem.ToString(), "Getting the string value");
            MessageBox.Show(listBox1.Text, "");
            if (listBox1.SelectedIndex!= -1)
                MessageBox.Show(listBox1.SelectedIndex.ToString(), "Getting the string index");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                MessageBox.Show(listBox1.Items[i].ToString() + "");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(0);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We clicked on the component with the mouse");
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                MessageBox.Show(listBox1.SelectedItem.ToString(), "Getting string value");
            }
            else
            {
                MessageBox.Show("No item is selected.", "Information");
            }

        }
    }
}
