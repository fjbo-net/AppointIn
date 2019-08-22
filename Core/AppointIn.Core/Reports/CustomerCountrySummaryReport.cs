using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Domain.Entities;
using AppointIn.Domain.Repositories;

namespace AppointIn.Core.Reports
{
	public class CustomerCountrySummaryReport : Abstracts.Report
	{
		#region Constructors
		public CustomerCountrySummaryReport(Parameters parameters, Strings strings)
		{
			_Parameters = parameters;
			_Strings = strings;
		}
		#endregion


		#region Structs
		public struct Parameters
		{
			public IAppointmentRepository Appointments;
			public IRepository<Country, int> Countries;
			public IRepository<Customer, int> Customers;
			public Func<Appointment, string> AppointmentFormatter;
			public int SelectedCountryId;
		}

		public struct Strings
		{
			public string Title;
			public string SelectedCountry;
			public string NoCountriesFoundMessage;
			public string NoAppointmentsFoundMessage;
			public string CountryWithMostCustomersMessage;
			public string NoMatchFoundMessage;
		}
		#endregion


		#region Properties
		private Parameters _Parameters;
		private Strings _Strings;
		#endregion


		#region Methods
		public override string Generate()
		{
			var builder = new StringBuilder();

			builder.AppendLine($"{_Strings.Title}, {_Strings.SelectedCountry}".ToUpper());
			builder.AppendLine();

			if (_Parameters.Countries.GetAll().Any())
			{
				var customers = _Parameters.Customers.GetAll();
				var countries = _Parameters.Countries.GetAll();
				var countByCountry = new Dictionary<int, int>();

				if (_Parameters.SelectedCountryId == -1)
				{
					foreach(var country in countries)
					{
						var customerCountForCountry = customers
							// Using lambdas for LINQ's lambda expression notation
							.Where(customer => customer.Address.City.CountryId == country.Id)
							.Count();

						if (customerCountForCountry > 0) countByCountry
								.Add(country.Id, customerCountForCountry);
					}
				}
				else
				{
					var customerCountForCountry = customers
						// Using lambdas for LINQ's lambda expression notation
						.Where(customer =>
							customer.Address.City.Country.Id == _Parameters.SelectedCountryId)
						.Count();

					countByCountry.Add(_Parameters.SelectedCountryId, customerCountForCountry);
				}

				if (!countByCountry.Keys.Any())
				{
					builder.AppendLine(_Strings.NoMatchFoundMessage);
					return builder.ToString();
				}

				var countryIdsOrderedByCustomerVolume = countByCountry
					.Keys
					// Using lambdas for LINQ's lambda expression notation
					.Select(key => new { CountryId = key, Count = countByCountry[key] })
					.OrderByDescending(x => x.Count)
					.Select(x => x.CountryId);

				if (_Parameters.SelectedCountryId == -1 && countByCountry.Keys.Count() > 0)
				{
					builder.AppendLine(string.Format(
						_Strings.CountryWithMostCustomersMessage,
						_Parameters.Countries
							.GetById(countryIdsOrderedByCustomerVolume.First()).Name));
					builder.AppendLine();
				}

				foreach (var countryId in countryIdsOrderedByCustomerVolume)
				{
					var customersForCountry = customers
						// Using lambdas for LINQ's lambda expression notation
						.Where(customer
							=> customer.Address.City.Country.Id == countryId)
						.OrderBy(customer => customer.Name);

					var currentCountryName = _Parameters.Countries.GetById(countryId).Name;

					builder.AppendLine($"{currentCountryName.ToUpper()} ({countByCountry[countryId]}):");

					foreach (var customer in customersForCountry)
					{
						builder.AppendLine($"\t{customer.Name}");
					}

					builder.AppendLine();
				}
			} else
			{
				builder.AppendLine(_Strings.NoCountriesFoundMessage);
			}

			return builder.ToString();
		}
		#endregion
	}
}
