using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basketball
{
	public partial class LogForm : Form
	{
		string teamName;
		string countryName;
		public LogForm()
		{
			InitializeComponent();
		}

		private void NextButton_Click(object sender, EventArgs e)
		{
			teamName = teamTextBox.Text;
			countryName = countryTextBox.Text;

			playerPanel.BringToFront();
		}

		private void CompComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (compComboBox.Text.Length > 0 &&
				teamTextBox.Text.Length > 0 &&
				countryTextBox.Text.Length > 0)
				nextButton.Enabled = true;
		}

		private void TeamTextBox_TextChanged(object sender, EventArgs e)
		{
			if (compComboBox.Text.Length > 0 &&
				teamTextBox.Text.Length > 0 &&
				countryTextBox.Text.Length > 0)
				nextButton.Enabled = true;
		}

		private void CountryTextBox_TextChanged(object sender, EventArgs e)
		{
			if (compComboBox.Text.Length > 0 &&
				teamTextBox.Text.Length > 0 &&
				countryTextBox.Text.Length > 0)
				nextButton.Enabled = true;
		}

		private void BackButton_Click(object sender, EventArgs e)
		{
			teamPanel.BringToFront();
		}

		private void PlayerTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void RequestButton_Click(object sender, EventArgs e)
		{
			if (playerRadioButton.Checked)
			{

			}
			else if (judgeRadioButton.Checked)
			{

			}
		}
	}
}
