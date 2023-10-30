using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaratoryWork2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32((sender as Button).Tag);
            string s = "You pressed the button";
            switch (k)
            {
                case 1:
                    s += "number 1";
                    break;
                case 2:
                    s += "number 2";
                    break;
                default:
                    s = "you couldn't get here";
                    break;
            }
            MessageBox.Show(this, s, "Which button?");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                // Looking for Button controls 
                if (Convert.ToString(this.Controls[i].GetType().Name) == "Button")
                {
                    MessageBox.Show(this,
                      Convert.ToString(this.Controls[i].Name),
                      "What buttons are there?");
                }
            }
        }

    }
}
