using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointIn.DesktopApp.Gui
{
	public partial class ExtendedDateTimePicker : UserControl
	{
		public ExtendedDateTimePicker()
		{
			Init();
		}


		#region Properties
		[Bindable(true)]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		protected new bool Enabled
		{
			get => DateTimePicker.Enabled;
			set => DateTimePicker.Enabled = value;
		}

		[Bindable(true)]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public string LabelText
		{
			get => Label.Text;
			set => Label.Text = value;
		}

		[Bindable(true)]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public DateTime Value
		{
			get => DateTimePicker.Value;
			set => DateTimePicker.Value = value;
		}
		#endregion


		#region Methods
		private void Init()
		{
			InitializeComponent();
		}
		#endregion
	}
}
