namespace AppointIn.DesktopApp.Gui
{
	partial class NotificationForm
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
			this.DismissActionButton = new AppointIn.DesktopApp.Gui.ActionButton();
			this.ViewActionButton = new AppointIn.DesktopApp.Gui.ActionButton();
			this.FooterPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.MessageTextBox = new System.Windows.Forms.TextBox();
			this.FooterPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// TitleLabel
			// 
			this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TitleLabel.Location = new System.Drawing.Point(12, 9);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(360, 25);
			this.TitleLabel.TabIndex = 1;
			this.TitleLabel.Text = "NotificationTitleText";
			// 
			// DismissActionButton
			// 
			this.DismissActionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DismissActionButton.AutoSize = true;
			this.DismissActionButton.Location = new System.Drawing.Point(271, 13);
			this.DismissActionButton.Name = "DismissActionButton";
			this.DismissActionButton.Size = new System.Drawing.Size(104, 23);
			this.DismissActionButton.TabIndex = 0;
			this.DismissActionButton.Text = "DismissButtonText";
			this.DismissActionButton.UseVisualStyleBackColor = true;
			// 
			// ViewActionButton
			// 
			this.ViewActionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ViewActionButton.AutoSize = true;
			this.ViewActionButton.Location = new System.Drawing.Point(161, 13);
			this.ViewActionButton.Name = "ViewActionButton";
			this.ViewActionButton.Size = new System.Drawing.Size(104, 23);
			this.ViewActionButton.TabIndex = 0;
			this.ViewActionButton.Text = "ViewButtonText";
			this.ViewActionButton.UseVisualStyleBackColor = true;
			// 
			// FooterPanel
			// 
			this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.FooterPanel.Controls.Add(this.DismissActionButton);
			this.FooterPanel.Controls.Add(this.ViewActionButton);
			this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.FooterPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.FooterPanel.Location = new System.Drawing.Point(0, 311);
			this.FooterPanel.Name = "FooterPanel";
			this.FooterPanel.Padding = new System.Windows.Forms.Padding(3, 10, 3, 10);
			this.FooterPanel.Size = new System.Drawing.Size(384, 50);
			this.FooterPanel.TabIndex = 2;
			// 
			// MessageTextBox
			// 
			this.MessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.MessageTextBox.Location = new System.Drawing.Point(17, 37);
			this.MessageTextBox.Multiline = true;
			this.MessageTextBox.Name = "MessageTextBox";
			this.MessageTextBox.ReadOnly = true;
			this.MessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.MessageTextBox.Size = new System.Drawing.Size(355, 268);
			this.MessageTextBox.TabIndex = 3;
			// 
			// NotificationForm
			// 
			this.AcceptButton = this.ViewActionButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.DismissActionButton;
			this.ClientSize = new System.Drawing.Size(384, 361);
			this.Controls.Add(this.MessageTextBox);
			this.Controls.Add(this.FooterPanel);
			this.Controls.Add(this.TitleLabel);
			this.MaximumSize = new System.Drawing.Size(400, 400);
			this.MinimumSize = new System.Drawing.Size(400, 400);
			this.Name = "NotificationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NotificationForm";
			this.FooterPanel.ResumeLayout(false);
			this.FooterPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label TitleLabel;
		private ActionButton DismissActionButton;
		private ActionButton ViewActionButton;
		private System.Windows.Forms.FlowLayoutPanel FooterPanel;
		private System.Windows.Forms.TextBox MessageTextBox;
	}
}