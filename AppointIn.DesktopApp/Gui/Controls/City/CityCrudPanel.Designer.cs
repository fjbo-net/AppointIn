namespace AppointIn.DesktopApp.Gui.Controls
{
	partial class CityCrudPanel
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
			this.CountryColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.NameColumnHeader,
            this.CountryColumnHeader,
            this.CreateDateColumnHeader,
            this.CreatedByColumnHeader,
            this.LastUpdateColumnHeader,
            this.LastUpdateByColumHeader});
			// 
			// IdColumnHeader
			// 
			this.IdColumnHeader.Text = "IdColumn";
			// 
			// NameColumnHeader
			// 
			this.NameColumnHeader.Text = "NameColumn";
			// 
			// CountryColumnHeader
			// 
			this.CountryColumnHeader.Text = "CountryColumn";
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
			this.LastUpdateByColumHeader.Text = "LastUpdateByColumn";
			// 
			// CityCrudPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Name = "CityCrudPanel";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ColumnHeader IdColumnHeader;
		private System.Windows.Forms.ColumnHeader NameColumnHeader;
		private System.Windows.Forms.ColumnHeader CountryColumnHeader;
		private System.Windows.Forms.ColumnHeader CreateDateColumnHeader;
		private System.Windows.Forms.ColumnHeader CreatedByColumnHeader;
		private System.Windows.Forms.ColumnHeader LastUpdateColumnHeader;
		private System.Windows.Forms.ColumnHeader LastUpdateByColumHeader;
	}
}
