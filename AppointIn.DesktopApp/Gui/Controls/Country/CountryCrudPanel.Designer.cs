namespace AppointIn.DesktopApp.Gui.Controls
{
	partial class CountryCrudPanel
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
			this.CountryIdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CountryNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CountryCreateDateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CountryCreatedByColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CountryLastUpdateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CountryLastUpdateByColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// ListView
			// 
			this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CountryIdColumnHeader,
            this.CountryNameColumnHeader,
            this.CountryCreateDateColumnHeader,
            this.CountryCreatedByColumnHeader,
            this.CountryLastUpdateColumnHeader,
            this.CountryLastUpdateByColumnHeader});
			this.ListView.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
			this.ListView.MultiSelect = false;
			this.ListView.Size = new System.Drawing.Size(386, 176);
			// 
			// CountryIdColumnHeader
			// 
			this.CountryIdColumnHeader.Text = "ID";
			// 
			// CountryNameColumnHeader
			// 
			this.CountryNameColumnHeader.Text = "Name";
			// 
			// CountryCreateDateColumnHeader
			// 
			this.CountryCreateDateColumnHeader.Text = "Create Date";
			// 
			// CountryCreatedByColumnHeader
			// 
			this.CountryCreatedByColumnHeader.Text = "Created By";
			// 
			// CountryLastUpdateColumnHeader
			// 
			this.CountryLastUpdateColumnHeader.Text = "Last Update";
			// 
			// CountryLastUpdateByColumnHeader
			// 
			this.CountryLastUpdateByColumnHeader.Text = "Last Update By";
			// 
			// CountryCrudPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Name = "CountryCrudPanel";
			this.Text = "All Countries";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ColumnHeader CountryIdColumnHeader;
		private System.Windows.Forms.ColumnHeader CountryNameColumnHeader;
		private System.Windows.Forms.ColumnHeader CountryCreateDateColumnHeader;
		private System.Windows.Forms.ColumnHeader CountryCreatedByColumnHeader;
		private System.Windows.Forms.ColumnHeader CountryLastUpdateColumnHeader;
		private System.Windows.Forms.ColumnHeader CountryLastUpdateByColumnHeader;
	}
}
