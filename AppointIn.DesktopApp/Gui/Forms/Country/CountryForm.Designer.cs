namespace AppointIn.DesktopApp.Gui
{
	partial class CountryForm
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
			this.DataPanel = new AppointIn.DesktopApp.Gui.CountryDataPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.CancelActionButton = new AppointIn.DesktopApp.Gui.ActionButton();
			this.SaveActionButton = new AppointIn.DesktopApp.Gui.ActionButton();
			this.panel1.SuspendLayout();
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
			this.DataPanel.Size = new System.Drawing.Size(484, 311);
			this.DataPanel.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.CancelActionButton);
			this.panel1.Controls.Add(this.SaveActionButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 311);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(484, 50);
			this.panel1.TabIndex = 1;
			// 
			// CancelActionButton
			// 
			this.CancelActionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelActionButton.AutoSize = true;
			this.CancelActionButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelActionButton.Location = new System.Drawing.Point(248, 10);
			this.CancelActionButton.Name = "CancelActionButton";
			this.CancelActionButton.Size = new System.Drawing.Size(109, 28);
			this.CancelActionButton.TabIndex = 1;
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
			// CountryForm
			// 
			this.AcceptButton = this.SaveActionButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CancelActionButton;
			this.ClientSize = new System.Drawing.Size(484, 361);
			this.Controls.Add(this.DataPanel);
			this.Controls.Add(this.panel1);
			this.Location = new System.Drawing.Point(0, 0);
			this.Name = "CountryForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "CountryForm";
			this.WindowState = System.Windows.Forms.FormWindowState.Normal;
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private CountryDataPanel DataPanel;
		private ActionButton CancelActionButton;
		private ActionButton SaveActionButton;
	}
}