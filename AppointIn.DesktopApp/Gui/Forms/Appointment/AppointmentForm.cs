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
	public partial class AppointmentForm : BaseForm, Interfaces.ILocalizable
	{
		public AppointmentForm()
		{
			Localizables.All.Add(this);

			AttachEvents();
		}

		#region Properties
		public Appointment Appointment
		{
			// Using lambda expressions to simplify property's getter and setter
			get => DataPanel.Appointment;
			set => DataPanel.Appointment = value;
		}

		[Bindable(false)]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		// Using lambda expression to simplify GET only property
		public ValidationResult IsValid { get => DataPanel.IsValid; }

		private static AppointmentForm sharedInstance;
		public static AppointmentForm SharedInstance
		{
			get
			{
				if (sharedInstance == null) sharedInstance = new AppointmentForm();
				return sharedInstance;
			}
		}

		public bool ReadOnly
		{
			// Using lambda expression to simplify property getter
			get => DataPanel.ReadOnly;
			set {
				DataPanel.ReadOnly = value;
				SaveActionButton.Enabled = !value;
			}
		}
		#endregion

		#region Methods
		protected override void AttachEvents()
		{
			base.AttachEvents();

			if(SaveActionButton != null)
			{
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

			Text = Resources.AppointmentFormStrings.Title;

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
					Resources.AppointmentFormStrings.InvalidDataFoundMessage,
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
