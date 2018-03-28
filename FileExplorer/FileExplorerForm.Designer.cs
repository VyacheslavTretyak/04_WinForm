namespace FileExplorer
{
	partial class FileExplorerForm
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
			this.components = new System.ComponentModel.Container();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.lbFolders = new System.Windows.Forms.ListBox();
			this.tbPath = new System.Windows.Forms.TextBox();
			this.lbFiles = new System.Windows.Forms.ListBox();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.msFile = new System.Windows.Forms.ToolStripMenuItem();
			this.msOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.msExit = new System.Windows.Forms.ToolStripMenuItem();
			this.msEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.msCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.msPaste = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cmsCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.cmsPaste = new System.Windows.Forms.ToolStripMenuItem();
			this.tsOpen = new System.Windows.Forms.ToolStripButton();
			this.tsCopy = new System.Windows.Forms.ToolStripButton();
			this.tsPaste = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.contextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOpen,
            this.tsCopy,
            this.tsPaste});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(800, 25);
			this.toolStrip1.TabIndex = 6;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// lbFolders
			// 
			this.lbFolders.BackColor = System.Drawing.Color.Tan;
			this.lbFolders.Dock = System.Windows.Forms.DockStyle.Left;
			this.lbFolders.FormattingEnabled = true;
			this.lbFolders.Location = new System.Drawing.Point(0, 49);
			this.lbFolders.Name = "lbFolders";
			this.lbFolders.Size = new System.Drawing.Size(120, 401);
			this.lbFolders.TabIndex = 0;
			// 
			// tbPath
			// 
			this.tbPath.BackColor = System.Drawing.Color.MediumAquamarine;
			this.tbPath.Dock = System.Windows.Forms.DockStyle.Top;
			this.tbPath.Location = new System.Drawing.Point(120, 49);
			this.tbPath.Name = "tbPath";
			this.tbPath.ReadOnly = true;
			this.tbPath.Size = new System.Drawing.Size(680, 20);
			this.tbPath.TabIndex = 2;
			// 
			// lbFiles
			// 
			this.lbFiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbFiles.FormattingEnabled = true;
			this.lbFiles.Location = new System.Drawing.Point(120, 69);
			this.lbFiles.Name = "lbFiles";
			this.lbFiles.Size = new System.Drawing.Size(680, 381);
			this.lbFiles.TabIndex = 3;
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFile,
            this.msEdit});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(800, 24);
			this.menuStrip.TabIndex = 4;
			this.menuStrip.Text = "menuStrip1";
			// 
			// msFile
			// 
			this.msFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msOpen,
            this.toolStripMenuItem1,
            this.msExit});
			this.msFile.Name = "msFile";
			this.msFile.Size = new System.Drawing.Size(37, 20);
			this.msFile.Text = "&File";
			// 
			// msOpen
			// 
			this.msOpen.Name = "msOpen";
			this.msOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
			this.msOpen.Size = new System.Drawing.Size(180, 22);
			this.msOpen.Text = "Open";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
			// 
			// msExit
			// 
			this.msExit.Name = "msExit";
			this.msExit.Size = new System.Drawing.Size(180, 22);
			this.msExit.Text = "Exit";
			// 
			// msEdit
			// 
			this.msEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msCopy,
            this.msPaste});
			this.msEdit.Name = "msEdit";
			this.msEdit.Size = new System.Drawing.Size(39, 20);
			this.msEdit.Text = "&Edit";
			// 
			// msCopy
			// 
			this.msCopy.Name = "msCopy";
			this.msCopy.ShortcutKeyDisplayString = "";
			this.msCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.msCopy.Size = new System.Drawing.Size(144, 22);
			this.msCopy.Text = "Copy";
			// 
			// msPaste
			// 
			this.msPaste.Name = "msPaste";
			this.msPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.msPaste.Size = new System.Drawing.Size(144, 22);
			this.msPaste.Text = "Paste";
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsCopy,
            this.cmsPaste});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(103, 48);
			// 
			// cmsCopy
			// 
			this.cmsCopy.Name = "cmsCopy";
			this.cmsCopy.Size = new System.Drawing.Size(102, 22);
			this.cmsCopy.Text = "Copy";
			// 
			// cmsPaste
			// 
			this.cmsPaste.Name = "cmsPaste";
			this.cmsPaste.Size = new System.Drawing.Size(102, 22);
			this.cmsPaste.Text = "Paste";
			// 
			// tsOpen
			// 
			this.tsOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsOpen.Image = global::FileExplorer.Properties.Resources.if_ic_folder_open_48px_352375;
			this.tsOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsOpen.Name = "tsOpen";
			this.tsOpen.Size = new System.Drawing.Size(23, 22);
			this.tsOpen.Text = "Open";
			this.tsOpen.ToolTipText = "Open";
			// 
			// tsCopy
			// 
			this.tsCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsCopy.Image = global::FileExplorer.Properties.Resources.if_39_Minimize_2123874;
			this.tsCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsCopy.Name = "tsCopy";
			this.tsCopy.Size = new System.Drawing.Size(23, 22);
			this.tsCopy.Text = "toolStripButton2";
			this.tsCopy.ToolTipText = "Copy";
			// 
			// tsPaste
			// 
			this.tsPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsPaste.Image = global::FileExplorer.Properties.Resources.if_paste_1608782;
			this.tsPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsPaste.Name = "tsPaste";
			this.tsPaste.Size = new System.Drawing.Size(23, 22);
			this.tsPaste.Text = "toolStripButton3";
			this.tsPaste.ToolTipText = "Paste";
			// 
			// FileExplorerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lbFiles);
			this.Controls.Add(this.tbPath);
			this.Controls.Add(this.lbFolders);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "FileExplorerForm";
			this.Text = "File Explorer";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.contextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		
		private System.Windows.Forms.ListBox lbFolders;
		private System.Windows.Forms.TextBox tbPath;
		private System.Windows.Forms.ListBox lbFiles;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem msFile;
		private System.Windows.Forms.ToolStripMenuItem msOpen;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem msExit;
		private System.Windows.Forms.ToolStripMenuItem msEdit;
		private System.Windows.Forms.ToolStripMenuItem msCopy;
		private System.Windows.Forms.ToolStripMenuItem msPaste;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem cmsCopy;
		private System.Windows.Forms.ToolStripMenuItem cmsPaste;
		private System.Windows.Forms.ToolStripButton tsOpen;
		private System.Windows.Forms.ToolStripButton tsCopy;
		private System.Windows.Forms.ToolStripButton tsPaste;
	}
}

