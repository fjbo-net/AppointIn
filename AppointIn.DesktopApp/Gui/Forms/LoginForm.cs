using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppointIn.Data;
using AppointIn.Domain.Entities;
using AppointIn.DesktopApp.Gui.Extensions;

namespace AppointIn.DesktopApp.Gui
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
		internal User User = null;
		#endregion


		#region Methods
		protected override void AttachEvents()
		{
			LoginButton.Click += (sender, e) => Login();

			LanguageCombobox.SelectedIndexChanged += (sender, e) =>
			{
				LocalizeText(LanguageCombobox.SelectedValue.ToString());
			};
		}

		protected override void Init()
		{
			InitializeVisualStyles();

			SyncData();

			Localize();
		}

		protected override void InitializeVisualStyles()
		{
			base.InitializeVisualStyles();

			InitializeComponent();
		}

		private void Localize()
		{
			LanguageCombobox.SelectedIndex = 0;

			var currentCulture = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName.ToLower();

			foreach(KeyValuePair<string,string> item in LanguageCombobox.Items)
			{
				if(item.Key.Equals(currentCulture, StringComparison.OrdinalIgnoreCase))
				{
					LocalizeText(currentCulture);
					return;
				}
			}

			LocalizeText(LanguageCombobox.SelectedValue.ToString());
		}

		public override void LocalizeText(string cultureName = "")
		{
			base.LocalizeText();

			if(!string.IsNullOrEmpty(cultureName) && !string.IsNullOrWhiteSpace(cultureName))
			{
				Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(cultureName);

				var parent = this.Owner;

				if (parent is BaseForm) ((BaseForm)parent).LocalizeText(cultureName);
			}

			Text = Resources.LoginFormStrings.Title;

			usernameLabel.Text = Resources.LoginFormStrings.UsernameLabelText;
			passwordLabel.Text = Resources.LoginFormStrings.PasswordLabelText;
			LanguageLabel.Text = Resources.LoginFormStrings.LanguageLabelText;
			LoginButton.Text = Resources.LoginFormStrings.LoginButtonText;

			
		}


		private void Login()
		{
			var repository = UnitOfWork.Data.Users;

			var loginResult = Core.User.Actions.UserActions.LogUserIn(repository, usernameTextbox.Text, passwordTextbox.Text);

			if (loginResult.Value != null)
			{
				User = loginResult.Value;
				DialogResult = DialogResult.OK;
				Close();
			}
			else
			{
				var message = new StringBuilder();

				foreach (var resultMessage in loginResult.Messages) message.Append(resultMessage);

				MessageBox.Show(message.ToString(), "Could not login", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void SyncData()
		{
			var languages = new Dictionary<string, string>() {
				{"en", "English"},
				{"es", "Español"}
			};

			LanguageCombobox.Bind(languages);
		}
		#endregion
	}
}
