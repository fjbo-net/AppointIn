namespace AppointIn.DesktopApp.Gui
{
	partial class AddressForm
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
			this.DataPanel = new AppointIn.DesktopApp.Gui.Controls.AddressDataPanel();
			this.ButtonsPanel = new System.Windows.Forms.Panel();
			this.CancelActionButton = new AppointIn.DesktopApp.Gui.ActionButton();
			this.SaveActionButton = new AppointIn.DesktopApp.Gui.ActionButton();
			this.ButtonsPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// DataPanel
			// 
			this.DataPanel.BackColor = System.Drawing.Color.Transparent;
			this.DataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DataPanel.Location = new System.Drawing.Point(0, 0);
			this.DataPanel.Name = "DataPanel";
			this.DataPanel.Padding = new System.Windows.Forms.Padding(10);
			this.DataPanel.Size = new System.Drawing.Size(484, 361);
			this.DataPanel.TabIndex = 0;
			// 
			// ButtonsPanel
			// 
			this.ButtonsPanel.Controls.Add(this.CancelActionButton);
			this.ButtonsPanel.Controls.Add(this.SaveActionButton);
			this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ButtonsPanel.Location = new System.Drawing.Point(0, 311);
			this.ButtonsPanel.Name = "ButtonsPanel";
			this.ButtonsPanel.Size = new System.Drawing.Size(484, 50);
			this.ButtonsPanel.TabIndex = 1;
			// 
			// CancelActionButton
			// 
			this.CancelActionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelActionButton.AutoSize = true;
			this.CancelActionButton.Location = new System.Drawing.Point(248, 10);
			this.CancelActionButton.Name = "CancelActionButton";
			this.CancelActionButton.Size = new System.Drawing.Size(109, 28);
			this.CancelActionButton.TabIndex = 0;
			this.CancelActionButton.Text = "CancelButton";
			this.CancelActionButton.UseVisualStyleBackColor = true;
			// 
			// SaveActionButton
			// 
			this.SaveActionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveActionButton.AutoSize = true;
			this.SaveActionButton.Location = new System.Drawing.Point(363, 10);
			this.SaveActionButton.Name = "SaveActionButton";
			this.SaveActionButton.Size = new System.Drawing.Size(109, 28);
			this.SaveActionButton.TabIndex = 0;
			this.SaveActionButton.Text = "SaveButton";
			this.SaveActionButton.UseVisualStyleBackColor = true;
			// 
			// AddressForm
			// 
			this.AcceptButton = this.SaveActionButton;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CancelActionButton;
			this.ClientSize = new System.Drawing.Size(484, 361);
			this.Controls.Add(this.ButtonsPanel);
			this.Controls.Add(this.DataPanel);
			this.Location = new System.Drawing.Point(0, 0);
			this.Name = "AddressForm";
			this.Text = "AddressForm";
			this.ButtonsPanel.ResumeLayout(false);
			this.ButtonsPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Controls.AddressDataPanel DataPanel;
		private System.Windows.Forms.Panel ButtonsPanel;
		private ActionButton CancelActionButton;
		private ActionButton SaveActionButton;
	}
}