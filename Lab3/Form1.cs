namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double result = (i + b) / c;
            textBox4.Text = Convert.ToString(result);
            // or
            //textBox4.Text = Convert.ToString ((Convert.ToDouble (textBox1.Text) + Convert.ToDouble (textBox2.Text)) / Convert.ToDouble (textBox3.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {// check which radiobutton was selected
            if (radioButton1.Checked == true)
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 10 / 100);
            if (radioButton2.Checked == true)
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 20 / 100);
            if (radioButton3.Checked == true)
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 50 / 100);
        }


    }
}