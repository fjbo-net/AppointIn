﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppointIn.Domain.Entities;

namespace AppointIn.DesktopApp.Gui
{
	public partial class CustomerForm : BaseForm, Interfaces.ILocalizable
	{
		public CustomerForm()
		{
			Localizables.All.Add(this);

			AttachEvents();
		}

		#region Properties
		public Customer Customer
		{
			get => DataPanel.Customer;
			set => DataPanel.Customer = value;
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

			LocalizeText();
		}

		public override void LocalizeText(string cultureName = "")
		{
			base.LocalizeText(cultureName);

			Text = Resources.CustomerFormStrings.Title;

			if (DataPanel != null) DataPanel.LocalizeText(cultureName);

			if (SaveActionButton != null) SaveActionButton.Text = Resources.BaseFormStrings.SaveButtonText;
			if (CancelActionButton != null) CancelActionButton.Text = Resources.BaseFormStrings.CancelButtonText;
		}

		public void Reset() => DataPanel.Reset();
		#endregion
	}
}
