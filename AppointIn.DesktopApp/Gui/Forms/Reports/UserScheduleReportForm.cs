using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppointIn.Core.Reports;

using AppointIn.Data;
using AppointIn.DesktopApp.Gui.Extensions;

namespace AppointIn.DesktopApp.Gui
{
	public partial class UserScheduleReportForm : ReportForm, Interfaces.ILocalizable
	{
		public UserScheduleReportForm()
		{
		}

		#region Properties
		private DateTime Start
		{
			get => new DateTime(
				StartDateDateTimePicker.Value.Year,
				StartDateDateTimePicker.Value.Month,
				StartDateDateTimePicker.Value.Day,
				StartTimeDateTimePicker.Value.Hour,
				StartTimeDateTimePicker.Value.Minute,
				0).ToUniversalTime();
		}

		private DateTime End
		{
			get => new DateTime(
				EndDateDateTimePicker.Value.Year,
				EndDateDateTimePicker.Value.Month,
				EndDateDateTimePicker.Value.Day,
				EndTimeDateTimePicker.Value.Hour,
				EndTimeDateTimePicker.Value.Minute,
				59).ToUniversalTime();
		}
		#endregion

		#region Methods
		protected override void AttachEvents()
		{
			base.AttachEvents();

			if (StartDateDateTimePicker != null) StartDateDateTimePicker.ValueChanged += (sender, e) =>
			{
				LimitDates();
				GenerateReport();
			};
			if (StartTimeDateTimePicker != null) StartTimeDateTimePicker.ValueChanged += (sender, e)
					 => GenerateReport();

			if (EndDateDateTimePicker != null) EndDateDateTimePicker.ValueChanged += (sender, e) =>
			{
				LimitDates();
				GenerateReport();
			};
			if (EndTimeDateTimePicker != null) EndTimeDateTimePicker.ValueChanged += (sender, e)
					 => GenerateReport();
		}

		private void DisableDateTimePickers()
		{
			StartDateDateTimePicker.Enabled = false;
			StartTimeDateTimePicker.Enabled = false;
			EndDateDateTimePicker.Enabled = false;
			EndTimeDateTimePicker.Enabled = false;
		}

		private void EnableDateTimePickers()
		{
			StartDateDateTimePicker.Enabled = true;
			StartTimeDateTimePicker.Enabled = true;
			EndDateDateTimePicker.Enabled = true;
			EndTimeDateTimePicker.Enabled = true;
		}

		protected override void Init()
		{
			base.Init();

			InitializeComponent();

			AttachEvents();

			LocalizeText();

			Reset();

			GenerateReport();
		}

		private void GenerateReport()
		{
			DisableDateTimePickers();

			var report = new UserScheduleReport(
				new UserScheduleReport.Parameters() {
					AppointmentFormatter = appointment => appointment.ToLocalString(),
					Appointments = UnitOfWork.Data.Appointments,
					Start = Start,
					End = End,
					Users = UnitOfWork.Data.Users
				},
				new UserScheduleReport.Strings() {
					AppointmentPluralNoun = Resources.ReportFormStrings.AppointmentNounPlural,
					AppointmentSingularNoun = Resources.ReportFormStrings.AppointmentNounSingular,
					Start = Start.ToLongDateAndTimeString(),
					End = Start.ToLongDateAndTimeString(),
					Title = Resources.UserScheduleReportFormStrings.Title,
					DateRangeMessage = Resources.UserScheduleReportFormStrings.ReportDateRangeMessage,
					AppointmentsFoundForUser = Resources.UserScheduleReportFormStrings.AppointmentsFoundForUserMessage
				});

			TextBox.Text = report.Generate();

			EnableDateTimePickers();
		}

		public override void LocalizeText(string cultureName = "")
		{
			base.LocalizeText(cultureName);

			Text = Resources.UserScheduleReportFormStrings.Title;

			if (DescriptionLabel != null) DescriptionLabel.Text = Resources.UserScheduleReportFormStrings.DescriptionLabelText;
			if (StartLabel != null) StartLabel.Text = Resources.UserScheduleReportFormStrings.StartLabelText;
			if (EndLabel != null) EndLabel.Text = Resources.UserScheduleReportFormStrings.EndLabelText;
		}

		protected override void Reset()
		{
			base.Reset();

			var today = DateTime.Today;

			StartDateDateTimePicker.Value = today;
			StartTimeDateTimePicker.Value = StartDateDateTimePicker.Value;

			EndDateDateTimePicker.Value = today.AddDays(7);
			EndTimeDateTimePicker.Value = EndDateDateTimePicker.Value;

			LimitDates();
		}

		private void LimitDates()
		{
			EndDateDateTimePicker.MinDate = StartDateDateTimePicker.Value.AddMinutes(5);
			EndTimeDateTimePicker.MinDate = EndDateDateTimePicker.Value;
			var startDate = EndDateDateTimePicker.Value;
			EndTimeDateTimePicker.Value = new DateTime(startDate.Year, startDate.Month, startDate.Day, 23, 59, 59);
		}
		#endregion
	}
}
