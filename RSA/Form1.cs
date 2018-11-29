using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace RSA
{
	public partial class Form1 : Form
	{
		private VariablesGenerator VariablesGenerator;

		public Form1()
		{
			InitializeComponent();
			VariablesGenerator = new VariablesGenerator();
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			info_textBox.Text = "Wait. Computing!";
			info_textBox.Refresh();

			if (!ValidateInputedRange())
			{
				info_textBox.Text = "The range should be from 2 to 4.000.000\r\nSecond value shoud be bigger than first\r\nFirst value minus second value shoud be at least 1000";
				return;
			}
			VariablesGenerator.listOfPrimes = VariablesGenerator.GenerateListOfPrimes(int.Parse(rangeFromtextBox.Text), int.Parse(rangeTotextBox.Text));
			VariablesGenerator.SelectRandomPandQ();
			VariablesGenerator.CalculateN();
			VariablesGenerator.CalculatePhi();
			VariablesGenerator.CalculateE();

			p_set_textBox.Text = VariablesGenerator.p.ToString();
			q_set_textBox.Text = VariablesGenerator.q.ToString();
			n_set_textBox.Text = VariablesGenerator.n.ToString();
			phi_set_textBox.Text = VariablesGenerator.phi.ToString();
			e_set_textBox.Text = VariablesGenerator.e.ToString();

			info_textBox.Text = "Done!";
		}
		private bool ValidateInputedRange()
		{
			int a = int.Parse(rangeFromtextBox.Text);
			int b = int.Parse(rangeTotextBox.Text);
			if (a < 2 || b > 4000000 || a >= b)
				return false;
			if (b - a < 1000)
				return false;
			return true;

		}
	}
}
