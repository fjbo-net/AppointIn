using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppointIn.Domain.Entities;

namespace AppointIn.DesktopApp.Gui
{
	public partial class CountryDataPanel : UserControl
	{
		public CountryDataPanel()
		{
			Init();
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
				return _country;
			}

			set
			{
				_country = value;
				BindGui();
			}
		}


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

		internal void LocalizeText()
		{
			IdExtendedTextbox.LabelText = Resources.CountryDataPanelStrings.IdLabelText;
			NameExtendedTextbox.LabelText = Resources.CountryDataPanelStrings.NameLabelText;
			CreateDateExtendedDateTimePicker.LabelText = Resources.CountryDataPanelStrings.CreateDateLabelText;
			CreatedByExtendedTextbox.LabelText = Resources.CountryDataPanelStrings.CreatedByLabelText;
			LastUpdateByExtendedTextbox.LabelText = Resources.CountryDataPanelStrings.LastUpdateByLabelText;
		}

		private void Init()
		{
			InitializeComponent();

			Reset();
		}

		public void Reset() => Country = new Country() {
			CreateDate = DateTime.Now,
			CreatedBy = Dashboard.Username
		};
		#endregion
	}
}
