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
	public partial class ExtendedComboBox : UserControl
	{
		#region Constructors
		public ExtendedComboBox()
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
			// Using lambda expressions to simplify property's getter and setter
			get => ComboBox.Enabled;
			set => ComboBox.Enabled = value;
		}

		[Bindable(true)]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public string LabelText
		{
			// Using lambda expressions to simplify property's getter and setter
			get => Label.Text;
			set => Label.Text = value;
		}

		[Bindable(true)]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public override string Text
		{
			// Using lambda expressions to simplify property's getter and setter
			get => ComboBox.Text;
			set => ComboBox.Text = value;
		}
		#endregion

		#region Methods
		protected void ApplyVisualStyles()
		{
		}

		protected void AttachEventListeners()
		{
		}

		protected void Init()
		{
			InitializeComponent();
			ApplyVisualStyles();
			AttachEventListeners();
		}
		#endregion
	}
}
