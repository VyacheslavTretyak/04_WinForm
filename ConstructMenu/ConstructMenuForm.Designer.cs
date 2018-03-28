namespace ConstructMenu
{
	partial class ConstructMenuForm
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
			this.btnTopItem = new System.Windows.Forms.Button();
			this.tbTopItem = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tbSubItem = new System.Windows.Forms.TextBox();
			this.btnSumItem = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnTopItem
			// 
			this.btnTopItem.Enabled = false;
			this.btnTopItem.Location = new System.Drawing.Point(148, 40);
			this.btnTopItem.Name = "btnTopItem";
			this.btnTopItem.Size = new System.Drawing.Size(86, 57);
			this.btnTopItem.TabIndex = 0;
			this.btnTopItem.Text = "Add Top Item Menu";
			this.btnTopItem.UseVisualStyleBackColor = true;
			// 
			// tbTopItem
			// 
			this.tbTopItem.Location = new System.Drawing.Point(13, 59);
			this.tbTopItem.Name = "tbTopItem";
			this.tbTopItem.Size = new System.Drawing.Size(100, 20);
			this.tbTopItem.TabIndex = 1;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(426, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tbSubItem
			// 
			this.tbSubItem.Location = new System.Drawing.Point(12, 121);
			this.tbSubItem.Name = "tbSubItem";
			this.tbSubItem.Size = new System.Drawing.Size(100, 20);
			this.tbSubItem.TabIndex = 4;
			// 
			// btnSumItem
			// 
			this.btnSumItem.Enabled = false;
			this.btnSumItem.Location = new System.Drawing.Point(148, 103);
			this.btnSumItem.Name = "btnSumItem";
			this.btnSumItem.Size = new System.Drawing.Size(86, 54);
			this.btnSumItem.TabIndex = 3;
			this.btnSumItem.Text = "Add Sub Item Menu";
			this.btnSumItem.UseVisualStyleBackColor = true;
			// 
			// ConstructMenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(426, 298);
			this.Controls.Add(this.tbSubItem);
			this.Controls.Add(this.btnSumItem);
			this.Controls.Add(this.tbTopItem);
			this.Controls.Add(this.btnTopItem);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "ConstructMenuForm";
			this.Text = "Construct Menu";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnTopItem;
		private System.Windows.Forms.TextBox tbTopItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.TextBox tbSubItem;
		private System.Windows.Forms.Button btnSumItem;
	}
}

