using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			textBox_Angka1.Clear();
			textBox_angka2.Clear();
			lbl_hasil.Text = "";
		}

		private void btn_clear_Click(object sender, EventArgs e)
		{
			textBox_Angka1.Clear();
			textBox_angka2.Clear();
			lbl_hasil.Text = "";
		}

		private void btn_plus_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(textBox_Angka1.Text) || String.IsNullOrEmpty(textBox_angka2.Text))
			{
				MessageBox.Show("Angka 1 dan Angka 2 harus terisi");
			}
			else {
				int a, b, c;
				a = int.Parse(this.textBox_Angka1.Text);
				b = int.Parse(this.textBox_angka2.Text);
				c = a + b;
				this.lbl_hasil.Text = c.ToString();
			}			
		}

		private void btn_minus_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(textBox_Angka1.Text) || String.IsNullOrEmpty(textBox_angka2.Text))
			{
				MessageBox.Show("Angka 1 dan Angka 2 harus terisi");
			}
			else
			{
				int a, b, c;
				a = int.Parse(this.textBox_Angka1.Text);
				b = int.Parse(this.textBox_angka2.Text);
				c = a - b;
				this.lbl_hasil.Text = c.ToString();
			}
		}

		private void btn_kali_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(textBox_Angka1.Text) || String.IsNullOrEmpty(textBox_angka2.Text))
			{
				MessageBox.Show("Angka 1 dan Angka 2 harus terisi");
			}
			else
			{
				int a, b, c;
				a = int.Parse(this.textBox_Angka1.Text);
				b = int.Parse(this.textBox_angka2.Text);
				c = a * b;
				this.lbl_hasil.Text = c.ToString();
			}
		}

		private void btn_bagi_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(textBox_Angka1.Text) || String.IsNullOrEmpty(textBox_angka2.Text))
			{
				MessageBox.Show("Angka 1 dan Angka 2 harus terisi");
			}
			else
			{
				int a, b, c;
				a = int.Parse(this.textBox_Angka1.Text);
				b = int.Parse(this.textBox_angka2.Text);
				c = a / b;
				this.lbl_hasil.Text = c.ToString();
			}
		}

		private void textBox_Angka1_KeyPress(object sender, KeyPressEventArgs e)
		{
			// hanya bisa diisi angka
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void textBox_Angka2_KeyPress(object sender, KeyPressEventArgs e)
		{
			// hanya bisa diisi angka
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		
	}
}
