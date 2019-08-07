namespace AppointIn.DesktopApp.Gui
{
	partial class UserScheduleReportForm
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
			this.StartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.StartTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.DescriptionLabel = new System.Windows.Forms.Label();
			this.StartLabel = new System.Windows.Forms.Label();
			this.EndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.EndTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.EndLabel = new System.Windows.Forms.Label();
			this.HeaderPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// HeaderPanel
			// 
			this.HeaderPanel.Controls.Add(this.EndLabel);
			this.HeaderPanel.Controls.Add(this.StartLabel);
			this.HeaderPanel.Controls.Add(this.DescriptionLabel);
			this.HeaderPanel.Controls.Add(this.EndTimeDateTimePicker);
			this.HeaderPanel.Controls.Add(this.StartTimeDateTimePicker);
			this.HeaderPanel.Controls.Add(this.EndDateDateTimePicker);
			this.HeaderPanel.Controls.Add(this.StartDateDateTimePicker);
			this.HeaderPanel.Size = new System.Drawing.Size(576, 180);
			this.HeaderPanel.Controls.SetChildIndex(this.StartDateDateTimePicker, 0);
			this.HeaderPanel.Controls.SetChildIndex(this.EndDateDateTimePicker, 0);
			this.HeaderPanel.Controls.SetChildIndex(this.StartTimeDateTimePicker, 0);
			this.HeaderPanel.Controls.SetChildIndex(this.EndTimeDateTimePicker, 0);
			this.HeaderPanel.Controls.SetChildIndex(this.DescriptionLabel, 0);
			this.HeaderPanel.Controls.SetChildIndex(this.StartLabel, 0);
			this.HeaderPanel.Controls.SetChildIndex(this.EndLabel, 0);
			// 
			// TextBox
			// 
			this.TextBox.Location = new System.Drawing.Point(0, 180);
			this.TextBox.Margin = new System.Windows.Forms.Padding(4);
			this.TextBox.Size = new System.Drawing.Size(576, 320);
			// 
			// StartDateDateTimePicker
			// 
			this.StartDateDateTimePicker.Location = new System.Drawing.Point(8, 101);
			this.StartDateDateTimePicker.Name = "StartDateDateTimePicker";
			this.StartDateDateTimePicker.Size = new System.Drawing.Size(280, 24);
			this.StartDateDateTimePicker.TabIndex = 1;
			// 
			// StartTimeDateTimePicker
			// 
			this.StartTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.StartTimeDateTimePicker.Location = new System.Drawing.Point(294, 101);
			this.StartTimeDateTimePicker.Name = "StartTimeDateTimePicker";
			this.StartTimeDateTimePicker.ShowUpDown = true;
			this.StartTimeDateTimePicker.Size = new System.Drawing.Size(120, 24);
			this.StartTimeDateTimePicker.TabIndex = 2;
			// 
			// DescriptionLabel
			// 
			this.DescriptionLabel.AutoSize = true;
			this.DescriptionLabel.Location = new System.Drawing.Point(5, 48);
			this.DescriptionLabel.Name = "DescriptionLabel";
			this.DescriptionLabel.Size = new System.Drawing.Size(146, 18);
			this.DescriptionLabel.TabIndex = 3;
			this.DescriptionLabel.Text = "DescriptionLabelText";
			// 
			// StartLabel
			// 
			this.StartLabel.AutoSize = true;
			this.StartLabel.Location = new System.Drawing.Point(5, 80);
			this.StartLabel.Name = "StartLabel";
			this.StartLabel.Size = new System.Drawing.Size(102, 18);
			this.StartLabel.TabIndex = 4;
			this.StartLabel.Text = "StartLabelText";
			// 
			// EndDateDateTimePicker
			// 
			this.EndDateDateTimePicker.Location = new System.Drawing.Point(8, 149);
			this.EndDateDateTimePicker.Name = "EndDateDateTimePicker";
			this.EndDateDateTimePicker.Size = new System.Drawing.Size(280, 24);
			this.EndDateDateTimePicker.TabIndex = 1;
			// 
			// EndTimeDateTimePicker
			// 
			this.EndTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.EndTimeDateTimePicker.Location = new System.Drawing.Point(294, 149);
			this.EndTimeDateTimePicker.Name = "EndTimeDateTimePicker";
			this.EndTimeDateTimePicker.ShowUpDown = true;
			this.EndTimeDateTimePicker.Size = new System.Drawing.Size(120, 24);
			this.EndTimeDateTimePicker.TabIndex = 2;
			// 
			// EndLabel
			// 
			this.EndLabel.AutoSize = true;
			this.EndLabel.Location = new System.Drawing.Point(5, 128);
			this.EndLabel.Name = "EndLabel";
			this.EndLabel.Size = new System.Drawing.Size(97, 18);
			this.EndLabel.TabIndex = 4;
			this.EndLabel.Text = "EndLabelText";
			// 
			// UserScheduleReportForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(576, 500);
			this.Margin = new System.Windows.Forms.Padding(6);
			this.MinimumSize = new System.Drawing.Size(592, 539);
			this.Name = "UserScheduleReportForm";
			this.Text = "UserScheduleReportForm";
			this.HeaderPanel.ResumeLayout(false);
			this.HeaderPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label DescriptionLabel;
		private System.Windows.Forms.DateTimePicker StartTimeDateTimePicker;
		private System.Windows.Forms.DateTimePicker StartDateDateTimePicker;
		private System.Windows.Forms.Label StartLabel;
		private System.Windows.Forms.Label EndLabel;
		private System.Windows.Forms.DateTimePicker EndTimeDateTimePicker;
		private System.Windows.Forms.DateTimePicker EndDateDateTimePicker;
	}
}