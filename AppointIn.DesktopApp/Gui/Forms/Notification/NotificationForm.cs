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

namespace AppointIn.DesktopApp.Gui
{
	public partial class NotificationForm : Form
	{
		#region Constructor
		public NotificationForm(Appointment appointment)
		{
			Appointment = appointment;

			Init();
		}
		#endregion

		#region Properties
		[Bindable(true)]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public override string Text {
			get => base.Text;
			set
			{
				base.Text = value;
				TitleLabel.Text = value;
			}
		}

		[Bindable(true)]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public Appointment Appointment;
		#endregion

		#region Methods
		public void AttachEvents()
		{

		}

		public void Init()
		{
			InitializeComponent();

			LocalizeText();

			AttachEvents();
		}

		public void LocalizeText(string culture = "")
		{
			Text = Resources.NotificationFormStrings.Title;
			MessageTextBox.Text = string.Format(
				Resources.NotificationFormStrings.MessageTextBoxText,
				Appointment.Title,
				Appointment.Start.ToLocalTime().ToShortTimeString());
		}
		#endregion
	}
}
