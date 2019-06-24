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

namespace AppointIn.DesktopApp.Gui
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

				User = loginForm.User;
			}
			
			CustomersForm = new AllCustomersForm();
		}
		#endregion


		#region Properties
		private User _user;
		private User User
		{
			get => _user;
			set
			{
				_user = value;
				Username = _user != null ? _user.Username : string.Empty;
			}
		}

		internal static string Username { get; private set; }

		protected AllCustomersForm CustomersForm;
		#endregion


		#region Methods
		protected override void AttachEvents()
		{
			base.AttachEvents();

			actionButton1.Click += (sender, e) =>
			{
				if (CustomersForm.Visible)
				{
					CustomersForm.Focus();
					return;
				}

				CustomersForm.Visible = true;
			};

			ManageCountriesButton.Click += (sender, e) =>
			{
				if (AllCountriesForm.SharedInstance.Visible)
				{
					AllCountriesForm.SharedInstance.Focus();
					return;
				}

				AllCountriesForm.SharedInstance.Visible = true;
			};
		}

		protected override void InitializeVisualStyles()
		{
			base.InitializeVisualStyles();
			InitializeComponent();
		}

		public override void LocalizeText(string cultureName = "")
		{
			Text = Resources.DashboardFormStrings.Title;
		}
		#endregion
	}
}
