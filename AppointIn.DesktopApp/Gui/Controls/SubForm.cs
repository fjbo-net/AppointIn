﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointIn.DesktopApp.Gui
{
	public partial class SubForm : BaseForm
	{
		#region Constructors
		public SubForm()
		{
			
		}
		#endregion


		#region Methods
		protected override void AttachEvents()
		{
			base.AttachEvents();

			FormClosing += FormClosingHandler;
		}

		protected override void Init()
		{
			base.Init();
			InitializeComponent();
		}

		#region Event Handlers
		protected void FormClosingHandler(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;

			Visible = false;
		}
		#endregion
		#endregion
	}
}
