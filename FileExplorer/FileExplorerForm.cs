using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Specialized;

namespace FileExplorer
{	
	public partial class FileExplorerForm : Form
	{
		List<string> openedFolders;
		string selected;
		int lastSelect = 0;
		public FileExplorerForm()
		{
			Clipboard.Clear();
			InitializeComponent();
			openedFolders = new List<string>();			
			lbFiles.ContextMenuStrip = contextMenuStrip;
			Load += FileExplorerForm_Load;
			lbFolders.Click += LbFolders_Click;
			lbFolders.DoubleClick += LbFolders_DoubleClick;
			msEdit.DropDownOpening += MsEdit_Open;
			contextMenuStrip.Opening += ContextMenuStrip_Opening;
			msCopy.Click += MsCopy_Click;
			msPaste.Click += MsPaste_Click;
			msOpen.Click += LbFolders_DoubleClick;
			cmsCopy.Click += MsCopy_Click;
			cmsPaste.Click += MsPaste_Click;
			tsCopy.Click += MsCopy_Click;
			tsPaste.Click += MsPaste_Click;
			tsOpen.Click += LbFolders_DoubleClick;
		}

		private void MsPaste_Click(object sender, EventArgs e)
		{
			StringCollection col = Clipboard.GetFileDropList();
			if (col.Count <= 0)
			{
				return;
			}
			foreach (string item in col)
			{	
				try
				{
					File.Copy(item, tbPath.Text+'\\' + Path.GetFileName(item));
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			LoadFiles();
		}

		private void MsCopy_Click(object sender, EventArgs e)
		{
			FileInfo file = lbFiles.SelectedItem as FileInfo;
			if (file == null)
			{
				return;
			}
			string[] files = new string[1];
			files[0] = file.FullName;			
			Clipboard.Clear();
			Clipboard.SetData(DataFormats.FileDrop, files);
		}

		private void ContextMenuStrip_Opening(object sender, CancelEventArgs e)
		{
			if (lbFiles.SelectedItems.Count > 0)
			{
				cmsCopy.Enabled = true;
			}
			else
			{
				cmsCopy.Enabled = false;
			}
			if (tbPath.Text.Length > 0 && Clipboard.GetFileDropList().Count != 0)
			{
				cmsPaste.Enabled = true;
			}
			else
			{
				cmsPaste.Enabled = false;
			}
		}

		private void MsEdit_Open(object sender, EventArgs e)
		{
			if(lbFiles.SelectedItems.Count > 0)
			{
				msCopy.Enabled = true;
			}
			else
			{
				msCopy.Enabled = false;
			}
			if(tbPath.Text.Length > 0 && Clipboard.GetFileDropList().Count != 0)
			{
				msPaste.Enabled = true;
			}
			else
			{
				msPaste.Enabled = false;
			}
		}
		private void LoadFiles()
		{
			DirectoryInfo dirInfo = new DirectoryInfo(selected);
			DirectoryInfo[] dirs = dirInfo.GetDirectories();
			lbFiles.Items.Clear();
			foreach (DirectoryInfo dir in dirs)
			{
				if ((dir.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
				{
					continue;
				}
				lbFiles.Items.Add(dir);
			}
			FileInfo[] files = dirInfo.GetFiles();
			foreach (FileInfo file in files)
			{
				if ((file.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
				{
					continue;
				}
				lbFiles.Items.Add(file);
			}
		}
		private void LbFolders_DoubleClick(object sender, EventArgs e)
		{
			LoadFiles();	
		}
		private string GetPath(ListBox sender)
		{
			DirectoryEx ex = sender.SelectedItem as DirectoryEx;
			if (ex.Drive != null)
			{
				return ex.Drive.Name;
			}
			return ex.Dir.FullName;			
		}

		private void LbFolders_Click(object sender, EventArgs e)
		{			
			selected = GetPath(sender as ListBox);
			lastSelect = lbFolders.SelectedIndex;
			tbPath.Text = selected;
			if (openedFolders.Contains(selected))
			{
				openedFolders.Remove(selected);
			}
			else
			{
				openedFolders.Add(selected);
			}
			lbFolders.Items.Clear();
			LoadDrives();
		}

		private void FileExplorerForm_Load(object sender, EventArgs e)
		{
			LoadDrives();
		}	

		private void LoadDrives()
		{
			DriveInfo[] driveInfos = DriveInfo.GetDrives();
			foreach(DriveInfo drive in driveInfos)
			{
				lbFolders.Items.Add(new DirectoryEx() { Drive = drive});
				if (openedFolders.Contains(drive.Name))
				{
					LoadFolders(drive.Name, 1);
				}
			}
			lbFolders.SetSelected(lastSelect, true);
			selected = GetPath(lbFolders);
		}
		private void LoadFolders(string path, int level)
		{
			DirectoryInfo dirInfo = new DirectoryInfo(path);
			DirectoryInfo[] dirs = dirInfo.GetDirectories();
			foreach (DirectoryInfo dir in dirs)
			{				
				if((dir.Attributes & FileAttributes.Hidden)== FileAttributes.Hidden)
				{
					continue;
				}
				lbFolders.Items.Add(new DirectoryEx() { Dir = dir, Level = level });
				if (openedFolders.Contains(dir.FullName))
				{
					LoadFolders(dir.FullName, level+1);
				}
			}			
		}
	}
}
