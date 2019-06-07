using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppointIn.Domain.Entities;

namespace AppointIn.DesktopApp.Gui.Forms
{
	public partial class Dashboard : BaseForm
	{
		#region Constructor
		public Dashboard() : base()
		{
			this.Visible = false;

			using (var loginForm = new LoginForm())
			{

				loginForm.ShowDialog();

				if (loginForm.DialogResult != DialogResult.OK)
				{
					Load += (sender, e) => Close();
				}
			}
		}
		#endregion


		#region Properties
		private User User;
		#endregion


		#region Methods
		protected override void InitializeVisualStyles()
		{
			base.InitializeVisualStyles();
			InitializeComponent();
		}
		#endregion
	}
}
