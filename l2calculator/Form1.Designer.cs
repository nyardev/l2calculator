
namespace l2calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cboxPad = new System.Windows.Forms.CheckBox();
            this.calculate = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAal5bytes = new System.Windows.Forms.Label();
            this.lblAal5Effi = new System.Windows.Forms.Label();
            this.lblAal5Pad = new System.Windows.Forms.Label();
            this.lblAal5Cells = new System.Windows.Forms.Label();
            this.lblAal5Title = new System.Windows.Forms.Label();
            this.lblEthTitle = new System.Windows.Forms.Label();
            this.lblEthFrames = new System.Windows.Forms.Label();
            this.lblEthPad = new System.Windows.Forms.Label();
            this.lblEthEffi = new System.Windows.Forms.Label();
            this.lblEthbytes = new System.Windows.Forms.Label();
            this.lblAal3Title = new System.Windows.Forms.Label();
            this.lblAal3Cells = new System.Windows.Forms.Label();
            this.lblAal3Pad = new System.Windows.Forms.Label();
            this.lblAal3Effi = new System.Windows.Forms.Label();
            this.lblAal3bytes = new System.Windows.Forms.Label();
            this.lblEth1Title = new System.Windows.Forms.Label();
            this.lblEth1frame = new System.Windows.Forms.Label();
            this.lblEth1pad = new System.Windows.Forms.Label();
            this.lblEth1effi = new System.Windows.Forms.Label();
            this.lblEth1Bytes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "aa";
            this.textBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.textBox1.Location = new System.Drawing.Point(53, 217);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cboxPad
            // 
            this.cboxPad.AutoSize = true;
            this.cboxPad.Location = new System.Drawing.Point(53, 323);
            this.cboxPad.Name = "cboxPad";
            this.cboxPad.Size = new System.Drawing.Size(65, 17);
            this.cboxPad.TabIndex = 6;
            this.cboxPad.Text = "Padding";
            this.cboxPad.UseVisualStyleBackColor = true;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(53, 358);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 8;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.button1_Click);
            this.calculate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.calcula);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "AAL5oATM",
            "AAL3/4oATM",
            "Ethernet",
            "Ethernet.1Q"});
            this.checkedListBox1.Location = new System.Drawing.Point(53, 253);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(126, 64);
            this.checkedListBox1.TabIndex = 9;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged_1);
            this.checkedListBox1.SystemColorsChanged += new System.EventHandler(this.checkedListBox1_SystemColorsChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Number of Bytes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAal5bytes
            // 
            this.lblAal5bytes.AutoSize = true;
            this.lblAal5bytes.BackColor = System.Drawing.SystemColors.Control;
            this.lblAal5bytes.Location = new System.Drawing.Point(303, 133);
            this.lblAal5bytes.Name = "lblAal5bytes";
            this.lblAal5bytes.Size = new System.Drawing.Size(54, 13);
            this.lblAal5bytes.TabIndex = 11;
            this.lblAal5bytes.Tag = "lblAal5bytes";
            this.lblAal5bytes.Text = "Aal5Bytes";
            this.lblAal5bytes.Visible = false;
            this.lblAal5bytes.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lblAal5Effi
            // 
            this.lblAal5Effi.AutoSize = true;
            this.lblAal5Effi.BackColor = System.Drawing.SystemColors.Control;
            this.lblAal5Effi.Location = new System.Drawing.Point(303, 236);
            this.lblAal5Effi.Name = "lblAal5Effi";
            this.lblAal5Effi.Size = new System.Drawing.Size(74, 13);
            this.lblAal5Effi.TabIndex = 12;
            this.lblAal5Effi.Tag = "lblAal5Effi";
            this.lblAal5Effi.Text = "Aal5Efficiency";
            this.lblAal5Effi.Visible = false;
            // 
            // lblAal5Pad
            // 
            this.lblAal5Pad.AutoSize = true;
            this.lblAal5Pad.BackColor = System.Drawing.SystemColors.Control;
            this.lblAal5Pad.Location = new System.Drawing.Point(654, 236);
            this.lblAal5Pad.Name = "lblAal5Pad";
            this.lblAal5Pad.Size = new System.Drawing.Size(67, 13);
            this.lblAal5Pad.TabIndex = 13;
            this.lblAal5Pad.Tag = "lblAal5Pad";
            this.lblAal5Pad.Text = "Aal5Padding";
            this.lblAal5Pad.Visible = false;
            // 
            // lblAal5Cells
            // 
            this.lblAal5Cells.AutoSize = true;
            this.lblAal5Cells.BackColor = System.Drawing.SystemColors.Control;
            this.lblAal5Cells.Location = new System.Drawing.Point(654, 133);
            this.lblAal5Cells.Name = "lblAal5Cells";
            this.lblAal5Cells.Size = new System.Drawing.Size(50, 13);
            this.lblAal5Cells.TabIndex = 14;
            this.lblAal5Cells.Tag = "lblAal5Cells";
            this.lblAal5Cells.Text = "Aal5Cells";
            this.lblAal5Cells.Visible = false;
            this.lblAal5Cells.Click += new System.EventHandler(this.lblAal5Cells_Click);
            // 
            // lblAal5Title
            // 
            this.lblAal5Title.AutoSize = true;
            this.lblAal5Title.BackColor = System.Drawing.SystemColors.Control;
            this.lblAal5Title.Location = new System.Drawing.Point(406, 75);
            this.lblAal5Title.Name = "lblAal5Title";
            this.lblAal5Title.Size = new System.Drawing.Size(110, 13);
            this.lblAal5Title.TabIndex = 15;
            this.lblAal5Title.Tag = "lblAal5bytes";
            this.lblAal5Title.Text = "Protocolo AAL5oATM";
            this.lblAal5Title.Visible = false;
            // 
            // lblEthTitle
            // 
            this.lblEthTitle.AutoSize = true;
            this.lblEthTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblEthTitle.Location = new System.Drawing.Point(421, 361);
            this.lblEthTitle.Name = "lblEthTitle";
            this.lblEthTitle.Size = new System.Drawing.Size(95, 13);
            this.lblEthTitle.TabIndex = 20;
            this.lblEthTitle.Tag = "lblAal5bytes";
            this.lblEthTitle.Text = "Protocolo Ethernet";
            this.lblEthTitle.Visible = false;
            // 
            // lblEthFrames
            // 
            this.lblEthFrames.AutoSize = true;
            this.lblEthFrames.BackColor = System.Drawing.SystemColors.Control;
            this.lblEthFrames.Location = new System.Drawing.Point(654, 431);
            this.lblEthFrames.Name = "lblEthFrames";
            this.lblEthFrames.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEthFrames.Size = new System.Drawing.Size(52, 13);
            this.lblEthFrames.TabIndex = 19;
            this.lblEthFrames.Tag = "lblAal5Cells";
            this.lblEthFrames.Text = "EthFrame";
            this.lblEthFrames.Visible = false;
            // 
            // lblEthPad
            // 
            this.lblEthPad.AutoSize = true;
            this.lblEthPad.BackColor = System.Drawing.SystemColors.Control;
            this.lblEthPad.Location = new System.Drawing.Point(654, 515);
            this.lblEthPad.Name = "lblEthPad";
            this.lblEthPad.Size = new System.Drawing.Size(62, 13);
            this.lblEthPad.TabIndex = 18;
            this.lblEthPad.Tag = "lblAal5Pad";
            this.lblEthPad.Text = "EthPadding";
            this.lblEthPad.Visible = false;
            // 
            // lblEthEffi
            // 
            this.lblEthEffi.AutoSize = true;
            this.lblEthEffi.BackColor = System.Drawing.SystemColors.Control;
            this.lblEthEffi.Location = new System.Drawing.Point(303, 515);
            this.lblEthEffi.Name = "lblEthEffi";
            this.lblEthEffi.Size = new System.Drawing.Size(38, 13);
            this.lblEthEffi.TabIndex = 17;
            this.lblEthEffi.Tag = "lblAal5Effi";
            this.lblEthEffi.Text = "EthEffi";
            this.lblEthEffi.Visible = false;
            // 
            // lblEthbytes
            // 
            this.lblEthbytes.AutoSize = true;
            this.lblEthbytes.BackColor = System.Drawing.SystemColors.Control;
            this.lblEthbytes.Location = new System.Drawing.Point(303, 431);
            this.lblEthbytes.Name = "lblEthbytes";
            this.lblEthbytes.Size = new System.Drawing.Size(49, 13);
            this.lblEthbytes.TabIndex = 16;
            this.lblEthbytes.Tag = "lblAal5bytes";
            this.lblEthbytes.Text = "EthBytes";
            this.lblEthbytes.Visible = false;
            // 
            // lblAal3Title
            // 
            this.lblAal3Title.AutoSize = true;
            this.lblAal3Title.BackColor = System.Drawing.SystemColors.Control;
            this.lblAal3Title.Location = new System.Drawing.Point(1025, 75);
            this.lblAal3Title.Name = "lblAal3Title";
            this.lblAal3Title.Size = new System.Drawing.Size(121, 13);
            this.lblAal3Title.TabIndex = 25;
            this.lblAal3Title.Tag = "";
            this.lblAal3Title.Text = "Protocolo AAL3/4oATM";
            this.lblAal3Title.Visible = false;
            // 
            // lblAal3Cells
            // 
            this.lblAal3Cells.AutoSize = true;
            this.lblAal3Cells.BackColor = System.Drawing.SystemColors.Control;
            this.lblAal3Cells.Location = new System.Drawing.Point(1178, 133);
            this.lblAal3Cells.Name = "lblAal3Cells";
            this.lblAal3Cells.Size = new System.Drawing.Size(61, 13);
            this.lblAal3Cells.TabIndex = 24;
            this.lblAal3Cells.Tag = "";
            this.lblAal3Cells.Text = "Aal3/4Cells";
            this.lblAal3Cells.Visible = false;
            // 
            // lblAal3Pad
            // 
            this.lblAal3Pad.AutoSize = true;
            this.lblAal3Pad.BackColor = System.Drawing.SystemColors.Control;
            this.lblAal3Pad.Location = new System.Drawing.Point(1178, 236);
            this.lblAal3Pad.Name = "lblAal3Pad";
            this.lblAal3Pad.Size = new System.Drawing.Size(78, 13);
            this.lblAal3Pad.TabIndex = 23;
            this.lblAal3Pad.Tag = "lblAal5Pad";
            this.lblAal3Pad.Text = "Aal3/4Padding";
            this.lblAal3Pad.Visible = false;
            // 
            // lblAal3Effi
            // 
            this.lblAal3Effi.AutoSize = true;
            this.lblAal3Effi.BackColor = System.Drawing.SystemColors.Control;
            this.lblAal3Effi.Location = new System.Drawing.Point(940, 236);
            this.lblAal3Effi.Name = "lblAal3Effi";
            this.lblAal3Effi.Size = new System.Drawing.Size(85, 13);
            this.lblAal3Effi.TabIndex = 22;
            this.lblAal3Effi.Tag = "lblAal5Effi";
            this.lblAal3Effi.Text = "Aal3/4Efficiency";
            this.lblAal3Effi.Visible = false;
            // 
            // lblAal3bytes
            // 
            this.lblAal3bytes.AutoSize = true;
            this.lblAal3bytes.BackColor = System.Drawing.SystemColors.Control;
            this.lblAal3bytes.Location = new System.Drawing.Point(940, 133);
            this.lblAal3bytes.Name = "lblAal3bytes";
            this.lblAal3bytes.Size = new System.Drawing.Size(54, 13);
            this.lblAal3bytes.TabIndex = 21;
            this.lblAal3bytes.Tag = "lblAal5bytes";
            this.lblAal3bytes.Text = "Aal3Bytes";
            this.lblAal3bytes.Visible = false;
            // 
            // lblEth1Title
            // 
            this.lblEth1Title.AutoSize = true;
            this.lblEth1Title.BackColor = System.Drawing.SystemColors.Control;
            this.lblEth1Title.Location = new System.Drawing.Point(1025, 361);
            this.lblEth1Title.Name = "lblEth1Title";
            this.lblEth1Title.Size = new System.Drawing.Size(115, 13);
            this.lblEth1Title.TabIndex = 30;
            this.lblEth1Title.Tag = "lblAal5bytes";
            this.lblEth1Title.Text = "Protocolo Ethernet .1Q";
            this.lblEth1Title.Visible = false;
            // 
            // lblEth1frame
            // 
            this.lblEth1frame.AutoSize = true;
            this.lblEth1frame.BackColor = System.Drawing.SystemColors.Control;
            this.lblEth1frame.Location = new System.Drawing.Point(1188, 396);
            this.lblEth1frame.Name = "lblEth1frame";
            this.lblEth1frame.Size = new System.Drawing.Size(66, 13);
            this.lblEth1frame.TabIndex = 29;
            this.lblEth1frame.Tag = "lblAal5Cells";
            this.lblEth1frame.Text = "Eth1 Frames";
            this.lblEth1frame.Visible = false;
            // 
            // lblEth1pad
            // 
            this.lblEth1pad.AutoSize = true;
            this.lblEth1pad.BackColor = System.Drawing.SystemColors.Control;
            this.lblEth1pad.Location = new System.Drawing.Point(1188, 515);
            this.lblEth1pad.Name = "lblEth1pad";
            this.lblEth1pad.Size = new System.Drawing.Size(68, 13);
            this.lblEth1pad.TabIndex = 28;
            this.lblEth1pad.Tag = "lblAal5Pad";
            this.lblEth1pad.Text = "Eth1Padding";
            this.lblEth1pad.Visible = false;
            // 
            // lblEth1effi
            // 
            this.lblEth1effi.AutoSize = true;
            this.lblEth1effi.BackColor = System.Drawing.SystemColors.Control;
            this.lblEth1effi.Location = new System.Drawing.Point(940, 515);
            this.lblEth1effi.Name = "lblEth1effi";
            this.lblEth1effi.Size = new System.Drawing.Size(75, 13);
            this.lblEth1effi.TabIndex = 27;
            this.lblEth1effi.Tag = "lblAal5Effi";
            this.lblEth1effi.Text = "Eth1Efficiency";
            this.lblEth1effi.Visible = false;
            // 
            // lblEth1Bytes
            // 
            this.lblEth1Bytes.AutoSize = true;
            this.lblEth1Bytes.BackColor = System.Drawing.SystemColors.Control;
            this.lblEth1Bytes.Location = new System.Drawing.Point(940, 396);
            this.lblEth1Bytes.Name = "lblEth1Bytes";
            this.lblEth1Bytes.Size = new System.Drawing.Size(55, 13);
            this.lblEth1Bytes.TabIndex = 26;
            this.lblEth1Bytes.Tag = "lblAal5bytes";
            this.lblEth1Bytes.Text = "Eth1Bytes";
            this.lblEth1Bytes.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Location = new System.Drawing.Point(291, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 537);
            this.panel1.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1409, 758);
            this.Controls.Add(this.lblEth1Title);
            this.Controls.Add(this.lblEth1frame);
            this.Controls.Add(this.lblEth1pad);
            this.Controls.Add(this.lblEth1effi);
            this.Controls.Add(this.lblEth1Bytes);
            this.Controls.Add(this.lblAal3Title);
            this.Controls.Add(this.lblAal3Cells);
            this.Controls.Add(this.lblAal3Pad);
            this.Controls.Add(this.lblAal3Effi);
            this.Controls.Add(this.lblAal3bytes);
            this.Controls.Add(this.lblEthTitle);
            this.Controls.Add(this.lblEthFrames);
            this.Controls.Add(this.lblEthPad);
            this.Controls.Add(this.lblEthEffi);
            this.Controls.Add(this.lblEthbytes);
            this.Controls.Add(this.lblAal5Title);
            this.Controls.Add(this.lblAal5Cells);
            this.Controls.Add(this.lblAal5Pad);
            this.Controls.Add(this.lblAal5Effi);
            this.Controls.Add(this.lblAal5bytes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.cboxPad);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox cboxPad;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAal5bytes;
        private System.Windows.Forms.Label lblAal5Effi;
        private System.Windows.Forms.Label lblAal5Pad;
        private System.Windows.Forms.Label lblAal5Cells;
        private System.Windows.Forms.Label lblAal5Title;
        private System.Windows.Forms.Label lblEthTitle;
        private System.Windows.Forms.Label lblEthFrames;
        private System.Windows.Forms.Label lblEthPad;
        private System.Windows.Forms.Label lblEthEffi;
        private System.Windows.Forms.Label lblEthbytes;
        private System.Windows.Forms.Label lblAal3Title;
        private System.Windows.Forms.Label lblAal3Cells;
        private System.Windows.Forms.Label lblAal3Pad;
        private System.Windows.Forms.Label lblAal3Effi;
        private System.Windows.Forms.Label lblAal3bytes;
        private System.Windows.Forms.Label lblEth1Title;
        private System.Windows.Forms.Label lblEth1frame;
        private System.Windows.Forms.Label lblEth1pad;
        private System.Windows.Forms.Label lblEth1effi;
        private System.Windows.Forms.Label lblEth1Bytes;
        private System.Windows.Forms.Panel panel1;
    }
}

