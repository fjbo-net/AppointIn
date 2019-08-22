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
using AppointIn.Domain.Entities;
using AppointIn.DesktopApp.Gui.Extensions;

namespace AppointIn.DesktopApp.Gui
{
	public partial class CustomerCountrySummaryReportForm : ReportForm, Interfaces.ILocalizable
	{
		public CustomerCountrySummaryReportForm()
		{
		}

		#region Properties
		private DateTime Start;
		private DateTime End;
		#endregion

		#region Methods
		protected override void AttachEvents()
		{
			base.AttachEvents();
			
			// Using lambda expression to simplify event handler due to handler's simplicity
			if (CountryComboBox != null) CountryComboBox.SelectedValueChanged += (sender, e)
					=> GenerateReport();
		}

		private void BindData()
		{
			var countries = new List<Country>()
			{
				new Country()
				{
					Id = -1,
					Name = Resources.CustomerReportSummaryReportStrings.AnyCountryText
				}
			}
			.Concat(UnitOfWork.Data.Countries.GetAll())
			.ToList();

			CountryComboBox.Bind(countries, "Name");
			CountryComboBox.SelectedIndex = 0;
		}

		private void GenerateReport()
		{
			var selectedCountryID = ((Country)CountryComboBox.SelectedValue).Id;

			var report = new CustomerCountrySummaryReport(
				new CustomerCountrySummaryReport.Parameters()
				{
					Appointments = UnitOfWork.Data.Appointments,
					Countries = UnitOfWork.Data.Countries,
					Customers = UnitOfWork.Data.Customers,
					SelectedCountryId = selectedCountryID
				},
				new CustomerCountrySummaryReport.Strings()
				{
					Title = Resources.CustomerReportSummaryReportStrings.Title,
					NoAppointmentsFoundMessage = Resources.CustomerReportSummaryReportStrings.NoAppointmentsFoundMessage,
					NoCountriesFoundMessage = Resources.CustomerReportSummaryReportStrings.NoCountriesFoundMessage,
					SelectedCountry = ((Country)CountryComboBox.SelectedItem).Name,
					CountryWithMostCustomersMessage = Resources.CustomerReportSummaryReportStrings.CountryWithMostCustomersMessage,
					NoMatchFoundMessage = Resources.CustomerReportSummaryReportStrings.NoMatchFoundMessage
				});

			TextBox.Text = report.Generate();
		}

		protected override void Init()
		{
			base.Init();

			InitializeComponent();

			AttachEvents();

			LocalizeText();

			BindData();

			Reset();

			GenerateReport();
		}

		public override void LocalizeText(string cultureName = "")
		{
			base.LocalizeText(cultureName);

			Text = Resources.CustomerReportSummaryReportStrings.Title;

			if(CountryLabel != null) CountryLabel.Text = Resources.CityDataPanelStrings.CountryLabelText;
		}
		#endregion
	}
}
