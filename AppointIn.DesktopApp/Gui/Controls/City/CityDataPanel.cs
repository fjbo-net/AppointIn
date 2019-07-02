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

namespace AppointIn.DesktopApp.Gui
{
	public partial class CityDataPanel : UserControl
	{
		public CityDataPanel()
		{
			Init();
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
				return _city;
			}

			set
			{
				_city = value;
				BindGui();
			}
		}
		#endregion

		#region Methods
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
			IdExtendedTextBox.Text = _city.Id.ToString();
			NameExtendedTextBox.Text = _city.Name;
			using (var workSegment = new UnitOfWork()) {
				var countries = workSegment.Countries;

				CountryExtendedComboBox.ComboBox.Bind(countries.GetAll(), "Name");
			}
			CreateDateDateTimePicker.Value = _city.CreateDate;
			CreatedByExtendedTextBox.Text = _city.CreatedBy;
			LastUpdateByExtendedTextBox.Text = _city.LastUpdateBy;
		}

		private void Init()
		{
			InitializeComponent();

			Reset();
		}

		internal void LocalizeText()
		{
			IdExtendedTextBox.LabelText = Resources.CityDataPanelStrings.IdLabelText;
			NameExtendedTextBox.LabelText = Resources.CityDataPanelStrings.NameLabelText;
			CountryExtendedComboBox.LabelText = Resources.CityDataPanelStrings.CountryLabelText;
			CreateDateDateTimePicker.LabelText = Resources.CityDataPanelStrings.CreateDateLabelText;
			LastUpdateByExtendedTextBox.LabelText = Resources.CityDataPanelStrings.LastUpdateByLabelText;
		}

		public void Reset() => City = new City() {
			CreateDate = DateTime.Now,
			CreatedBy = Dashboard.Username
		};
		#endregion
	}
}
