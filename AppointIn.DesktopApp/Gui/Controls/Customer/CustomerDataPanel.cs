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
using AppointIn.DesktopApp.Gui.Extensions;
using AppointIn.Domain.Entities;

namespace AppointIn.DesktopApp.Gui
{
	public partial class CustomerDataPanel : UserControl, Interfaces.ILocalizable, Interfaces.ISyncable
	{
		public CustomerDataPanel()
		{
			Init();

			Localizables.All.Add(this);
			Syncables.All.Add(this);
		}

		#region Properties
		private Customer _customer;
		[Bindable(false)]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Customer Customer
		{
			get
			{
				BindEntity();
				return _customer;
			}

			set
			{
				_customer = value;
				BindGui();
			}
		}
		#endregion

		#region Methods
		private void BindEntity()
		{
			_customer.Id = int.Parse(IdExtendedTextbox.Text);
			_customer.Name = NameExtendedTextbox.Text;
			_customer.Address = (Address) AddressExtendedCombobox.ComboBox.SelectedValue;
			_customer.IsActive = ActiveCheckbox.Checked;
			_customer.CreateDate = CreatedDateDateTimePicker.Value;
			_customer.CreatedBy = CreatedByExtendedTextbox.Text;
			_customer.LastUpdateBy = LastUpdateByExtendedTextbox.Text;
		}

		private void BindGui()
		{
			SyncData();

			IdExtendedTextbox.Text = _customer.Id.ToString();
			NameExtendedTextbox.Text = _customer.Name;
			AddressExtendedCombobox.ComboBox.SelectedItem = _customer.Address;
		}

		public void LocalizeText(string culture = "")
		{
			IdExtendedTextbox.LabelText = Resources.DataPanelStrings.IdLabelText;
			NameExtendedTextbox.LabelText = Resources.CustomerDataPanelStrings.NameLabelText;
			AddressExtendedCombobox.LabelText = Resources.CustomerDataPanelStrings.AddressLabelText;
			ActiveCheckbox.Text = Resources.CustomerDataPanelStrings.ActiveLabelText;
			CreatedDateDateTimePicker.LabelText = Resources.DataPanelStrings.CreateDateLabelText;
			CreatedByExtendedTextbox.LabelText = Resources.DataPanelStrings.CreatedByLabelText;
			LastUpdateExtendedTextbox.LabelText = Resources.DataPanelStrings.LastUpdateLabelText;
			LastUpdateByExtendedTextbox.LabelText = Resources.DataPanelStrings.LastUpdateByLabelText;
		}

		private void Init()
		{
			InitializeComponent();

			Reset();
		}

		public void Reset() => Customer = new Customer()
		{
			CreateDate = DateTime.Now,
			CreatedBy = Dashboard.Username
		};

		public void SyncData()
		{
			AddressExtendedCombobox.ComboBox.Bind(UnitOfWork.Data.Addresses.GetAll(), "StreetName");
		}
		#endregion
	}
}
