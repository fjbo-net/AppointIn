namespace AppointIn.DesktopApp.Gui
{
	partial class CountryDataPanel
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
			this.CreateDateExtendedDateTimePicker = new AppointIn.DesktopApp.Gui.ExtendedDateTimePicker();
			this.LastUpdateByExtendedTextbox = new AppointIn.DesktopApp.Gui.ExtendedTextbox();
			this.CreatedByExtendedTextbox = new AppointIn.DesktopApp.Gui.ExtendedTextbox();
			this.NameExtendedTextbox = new AppointIn.DesktopApp.Gui.ExtendedTextbox();
			this.IdExtendedTextbox = new AppointIn.DesktopApp.Gui.ExtendedTextbox();
			this.SuspendLayout();
			// 
			// CreateDateExtendedDateTimePicker
			// 
			this.CreateDateExtendedDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CreateDateExtendedDateTimePicker.BackColor = System.Drawing.Color.Transparent;
			this.CreateDateExtendedDateTimePicker.Enabled = false;
			this.CreateDateExtendedDateTimePicker.LabelText = "Create Date";
			this.CreateDateExtendedDateTimePicker.Location = new System.Drawing.Point(13, 82);
			this.CreateDateExtendedDateTimePicker.Name = "CreateDateExtendedDateTimePicker";
			this.CreateDateExtendedDateTimePicker.Size = new System.Drawing.Size(315, 20);
			this.CreateDateExtendedDateTimePicker.TabIndex = 1;
			this.CreateDateExtendedDateTimePicker.Value = new System.DateTime(2019, 6, 20, 10, 44, 2, 978);
			// 
			// LastUpdateByExtendedTextbox
			// 
			this.LastUpdateByExtendedTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LastUpdateByExtendedTextbox.BackColor = System.Drawing.Color.Transparent;
			this.LastUpdateByExtendedTextbox.LabelText = "Last Update By";
			this.LastUpdateByExtendedTextbox.Location = new System.Drawing.Point(10, 134);
			this.LastUpdateByExtendedTextbox.Name = "LastUpdateByExtendedTextbox";
			this.LastUpdateByExtendedTextbox.Readonly = true;
			this.LastUpdateByExtendedTextbox.Size = new System.Drawing.Size(318, 20);
			this.LastUpdateByExtendedTextbox.TabIndex = 0;
			this.LastUpdateByExtendedTextbox.Type = AppointIn.DesktopApp.Gui.ExtendedTextboxType.Text;
			// 
			// CreatedByExtendedTextbox
			// 
			this.CreatedByExtendedTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CreatedByExtendedTextbox.BackColor = System.Drawing.Color.Transparent;
			this.CreatedByExtendedTextbox.LabelText = "Created By";
			this.CreatedByExtendedTextbox.Location = new System.Drawing.Point(10, 108);
			this.CreatedByExtendedTextbox.Name = "CreatedByExtendedTextbox";
			this.CreatedByExtendedTextbox.Readonly = true;
			this.CreatedByExtendedTextbox.Size = new System.Drawing.Size(318, 20);
			this.CreatedByExtendedTextbox.TabIndex = 0;
			this.CreatedByExtendedTextbox.Type = AppointIn.DesktopApp.Gui.ExtendedTextboxType.Text;
			// 
			// NameExtendedTextbox
			// 
			this.NameExtendedTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NameExtendedTextbox.BackColor = System.Drawing.Color.Transparent;
			this.NameExtendedTextbox.LabelText = "Name";
			this.NameExtendedTextbox.Location = new System.Drawing.Point(10, 56);
			this.NameExtendedTextbox.Name = "NameExtendedTextbox";
			this.NameExtendedTextbox.Readonly = false;
			this.NameExtendedTextbox.Size = new System.Drawing.Size(318, 20);
			this.NameExtendedTextbox.TabIndex = 0;
			this.NameExtendedTextbox.Type = AppointIn.DesktopApp.Gui.ExtendedTextboxType.Text;
			// 
			// IdExtendedTextbox
			// 
			this.IdExtendedTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.IdExtendedTextbox.BackColor = System.Drawing.Color.Transparent;
			this.IdExtendedTextbox.LabelText = "Id";
			this.IdExtendedTextbox.Location = new System.Drawing.Point(10, 30);
			this.IdExtendedTextbox.Name = "IdExtendedTextbox";
			this.IdExtendedTextbox.Readonly = true;
			this.IdExtendedTextbox.Size = new System.Drawing.Size(318, 20);
			this.IdExtendedTextbox.TabIndex = 0;
			this.IdExtendedTextbox.Type = AppointIn.DesktopApp.Gui.ExtendedTextboxType.Int;
			// 
			// CountryDataPanel
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.CreateDateExtendedDateTimePicker);
			this.Controls.Add(this.LastUpdateByExtendedTextbox);
			this.Controls.Add(this.CreatedByExtendedTextbox);
			this.Controls.Add(this.NameExtendedTextbox);
			this.Controls.Add(this.IdExtendedTextbox);
			this.Name = "CountryDataPanel";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.Size = new System.Drawing.Size(341, 200);
			this.ResumeLayout(false);

		}

		#endregion

		private ExtendedTextbox IdExtendedTextbox;
		private ExtendedTextbox NameExtendedTextbox;
		private ExtendedTextbox CreatedByExtendedTextbox;
		private ExtendedTextbox LastUpdateByExtendedTextbox;
		private ExtendedDateTimePicker CreateDateExtendedDateTimePicker;
	}
}
