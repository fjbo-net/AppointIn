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

		public void Reset() => City = new City() {
			CreateDate = DateTime.Now,
			CreatedBy = Dashboard.Username
		};

		public void SyncData()
		{
			CountryExtendedComboBox.ComboBox.Bind(UnitOfWork.Data.Countries.GetAll(), "Name");
		}
		#endregion
	}
}
