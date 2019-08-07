namespace AppointIn.DesktopApp.Gui
{
	partial class AppointmentsPerMonthReportForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.MonthLabel = new System.Windows.Forms.Label();
			this.MonthDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.HeaderPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// HeaderPanel
			// 
			this.HeaderPanel.Controls.Add(this.MonthDateTimePicker);
			this.HeaderPanel.Controls.Add(this.MonthLabel);
			this.HeaderPanel.Controls.SetChildIndex(this.MonthLabel, 0);
			this.HeaderPanel.Controls.SetChildIndex(this.MonthDateTimePicker, 0);
			// 
			// MonthLabel
			// 
			this.MonthLabel.AutoSize = true;
			this.MonthLabel.Location = new System.Drawing.Point(5, 49);
			this.MonthLabel.Name = "MonthLabel";
			this.MonthLabel.Size = new System.Drawing.Size(113, 18);
			this.MonthLabel.TabIndex = 1;
			this.MonthLabel.Text = "MonthLabelText";
			// 
			// MonthDateTimePicker
			// 
			this.MonthDateTimePicker.CustomFormat = "MMMM yyyy";
			this.MonthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.MonthDateTimePicker.Location = new System.Drawing.Point(8, 70);
			this.MonthDateTimePicker.Name = "MonthDateTimePicker";
			this.MonthDateTimePicker.Size = new System.Drawing.Size(200, 24);
			this.MonthDateTimePicker.TabIndex = 2;
			// 
			// AppointmentsPerMonthReportForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 361);
			this.Name = "AppointmentsPerMonthReportForm";
			this.HeaderPanel.ResumeLayout(false);
			this.HeaderPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label MonthLabel;
		private System.Windows.Forms.DateTimePicker MonthDateTimePicker;
	}
}