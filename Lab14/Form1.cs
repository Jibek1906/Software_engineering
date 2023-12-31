﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Lab14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.SelectionBullet = true;
            richTextBox1.BulletIndent = 50;
            richTextBox1.SelectionFont = new Font("Arial", 16);
            richTextBox1.SelectedText = "Below is a list \n";
            richTextBox1.SelectionFont = new Font("Arial", 12);
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.SelectedText = "Apple" + "\n";
            richTextBox1.SelectionFont = new Font("Arial", 12);
            richTextBox1.SelectionColor = Color.Orange;
            richTextBox1.SelectedText = "Orange" + "\n";
            richTextBox1.SelectionFont = new Font("Arial", 12);
            richTextBox1.SelectionColor = Color.Purple;
            richTextBox1.SelectedText = "Grapes" + "\n";
            richTextBox1.SelectionBullet = false;
            richTextBox1.SelectionFont = new Font("Verdana", 10);
            richTextBox1.SelectedText = "The list is over \n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "My site http://moi.ru";
            System.Diagnostics.Process.Start("http://moi.ru");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string sText1, sText2, sText3, sText4;
            for (int i = 1; i <= 4; i++)
            {
                richTextBox1.Text += "String" + i.ToString() + System.Environment.NewLine;
            }

            sText1 = "String1";
            sText2 = "String2";
            sText3 = "String3";
            sText4 = "String4";

            ApplyFormatting(sText1, 10, FontStyle.Regular, Color.Red);
            ApplyFormatting(sText2, 12, FontStyle.Underline, Color.Blue);
            ApplyFormatting(sText3, 14, FontStyle.Bold, Color.Aqua);
            ApplyFormatting(sText4, 16, FontStyle.Bold | FontStyle.Italic, Color.Cyan);
        }

        private void ApplyFormatting(string searchText, int fontSize, FontStyle style, Color color)
        {
            richTextBox1.Select(richTextBox1.Find(searchText), searchText.Length);
            richTextBox1.SelectionFont = new Font("Arial", fontSize, style);
            richTextBox1.SelectionColor = color;
            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectionLength = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            richTextBox1.SaveFile("a.rtf", RichTextBoxStreamType.RichText);

            richTextBox1.Clear();
            try
            {

                richTextBox1.LoadFile("a.rtf", RichTextBoxStreamType.RichText);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}