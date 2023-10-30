namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            textBox4 = new TextBox();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button2 = new Button();
            label6 = new Label();
            textBox5 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(15, 21);
            label1.TabIndex = 0;
            label1.Text = "(";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(182, 34);
            label2.Name = "label2";
            label2.Size = new Size(21, 21);
            label2.TabIndex = 1;
            label2.Text = "+";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(364, 32);
            label3.Name = "label3";
            label3.Size = new Size(15, 21);
            label3.TabIndex = 2;
            label3.Text = ")";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(385, 32);
            label4.Name = "label4";
            label4.Size = new Size(16, 21);
            label4.TabIndex = 3;
            label4.Text = "/";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(209, 34);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(407, 34);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(149, 23);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.Location = new Point(199, 96);
            button1.Name = "button1";
            button1.Size = new Size(239, 29);
            button1.TabIndex = 7;
            button1.Text = "получить результат";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(165, 156);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 8;
            label5.Text = "итого";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(230, 153);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(149, 23);
            textBox4.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.ForeColor = SystemColors.Highlight;
            groupBox1.Location = new Point(87, 237);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(437, 100);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "от полученного значения взять процент";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.ForeColor = Color.Black;
            radioButton3.Location = new Point(198, 72);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(47, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "50%";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = Color.Black;
            radioButton2.Location = new Point(198, 47);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(47, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "20%";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = Color.Black;
            radioButton1.Location = new Point(198, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(47, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "10%";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.WhiteSmoke;
            button2.Location = new Point(199, 356);
            button2.Name = "button2";
            button2.Size = new Size(239, 29);
            button2.TabIndex = 11;
            button2.Text = "получить результат";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(165, 413);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 12;
            label6.Text = "итого";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(220, 405);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(149, 23);
            textBox5.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(620, 473);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Расчет";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Label label5;
        private TextBox textBox4;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button2;
        private Label label6;
        private TextBox textBox5;
    }
}