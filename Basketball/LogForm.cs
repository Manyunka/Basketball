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
		private string regLogin;
		private string regPassword;
		private string teamName;
		private string countryName;
		private string trainerName;
		private string trainerSurname;
		public LogForm()
		{
			InitializeComponent();
		}

		private void NextRegButton_Click(object sender, EventArgs e)
		{
			if (regLoginTextBox.TextLength > 0 &&
				regPasswordTextBox.TextLength > 0 &&
				confPasswordextBox.Text == regPasswordTextBox.Text)
			{
				bool flag = true;
				using (BasketballContext db = new BasketballContext())
				{
					var teams = db.Team.ToList();
					foreach (var t in teams)
						if (t.Login == regLoginTextBox.Text)
						{
							flag = false;
							break;
						}
				}

				if (flag)
				{
					regLogin = regLoginTextBox.Text;
					regPassword = regPasswordTextBox.Text;

					teamPanel.BringToFront();
				}
				else MessageBox.Show("Логин занят");
			}
			else MessageBox.Show("Данные введены некорректно");
		}

		private void BackTeamButton_Click(object sender, EventArgs e)
		{
			registerPanel.BringToFront();
		}

		private void NextTeamButton_Click(object sender, EventArgs e)
		{
			if (teamTextBox.TextLength > 0 &&
				countryTextBox.TextLength > 0 &&
				trainerNameTextBox.TextLength > 0 &&
				trainerSurnameTextBox.TextLength > 0)
			{

				bool flag = true;
				using (BasketballContext db = new BasketballContext())
				{
					var teams = db.Team.ToList();
					foreach (var t in teams)
						if (t.Name == teamTextBox.Text)
						{
							flag = false;
							break;
						}
				}

				if (flag)
				{
					teamName = teamTextBox.Text;
					countryName = countryTextBox.Text;
					trainerName = trainerNameTextBox.Text;
					trainerSurname = trainerSurnameTextBox.Text;

					playerPanel.BringToFront();
				}
				else MessageBox.Show("Такая команда уже существует");
			}
			else MessageBox.Show("Данные введены некорректно");
		}

		private void BackPlayerButton_Click(object sender, EventArgs e)
		{
			teamPanel.BringToFront();
		}

		private void RegisterButton_Click(object sender, EventArgs e)
		{
			string[] playerNames = playerNameTextBox.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
			string[] playerSurnames = playerSurnameTextBox.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

			if (playerNames.Length == 5 && playerSurnames.Length == 5)
			{
				using (BasketballContext db = new BasketballContext())
				{
					Team t = new Team
					{
						Login = regLogin,
						Password = regPassword,
						Name = teamName,
						Сountry = countryName,
						Rating = 0,
						TrainerName = trainerName,
						TrainerSurname = trainerSurname
					};
					db.Team.Add(t);
					db.SaveChanges();

					for (int i = 0; i < 5; i++)
					{
						Player p = new Player
						{
							Name = playerNames[i],
							Surname = playerSurnames[i],
							Rating = 0,
							TeamId = t.Id
						};
						db.Player.Add(p);
					}
					db.SaveChanges();
					registerPanel.BringToFront();
				}
			}
			else MessageBox.Show("Данные введены некорректно");
		}

		private void LoginButton_Click(object sender, EventArgs e)
		{
			if (loginTextBox.TextLength > 0 && passwordTextBox.TextLength > 0)
			{
				bool flag = false;
				using (BasketballContext db = new BasketballContext())
				{
					if (teamRadioButton.Checked)
					{
						var teams = db.Team.ToList();
						foreach (var t in teams)
							if (t.Login == loginTextBox.Text && t.Password == passwordTextBox.Text)
							{
								TeamForm tF = new TeamForm(t.Id);
								tF.ShowDialog();
								flag = true;
								break;
							}
					}
					else if (judgeRadioButton.Checked)
					{
						var judges = db.Judge.ToList();
						foreach (var j in judges)
							if (j.Login == loginTextBox.Text && j.Password == passwordTextBox.Text)
							{
								JudgeForm jF = new JudgeForm(j.Id);
								jF.ShowDialog();
								flag = true;
								break;
							}
					}
				}
				if (flag)
					Close();
				else MessageBox.Show("Неверный логин или пароль");
			}
			else MessageBox.Show("Данные введены некорректно");
		}
	}
}
