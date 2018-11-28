namespace RSA
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
			this.firstPrime_p_label = new System.Windows.Forms.Label();
			this.secoundPrime_q_label = new System.Windows.Forms.Label();
			this.rangeLabel = new System.Windows.Forms.Label();
			this.rangeFromtextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.rangeTotextBox = new System.Windows.Forms.TextBox();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.p_primetextBox = new System.Windows.Forms.TextBox();
			this.q_primetextBox = new System.Windows.Forms.TextBox();
			this.label = new System.Windows.Forms.Label();
			this.e_textBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnSet = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.p_set_textBox = new System.Windows.Forms.TextBox();
			this.q_set_textBox = new System.Windows.Forms.TextBox();
			this.n_set_textBox = new System.Windows.Forms.TextBox();
			this.phi_set_textBox = new System.Windows.Forms.TextBox();
			this.e_set_textBox = new System.Windows.Forms.TextBox();
			this.d_set_textBox = new System.Windows.Forms.TextBox();
			this.info_textBox = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// firstPrime_p_label
			// 
			this.firstPrime_p_label.AutoSize = true;
			this.firstPrime_p_label.Location = new System.Drawing.Point(9, 34);
			this.firstPrime_p_label.Name = "firstPrime_p_label";
			this.firstPrime_p_label.Size = new System.Drawing.Size(16, 13);
			this.firstPrime_p_label.TabIndex = 0;
			this.firstPrime_p_label.Text = "p:";
			// 
			// secoundPrime_q_label
			// 
			this.secoundPrime_q_label.AutoSize = true;
			this.secoundPrime_q_label.Location = new System.Drawing.Point(9, 62);
			this.secoundPrime_q_label.Name = "secoundPrime_q_label";
			this.secoundPrime_q_label.Size = new System.Drawing.Size(16, 13);
			this.secoundPrime_q_label.TabIndex = 1;
			this.secoundPrime_q_label.Text = "q:";
			// 
			// rangeLabel
			// 
			this.rangeLabel.AutoSize = true;
			this.rangeLabel.Location = new System.Drawing.Point(13, 28);
			this.rangeLabel.Name = "rangeLabel";
			this.rangeLabel.Size = new System.Drawing.Size(42, 13);
			this.rangeLabel.TabIndex = 2;
			this.rangeLabel.Text = "Range:";
			// 
			// rangeFromtextBox
			// 
			this.rangeFromtextBox.Location = new System.Drawing.Point(61, 25);
			this.rangeFromtextBox.Name = "rangeFromtextBox";
			this.rangeFromtextBox.Size = new System.Drawing.Size(69, 20);
			this.rangeFromtextBox.TabIndex = 3;
			this.rangeFromtextBox.Text = "1000";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(136, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(10, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "-";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(134, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Generate random variables";
			// 
			// rangeTotextBox
			// 
			this.rangeTotextBox.Location = new System.Drawing.Point(152, 25);
			this.rangeTotextBox.Name = "rangeTotextBox";
			this.rangeTotextBox.Size = new System.Drawing.Size(69, 20);
			this.rangeTotextBox.TabIndex = 6;
			this.rangeTotextBox.Text = "9999";
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(6, 61);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(75, 23);
			this.btnGenerate.TabIndex = 7;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.d_set_textBox);
			this.panel1.Controls.Add(this.e_set_textBox);
			this.panel1.Controls.Add(this.phi_set_textBox);
			this.panel1.Controls.Add(this.n_set_textBox);
			this.panel1.Controls.Add(this.q_set_textBox);
			this.panel1.Controls.Add(this.p_set_textBox);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.btnGenerate);
			this.panel1.Controls.Add(this.rangeLabel);
			this.panel1.Controls.Add(this.rangeTotextBox);
			this.panel1.Controls.Add(this.rangeFromtextBox);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(258, 338);
			this.panel1.TabIndex = 8;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnSet);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.textBox1);
			this.panel2.Controls.Add(this.e_textBox);
			this.panel2.Controls.Add(this.label);
			this.panel2.Controls.Add(this.q_primetextBox);
			this.panel2.Controls.Add(this.p_primetextBox);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.firstPrime_p_label);
			this.panel2.Controls.Add(this.secoundPrime_q_label);
			this.panel2.Location = new System.Drawing.Point(0, 90);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(258, 120);
			this.panel2.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Or enter them yourself";
			// 
			// p_primetextBox
			// 
			this.p_primetextBox.Location = new System.Drawing.Point(32, 34);
			this.p_primetextBox.Name = "p_primetextBox";
			this.p_primetextBox.Size = new System.Drawing.Size(81, 20);
			this.p_primetextBox.TabIndex = 10;
			// 
			// q_primetextBox
			// 
			this.q_primetextBox.Location = new System.Drawing.Point(31, 62);
			this.q_primetextBox.Name = "q_primetextBox";
			this.q_primetextBox.Size = new System.Drawing.Size(82, 20);
			this.q_primetextBox.TabIndex = 11;
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.Location = new System.Drawing.Point(132, 34);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(16, 13);
			this.label.TabIndex = 12;
			this.label.Text = "e:";
			// 
			// e_textBox
			// 
			this.e_textBox.Location = new System.Drawing.Point(160, 34);
			this.e_textBox.Name = "e_textBox";
			this.e_textBox.Size = new System.Drawing.Size(81, 20);
			this.e_textBox.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(149, 4);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "(p and q range)";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(132, 65);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(16, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "d:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(160, 62);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(81, 20);
			this.textBox1.TabIndex = 11;
			// 
			// btnSet
			// 
			this.btnSet.Location = new System.Drawing.Point(6, 88);
			this.btnSet.Name = "btnSet";
			this.btnSet.Size = new System.Drawing.Size(75, 23);
			this.btnSet.TabIndex = 14;
			this.btnSet.Text = "Set";
			this.btnSet.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(9, 224);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(16, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "p:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(9, 250);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(16, 13);
			this.label7.TabIndex = 11;
			this.label7.Text = "q:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(9, 276);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(16, 13);
			this.label8.TabIndex = 12;
			this.label8.Text = "n:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(9, 302);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(24, 13);
			this.label9.TabIndex = 13;
			this.label9.Text = "phi:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(138, 224);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(16, 13);
			this.label10.TabIndex = 14;
			this.label10.Text = "e:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(138, 250);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(16, 13);
			this.label11.TabIndex = 15;
			this.label11.Text = "d:";
			// 
			// p_set_textBox
			// 
			this.p_set_textBox.BackColor = System.Drawing.SystemColors.Control;
			this.p_set_textBox.Location = new System.Drawing.Point(31, 221);
			this.p_set_textBox.Name = "p_set_textBox";
			this.p_set_textBox.ReadOnly = true;
			this.p_set_textBox.Size = new System.Drawing.Size(81, 20);
			this.p_set_textBox.TabIndex = 16;
			// 
			// q_set_textBox
			// 
			this.q_set_textBox.BackColor = System.Drawing.SystemColors.Control;
			this.q_set_textBox.Location = new System.Drawing.Point(31, 247);
			this.q_set_textBox.Name = "q_set_textBox";
			this.q_set_textBox.ReadOnly = true;
			this.q_set_textBox.Size = new System.Drawing.Size(81, 20);
			this.q_set_textBox.TabIndex = 17;
			// 
			// n_set_textBox
			// 
			this.n_set_textBox.BackColor = System.Drawing.SystemColors.Control;
			this.n_set_textBox.Location = new System.Drawing.Point(31, 273);
			this.n_set_textBox.Name = "n_set_textBox";
			this.n_set_textBox.ReadOnly = true;
			this.n_set_textBox.Size = new System.Drawing.Size(178, 20);
			this.n_set_textBox.TabIndex = 18;
			// 
			// phi_set_textBox
			// 
			this.phi_set_textBox.BackColor = System.Drawing.SystemColors.Control;
			this.phi_set_textBox.Location = new System.Drawing.Point(30, 299);
			this.phi_set_textBox.Name = "phi_set_textBox";
			this.phi_set_textBox.ReadOnly = true;
			this.phi_set_textBox.Size = new System.Drawing.Size(179, 20);
			this.phi_set_textBox.TabIndex = 19;
			// 
			// e_set_textBox
			// 
			this.e_set_textBox.BackColor = System.Drawing.SystemColors.Control;
			this.e_set_textBox.Location = new System.Drawing.Point(160, 221);
			this.e_set_textBox.Name = "e_set_textBox";
			this.e_set_textBox.ReadOnly = true;
			this.e_set_textBox.Size = new System.Drawing.Size(81, 20);
			this.e_set_textBox.TabIndex = 20;
			// 
			// d_set_textBox
			// 
			this.d_set_textBox.BackColor = System.Drawing.SystemColors.Control;
			this.d_set_textBox.Location = new System.Drawing.Point(160, 247);
			this.d_set_textBox.Name = "d_set_textBox";
			this.d_set_textBox.ReadOnly = true;
			this.d_set_textBox.Size = new System.Drawing.Size(81, 20);
			this.d_set_textBox.TabIndex = 21;
			// 
			// info_textBox
			// 
			this.info_textBox.Location = new System.Drawing.Point(12, 428);
			this.info_textBox.Multiline = true;
			this.info_textBox.Name = "info_textBox";
			this.info_textBox.Size = new System.Drawing.Size(872, 63);
			this.info_textBox.TabIndex = 9;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(896, 501);
			this.Controls.Add(this.info_textBox);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label firstPrime_p_label;
		private System.Windows.Forms.Label secoundPrime_q_label;
		private System.Windows.Forms.Label rangeLabel;
		private System.Windows.Forms.TextBox rangeFromtextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox rangeTotextBox;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox d_set_textBox;
		private System.Windows.Forms.TextBox e_set_textBox;
		private System.Windows.Forms.TextBox phi_set_textBox;
		private System.Windows.Forms.TextBox n_set_textBox;
		private System.Windows.Forms.TextBox q_set_textBox;
		private System.Windows.Forms.TextBox p_set_textBox;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnSet;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox e_textBox;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.TextBox q_primetextBox;
		private System.Windows.Forms.TextBox p_primetextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox info_textBox;
	}
}

