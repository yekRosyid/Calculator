namespace HelloWorld
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_Angka1 = new System.Windows.Forms.TextBox();
			this.btn_plus = new System.Windows.Forms.Button();
			this.textBox_angka2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_minus = new System.Windows.Forms.Button();
			this.btn_bagi = new System.Windows.Forms.Button();
			this.btn_kali = new System.Windows.Forms.Button();
			this.btn_clear = new System.Windows.Forms.Button();
			this.lbl_hasil = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(70, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Angka 1";
			// 
			// textBox_Angka1
			// 
			this.textBox_Angka1.Location = new System.Drawing.Point(146, 44);
			this.textBox_Angka1.Name = "textBox_Angka1";
			this.textBox_Angka1.Size = new System.Drawing.Size(184, 20);
			this.textBox_Angka1.TabIndex = 1;
			this.textBox_Angka1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Angka1_KeyPress);
			// 
			// btn_plus
			// 
			this.btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_plus.Location = new System.Drawing.Point(94, 181);
			this.btn_plus.Name = "btn_plus";
			this.btn_plus.Size = new System.Drawing.Size(64, 56);
			this.btn_plus.TabIndex = 2;
			this.btn_plus.Text = "+";
			this.btn_plus.UseVisualStyleBackColor = true;
			this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
			// 
			// textBox_angka2
			// 
			this.textBox_angka2.Location = new System.Drawing.Point(146, 81);
			this.textBox_angka2.Name = "textBox_angka2";
			this.textBox_angka2.Size = new System.Drawing.Size(184, 20);
			this.textBox_angka2.TabIndex = 4;
			this.textBox_angka2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Angka2_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(70, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Angka 2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(70, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Hasil";
			// 
			// btn_minus
			// 
			this.btn_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_minus.Location = new System.Drawing.Point(164, 181);
			this.btn_minus.Name = "btn_minus";
			this.btn_minus.Size = new System.Drawing.Size(64, 56);
			this.btn_minus.TabIndex = 7;
			this.btn_minus.Text = "-";
			this.btn_minus.UseVisualStyleBackColor = true;
			this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
			// 
			// btn_bagi
			// 
			this.btn_bagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_bagi.Location = new System.Drawing.Point(164, 243);
			this.btn_bagi.Name = "btn_bagi";
			this.btn_bagi.Size = new System.Drawing.Size(64, 56);
			this.btn_bagi.TabIndex = 9;
			this.btn_bagi.Text = "/";
			this.btn_bagi.UseVisualStyleBackColor = true;
			this.btn_bagi.Click += new System.EventHandler(this.btn_bagi_Click);
			// 
			// btn_kali
			// 
			this.btn_kali.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_kali.Location = new System.Drawing.Point(94, 243);
			this.btn_kali.Name = "btn_kali";
			this.btn_kali.Size = new System.Drawing.Size(64, 56);
			this.btn_kali.TabIndex = 8;
			this.btn_kali.Text = "*";
			this.btn_kali.UseVisualStyleBackColor = true;
			this.btn_kali.Click += new System.EventHandler(this.btn_kali_Click);
			// 
			// btn_clear
			// 
			this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_clear.Location = new System.Drawing.Point(234, 181);
			this.btn_clear.Name = "btn_clear";
			this.btn_clear.Size = new System.Drawing.Size(91, 118);
			this.btn_clear.TabIndex = 10;
			this.btn_clear.Text = "C";
			this.btn_clear.UseVisualStyleBackColor = true;
			this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
			// 
			// lbl_hasil
			// 
			this.lbl_hasil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_hasil.Location = new System.Drawing.Point(143, 119);
			this.lbl_hasil.Name = "lbl_hasil";
			this.lbl_hasil.Size = new System.Drawing.Size(187, 23);
			this.lbl_hasil.TabIndex = 11;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(419, 359);
			this.Controls.Add(this.lbl_hasil);
			this.Controls.Add(this.btn_clear);
			this.Controls.Add(this.btn_bagi);
			this.Controls.Add(this.btn_kali);
			this.Controls.Add(this.btn_minus);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox_angka2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btn_plus);
			this.Controls.Add(this.textBox_Angka1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_Angka1;
		private System.Windows.Forms.Button btn_plus;
		private System.Windows.Forms.TextBox textBox_angka2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btn_minus;
		private System.Windows.Forms.Button btn_bagi;
		private System.Windows.Forms.Button btn_kali;
		private System.Windows.Forms.Button btn_clear;
		private System.Windows.Forms.Label lbl_hasil;
	}
}

