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

            
           void AAL5Bytes(int dataBytes, bool padding)
        {
            int totalAAL5Bytes = 0;
            int totalAAL5Cells = 0;
            int totalAAL5Padding = 0;

            //1. Calculate number of complete AAL5 packets (max 9180 dataBytes)
            int numCompletePackets = dataBytes / 9180;
            int numDataBytesOnLastPacket = dataBytes % 9180;
            
            //Number of bytes in a complete AAL5 packets
            int cellsOnCompletePacket = (9180 / 48);
            int bytesInCompletePacket = 53 * 192;
            int paddingOnCompletePacket = 12;
            

            //Number of totalBytes on nonComplete packet
            int cellsOnNonCompletePacket = numDataBytesOnLastPacket / 48;
            int paddingOnNonCompletePacket = 40 - (numDataBytesOnLastPacket - (cellsOnNonCompletePacket * 48));
            int bytesInNonCompletePacket = (cellsOnNonCompletePacket + 1) * 53;

            if (numCompletePackets != 0)
            {
                totalAAL5Bytes = (bytesInCompletePacket*numCompletePackets) + bytesInNonCompletePacket;
                totalAAL5Cells = (cellsOnCompletePacket * numCompletePackets) + cellsOnNonCompletePacket +1;
                if(numDataBytesOnLastPacket == 0)
                {
                    totalAAL5Padding = paddingOnCompletePacket;
                }else totalAAL5Padding = (paddingOnCompletePacket * numCompletePackets) + paddingOnNonCompletePacket;

            }
            else
            {
                totalAAL5Bytes = bytesInNonCompletePacket;
                totalAAL5Cells =cellsOnNonCompletePacket +1;
                totalAAL5Padding = paddingOnNonCompletePacket;
            }

            //Finally, we calculate the efficiency
            float efficiency = (float)dataBytes / totalAAL5Bytes;
      
          
            if (padding == true)
            {
                System.Console.WriteLine(totalAAL5Padding+ " Bytes of padding");
            }

                lblAal5Title.Visible = true;
                lblAal5bytes.Text = totalAAL5Bytes.ToString() + " Bytes"; //Calcularlo y meterlo con un ToString
                lblAal5bytes.Visible = true;
                lblAal5Cells.Text = totalAAL5Cells.ToString()  + " Cells";
                lblAal5Cells.Visible = true;
                lblAal5Effi.Text = Math.Round((efficiency * 100), 2).ToString() + " % L3/L2 Efficiency";
                lblAal5Effi.Visible = true;
                if (padding)
                {
                    lblAal5Pad.Text = totalAAL5Padding.ToString() + " Bytes of padding";
                    lblAal5Pad.Visible = true;

                }

            }
             
           void AAL3Bytes(int dataBytes, bool padding)
        {
            int totalAAL3Bytes = 0;
            int totalAAL3Padding = 0;
            int totalAAL3Cells = 0;

            //Calculate the number of cells full filled
            totalAAL3Cells = dataBytes / 44;

            //Calculate the not full filled cell
            int numDataBytesLeft = dataBytes - totalAAL3Cells * 44;
            totalAAL3Padding = 48 - numDataBytesLeft - 4;
            totalAAL3Cells++;

            //Calculate the total bytes sent
            totalAAL3Bytes = totalAAL3Cells * 44;

            //Finally, we calculate the efficiency
            float efficiency = (float)dataBytes / totalAAL3Bytes;
            
         
            lblAal3Title.Visible = true;
            lblAal3bytes.Text = totalAAL3Bytes + " Bytes"; //Calcularlo y meterlo con un ToString
            lblAal3bytes.Visible = true;
            lblAal3Cells.Text = totalAAL3Cells + " Cells";
            lblAal3Cells.Visible = true;
            lblAal3Effi.Text = Math.Round((efficiency * 100), 2).ToString() + " % L3/L2 Efficiency";
            lblAal3Effi.Visible = true;
            if (padding)
            {
                lblAal3Pad.Text = totalAAL3Padding.ToString() + " Bytes of padding";
                lblAal3Pad.Visible = true;
            }

            }

           void ethernetBytes(int dataBytes, bool padding)
            {
                //First, we calculate the total number of bytes
                int frames = 0;
                int totalBytes = 0;
                int paddingBytes = 0;
                frames = (dataBytes / 1500) + 1;
                //For a single frame
                if (frames == 1)
                {
                    if (dataBytes < 46)
                    {
                        totalBytes = 46 + 18;
                        paddingBytes = 46 - dataBytes;
                    }
                    else
                    {
                        totalBytes = dataBytes + 18;
                        paddingBytes = 0;
                    }
                }
                //For multiple frames
                else
                {
                    int lastFrameData = dataBytes % 1500;
                    if (lastFrameData == 0)
                    {
                        totalBytes = frames * 1518;
                    }
                    else
                    {
                        //We calculate the size of the last frame
                        int lastFrameBytes = 0;
                        if (lastFrameData < 46)
                        {
                            lastFrameBytes = 46 + 18;
                            paddingBytes = 46 - lastFrameData;
                        }
                        else
                        {
                            lastFrameBytes = lastFrameData + 18;
                            paddingBytes = 0;
                        }
                        //We add the size of the last frame to all the other complete frames
                        totalBytes = (frames * 1518) + lastFrameBytes;
                    }
                }
                //Finally, we calculate the efficiency
                float efficiency = (float)dataBytes / totalBytes;
                //Print  empty line
                System.Console.WriteLine();
                lblEthTitle.Visible = true;
                lblEthbytes.Text = totalBytes.ToString() + " Bytes"; //Calcularlo y meterlo con un ToString
                lblEthbytes.Visible = true;
                lblEthFrames.Text = frames.ToString() + " Frames";
                lblEthFrames.Visible = true;
                lblEthEffi.Text = Math.Round((efficiency * 100), 2).ToString() + " % L3/L2 Efficiency";
                lblEthEffi.Visible = true;
                if (padding)
                {
                    lblEthPad.Text = paddingBytes + " Bytes of padding";
                    lblEthPad.Visible = true;

                }
            }

           void ethernet1QBytes(int dataBytes, bool padding)
            {
                //First, we calculate the total number of bytes
                int frames = 0;
                int totalBytes = 0;
                int paddingBytes = 0;
                frames = (dataBytes / 1500) + 1;
                //For a single frame
                if (frames == 1)
                {
                    if (dataBytes < 46)
                    {
                        totalBytes = 46 + 22;
                        paddingBytes = 46 - dataBytes;
                    }
                    else
                    {
                        totalBytes = dataBytes + 22;
                        paddingBytes = 0;
                    }
                }
                //For multiple frames
                else
                {
                    int lastFrameData = dataBytes % 1500;
                    if (lastFrameData == 0)
                    {
                        totalBytes = frames * 1522;
                    }
                    else
                    {
                        //We calculate the size of the last frame
                        int lastFrameBytes = 0;
                        if (lastFrameData < 46)
                        {
                            lastFrameBytes = 46 + 22;
                            paddingBytes = 46 - lastFrameData;
                        }
                        else
                        {
                            lastFrameBytes = lastFrameData + 22;
                            paddingBytes = 0;
                        }
                        //We add the size of the last frame to all the other complete frames
                        totalBytes = (frames * 1522) + lastFrameBytes;
                    }
                }
                //Finally, we calculate the efficiency
                float efficiency = (float)dataBytes / totalBytes;
          
           
                if (padding == true)
                {
                    System.Console.WriteLine(paddingBytes + " bytes of padding");
                }
           

        
                lblEth1Title.Visible = true;
                lblEth1Bytes.Text = totalBytes.ToString() + " Bytes"; 
                lblEth1Bytes.Visible = true;
                lblEth1frame.Text = frames.ToString()  + " Frames";
                lblEth1frame.Visible = true;
                
                lblEth1effi.Text = Math.Round((efficiency * 100),2).ToString() + " % L3/L2 Efficiency";

                lblEth1effi.Visible = true;
                if (padding)
                {
                    lblEth1pad.Text = paddingBytes.ToString() + " Bytes of padding";
                    lblEth1pad.Visible = true;

                }


            }







            int bytes = Int32.Parse(textBox1.Text);
            Console.WriteLine(bytes);
            
            foreach (int index in checkedListBox1.CheckedIndices)
            {
                if (index == 0) // AAL5
                {
                    Console.WriteLine();
                    //do something
                    AAL5Bytes(bytes, cboxPad.Checked);

                }
                if (index == 1) // AAL3/4
                {
                    AAL3Bytes(bytes, cboxPad.Checked);
                   
                   

                }
                if (index == 2) // Eth
                {
                    Console.WriteLine();
                    //do something
                    ethernetBytes(bytes, cboxPad.Checked);  

                }
                if (index == 3) // Eth1q
                {
                    Console.WriteLine();
                    //do something
                    ethernet1QBytes(bytes, cboxPad.Checked);

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
