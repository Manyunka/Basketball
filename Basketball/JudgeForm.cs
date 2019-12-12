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
	public partial class JudgeForm : Form
	{
		private readonly int id;

		public JudgeForm(int id)
		{
			InitializeComponent();
			this.id = id;
		}

		private void CreateCompButton_Click(object sender, EventArgs e)
		{
			if (compTextBox.TextLength > 0 && countryTextBox.TextLength > 0)
			{
				bool flag = true;
				using (BasketballContext db = new BasketballContext())
				{
					var comppetitions = db.Competition.ToList();
					foreach (var comp in comppetitions)
						if (comp.Name == compTextBox.Text &&
							comp.Country == countryTextBox.Text &&
							comp.Year == yearNumericUpDown.Value)
						{
							flag = false;
							break;
						}
				}

				if (flag)
				{
					using (BasketballContext db = new BasketballContext())
					{
						Competition comp = new Competition
						{
							Name = compTextBox.Text,
							Country = countryTextBox.Text,
							Year = yearNumericUpDown.Value
						};
						db.Competition.Add(comp);
						db.SaveChanges();
					}
					MessageBox.Show("Соревнование успешно добавлено!");
				}
				else MessageBox.Show("Соревнование уже существует");
			}
			else MessageBox.Show("Данные введены некорректно");
		}

		private void JudgeForm_Load(object sender, EventArgs e)
		{

		}
	}
}
