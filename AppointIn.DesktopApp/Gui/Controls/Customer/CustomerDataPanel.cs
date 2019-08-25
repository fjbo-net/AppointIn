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
using AppointIn.Domain.Classes;
using AppointIn.Domain.Entities;
using AppointIn.Domain.Extensions;

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

				_customer.CreateDate = _customer.CreateDate.ToUniversalTime();

				return _customer;
			}

			set
			{
				_customer = value;

				_customer.CreateDate = _customer.CreateDate.ToLocalTime();

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
			if (AddAddressButton != null) AddAddressButton.Click += AddAddressButtonClickHandler;
		}

		private void BindEntity()
		{
			_customer.Id = int.Parse(IdExtendedTextbox.Text);
			_customer.Name = NameExtendedTextbox.Text;
			_customer.Address = (Address)AddressExtendedCombobox.ComboBox.SelectedValue;
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
			ActiveCheckbox.Checked = _customer.IsActive;
			AddressExtendedCombobox.ComboBox.SelectedItem = _customer.Address;
			CreatedDateDateTimePicker.Value = _customer.CreateDate;
			CreatedByExtendedTextbox.Text = _customer.CreatedBy;
			LastUpdateByExtendedTextbox.Text = _customer.LastUpdateBy;
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
			AttachEvents();
			Reset();
		}

		// Using lambda expression to simplify function definition
		public void Reset() => Customer = new Customer()
		{
			CreateDate = DateTime.Now,
			CreatedBy = Dashboard.Username,
			LastUpdateBy = Dashboard.Username
		};

		public void SyncData()
		{
			AddressExtendedCombobox.ComboBox.Bind(UnitOfWork.Data.Addresses.GetAll(), "FullAddress");
		}

		public ValidationResult ValidateValue()
			=> Customer.Validate();
		#endregion


		#region Event Handlers
		private void AddAddressButtonClickHandler(object sender, EventArgs e)
		{
			var now = DateTime.Now;
			var nowUtc = now.ToUniversalTime();

			using (var addressForm = new AddressForm())
			{
				addressForm.Text = Resources.AddressFormStrings.TitleAdd;
				var result = addressForm.ShowDialog();

				if (result == DialogResult.OK)
				{
					var repository = UnitOfWork.Data.Addresses;

					var address = addressForm.Address;

					address.CreateDate = nowUtc;

					repository.Insert(address);

					UnitOfWork.Data.Save();

					Syncables.SyncAll();
					CrudPanel.RefreshAll();
				}
			}
		}
		#endregion
	}
}
