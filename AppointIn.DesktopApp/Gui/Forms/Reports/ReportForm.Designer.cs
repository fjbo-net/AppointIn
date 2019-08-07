namespace AppointIn.DesktopApp.Gui
{
	partial class ReportForm
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
			this.TitleLabel = new System.Windows.Forms.Label();
			this.HeaderPanel = new System.Windows.Forms.Panel();
			this.TextBox = new System.Windows.Forms.TextBox();
			this.SaveAsActionButton = new AppointIn.DesktopApp.Gui.ActionButton();
			this.FooterPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.CloseActionButton = new AppointIn.DesktopApp.Gui.ActionButton();
			this.HeaderPanel.SuspendLayout();
			this.FooterPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// TitleLabel
			// 
			this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TitleLabel.Location = new System.Drawing.Point(3, 9);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(360, 25);
			this.TitleLabel.TabIndex = 0;
			this.TitleLabel.Text = "ReportTitleText";
			// 
			// HeaderPanel
			// 
			this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(234)))));
			this.HeaderPanel.Controls.Add(this.TitleLabel);
			this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
			this.HeaderPanel.Name = "HeaderPanel";
			this.HeaderPanel.Size = new System.Drawing.Size(384, 100);
			this.HeaderPanel.TabIndex = 1;
			// 
			// TextBox
			// 
			this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextBox.Location = new System.Drawing.Point(0, 100);
			this.TextBox.Multiline = true;
			this.TextBox.Name = "TextBox";
			this.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.TextBox.Size = new System.Drawing.Size(384, 261);
			this.TextBox.TabIndex = 2;
			// 
			// SaveAsActionButton
			// 
			this.SaveAsActionButton.AutoSize = true;
			this.SaveAsActionButton.Location = new System.Drawing.Point(236, 12);
			this.SaveAsActionButton.Name = "SaveAsActionButton";
			this.SaveAsActionButton.Size = new System.Drawing.Size(139, 28);
			this.SaveAsActionButton.TabIndex = 0;
			this.SaveAsActionButton.Text = "SaveAsButtonText";
			this.SaveAsActionButton.UseVisualStyleBackColor = true;
			// 
			// FooterPanel
			// 
			this.FooterPanel.Controls.Add(this.SaveAsActionButton);
			this.FooterPanel.Controls.Add(this.CloseActionButton);
			this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.FooterPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.FooterPanel.Location = new System.Drawing.Point(0, 311);
			this.FooterPanel.Name = "FooterPanel";
			this.FooterPanel.Padding = new System.Windows.Forms.Padding(3, 9, 3, 0);
			this.FooterPanel.Size = new System.Drawing.Size(384, 50);
			this.FooterPanel.TabIndex = 3;
			// 
			// CloseActionButton
			// 
			this.CloseActionButton.AutoSize = true;
			this.CloseActionButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CloseActionButton.Location = new System.Drawing.Point(91, 12);
			this.CloseActionButton.Name = "CloseActionButton";
			this.CloseActionButton.Size = new System.Drawing.Size(139, 28);
			this.CloseActionButton.TabIndex = 0;
			this.CloseActionButton.Text = "CloseButtonText";
			this.CloseActionButton.UseVisualStyleBackColor = true;
			// 
			// ReportForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CloseActionButton;
			this.ClientSize = new System.Drawing.Size(384, 361);
			this.Controls.Add(this.FooterPanel);
			this.Controls.Add(this.TextBox);
			this.Controls.Add(this.HeaderPanel);
			this.Location = new System.Drawing.Point(0, 0);
			this.Name = "ReportForm";
			this.Text = "ReportFormText";
			this.HeaderPanel.ResumeLayout(false);
			this.FooterPanel.ResumeLayout(false);
			this.FooterPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label TitleLabel;
		protected System.Windows.Forms.Panel HeaderPanel;
		protected System.Windows.Forms.TextBox TextBox;
		private ActionButton SaveAsActionButton;
		protected System.Windows.Forms.FlowLayoutPanel FooterPanel;
		private ActionButton CloseActionButton;
	}
}