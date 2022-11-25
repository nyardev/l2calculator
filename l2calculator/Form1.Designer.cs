
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAAL5 = new System.Windows.Forms.RadioButton();
            this.btnAAL34 = new System.Windows.Forms.RadioButton();
            this.btnEth0 = new System.Windows.Forms.RadioButton();
            this.btnEth1q = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.calculate = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "aa";
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(53, 236);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(644, 52);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(598, 617);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAAL34);
            this.groupBox1.Controls.Add(this.btnAAL5);
            this.groupBox1.Location = new System.Drawing.Point(53, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 63);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Layer3";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEth1q);
            this.groupBox2.Controls.Add(this.btnEth0);
            this.groupBox2.Location = new System.Drawing.Point(53, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 63);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Layer2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnAAL5
            // 
            this.btnAAL5.AutoSize = true;
            this.btnAAL5.Location = new System.Drawing.Point(7, 21);
            this.btnAAL5.Name = "btnAAL5";
            this.btnAAL5.Size = new System.Drawing.Size(80, 17);
            this.btnAAL5.TabIndex = 6;
            this.btnAAL5.TabStop = true;
            this.btnAAL5.Text = "AAL5oATM";
            this.btnAAL5.UseVisualStyleBackColor = true;
            // 
            // btnAAL34
            // 
            this.btnAAL34.AutoSize = true;
            this.btnAAL34.Location = new System.Drawing.Point(6, 40);
            this.btnAAL34.Name = "btnAAL34";
            this.btnAAL34.Size = new System.Drawing.Size(91, 17);
            this.btnAAL34.TabIndex = 7;
            this.btnAAL34.TabStop = true;
            this.btnAAL34.Text = "AAL3/4oATM";
            this.btnAAL34.UseVisualStyleBackColor = true;
            // 
            // btnEth0
            // 
            this.btnEth0.AutoSize = true;
            this.btnEth0.Location = new System.Drawing.Point(6, 21);
            this.btnEth0.Name = "btnEth0";
            this.btnEth0.Size = new System.Drawing.Size(65, 17);
            this.btnEth0.TabIndex = 7;
            this.btnEth0.TabStop = true;
            this.btnEth0.Text = "Ethernet";
            this.btnEth0.UseVisualStyleBackColor = true;
            // 
            // btnEth1q
            // 
            this.btnEth1q.AutoSize = true;
            this.btnEth1q.Location = new System.Drawing.Point(6, 40);
            this.btnEth1q.Name = "btnEth1q";
            this.btnEth1q.Size = new System.Drawing.Size(82, 17);
            this.btnEth1q.TabIndex = 8;
            this.btnEth1q.TabStop = true;
            this.btnEth1q.Text = "Ethernet.1Q";
            this.btnEth1q.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(53, 476);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(65, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Padding";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(53, 537);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 8;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(302, 127);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 758);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnAAL34;
        private System.Windows.Forms.RadioButton btnAAL5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton btnEth0;
        private System.Windows.Forms.RadioButton btnEth1q;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

