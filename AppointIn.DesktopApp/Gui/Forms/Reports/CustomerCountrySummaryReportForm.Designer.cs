namespace AppointIn.DesktopApp.Gui
{
	partial class CustomerCountrySummaryReportForm
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
			this.CountryComboBox = new System.Windows.Forms.ComboBox();
			this.CountryLabel = new System.Windows.Forms.Label();
			this.HeaderPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// HeaderPanel
			// 
			this.HeaderPanel.Controls.Add(this.CountryLabel);
			this.HeaderPanel.Controls.Add(this.CountryComboBox);
			this.HeaderPanel.Size = new System.Drawing.Size(576, 100);
			this.HeaderPanel.Controls.SetChildIndex(this.CountryComboBox, 0);
			this.HeaderPanel.Controls.SetChildIndex(this.CountryLabel, 0);
			// 
			// TextBox
			// 
			this.TextBox.Margin = new System.Windows.Forms.Padding(4);
			this.TextBox.Size = new System.Drawing.Size(576, 400);
			// 
			// CountryComboBox
			// 
			this.CountryComboBox.FormattingEnabled = true;
			this.CountryComboBox.Location = new System.Drawing.Point(8, 67);
			this.CountryComboBox.Name = "CountryComboBox";
			this.CountryComboBox.Size = new System.Drawing.Size(200, 26);
			this.CountryComboBox.TabIndex = 1;
			// 
			// CountryLabel
			// 
			this.CountryLabel.AutoSize = true;
			this.CountryLabel.Location = new System.Drawing.Point(5, 46);
			this.CountryLabel.Name = "CountryLabel";
			this.CountryLabel.Size = new System.Drawing.Size(123, 18);
			this.CountryLabel.TabIndex = 2;
			this.CountryLabel.Text = "CountryLabelText";
			// 
			// CustomerCountrySummaryReportForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(576, 500);
			this.Margin = new System.Windows.Forms.Padding(6);
			this.MinimumSize = new System.Drawing.Size(592, 539);
			this.Name = "CustomerCountrySummaryReportForm";
			this.Text = "CustomerCountrySummaryReportForm";
			this.HeaderPanel.ResumeLayout(false);
			this.HeaderPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label CountryLabel;
		private System.Windows.Forms.ComboBox CountryComboBox;
	}
}