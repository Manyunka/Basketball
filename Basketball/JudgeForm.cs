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
		private IList<int> matchCompIds = new List<int>();

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

		private void CreateMatchButton_Click(object sender, EventArgs e)
		{
			if (matchCompComboBox.SelectedIndex == -1)
				MessageBox.Show("Выберите соревнование");
			else
			{
				using (BasketballContext db = new BasketballContext())
				{
					int ind = matchCompIds[matchCompComboBox.SelectedIndex];
					int requestCount = db.Request.Count(r => r.CompetitionId == ind);
					if (requestCount == 8)
					{
						var matches = db.Match.Where(m => m.Request1.CompetitionId == ind);
						int count = matches.Count();
						MessageBox.Show(count.ToString());
						if (count < 7)
						{
							var finishedMatches = matches.Where(m => m.IsFinished == false);
							if (finishedMatches.Count() > 0 && (count == 4 || count == 6))
							{
								MessageBox.Show("Не все команды закончили раунд");
							}
							else
							{
								int round;
								if (count < 4) round = 1;
								else if (count < 6) round = 2;
								else round = 3;

								var freeRequest = db.Request.Where(r => r.Match.Count(m => m.Round == round) == 0 &&
								r.Match1.Count(m => m.Round == round) == 0 && (r.Match.Count(m => m.Score1 > m.Score2) == round - 1 || r.Match1.Count(m => m.Score2 > m.Score1) == round - 1));

								if (freeRequest.Count() > 0)
								{
									IList<Request> requestIds = freeRequest.ToList();
									Random rnd = new Random();

									int id1 = rnd.Next(requestIds.Count() - 1);
									var req1 = requestIds[id1];
									requestIds.RemoveAt(id1);

									int id2 = rnd.Next(requestIds.Count() - 1);
									var req2 = requestIds[id2];

									Match match = new Match
									{
										Round = round,
										Date = matchDatePicker.Value.Date + matchTimePicker.Value.TimeOfDay,
										IsFinished = false,
										RequestId1 = req1.Id,
										RequestId2 = req2.Id,
										Score1 = 0,
										Score2 = 0
									};
									db.Match.Add(match);
									db.SaveChanges();

									roundLabel.Text = "Раунд:\n" + round;
									team1Label.Text = "Команда №1:\n" + req1.Team.Name;
									team2Label.Text = "Команда №2:\n" + req2.Team.Name;
									MessageBox.Show("Матч создан!");
								}
								else MessageBox.Show("Нет команд для распределения");
							}
						}
						else MessageBox.Show("Турнирная сетка уже заполнена");
					}
					else MessageBox.Show("Недостаточно заявок на соревнование");
				}
			}
		}

		private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tabControl.SelectedTab.Text == "Создать матч")
			{
				matchCompIds.Clear();
				matchCompComboBox.Items.Clear();
				using (BasketballContext db = new BasketballContext())
				{
					var competitions = db.Competition.ToList();
					foreach (var comp in competitions)
					{
						matchCompComboBox.Items.Add(comp.Name + "-" + comp.Year + "-" + comp.Country);
						matchCompIds.Add(comp.Id);
					}
				}
			}
		}
	}
}
