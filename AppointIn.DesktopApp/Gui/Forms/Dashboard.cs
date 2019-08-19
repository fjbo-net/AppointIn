﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppointIn.Data;

using AppointIn.Domain.Entities;

namespace AppointIn.DesktopApp.Gui
{
	public partial class Dashboard : BaseForm, Interfaces.ILocalizable
	{
		#region Constructor
		public Dashboard() : base()
		{
			this.Visible = false;
			Localizables.All.Add(this);

			using (var loginForm = new LoginForm())
			{
				loginForm.ShowDialog();

				if (loginForm.DialogResult != DialogResult.OK)
				{
					Load += (sender, e) => Close();
				}

				User = loginForm.User;

				Load += (sender, e) =>
				{
					Timer.Tick += IntervalTickHandler;

					Timer.Enabled = true;

					CheckForNextAppointments();
				};
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
		protected Timer Timer = new Timer()
		{
			Interval = 45000,
			Enabled = false
		};

		protected List<Appointment> NotifiedAppointments = new List<Appointment>();
		#endregion


		#region Methods
		protected override void AttachEvents()
		{
			base.AttachEvents();

			AttachManageRecordsMenuEvents();
			AttachReportsMenuEvents();
		}

		private void AttachManageRecordsMenuEvents()
		{
			ManageCustomersMenuItem.Click += (sender, e) =>
			{
				if (CustomersForm.Visible)
				{
					CustomersForm.Focus();
					return;
				}

				CustomersForm.Visible = true;
			};

			ManageCountriesMenuItem.Click += (sender, e) =>
			{
				if (AllCountriesForm.SharedInstance.Visible)
				{
					AllCountriesForm.SharedInstance.Focus();
					return;
				}

				AllCountriesForm.SharedInstance.Visible = true;
			};

			ManageCitiesMenuItem.Click += (sender, e) =>
			{
				if (AllCitiesForm.SharedInstance.Visible)
				{
					AllCitiesForm.SharedInstance.Focus();
					return;
				}

				AllCitiesForm.SharedInstance.Visible = true;
			};

			ManageAddressesMenuItem.Click += (sender, e) =>
			{
				if (AllAddressesForm.SharedInstance.Visible)
				{
					AllAddressesForm.SharedInstance.Focus();
					return;
				}

				AllAddressesForm.SharedInstance.Visible = true;
			};

			ManageAppointmentsMenuItem.Click += (sender, e) =>
			{
				if (AllAppointmentsForm.SharedInstance.Visible)
				{
					AllAppointmentsForm.SharedInstance.Focus();
					return;
				}

				AllAppointmentsForm.SharedInstance.Visible = true;
			};
		}

		private void AttachReportsMenuEvents()
		{
			AppointmentsPerMonthReportMenuButton.Click += (sender, e)
				=> new AppointmentsPerMonthReportForm().Show();

			UserScheduleReportMenuButton.Click += (sender, e)
				=> new UserScheduleReportForm().Show();

			CustomerCountrySummaryMenuButton.Click += (sender, e)
				=> new CustomerCountrySummaryReportForm().Show();
		}

		protected void CheckForNextAppointments()
		{
			var nextAppointment = UnitOfWork.Data.Appointments
						.GetNextAppointments(User)
						.Where(appointment =>
							!NotifiedAppointments
							.Any(notifiedAppointment =>
								notifiedAppointment.Id == appointment.Id)
						)
						.SingleOrDefault();

			if (nextAppointment != null)
			{
				NotifiedAppointments.Add(nextAppointment);
				new NotificationForm(nextAppointment).ShowDialog();
			}
		}

		protected void ClearNotifiedAppointmentsList()
		{
			var now = DateTime.Now.ToUniversalTime();
			NotifiedAppointments = NotifiedAppointments
				.Where(a => a.Start >= now)
				.ToList();
		}

		protected override void InitializeVisualStyles()
		{
			base.InitializeVisualStyles();
			InitializeComponent();

			LocalizeText();
		}

		public override void LocalizeText(string cultureName = "")
		{
			Text = Resources.DashboardFormStrings.Title;

			ManageRecordsMenuButton.Text = Resources.DashboardFormStrings.ManageRecordsMenuButtonText;
			ManageCountriesMenuItem.Text = Resources.DashboardFormStrings.ManageCountriesMenuButtonText;
			ManageCitiesMenuItem.Text = Resources.DashboardFormStrings.ManageCitiesMenuButtonText;
			ManageAddressesMenuItem.Text = Resources.DashboardFormStrings.ManageAddressesMenuButtonText;
			ManageCustomersMenuItem.Text = Resources.DashboardFormStrings.ManageCustomersMenuButtonText;
			ManageAppointmentsMenuItem.Text = Resources.DashboardFormStrings.ManageAppointmentsMenuButtonText;

			ReportsMenuButton.Text = Resources.DashboardFormStrings.ReportsMenuButtonText;
			AppointmentsPerMonthReportMenuButton.Text = Resources.DashboardFormStrings.AppointmentsPerMonthReportMenuButtonText;
			UserScheduleReportMenuButton.Text = Resources.DashboardFormStrings.UserScheduleReportMenuButtonText;
			CustomerCountrySummaryMenuButton.Text = Resources.DashboardFormStrings.CustomerCountrySummaryMenuButtonText;

			UpcomingAppointmentsGroupbox.Text = Resources.DashboardFormStrings.UpcomingAppointmentsLabelText;
		}

		#region EventHandlers
		private void IntervalTickHandler(object sender, EventArgs e)
		{
			CheckForNextAppointments();

			ClearNotifiedAppointmentsList();

			Syncables.SyncAll();
		}
		#endregion
		#endregion
	}
}
