namespace AppointIn.DesktopApp.Gui.Controls
{
	partial class CustomerCrudPanel
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.IdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.NameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.AddressColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ActiveColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CreateDateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CreatedByColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.LastUpdateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.LastUpdateByColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// ListView
			// 
			this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdColumnHeader,
            this.NameColumnHeader,
            this.AddressColumnHeader,
            this.ActiveColumnHeader,
            this.CreateDateColumnHeader,
            this.CreatedByColumnHeader,
            this.LastUpdateColumnHeader,
            this.LastUpdateByColumnHeader});
			this.ListView.Size = new System.Drawing.Size(386, 336);
			// 
			// IdColumnHeader
			// 
			this.IdColumnHeader.Text = "IdColumn";
			this.IdColumnHeader.Width = 96;
			// 
			// NameColumnHeader
			// 
			this.NameColumnHeader.Text = "NameColumn";
			this.NameColumnHeader.Width = 96;
			// 
			// AddressColumnHeader
			// 
			this.AddressColumnHeader.Text = "AddressColumn";
			this.AddressColumnHeader.Width = 96;
			// 
			// ActiveColumnHeader
			// 
			this.ActiveColumnHeader.Text = "ActiveColumn";
			// 
			// CreateDateColumnHeader
			// 
			this.CreateDateColumnHeader.Text = "CreateDateColumn";
			// 
			// CreatedByColumnHeader
			// 
			this.CreatedByColumnHeader.Text = "CreatedByColumn";
			// 
			// LastUpdateColumnHeader
			// 
			this.LastUpdateColumnHeader.Text = "LastUpdateColumn";
			// 
			// LastUpdateByColumnHeader
			// 
			this.LastUpdateByColumnHeader.Text = "LastUpdateByColumn";
			// 
			// CustomerCrudPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Name = "CustomerCrudPanel";
			this.Size = new System.Drawing.Size(400, 400);
			this.Text = "Customer CRUD Panel";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ColumnHeader ActiveColumnHeader;
		private System.Windows.Forms.ColumnHeader CreateDateColumnHeader;
		private System.Windows.Forms.ColumnHeader CreatedByColumnHeader;
		private System.Windows.Forms.ColumnHeader LastUpdateColumnHeader;
		private System.Windows.Forms.ColumnHeader LastUpdateByColumnHeader;
		private System.Windows.Forms.ColumnHeader IdColumnHeader;
		private System.Windows.Forms.ColumnHeader NameColumnHeader;
		private System.Windows.Forms.ColumnHeader AddressColumnHeader;
	}
}
