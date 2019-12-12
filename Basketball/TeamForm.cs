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

		public TeamForm(int id)
		{
			InitializeComponent();
			this.id = id;
		}

		private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tabControl.SelectedTab.Text == "Подать заявку")
			{
				using (BasketballContext db = new BasketballContext())
				{
					var competitions = db.Competition.ToList();
					foreach (var comp in competitions)
					{
						requestComboBox.Items.Add(comp.Name + "-" + comp.Year + "-" + comp.Country);
					}

				}
			}
		}
	}
}
