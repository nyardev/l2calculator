using System;
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
            lblAal5Title.Visible = false;
            lblAal5bytes.Visible = false;
            lblAal5Cells.Visible = false;
            lblAal5Effi.Visible = false;
            lblAal5Pad.Visible = false;

            lblAal3Title.Visible = false;
            lblAal3bytes.Visible = false;
            lblAal3Cells.Visible = false;
            lblAal3Effi.Visible = false;
            lblAal3Pad.Visible = false;

            lblEthTitle.Visible = false;
            lblEthbytes.Visible = false;
            lblEthFrames.Visible = false;
            lblEthEffi.Visible = false;
            lblEthPad.Visible = false;

            lblEth1Title.Visible = false;
            lblEth1Bytes.Visible = false;
            lblEth1frame.Visible = false;
            lblEth1effi.Visible = false;
            lblEth1pad.Visible = false;











            int bytes = Int32.Parse(textBox1.Text);
            Console.WriteLine(bytes);
            
            foreach (int index in checkedListBox1.CheckedIndices)
            {
                if (index == 0) // AAL5
                {
                    Console.WriteLine();
                    //do something
                    lblAal5Title.Visible = true;
                    lblAal5bytes.Text = "1"+" Bytes"; //Calcularlo y meterlo con un ToString
                    lblAal5bytes.Visible = true;
                    lblAal5Cells.Text = "1111111"+" Cells"; 
                    lblAal5Cells.Visible = true;
                    lblAal5Effi.Text = "1"+ "% L3/L2 Efficiency";
                    lblAal5Effi.Visible = true;
                    if (cboxPad.Checked) {
                        lblAal5Pad.Text = "1"+ "Bytes of padding";
                        lblAal5Pad.Visible = true;

                    }

                }
                if (index == 1) // AAL3/4
                {
                    Console.WriteLine();
                    //do something
                    lblAal3Title.Visible = true;
                    lblAal3bytes.Text = "1"+" Bytes"; //Calcularlo y meterlo con un ToString
                    lblAal3bytes.Visible = true;
                    lblAal3Cells.Text = "1"+ " Cells";
                    lblAal3Cells.Visible = true;
                    lblAal3Effi.Text = "1" + "% L3/L2 Efficiency";
                    lblAal3Effi.Visible = true;
                    if (cboxPad.Checked)
                    {
                        lblAal3Pad.Text = "1" + "Bytes of padding";
                        lblAal3Pad.Visible = true;
                    }

                }
                if (index == 2) // Eth
                {
                    Console.WriteLine();
                    //do something
                    
                    //do something
                    lblEthTitle.Visible = true;
                    lblEthbytes.Text = "1" + " Bytes"; //Calcularlo y meterlo con un ToString
                    lblEthbytes.Visible = true;
                    lblEthFrames.Text = "1"+" Frames";
                    lblEthFrames.Visible = true;
                    lblEthEffi.Text = "1" + "% L3/L2 Efficiency";
                    lblEthEffi.Visible = true;
                    if (cboxPad.Checked)
                    {
                        lblEthPad.Text = "1" + "Bytes of padding";
                        lblEthPad.Visible = true;

                    }

                }
                if (index == 3) // Eth1q
                {
                    Console.WriteLine();
                    //do something

                    //do something
                    lblEth1Title.Visible = true;
                    lblEth1Bytes.Text = "1" + " Bytes"; //Calcularlo y meterlo con un ToString
                    lblEth1Bytes.Visible = true;
                    lblEth1frame.Text = "1" + " Frames";
                    lblEth1frame.Visible = true;
                    lblEth1effi.Text = "1" + "% L3/L2 Efficiency";
                    lblEth1effi.Visible = true;
                    if (cboxPad.Checked)
                    {
                        lblEth1pad.Text = "1" + "Bytes of padding";
                        lblEth1pad.Visible = true;

                    }
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

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void lblAal5Cells_Click(object sender, EventArgs e)
        {

        }
    }
}
