﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace l2calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEth0_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void calcula(object sender, MouseEventArgs e)
        {
            int bytes = Int32.Parse(textBox1.Text);
            Console.WriteLine(bytes);
            
            foreach (int index in checkedListBox1.CheckedIndices)
            {
                if (index == 0) // AAL5
                {
                    Console.WriteLine();
                    //do something
                 
                
                
                }
                if (index == 1) // AAL3/4
                {
                    Console.WriteLine();
                    //do something
                }
                if (index == 2) // Eth
                {
                    Console.WriteLine();
                    //do something
                }
                if (index == 3) // Eth1q
                {
                    Console.WriteLine();
                    //do something
                }

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SystemColorsChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
