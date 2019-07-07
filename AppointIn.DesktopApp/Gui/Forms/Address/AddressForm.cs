using System.Windows.Forms;

using AppointIn.Domain.Entities;

namespace AppointIn.DesktopApp.Gui
{
	public partial class AddressForm : BaseForm, Interfaces.ILocalizable
	{
		public AddressForm()
		{
			Localizables.All.Add(this);

			AttachEvents();
		}

		#region Properties
		public Address Address
		{
			get => DataPanel.Address;
			set => DataPanel.Address = value;
		}
		#endregion

		#region Methods
		protected override void AttachEvents()
		{
			base.AttachEvents();
			
			if(SaveActionButton != null)
			{
				SaveActionButton.Click += (sender, e) =>
				{
					Hide();
					DialogResult = DialogResult.OK;
				};
			}
		}

		protected override void Init()
		{
			base.Init();

			InitializeComponent();

			LocalizeText();
		}

		public override void LocalizeText(string cultureName = "")
		{
			base.LocalizeText(cultureName);

			Text = Resources.AddressFormStrings.Title;

			if (DataPanel != null) DataPanel.LocalizeText(cultureName);

			if (SaveActionButton != null) SaveActionButton.Text = Resources.BaseFormStrings.SaveButtonText;
			if (CancelActionButton != null) CancelActionButton.Text = Resources.BaseFormStrings.CancelButtonText;
		}

		public void Reset() => DataPanel.Reset();
		#endregion
	}
}
