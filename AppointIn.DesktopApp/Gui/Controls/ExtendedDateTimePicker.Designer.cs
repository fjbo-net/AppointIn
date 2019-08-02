namespace AppointIn.DesktopApp.Gui
{
	partial class ExtendedDateTimePicker
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
			this.Label = new System.Windows.Forms.Label();
			this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// Label
			// 
			this.Label.Dock = System.Windows.Forms.DockStyle.Left;
			this.Label.Location = new System.Drawing.Point(0, 0);
			this.Label.Name = "Label";
			this.Label.Size = new System.Drawing.Size(150, 20);
			this.Label.TabIndex = 0;
			this.Label.Text = "label1";
			this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// DateTimePicker
			// 
			this.DateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
			this.DateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.DateTimePicker.Location = new System.Drawing.Point(150, 0);
			this.DateTimePicker.Name = "DateTimePicker";
			this.DateTimePicker.Size = new System.Drawing.Size(250, 20);
			this.DateTimePicker.TabIndex = 1;
			// 
			// ExtendedDateTimePicker
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.DateTimePicker);
			this.Controls.Add(this.Label);
			this.Name = "ExtendedDateTimePicker";
			this.Size = new System.Drawing.Size(400, 20);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label Label;
		private System.Windows.Forms.DateTimePicker DateTimePicker;
	}
}
