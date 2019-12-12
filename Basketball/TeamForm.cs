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
	public partial class TeamForm : Form
	{
		private readonly int id;
		private IList<int> requestCompIds = new List<int>();

		public TeamForm(int id)
		{
			InitializeComponent();
			this.id = id;
		}

		private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tabControl.SelectedTab.Text == "Подать заявку")
			{
				requestCompIds.Clear();
				requestComboBox.Items.Clear();
				using (BasketballContext db = new BasketballContext())
				{
					var competitions = db.Competition.ToList();
					foreach (var comp in competitions)
					{
						requestComboBox.Items.Add(comp.Name + "-" + comp.Year + "-" + comp.Country);
						requestCompIds.Add(comp.Id);
					}
				}
			}
		}

		private void RequestButton_Click(object sender, EventArgs e)
		{
			if (requestComboBox.SelectedIndex == -1)
				MessageBox.Show("Выберите соревнование");
			else
			{
				using (BasketballContext db = new BasketballContext())
				{
					bool flag = true;
					var requests = db.Request.ToList();
					foreach (var r in requests)
						if (r.TeamId == id && r.CompetitionId == requestCompIds[requestComboBox.SelectedIndex])
						{
							flag = false;
							break;
						}
					
					if (flag)
					{
						int ind = requestCompIds[requestComboBox.SelectedIndex];
						if (db.Request.Count(r => r.CompetitionId == ind) < 8)
						{
							Request req = new Request
							{
								CompetitionId = ind,
								TeamId = id
							};
							db.Request.Add(req);
							db.SaveChanges();
							MessageBox.Show("Заявка успешно подана!");
						}
						else MessageBox.Show("Заявки на это соревнование больше не принимаются");
					}
					else MessageBox.Show("Вы уже участвуете в этом соревновании");
				}
				
			}
		}
	}
}
