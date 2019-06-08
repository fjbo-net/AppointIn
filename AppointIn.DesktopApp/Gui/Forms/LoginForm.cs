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
	public partial class LoginForm : BaseForm
	{
		#region Constructors
		public LoginForm() : base()
		{
			AttachEvents();
		}
		#endregion


		#region Properties
		User User = null;
		#endregion


		#region Methods
		private void AttachEvents()
		{
			LoginButton.Click += (sender, e) => Login();
		}

		protected override void InitializeVisualStyles()
		{
			base.InitializeVisualStyles();

			InitializeComponent();
		}


		private void Login()
		{
			var mockRepository = new TestDataSeed.DataInitializer.UserMockRepository(TestDataSeed.DataInitializer.GetUsers());
			var loginResult = Core.User.Actions.UserActions.LogUserIn(mockRepository, usernameTextbox.Text, passwordTextbox.Text);

			if(loginResult.Value != null)
			{
				User = loginResult.Value;
				DialogResult = DialogResult.OK;
				Close();
			} else
			{
				var message = new StringBuilder();

				foreach (var resultMessage in loginResult.Messages) message.Append(resultMessage);

				MessageBox.Show(message.ToString(), "Could not login", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion
	}
}
