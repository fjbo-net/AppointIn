﻿namespace AppointIn.DesktopApp.Gui
{
	partial class CustomerForm
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
			this.DataPanel = new AppointIn.DesktopApp.Gui.CustomerDataPanel();
			this.ButtonsContainer = new System.Windows.Forms.Panel();
			this.SaveActionButton = new AppointIn.DesktopApp.Gui.ActionButton();
			this.CancelActionButton = new AppointIn.DesktopApp.Gui.ActionButton();
			this.ButtonsContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// DataPanel
			// 
			this.DataPanel.BackColor = System.Drawing.Color.Transparent;
			this.DataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DataPanel.Location = new System.Drawing.Point(0, 0);
			this.DataPanel.Margin = new System.Windows.Forms.Padding(4);
			this.DataPanel.Name = "DataPanel";
			this.DataPanel.Padding = new System.Windows.Forms.Padding(15, 14, 15, 14);
			this.DataPanel.Size = new System.Drawing.Size(726, 500);
			this.DataPanel.TabIndex = 0;
			// 
			// ButtonsContainer
			// 
			this.ButtonsContainer.Controls.Add(this.CancelActionButton);
			this.ButtonsContainer.Controls.Add(this.SaveActionButton);
			this.ButtonsContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ButtonsContainer.Location = new System.Drawing.Point(0, 450);
			this.ButtonsContainer.Name = "ButtonsContainer";
			this.ButtonsContainer.Size = new System.Drawing.Size(726, 50);
			this.ButtonsContainer.TabIndex = 1;
			// 
			// SaveActionButton
			// 
			this.SaveActionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveActionButton.AutoSize = true;
			this.SaveActionButton.Location = new System.Drawing.Point(605, 10);
			this.SaveActionButton.Name = "SaveActionButton";
			this.SaveActionButton.Size = new System.Drawing.Size(109, 28);
			this.SaveActionButton.TabIndex = 0;
			this.SaveActionButton.Text = "SaveButton";
			this.SaveActionButton.UseVisualStyleBackColor = true;
			// 
			// CancelActionButton
			// 
			this.CancelActionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelActionButton.AutoSize = true;
			this.CancelActionButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelActionButton.Location = new System.Drawing.Point(490, 10);
			this.CancelActionButton.Name = "CancelActionButton";
			this.CancelActionButton.Size = new System.Drawing.Size(109, 28);
			this.CancelActionButton.TabIndex = 0;
			this.CancelActionButton.Text = "CancelButton";
			this.CancelActionButton.UseVisualStyleBackColor = true;
			// 
			// CustomerForm
			// 
			this.AcceptButton = this.SaveActionButton;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CancelActionButton;
			this.ClientSize = new System.Drawing.Size(726, 500);
			this.Controls.Add(this.ButtonsContainer);
			this.Controls.Add(this.DataPanel);
			this.Location = new System.Drawing.Point(0, 0);
			this.Margin = new System.Windows.Forms.Padding(6);
			this.MinimumSize = new System.Drawing.Size(592, 539);
			this.Name = "CustomerForm";
			this.Text = "CustomerForm";
			this.ButtonsContainer.ResumeLayout(false);
			this.ButtonsContainer.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private CustomerDataPanel DataPanel;
		private System.Windows.Forms.Panel ButtonsContainer;
		private ActionButton CancelActionButton;
		private ActionButton SaveActionButton;
	}
}