namespace AppointIn.DesktopApp.Gui
{
	partial class CustomerDataPanel
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
			this.NameExtendedTextbox = new AppointIn.DesktopApp.Gui.ExtendedTextbox();
			this.ActiveCheckbox = new System.Windows.Forms.CheckBox();
			this.CreatedDateDateTimePicker = new AppointIn.DesktopApp.Gui.ExtendedDateTimePicker();
			this.CreatedByExtendedTextbox = new AppointIn.DesktopApp.Gui.ExtendedTextbox();
			this.LastUpdateExtendedTextbox = new AppointIn.DesktopApp.Gui.ExtendedTextbox();
			this.LastUpdateByExtendedTextbox = new AppointIn.DesktopApp.Gui.ExtendedTextbox();
			this.AddressExtendedCombobox = new AppointIn.DesktopApp.Gui.ExtendedComboBox();
			this.SuspendLayout();
			// 
			// IdExtendedTextbox
			// 
			this.IdExtendedTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.IdExtendedTextbox.BackColor = System.Drawing.Color.Transparent;
			this.IdExtendedTextbox.LabelText = "IdLabel";
			this.IdExtendedTextbox.Location = new System.Drawing.Point(10, 30);
			this.IdExtendedTextbox.Name = "IdExtendedTextbox";
			this.IdExtendedTextbox.Readonly = true;
			this.IdExtendedTextbox.Size = new System.Drawing.Size(318, 20);
			this.IdExtendedTextbox.TabIndex = 0;
			this.IdExtendedTextbox.Type = AppointIn.DesktopApp.Gui.ExtendedTextboxType.Int;
			// 
			// NameExtendedTextbox
			// 
			this.NameExtendedTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NameExtendedTextbox.BackColor = System.Drawing.Color.Transparent;
			this.NameExtendedTextbox.LabelText = "NameLabel";
			this.NameExtendedTextbox.Location = new System.Drawing.Point(10, 56);
			this.NameExtendedTextbox.Name = "NameExtendedTextbox";
			this.NameExtendedTextbox.Readonly = false;
			this.NameExtendedTextbox.Size = new System.Drawing.Size(318, 20);
			this.NameExtendedTextbox.TabIndex = 0;
			this.NameExtendedTextbox.Type = AppointIn.DesktopApp.Gui.ExtendedTextboxType.Text;
			// 
			// ActiveCheckbox
			// 
			this.ActiveCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ActiveCheckbox.Location = new System.Drawing.Point(10, 108);
			this.ActiveCheckbox.Name = "ActiveCheckbox";
			this.ActiveCheckbox.Size = new System.Drawing.Size(168, 24);
			this.ActiveCheckbox.TabIndex = 3;
			this.ActiveCheckbox.Text = "ActiveLabel";
			this.ActiveCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ActiveCheckbox.UseVisualStyleBackColor = true;
			// 
			// CreatedDateDateTimePicker
			// 
			this.CreatedDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CreatedDateDateTimePicker.BackColor = System.Drawing.Color.Transparent;
			this.CreatedDateDateTimePicker.LabelText = "CreatedDateLabel";
			this.CreatedDateDateTimePicker.Location = new System.Drawing.Point(10, 138);
			this.CreatedDateDateTimePicker.Name = "CreatedDateDateTimePicker";
			this.CreatedDateDateTimePicker.Size = new System.Drawing.Size(318, 20);
			this.CreatedDateDateTimePicker.TabIndex = 4;
			this.CreatedDateDateTimePicker.Value = new System.DateTime(2019, 7, 7, 20, 18, 46, 105);
			// 
			// CreatedByExtendedTextbox
			// 
			this.CreatedByExtendedTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CreatedByExtendedTextbox.BackColor = System.Drawing.Color.Transparent;
			this.CreatedByExtendedTextbox.LabelText = "CreatedByLabel";
			this.CreatedByExtendedTextbox.Location = new System.Drawing.Point(10, 164);
			this.CreatedByExtendedTextbox.Name = "CreatedByExtendedTextbox";
			this.CreatedByExtendedTextbox.Readonly = true;
			this.CreatedByExtendedTextbox.Size = new System.Drawing.Size(318, 20);
			this.CreatedByExtendedTextbox.TabIndex = 0;
			this.CreatedByExtendedTextbox.Type = AppointIn.DesktopApp.Gui.ExtendedTextboxType.Text;
			// 
			// LastUpdateExtendedTextbox
			// 
			this.LastUpdateExtendedTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LastUpdateExtendedTextbox.BackColor = System.Drawing.Color.Transparent;
			this.LastUpdateExtendedTextbox.LabelText = "LastUpdateLabel";
			this.LastUpdateExtendedTextbox.Location = new System.Drawing.Point(10, 190);
			this.LastUpdateExtendedTextbox.Name = "LastUpdateExtendedTextbox";
			this.LastUpdateExtendedTextbox.Readonly = true;
			this.LastUpdateExtendedTextbox.Size = new System.Drawing.Size(318, 20);
			this.LastUpdateExtendedTextbox.TabIndex = 0;
			this.LastUpdateExtendedTextbox.Type = AppointIn.DesktopApp.Gui.ExtendedTextboxType.Text;
			// 
			// LastUpdateByExtendedTextbox
			// 
			this.LastUpdateByExtendedTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LastUpdateByExtendedTextbox.BackColor = System.Drawing.Color.Transparent;
			this.LastUpdateByExtendedTextbox.LabelText = "LastUpdateByLabel";
			this.LastUpdateByExtendedTextbox.Location = new System.Drawing.Point(10, 216);
			this.LastUpdateByExtendedTextbox.Name = "LastUpdateByExtendedTextbox";
			this.LastUpdateByExtendedTextbox.Readonly = true;
			this.LastUpdateByExtendedTextbox.Size = new System.Drawing.Size(318, 20);
			this.LastUpdateByExtendedTextbox.TabIndex = 0;
			this.LastUpdateByExtendedTextbox.Type = AppointIn.DesktopApp.Gui.ExtendedTextboxType.Text;
			// 
			// AddressExtendedCombobox
			// 
			this.AddressExtendedCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AddressExtendedCombobox.BackColor = System.Drawing.Color.Transparent;
			this.AddressExtendedCombobox.LabelText = "AddressLabel";
			this.AddressExtendedCombobox.Location = new System.Drawing.Point(10, 82);
			this.AddressExtendedCombobox.Name = "AddressExtendedCombobox";
			this.AddressExtendedCombobox.Size = new System.Drawing.Size(318, 20);
			this.AddressExtendedCombobox.TabIndex = 5;
			// 
			// CustomerDataPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.AddressExtendedCombobox);
			this.Controls.Add(this.CreatedDateDateTimePicker);
			this.Controls.Add(this.ActiveCheckbox);
			this.Controls.Add(this.CreatedByExtendedTextbox);
			this.Controls.Add(this.LastUpdateByExtendedTextbox);
			this.Controls.Add(this.LastUpdateExtendedTextbox);
			this.Controls.Add(this.NameExtendedTextbox);
			this.Controls.Add(this.IdExtendedTextbox);
			this.Name = "CustomerDataPanel";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.Size = new System.Drawing.Size(341, 250);
			this.ResumeLayout(false);

		}

		#endregion

		private ExtendedTextbox IdExtendedTextbox;
		private ExtendedTextbox NameExtendedTextbox;
		private System.Windows.Forms.CheckBox ActiveCheckbox;
		private ExtendedDateTimePicker CreatedDateDateTimePicker;
		private ExtendedTextbox CreatedByExtendedTextbox;
		private ExtendedTextbox LastUpdateExtendedTextbox;
		private ExtendedTextbox LastUpdateByExtendedTextbox;
		private ExtendedComboBox AddressExtendedCombobox;
	}
}
