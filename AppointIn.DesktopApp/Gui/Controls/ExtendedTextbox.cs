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
	public partial class ExtendedTextbox : UserControl
	{
		#region Constructors
		public ExtendedTextbox()
		{
			Init();
		}
		#endregion


		#region Properties
		[Bindable(true)]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		protected new bool Enabled
		{
			get => TextBox.Enabled;
			set => TextBox.Enabled = value;
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
		public bool Readonly
		{
			get => TextBox.ReadOnly;
			set => TextBox.ReadOnly = value;
		}

		[Bindable(true)]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public override string Text
		{
			get => TextBox.Text;
			set => TextBox.Text = value;
		}

		[Bindable(true)]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public ExtendedTextboxType Type { get; set; } = ExtendedTextboxType.Text;
		#endregion


		#region Methods
		protected void ApplyVisualStyles()
		{
		}

		protected void AttachEventlisteners()
		{
			TextBox.KeyPress += FilterKeyPresses;
		}
		protected void Init()
		{
			InitializeComponent();
			ApplyVisualStyles();
			AttachEventlisteners();
		}

		protected void FilterKeyPresses(object sender, KeyPressEventArgs e)
		{
			IEnumerable<int> backspace = new int[] { 8 };
			IEnumerable<int> period = new int[] { '.' };
			var digits = Enumerable.Range('0', '9' - '0' + 1);

			switch (Type)
			{
				case ExtendedTextboxType.Int:
					if (!digits.Concat(backspace).Contains(e.KeyChar)) e.Handled = true;
					break;
				case ExtendedTextboxType.Double:
					if (!digits.Concat(backspace).Concat(period).Contains(e.KeyChar) ||
						(e.KeyChar == '.' && TextBox.Text.Contains('.')))
					{
						e.Handled = true;
					}
					break;
			}
		}
		#endregion
	}

	public enum ExtendedTextboxType
	{
		Text,
		Int,
		Double,
		Custom
	}
}
