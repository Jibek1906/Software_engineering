using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Cells[3].Value = (Convert.ToDouble(dataGridView1.CurrentRow.Cells[2].Value) * Convert.ToDouble(dataGridView1.CurrentRow.Cells[1].Value));

            double sum = 0;
            for (int i = 0; i != dataGridView1.Rows.Count - 1; i++)//просмотр строк datagrid
            {
                dataGridView1[3, i].Value = (Convert.ToDouble(dataGridView1[2, i].Value) * Convert.ToDouble(dataGridView1[1, i].Value));

                sum += Convert.ToDouble(dataGridView1[3, i].Value);
            }
            label4.Text = "Итого  " + sum.ToString();

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
            {

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                double price = Convert.ToDouble(row.Cells[1].Value);
                double quantity = Convert.ToDouble(row.Cells[2].Value);
                double total = price * quantity;
                row.Cells[3].Value = total;

                UpdateLabel4();
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateLabel4();
        }

        private void UpdateLabel4()
        {
            double sum = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    sum += Convert.ToDouble(row.Cells[3].Value);
                }
            }
            label4.Text = "Итого " + sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
             dataGridView1.Rows.Add("Молоко", 2, 3, 2 * 3);


        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            label5.Text = "current product" + dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString() +
                "at the price" + dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString() + "available" + dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox3.Text)
                );

        }
    }
}
