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
	public partial class CityForm : BaseForm, ILocalizable
	{
		public CityForm()
		{
			Localizables.All.Add(this);

			AttachEvents();
		}

		#region Properties
		public City City
		{
			get => DataPanel.City;
			set => DataPanel.City = value;
		}
		#endregion

		#region Methods
		protected override void AttachEvents()
		{
			base.AttachEvents();

			if(SaveActionButton != null)
			{
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
		}

		public override void LocalizeText(string cultureName = "")
		{
			base.LocalizeText(cultureName);

			Text = Resources.CityFormStrings.Title;
			if (SaveActionButton != null) SaveActionButton.Text = Resources.BaseFormStrings.SaveButtonText;
			if (CancelActionButton != null) CancelActionButton.Text = Resources.BaseFormStrings.CancelButtonText;
		}

		public void Reset() => DataPanel.Reset();
		#endregion
	}
}
