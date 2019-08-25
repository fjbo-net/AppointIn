using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppointIn.Domain.Extensions;
using AppointIn.Data;
using AppointIn.Domain.Classes;
using AppointIn.Domain.Entities;
using AppointIn.DesktopApp.Gui.Extensions;
using AppointIn.DesktopApp.Gui.Interfaces;

namespace AppointIn.DesktopApp.Gui.Controls
{
	public partial class AppointmentDataPanel : UserControl, ILocalizable, ISyncable, Interfaces.IDataPanel
	{
		#region Constructors
		public AppointmentDataPanel()
		{
			Init();

			Localizables.All.Add(this);
			Syncables.All.Add(this);
		}

		public AppointmentDataPanel(Interfaces.DataPanelMode mode) : this()
		{

		}
		#endregion

		#region Properties
		private Domain.Entities.Appointment _appointment;
		[Bindable(false)]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Domain.Entities.Appointment Appointment
		{
			get
			{
				BindEntity();

				var originalStart = _appointment.Start;
				var originalEnd = _appointment.End;

				// Create new DateTime objects to clean the seconds for better calculations
				_appointment.Start = new DateTime(
					originalStart.Year,
					originalStart.Month,
					originalStart.Day,
					originalStart.Hour,
					originalStart.Minute,
					0);

				_appointment.End = new DateTime(
					originalEnd.Year,
					originalEnd.Month,
					originalEnd.Day,
					originalEnd.Hour,
					originalEnd.Minute,
					0);

				_appointment.CreateDate = _appointment.CreateDate.ToUniversalTime();
				_appointment.Start = _appointment.Start.ToUniversalTime();
				_appointment.End = _appointment.End.ToUniversalTime();

				return _appointment;
			}

			set
			{
				ClearDateLimits();

				_appointment = value;

				var originalStart = _appointment.Start.ToLocalTime();
				var originalEnd = _appointment.End.ToLocalTime();

				_appointment.CreateDate = _appointment.CreateDate.ToLocalTime();

				// Create new DateTime objects to clean the seconds for better calculations
				_appointment.Start = new DateTime(
					originalStart.Year,
					originalStart.Month,
					originalStart.Day,
					originalStart.Hour,
					originalStart.Minute,
					0);

				_appointment.End = new DateTime(
					originalEnd.Year,
					originalEnd.Month,
					originalEnd.Day,
					originalEnd.Hour,
					originalEnd.Minute,
					0);

				BindGui();
			}
		}

		[Bindable(false)]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		// Using lambda expression to simplify GET only property
		public ValidationResult IsValid { get => ValidateValue(); }

		private Interfaces.DataPanelMode mode = Interfaces.DataPanelMode.Edit;
		public Interfaces.DataPanelMode Mode
		{
			get => mode;

			set
			{
				switch (value)
				{
					case Interfaces.DataPanelMode.View:
						MakeInputsReadOnly();
						break;
					default:
						MakeInputsEditable();
						break;
				}

				mode = value;
			}
		}

		[Bindable(false)]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ReadOnly
		{
			// Using lambda expressions to simplify property's getter and setter
			get => Mode == Interfaces.DataPanelMode.View;
			set => Mode = value ? Interfaces.DataPanelMode.View : Interfaces.DataPanelMode.Edit;
		}
		#endregion

		#region Methods
		private void AttachEvents()
		{
			// Using lambda expression to simplify event handler due to handler's simplicity
			if (StartDateTimePicker != null) StartDateTimePicker.DateTimePicker.ValueChanged += (sender, e) =>
			{
				if (((DateTimePicker)sender).Focused) LimitDates();
			};
		}

