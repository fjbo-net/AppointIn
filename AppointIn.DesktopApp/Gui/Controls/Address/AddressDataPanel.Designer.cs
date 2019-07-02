namespace AppointIn.DesktopApp.Gui.Controls
{
	partial class AddressDataPanel
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
			this.IdExtendedTextbox = new AppointIn.DesktopApp.Gui.ExtendedTextbox();
			this.AddressExtendedTextbox = new AppointIn.DesktopApp.Gui.ExtendedTextbox();
			this.Address2Textbox = new AppointIn.DesktopApp.Gui.ExtendedTextbox();
			this.CityComboBox = new AppointIn.DesktopApp.Gui.ExtendedComboBox();
			this.SuspendLayout();
			// 
			// IdExtendedTextbox
			// 
			this.IdExtendedTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.IdExtendedTextbox.BackColor = System.Drawing.Color.Transparent;
			this.IdExtendedTextbox.LabelText = "Id";
			this.IdExtendedTextbox.Location = new System.Drawing.Point(13, 40);
			this.IdExtendedTextbox.Name = "IdExtendedTextbox";
			this.IdExtendedTextbox.Readonly = false;
			this.IdExtendedTextbox.Size = new System.Drawing.Size(315, 20);
			this.IdExtendedTextbox.TabIndex = 0;
			this.IdExtendedTextbox.Type = AppointIn.DesktopApp.Gui.ExtendedTextboxType.Int;
			// 
			// AddressExtendedTextbox
			// 
			this.AddressExtendedTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AddressExtendedTextbox.BackColor = System.Drawing.Color.Transparent;
			this.AddressExtendedTextbox.LabelText = "Street Address";
			this.AddressExtendedTextbox.Location = new System.Drawing.Point(13, 66);
			this.AddressExtendedTextbox.Name = "AddressExtendedTextbox";
			this.AddressExtendedTextbox.Readonly = false;
			this.AddressExtendedTextbox.Size = new System.Drawing.Size(315, 20);
			this.AddressExtendedTextbox.TabIndex = 0;
			this.AddressExtendedTextbox.Type = AppointIn.DesktopApp.Gui.ExtendedTextboxType.Int;
			// 
			// Address2Textbox
			// 
			this.Address2Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Address2Textbox.BackColor = System.Drawing.Color.Transparent;
			this.Address2Textbox.LabelText = "Building/Interior";
			this.Address2Textbox.Location = new System.Drawing.Point(13, 92);
			this.Address2Textbox.Name = "Address2Textbox";
			this.Address2Textbox.Readonly = false;
			this.Address2Textbox.Size = new System.Drawing.Size(315, 20);
			this.Address2Textbox.TabIndex = 0;
			this.Address2Textbox.Type = AppointIn.DesktopApp.Gui.ExtendedTextboxType.Int;
			// 
			// CityComboBox
			// 
			this.CityComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CityComboBox.BackColor = System.Drawing.Color.Transparent;
			this.CityComboBox.LabelText = "City";
			this.CityComboBox.Location = new System.Drawing.Point(13, 118);
			this.CityComboBox.Name = "CityComboBox";
			this.CityComboBox.Size = new System.Drawing.Size(315, 20);
			this.CityComboBox.TabIndex = 1;
			// 
			// AddressDataPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.CityComboBox);
			this.Controls.Add(this.Address2Textbox);
			this.Controls.Add(this.AddressExtendedTextbox);
			this.Controls.Add(this.IdExtendedTextbox);
			this.Name = "AddressDataPanel";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.Size = new System.Drawing.Size(341, 200);
			this.ResumeLayout(false);

		}

		#endregion

		private ExtendedTextbox IdExtendedTextbox;
		private ExtendedTextbox AddressExtendedTextbox;
		private ExtendedTextbox Address2Textbox;
		private ExtendedComboBox CityComboBox;
	}
}
