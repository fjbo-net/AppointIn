namespace AppointIn.DesktopApp.Gui
{
	partial class CityDataPanel
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
			this.CreateDateDateTimePicker = new AppointIn.DesktopApp.Gui.ExtendedDateTimePicker();
			this.CountryExtendedComboBox = new AppointIn.DesktopApp.Gui.ExtendedComboBox();
			this.LastUpdateByExtendedTextBox = new AppointIn.DesktopApp.Gui.ExtendedTextbox();
			this.CreatedByExtendedTextBox = new AppointIn.DesktopApp.Gui.ExtendedTextbox();
			this.NameExtendedTextBox = new AppointIn.DesktopApp.Gui.ExtendedTextbox();
			this.IdExtendedTextBox = new AppointIn.DesktopApp.Gui.ExtendedTextbox();
			this.AddCountryButton = new AppointIn.DesktopApp.Gui.ActionButton();
			this.SuspendLayout();
			// 
			// CreateDateDateTimePicker
			// 
			this.CreateDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CreateDateDateTimePicker.BackColor = System.Drawing.Color.Transparent;
			this.CreateDateDateTimePicker.Enabled = false;
			this.CreateDateDateTimePicker.LabelText = "CreateDateLabel";
			this.CreateDateDateTimePicker.Location = new System.Drawing.Point(13, 108);
			this.CreateDateDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.CreateDateDateTimePicker.Name = "CreateDateDateTimePicker";
			this.CreateDateDateTimePicker.Size = new System.Drawing.Size(314, 20);
			this.CreateDateDateTimePicker.TabIndex = 3;
			this.CreateDateDateTimePicker.Value = new System.DateTime(2019, 6, 29, 19, 49, 22, 963);
			// 
			// CountryExtendedComboBox
			// 
			this.CountryExtendedComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CountryExtendedComboBox.BackColor = System.Drawing.Color.Transparent;
			this.CountryExtendedComboBox.LabelText = "CountryLabel";
			this.CountryExtendedComboBox.Location = new System.Drawing.Point(13, 82);
			this.CountryExtendedComboBox.Name = "CountryExtendedComboBox";
			this.CountryExtendedComboBox.Size = new System.Drawing.Size(287, 20);
			this.CountryExtendedComboBox.TabIndex = 2;
			// 
			// LastUpdateByExtendedTextBox
			// 
			this.LastUpdateByExtendedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LastUpdateByExtendedTextBox.BackColor = System.Drawing.Color.Transparent;
			this.LastUpdateByExtendedTextBox.LabelText = "LastUpdateByLabel";
			this.LastUpdateByExtendedTextBox.Location = new System.Drawing.Point(13, 160);
			this.LastUpdateByExtendedTextBox.MultiLine = false;
			this.LastUpdateByExtendedTextBox.Name = "LastUpdateByExtendedTextBox";
			this.LastUpdateByExtendedTextBox.Readonly = true;
			this.LastUpdateByExtendedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.LastUpdateByExtendedTextBox.Size = new System.Drawing.Size(314, 20);
			this.LastUpdateByExtendedTextBox.TabIndex = 5;
			this.LastUpdateByExtendedTextBox.Type = AppointIn.DesktopApp.Gui.ExtendedTextboxType.Text;
			// 
			// CreatedByExtendedTextBox
			// 
			this.CreatedByExtendedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CreatedByExtendedTextBox.BackColor = System.Drawing.Color.Transparent;
			this.CreatedByExtendedTextBox.LabelText = "CreatedByLabel";
			this.CreatedByExtendedTextBox.Location = new System.Drawing.Point(13, 134);
			this.CreatedByExtendedTextBox.MultiLine = false;
			this.CreatedByExtendedTextBox.Name = "CreatedByExtendedTextBox";
			this.CreatedByExtendedTextBox.Readonly = true;
			this.CreatedByExtendedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.CreatedByExtendedTextBox.Size = new System.Drawing.Size(314, 20);
			this.CreatedByExtendedTextBox.TabIndex = 4;
			this.CreatedByExtendedTextBox.Type = AppointIn.DesktopApp.Gui.ExtendedTextboxType.Text;
			// 
			// NameExtendedTextBox
			// 
			this.NameExtendedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NameExtendedTextBox.BackColor = System.Drawing.Color.Transparent;
			this.NameExtendedTextBox.LabelText = "NameLabel";
			this.NameExtendedTextBox.Location = new System.Drawing.Point(13, 56);
			this.NameExtendedTextBox.MultiLine = false;
			this.NameExtendedTextBox.Name = "NameExtendedTextBox";
			this.NameExtendedTextBox.Readonly = false;
			this.NameExtendedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.NameExtendedTextBox.Size = new System.Drawing.Size(314, 20);
			this.NameExtendedTextBox.TabIndex = 1;
			this.NameExtendedTextBox.Type = AppointIn.DesktopApp.Gui.ExtendedTextboxType.Text;
			// 
			// IdExtendedTextBox
			// 
			this.IdExtendedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.IdExtendedTextBox.BackColor = System.Drawing.Color.Transparent;
			this.IdExtendedTextBox.LabelText = "IdLabel";
			this.IdExtendedTextBox.Location = new System.Drawing.Point(13, 30);
			this.IdExtendedTextBox.MultiLine = false;
			this.IdExtendedTextBox.Name = "IdExtendedTextBox";
			this.IdExtendedTextBox.Readonly = true;
			this.IdExtendedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.IdExtendedTextBox.Size = new System.Drawing.Size(314, 20);
			this.IdExtendedTextBox.TabIndex = 0;
			this.IdExtendedTextBox.Type = AppointIn.DesktopApp.Gui.ExtendedTextboxType.Int;
			// 
			// AddCountryButton
			// 
			this.AddCountryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddCountryButton.Location = new System.Drawing.Point(306, 82);
			this.AddCountryButton.Name = "AddCountryButton";
			this.AddCountryButton.Size = new System.Drawing.Size(21, 20);
			this.AddCountryButton.TabIndex = 6;
			this.AddCountryButton.Text = "+";
			this.AddCountryButton.UseVisualStyleBackColor = true;
			// 
			// CityDataPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.AddCountryButton);
			this.Controls.Add(this.CreateDateDateTimePicker);
			this.Controls.Add(this.CountryExtendedComboBox);
			this.Controls.Add(this.LastUpdateByExtendedTextBox);
			this.Controls.Add(this.CreatedByExtendedTextBox);
			this.Controls.Add(this.NameExtendedTextBox);
			this.Controls.Add(this.IdExtendedTextBox);
			this.Name = "CityDataPanel";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.Size = new System.Drawing.Size(340, 193);
			this.ResumeLayout(false);

		}

		#endregion

		private ExtendedTextbox IdExtendedTextBox;
		private ExtendedTextbox NameExtendedTextBox;
		private ExtendedComboBox CountryExtendedComboBox;
		private ExtendedDateTimePicker CreateDateDateTimePicker;
		private ExtendedTextbox CreatedByExtendedTextBox;
		private ExtendedTextbox LastUpdateByExtendedTextBox;
		private ActionButton AddCountryButton;
	}
}