		private void BindEntity()
		{
			_appointment.Id = int.Parse(IdExtendedTextbox.Text);
			_appointment.Customer = (Customer)CustomerComboBox.ComboBox.SelectedValue;
			_appointment.User = (User)UserComboBox.ComboBox.SelectedValue;
			_appointment.Title = TitleExtendedTextbox.Text;
			_appointment.Description = DescriptionExtendedTextBox.Text;
			_appointment.Location = LocationExtendedTextBox.Text;
			_appointment.Contact = ContactExtendedTextbox.Text;
			_appointment.Type = TypeExtendedTextbox.Text;
			_appointment.Url = UrlExtendedTextBox.Text;
			_appointment.Start = StartDateTimePicker.Value;
			_appointment.End = EndDateTimePicker.Value;
			_appointment.CreateDate = CreateDateDateTimePicker.Value;
			_appointment.CreatedBy = CreatedByExtendedTextbox.Text;
			_appointment.LastUpdateBy = LastUpdateByExtendedTextbox.Text;
		}

		private void BindGui()
		{
			SyncData();

			IdExtendedTextbox.Text = _appointment.Id.ToString();
			CustomerComboBox.ComboBox.SelectedItem = _appointment.Customer;
			UserComboBox.ComboBox.SelectedItem = _appointment.User;
			TitleExtendedTextbox.Text = _appointment.Title;
			DescriptionExtendedTextBox.Text = _appointment.Description;
			LocationExtendedTextBox.Text = _appointment.Location;
			ContactExtendedTextbox.Text = _appointment.Contact;
			TypeExtendedTextbox.Text = _appointment.Type;
			UrlExtendedTextBox.Text = _appointment.Url;
			StartDateTimePicker.Value = _appointment.Start;
			EndDateTimePicker.Value = _appointment.End;
			CreateDateDateTimePicker.Value = _appointment.CreateDate;
			CreatedByExtendedTextbox.Text = _appointment.CreatedBy;
			//LastUpdateExtendedTextbox.Text = _appointment.LastUpdate.AsString();
			LastUpdateByExtendedTextbox.Text = _appointment.LastUpdateBy;

			LimitDates();
		}

		private void ClearDateLimits()
		{
			StartDateTimePicker.MinDate = DateTimePicker.MinimumDateTime;
			EndDateTimePicker.MinDate = DateTimePicker.MinimumDateTime;
		}

		private void Init()
		{
			InitializeComponent();

			AttachEvents();

			Reset();
		}

		public void LimitDates()
		{
			var now = DateTime.Now;

			StartDateTimePicker.MinDate = Appointment.Id == 0
				? now.AddMinutes(1)
				: DateTimePicker.MinimumDateTime;

			EndDateTimePicker.MinDate = StartDateTimePicker.Value.AddMinutes(15);
		}

		public void LocalizeText(string culture = "")
		{
			IdExtendedTextbox.LabelText = Resources.DataPanelStrings.IdLabelText;
			CustomerComboBox.LabelText = Resources.AppointmentDataPanelStrings.CustomerLabelText;
			UserComboBox.LabelText = Resources.AppointmentDataPanelStrings.UserLabelText;
			TitleExtendedTextbox.LabelText = Resources.AppointmentDataPanelStrings.TitleLabelText;
			DescriptionExtendedTextBox.LabelText = Resources.AppointmentDataPanelStrings.DescriptionLabelText;
			LocationExtendedTextBox.LabelText = Resources.AppointmentDataPanelStrings.LocationLabelText;
			ContactExtendedTextbox.LabelText = Resources.AppointmentDataPanelStrings.ContactLabelText;
			TypeExtendedTextbox.LabelText = Resources.AppointmentDataPanelStrings.TypeLabelText;
			UrlExtendedTextBox.LabelText = Resources.AppointmentDataPanelStrings.UrlLabelText;
			StartDateTimePicker.LabelText = Resources.AppointmentDataPanelStrings.StartLabelText;
			EndDateTimePicker.LabelText = Resources.AppointmentDataPanelStrings.EndLabelText;
			CreateDateDateTimePicker.LabelText = Resources.DataPanelStrings.CreateDateLabelText;
			CreatedByExtendedTextbox.LabelText = Resources.DataPanelStrings.CreatedByLabelText;
			LastUpdateExtendedTextbox.LabelText = Resources.DataPanelStrings.LastUpdateLabelText;
			LastUpdateByExtendedTextbox.LabelText = Resources.DataPanelStrings.LastUpdateByLabelText;
		}

