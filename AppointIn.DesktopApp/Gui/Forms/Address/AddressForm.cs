using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppointIn.Domain.Classes;
using AppointIn.DesktopApp.Gui.Controls;
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
			// Using lambda expressions to simplify property's getter and setter
			get => DataPanel.Address;
			set => DataPanel.Address = value;
		}

		[Bindable(false)]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[EditorBrowsable(EditorBrowsableState.Never)]
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

			Text = Resources.AddressFormStrings.Title;

			if (DataPanel != null) DataPanel.LocalizeText(cultureName);

			if (SaveActionButton != null) SaveActionButton.Text = Resources.BaseFormStrings.SaveButtonText;
			if (CancelActionButton != null) CancelActionButton.Text = Resources.BaseFormStrings.CancelButtonText;
		}

		// Using lambda expression to simplify call to an object property's method
		public void Reset() => DataPanel.Reset();
		#endregion

		#region Event Handlers
		protected void SaveButtonClickHandler(object sender, EventArgs e)
		{
			if (!IsValid)
			{
				Validation.ShowValidationError(string.Format(
					Resources.AddressFormStrings.InvalidDataFoundMessage,
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
