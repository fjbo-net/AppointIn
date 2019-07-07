namespace AppointIn.DesktopApp.Gui.Controls
{
	partial class AddressCrudPanel
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
			this.AddressColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Address2ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CityColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PostalCodeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PhoneColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CreateDateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CreatedByColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.LastUpdateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.LastUpdateByColumHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// ListView
			// 
			this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdColumnHeader,
            this.AddressColumnHeader,
            this.Address2ColumnHeader,
            this.CityColumnHeader,
            this.PostalCodeColumnHeader,
            this.PhoneColumnHeader,
            this.CreateDateColumnHeader,
            this.CreatedByColumnHeader,
            this.LastUpdateColumnHeader,
            this.LastUpdateByColumHeader});
			// 
			// IdColumnHeader
			// 
			this.IdColumnHeader.Text = "IdColumn";
			// 
			// AddressColumnHeader
			// 
			this.AddressColumnHeader.Text = "AddressColumn";
			// 
			// Address2ColumnHeader
			// 
			this.Address2ColumnHeader.Text = "Address2Column";
			// 
			// CityColumnHeader
			// 
			this.CityColumnHeader.Text = "CityColumn";
			// 
			// PostalCodeColumnHeader
			// 
			this.PostalCodeColumnHeader.Text = "PostalCodeColumn";
			// 
			// PhoneColumnHeader
			// 
			this.PhoneColumnHeader.Text = "PhoneColumn";
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
			// LastUpdateByColumHeader
			// 
			this.LastUpdateByColumHeader.Text = "LastUpdateColumn";
			// 
			// AddressCrudPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Name = "AddressCrudPanel";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ColumnHeader IdColumnHeader;
		private System.Windows.Forms.ColumnHeader AddressColumnHeader;
		private System.Windows.Forms.ColumnHeader Address2ColumnHeader;
		private System.Windows.Forms.ColumnHeader CityColumnHeader;
		private System.Windows.Forms.ColumnHeader PostalCodeColumnHeader;
		private System.Windows.Forms.ColumnHeader PhoneColumnHeader;
		private System.Windows.Forms.ColumnHeader CreateDateColumnHeader;
		private System.Windows.Forms.ColumnHeader CreatedByColumnHeader;
		private System.Windows.Forms.ColumnHeader LastUpdateColumnHeader;
		private System.Windows.Forms.ColumnHeader LastUpdateByColumHeader;
	}
}
