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
using AppointIn.Domain.Classes;

namespace AppointIn.DesktopApp.Gui
{
	public partial class CustomerForm : BaseForm, Interfaces.ILocalizable
	{
		public CustomerForm()
		{
			Localizables.All.Add(this);

			AttachEvents();
		}

		#region Properties
		public Customer Customer
		{
			// Using lambda expressions to simplify property's getter and setter
			get => DataPanel.Customer;
			set => DataPanel.Customer = value;
		}

		// Using lambda expression to simplify GET only property
		public ValidationResult IsValid { get => DataPanel.IsValid; }
		#endregion

		#region Methods
		protected override void AttachEvents()
		{
			base.AttachEvents();

			if(SaveActionButton != null)
			{
				// Using lambda expression to simplify event handler due to handler's simplicity
				SaveActionButton.Click += SaveButtonClickHandler;
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

			Text = Resources.CustomerFormStrings.Title;

			if (DataPanel != null) DataPanel.LocalizeText(cultureName);

			if (SaveActionButton != null) SaveActionButton.Text = Resources.BaseFormStrings.SaveButtonText;
			if (CancelActionButton != null) CancelActionButton.Text = Resources.BaseFormStrings.CancelButtonText;
		}

		public void Reset() => DataPanel.Reset();
		#endregion


		#region Event Handlers
		protected void SaveButtonClickHandler(object sender, EventArgs e)
		{
			if (!IsValid)
			{
				Validation.ShowValidationError(string.Format(
					Resources.CustomerFormStrings.InvalidDataFoundMessage,
					Environment.NewLine,
					IsValid.ErrorMessagesAsString()));
				return;
			}

			Hide();
			DialogResult = DialogResult.OK;
		}
		#endregion
	}
}
