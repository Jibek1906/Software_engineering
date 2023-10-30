using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 editForm = new Form2();
            if (editForm.ShowDialog() != DialogResult.OK)
                return;

            ListViewItem newItem = listView1.Items.Add(editForm.FirstName);
            newItem.SubItems.Add(editForm.LastName);
            newItem.SubItems.Add(editForm.Age.ToString());
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            ListViewItem selectedItem = listView1.SelectedItems[0];

            Form2 editForm = new Form2();
            editForm.FirstName = selectedItem.SubItems[0].Text;
            editForm.LastName = selectedItem.SubItems[1].Text;
            editForm.Age = int.Parse(selectedItem.SubItems[2].Text);

            if (editForm.ShowDialog() == DialogResult.OK)
            {

                selectedItem.SubItems[0].Text = editForm.FirstName;
                selectedItem.SubItems[1].Text = editForm.LastName;
                selectedItem.SubItems[2].Text = editForm.Age.ToString();
            }

        }
    }
}
