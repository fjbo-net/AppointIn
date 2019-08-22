using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppointIn.Domain.Entities;
using AppointIn.DesktopApp.Gui.Interfaces;

namespace AppointIn.DesktopApp.Gui
{
	public partial class CountryForm : BaseForm, ILocalizable
	{
		public CountryForm()
		{
			Localizables.All.Add(this);
			AttachEvents();
		}


		#region Properties
		public Country Country {
			// Using lambda expressions to simplify property's getter and setter
			get => DataPanel.Country;
			set => DataPanel.Country = value;
		}
		#endregion


		#region Methods
		protected override void AttachEvents()
		{
			base.AttachEvents();

			if(SaveActionButton != null)
			{
				// Using lambda expression to simplify event handler due to handler's simplicity
				SaveActionButton.Click += (sender, e) =>
				{
					Hide();
					DialogResult = DialogResult.OK;
				};
			}
		}

		protected override void Init()
		{
			base.Init();

			InitializeComponent();

			LocalizeText();
		}

		public override void LocalizeText(string cultureName = "")
		{
			base.LocalizeText();

			Text = Resources.CountryFormStrings.Title;

			if (DataPanel != null) DataPanel.LocalizeText(cultureName);

			if(SaveActionButton != null) SaveActionButton.Text = Resources.CountryFormStrings.SaveButtonText;
			if(CancelActionButton != null) CancelActionButton.Text = Resources.CountryFormStrings.CancelButtonText;
		}

		// Using lambda expression to simplify call to an object property's method
		public void Reset() => DataPanel.Reset();
		#endregion
	}
}
