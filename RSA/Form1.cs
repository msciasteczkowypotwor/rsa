using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
			if(int.Parse(rangeFromtextBox.Text) < 2 || int.Parse(rangeTotextBox.Text)>4000000)
			{
				info_textBox.Text = "The range should be from 2 to 4.000.000";
				return;
			}
			VariablesGenerator.list = VariablesGenerator.GetListOfPrimes(int.Parse(rangeFromtextBox.Text), int.Parse(rangeTotextBox.Text));
			VariablesGenerator.SelectRandomPandQ();
			VariablesGenerator.CalculateN();
			VariablesGenerator.CalculatePhi();
		}
	}
}
