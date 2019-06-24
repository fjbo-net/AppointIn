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
			this.CreateDateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// ListView
			// 
			this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdColumnHeader,
            this.NameColumnHeader,
            this.AddressColumnHeader,
            this.CreateDateColumnHeader});
			this.ListView.Size = new System.Drawing.Size(386, 336);
			// 
			// IdColumnHeader
			// 
			this.IdColumnHeader.Text = "Id";
			// 
			// NameColumnHeader
			// 
			this.NameColumnHeader.Text = "Name";
			// 
			// AddressColumnHeader
			// 
			this.AddressColumnHeader.Text = "Address";
			// 
			// CreateDateColumnHeader
			// 
			this.CreateDateColumnHeader.Text = "Create Date";
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

		protected System.Windows.Forms.ColumnHeader IdColumnHeader;
		protected System.Windows.Forms.ColumnHeader NameColumnHeader;
		protected System.Windows.Forms.ColumnHeader AddressColumnHeader;
		protected System.Windows.Forms.ColumnHeader CreateDateColumnHeader;
	}
}
