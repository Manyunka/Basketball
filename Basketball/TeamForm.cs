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
	}
}
