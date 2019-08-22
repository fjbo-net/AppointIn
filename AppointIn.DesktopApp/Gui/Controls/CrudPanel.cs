using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppointIn.Core;

namespace AppointIn.DesktopApp.Gui
{
	public partial class CrudPanel : UserControl
	{
		#region Constructors
		public CrudPanel()
		{
			Instances.Add(this);
			Init();
		}
		#endregion

		#region Static Properties
		protected static List<CrudPanel> Instances = new List<CrudPanel>();
		#endregion


		#region Properties
		// Using lambda expression to simplify GET only property
		protected bool HasItems { get => ListView.Items.Count > 0; }
		// Using lambda expression to simplify GET only property
		protected bool HasSelection { get => ListView.SelectedIndices.Count == 1; }

		[Browsable(true)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Bindable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public override string Text
		{
			// Using lambda expressions to simplify property's getter and setter
			get => HeadingLabel.Text;
			set => HeadingLabel.Text = value;
		}
		#endregion


		#region Methods
		public virtual void Add()
			=> throw BuildNotImplementedException(nameof(Add));

		protected void ApplyVisualStyles()
		{
			HeadingLabel.Font = FontStyles.Heading1;

			SetupListView();

			ResizeHandler();
		}

		protected void AttachEvents()
		{
			// Using lambda expressions to simplify event handlers due to handlers' simplicity
			Resize += (sender, e) => ResizeHandler();
			AddButton.Click += (sender, e) => Add();
			EditButton.Click += (sender, e) => Edit();
			RemoveButton.Click += (sender, e) => Remove();
			ListView.ItemSelectionChanged += (sender, e) => UpdateGui();
			ListView.DoubleClick += (sender, e) =>
			{
				if (HasSelection) Edit();
			};
		}

		// Using lambda expression to simplify function definition due to simplicity
		private NotImplementedException BuildNotImplementedException(string methodName)
			=> new NotImplementedException($"\"{methodName}\" method needs to be implemented at sub-class level.");

		// Using lambda expression to simplify function definition due to simplicity
		public virtual void Edit()
			=> throw BuildNotImplementedException(nameof(Edit));

		protected virtual void Init()
		{
			InitializeComponent();
			ApplyVisualStyles();
			AttachEvents();
		}

		internal virtual void LoadData()
		{
			SyncListView();
		}

		public virtual void LocalizeText(string culture = "")
		{

		}

		protected void RefreshAll()
		{
			foreach (var instance in Instances) instance.ReloadData();
		}

		internal void ReloadData()
		{
			ListView.Items.Clear();

			LoadData();
		}

		// Using lambda expression to simplify function definition due to simplicity
		public virtual void Remove()
			=> throw BuildNotImplementedException(nameof(Remove));

		protected void ResizeHandler()
		{
			foreach(ColumnHeader column in ListView.Columns)
			{
				column.Width = ListView.Width / ListView.Columns.Count;
			}
		}

		protected virtual void SetupListView() { }

		// Using lambda expression to simplify function definition due to simplicity
		protected virtual void SyncListView()
			=> throw BuildNotImplementedException(nameof(SyncListView));

		protected virtual void UpdateGui()
		{
			AddButton.Enabled = true;
			RemoveButton.Enabled = HasItems;
			EditButton.Enabled = HasSelection;
		}
		#endregion
	}
}
