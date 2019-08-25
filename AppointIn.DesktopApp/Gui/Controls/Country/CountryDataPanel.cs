using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppointIn.Domain.Classes;
using AppointIn.Domain.Entities;
using AppointIn.Domain.Extensions;

namespace AppointIn.DesktopApp.Gui
{
	public partial class CountryDataPanel : UserControl, Interfaces.ILocalizable
	{
		public CountryDataPanel()
		{
			Init();

			Localizables.All.Add(this);
		}


		#region Properties
		private Country _country;
		[Bindable(false)]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Country Country
		{
			get
			{
				BindEntity();

				_country.CreateDate = _country.CreateDate.ToUniversalTime();

				return _country;
			}

			set
			{
				_country = value;

				_country.CreateDate = _country.CreateDate.ToLocalTime();

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
		private void BindEntity()
		{
			_country.Id = int.Parse(IdExtendedTextbox.Text);
			_country.Name = NameExtendedTextbox.Text;
			//_country.CreateDate = DateTime.Parse(CreateDateExtendedTextbox.Text);
			_country.CreateDate = CreateDateExtendedDateTimePicker.Value;
			_country.LastUpdateBy = LastUpdateByExtendedTextbox.Text;
		}

		private void BindGui()
		{
			IdExtendedTextbox.Text = _country.Id.ToString();
			NameExtendedTextbox.Text = _country.Name;
			CreateDateExtendedDateTimePicker.Value = _country.CreateDate;
			CreatedByExtendedTextbox.Text = _country.CreatedBy;
			LastUpdateByExtendedTextbox.Text = _country.LastUpdateBy;
		}

		public void LocalizeText(string culture = "")
		{
			IdExtendedTextbox.LabelText = Resources.DataPanelStrings.IdLabelText;
			NameExtendedTextbox.LabelText = Resources.CountryDataPanelStrings.NameLabelText;
			CreateDateExtendedDateTimePicker.LabelText = Resources.DataPanelStrings.CreateDateLabelText;
			CreatedByExtendedTextbox.LabelText = Resources.DataPanelStrings.CreatedByLabelText;
			LastUpdateByExtendedTextbox.LabelText = Resources.DataPanelStrings.LastUpdateByLabelText;
		}

		private void Init()
		{
			InitializeComponent();

			Reset();
		}

		//Using lambda expression to simplify function definition due to function simplicity
		public void Reset() => Country = new Country() {
			CreateDate = DateTime.Now,
			CreatedBy = Dashboard.Username
		};

		//Using lambda expression to simplify property's method reference
		public ValidationResult ValidateValue()
			=> Country.Validate();
		#endregion
	}
}
