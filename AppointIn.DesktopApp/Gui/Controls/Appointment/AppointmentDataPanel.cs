using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppointIn.Data;
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
				return _appointment;
			}

			set
			{
				_appointment = value;
				BindGui();
			}
		}

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
			get => Mode == Interfaces.DataPanelMode.View;
			set => Mode = value ? Interfaces.DataPanelMode.View : Interfaces.DataPanelMode.Edit;
		}
		#endregion

		#region Methods
		private void AttachEvents()
		{
			if(StartDateTimePicker != null) StartDateTimePicker.DateTimePicker.ValueChanged += (sender, e) => LimitDates();
		}

		private void BindEntity() {
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

		private void BindGui() {
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
			//LastUpdateExtendedTextbox.Text = _appointment.LastUpdate.ToString();
			LastUpdateByExtendedTextbox.Text = _appointment.LastUpdateBy;

			LimitDates();
		}

		private void Init() {
			InitializeComponent();

			AttachEvents();

			Reset();
		}

		public void LimitDates()
		{
			StartDateTimePicker.MinDate = DateTime.Now.AddMinutes(1);
			EndDateTimePicker.MinDate = StartDateTimePicker.Value.AddMinutes(15);
		}

		public void LocalizeText(string culture ="")
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
			TitleExtendedTextbox.Readonly = false;
			DescriptionExtendedTextBox.Readonly = false;
			LocationExtendedTextBox.Readonly = false;
			ContactExtendedTextbox.Readonly = false;
			TypeExtendedTextbox.Readonly = false;
			UrlExtendedTextBox.Readonly = false;
			StartDateTimePicker.Enabled = true;
		}

		public void MakeInputsReadOnly()
		{
			TitleExtendedTextbox.Readonly = true;
			DescriptionExtendedTextBox.Readonly = true;
			LocationExtendedTextBox.Readonly = true;
			ContactExtendedTextbox.Readonly = true;
			TypeExtendedTextbox.Readonly = true;
			UrlExtendedTextBox.Readonly = true;
			StartDateTimePicker.Enabled = false;
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
		}

		public void SyncData()
		{
			CustomerComboBox.ComboBox.Bind(UnitOfWork.Data.Customers.GetAll(), "Name");
			UserComboBox.ComboBox.Bind(UnitOfWork.Data.Users.GetAll(), "Username");
		}
		#endregion
	}
}
