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
using AppointIn.Domain.Classes;
using AppointIn.Domain.Entities;
using AppointIn.Domain.Extensions;
using AppointIn.DesktopApp.Gui.Extensions;

namespace AppointIn.DesktopApp.Gui
{
	public partial class CityDataPanel : UserControl, Interfaces.ILocalizable, Interfaces.ISyncable
	{
		public CityDataPanel()
		{
			Init();

			Localizables.All.Add(this);
			Syncables.All.Add(this);
		}

		#region Properties
		private City _city;
		[Bindable(false)]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public City City
		{
			get
			{
				BindEntity();

				_city.CreateDate = _city.CreateDate.ToUniversalTime();

				return _city;
			}

			set
			{
				_city = value;

				_city.CreateDate = _city.CreateDate.ToLocalTime();

				BindGui();
			}
		}

		[Bindable(false)]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		// Using lambda expression to simplify GET only property
		public ValidationResult IsValid { get => ValidateValue(); }
		#endregion

		#region Methods
		private void AttachEvents()
		{
			if (AddCountryButton != null) AddCountryButton.Click += AddCountryButtonClickHandler;
		}

		private void BindEntity()
		{
			_city.Id = int.Parse(IdExtendedTextBox.Text);
			_city.Name = NameExtendedTextBox.Text;
			_city.Country = (Country) CountryExtendedComboBox.ComboBox.SelectedValue;
			_city.CreateDate = CreateDateDateTimePicker.Value;
			_city.CreatedBy = CreatedByExtendedTextBox.Text;
			_city.LastUpdateBy = LastUpdateByExtendedTextBox.Text;
		}

		private void BindGui()
		{
			SyncData();

			IdExtendedTextBox.Text = _city.Id.ToString();
			NameExtendedTextBox.Text = _city.Name;
			CountryExtendedComboBox.ComboBox.SelectedItem = _city.Country;
			CreateDateDateTimePicker.Value = _city.CreateDate;
			CreatedByExtendedTextBox.Text = _city.CreatedBy;
			LastUpdateByExtendedTextBox.Text = _city.LastUpdateBy;
		}

		private void Init()
		{
			InitializeComponent();

			AttachEvents();

			Reset();
		}

		public void LocalizeText(string culture = "")
		{
			IdExtendedTextBox.LabelText = Resources.DataPanelStrings.IdLabelText;
			NameExtendedTextBox.LabelText = Resources.CityDataPanelStrings.NameLabelText;
			CountryExtendedComboBox.LabelText = Resources.CityDataPanelStrings.CountryLabelText;
			CreatedByExtendedTextBox.LabelText = Resources.DataPanelStrings.CreatedByLabelText;
			CreateDateDateTimePicker.LabelText = Resources.DataPanelStrings.CreateDateLabelText;
			LastUpdateByExtendedTextBox.LabelText = Resources.DataPanelStrings.LastUpdateByLabelText;
		}

		// Using lambda expression to simplify function definition
		public void Reset() => City = new City() {
			CreateDate = DateTime.Now,
			CreatedBy = Dashboard.Username,
			LastUpdateBy = Dashboard.Username
		};

		public void SyncData()
		{
			CountryExtendedComboBox.ComboBox.Bind(
				UnitOfWork.Data.Countries
					.GetAll()
					.OrderBy(country => country.Name)
					.ToList(),
				"Name");
		}

		public ValidationResult ValidateValue()
			=> City.Validate();
		#endregion


		#region EventHandlers
		protected void AddCountryButtonClickHandler(object sender, EventArgs e)
		{
			var now = DateTime.Now;
			var nowInUtc = now.ToUniversalTime();

			using (var countryForm = new CountryForm())
			{
				countryForm.Text = Resources.CountryFormStrings.TitleAdd;
				var result = countryForm.ShowDialog();

				if (result == DialogResult.OK)
				{
					var repository = UnitOfWork.Data.Countries;

					countryForm.Country.CreateDate = nowInUtc;

					repository.Insert(countryForm.Country);

					UnitOfWork.Data.Save();

					Syncables.SyncAll();
					CrudPanel.RefreshAll();
				}
			}
		}
		#endregion
	}
}
