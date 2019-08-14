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
	public partial class AddressDataPanel : UserControl, ILocalizable, ISyncable
	{
		#region Constructor
		public AddressDataPanel()
		{
			Init();

			Localizables.All.Add(this);
			Syncables.All.Add(this);
		}
		#endregion

		#region Properties
		private Address _address;
		[Bindable(false)]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Address Address
		{
			get
			{
				BindEntity();
				return _address;
			}

			set
			{
				_address = value;
				BindGui();
			}
		}
		#endregion

		#region Methods
		private void BindEntity()
		{
			_address.Id = int.Parse(IdExtendedTextbox.Text);
			_address.StreetName = AddressExtendedTextbox.Text;
			_address.BuildingOrInterior = Address2ExtendedTextbox.Text;
			_address.City = (City) CityComboBox.ComboBox.SelectedValue;
			_address.PostalCode = PostalCodeExtendedTextBox.Text;
			_address.CreateDate = CreateDateDateTimePicker.Value;
			_address.Phone = PhoneExtendedTextbox.Text;
			_address.CreatedBy = CreatedByExtendedTextbox.Text;
			_address.LastUpdateBy = LastUpdateByExtendedTextbox.Text;
		}

		private void BindGui()
		{
			SyncData();

			IdExtendedTextbox.Text = _address.Id.ToString();
			AddressExtendedTextbox.Text = _address.StreetName;
			Address2ExtendedTextbox.Text = _address.BuildingOrInterior;
			PostalCodeExtendedTextBox.Text = _address.PostalCode;
			PhoneExtendedTextbox.Text = _address.Phone;
			CityComboBox.ComboBox.SelectedItem = _address.City;
			CreateDateDateTimePicker.Value = _address.CreateDate;
			CreatedByExtendedTextbox.Text = _address.CreatedBy;
			if(_address.LastUpdate != null) LastUpdateExtendedTextbox.Text = _address.LastUpdate.ToString();
			LastUpdateByExtendedTextbox.Text = _address.LastUpdateBy;
		}

		private void Init()
		{
			InitializeComponent();

			Reset();
		}

		public void LocalizeText(string culture = "")
		{
			IdExtendedTextbox.LabelText = Resources.DataPanelStrings.IdLabelText;
			AddressExtendedTextbox.LabelText = Resources.AddressDataPanelStrings.AddressLabelText;
			Address2ExtendedTextbox.LabelText = Resources.AddressDataPanelStrings.Address2LabelText;
			CityComboBox.LabelText = Resources.AddressDataPanelStrings.CityLabelText;
			PostalCodeExtendedTextBox.LabelText = Resources.AddressDataPanelStrings.PostalCodeLabelText;
			PhoneExtendedTextbox.LabelText = Resources.AddressDataPanelStrings.PhoneLabelText;
			CreateDateDateTimePicker.LabelText = Resources.DataPanelStrings.CreateDateLabelText;
			CreatedByExtendedTextbox.LabelText = Resources.DataPanelStrings.CreatedByLabelText;
			LastUpdateExtendedTextbox.LabelText = Resources.DataPanelStrings.LastUpdateLabelText;
			LastUpdateByExtendedTextbox.LabelText = Resources.DataPanelStrings.LastUpdateByLabelText;
		}

		public void Reset() => Address = new Address()
		{
			CreateDate = DateTime.Now,
			CreatedBy = Dashboard.Username
		};

		public void SyncData()
		{
			CityComboBox.ComboBox.Bind(UnitOfWork.Data.Cities.GetAll(), "Name");
		}
		#endregion
	}
}