		public void MakeInputsEditable()
		{
			CustomerComboBox.Enabled = true;
			UserComboBox.Enabled = true;
			TitleExtendedTextbox.Readonly = false;
			DescriptionExtendedTextBox.Readonly = false;
			LocationExtendedTextBox.Readonly = false;
			ContactExtendedTextbox.Readonly = false;
			TypeExtendedTextbox.Readonly = false;
			UrlExtendedTextBox.Readonly = false;
			StartDateTimePicker.Enabled = true;
			EndDateTimePicker.Enabled = true;
		}

		public void MakeInputsReadOnly()
		{
			CustomerComboBox.Enabled = false;
			UserComboBox.Enabled = false;
			TitleExtendedTextbox.Readonly = true;
			DescriptionExtendedTextBox.Readonly = true;
			LocationExtendedTextBox.Readonly = true;
			ContactExtendedTextbox.Readonly = true;
			TypeExtendedTextbox.Readonly = true;
			UrlExtendedTextBox.Readonly = true;
			StartDateTimePicker.Enabled = false;
			EndDateTimePicker.Enabled = false;
		}

		public void Reset()
		{
			ReadOnly = false;
			var defaultStart = DateTime.Now.AddMinutes(60);
			var defaultEnd = defaultStart.AddMinutes(30);
			Appointment = new Domain.Entities.Appointment()
			{
				Start = defaultStart,
				End = defaultEnd,
				CreateDate = DateTime.Now,
				CreatedBy = Dashboard.Username
			};

			StartDateTimePicker.MinDate = DateTimePicker.MinimumDateTime;
			EndDateTimePicker.MinDate = DateTimePicker.MinimumDateTime;
		}

		public void SyncData()
		{
			CustomerComboBox.ComboBox.Bind(UnitOfWork.Data.Customers.GetAll(), "Name");
			UserComboBox.ComboBox.Bind(UnitOfWork.Data.Users.GetAll(), "Username");
		}

		public ValidationResult ValidateValue()
		{
			var errorMessages = new List<string>();
			var errorFound = false;

			var appointmentResult = Appointment.Validate();

			if (!appointmentResult.IsValid) return appointmentResult;

			// Validate Business Hours
			var start = Appointment.Start.ToLocalTime();
			var end = Appointment.End.ToLocalTime();
			var hours = Dashboard.BusinessHours;

			if (hours.ContainsKey(start.DayOfWeek))
			{
				var businessDay = hours[start.DayOfWeek];

				if (!businessDay.ContainsTimeRange(start, end))
				{
					errorFound = true;
					errorMessages.Add(string.Format(
						Resources.AppointmentDataPanelStrings.OutOfBusinessHoursErrorMessage,
						businessDay.AsString(start)));
				}
			}
			else
			{
				errorFound = true;
				errorMessages.Add(string.Format(
					Resources.AppointmentDataPanelStrings.NoBusinessHoursErrorMessage,
					start.ToLongDateString(),
					Environment.NewLine,
					hours.AsString()));
			}

			// Check for overlapping appointments
			var appointmentsThatOverlap = Appointment.FindOverlappingAppointments(UnitOfWork.Data.Appointments);

			if (appointmentsThatOverlap.Any())
			{
				errorFound = true;
				errorMessages.Add($"{Resources.AppointmentDataPanelStrings.OverlappingAppointmentsErrorMessage}{Environment.NewLine}{appointmentsThatOverlap.AsString()}");
			}

			return new ValidationResult(
				!errorFound && appointmentResult.IsValid,
				appointmentResult.ErrorMessages
					.Concat(errorMessages).ToList());
		}
		#endregion
	}
}
