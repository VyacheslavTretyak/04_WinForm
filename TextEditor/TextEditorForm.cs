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

namespace TextEditor
{
	public partial class TextEditorForm : Form
	{
		string savedText = "";
		string saveFileName = "";
		public TextEditorForm()
		{
			InitializeComponent();
			fontToolStripMenuItem.Click += FontToolStripMenuItem_Click;
			tsbFont.Click += FontToolStripMenuItem_Click;
			fontColorToolStripMenuItem.Click += FontColorToolStripMenuItem_Click;
			tsbFontColor.Click += FontColorToolStripMenuItem_Click;
			backgroundColorToolStripMenuItem.Click += BackgroundColorToolStripMenuItem_Click;
			tsbBackgroundFont.Click += BackgroundColorToolStripMenuItem_Click;
			newToolStripMenuItem.Click += NewToolStripMenuItem_Click;
			tsbNew.Click += NewToolStripMenuItem_Click;
			saveAsToolStripMenuItem.Click += SaveAsToolStripMenuItem_Click;
			openToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
			tsbOpen.Click += OpenToolStripMenuItem_Click;
			saveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
			tsbSave.Click += SaveToolStripMenuItem_Click;

			markAllToolStripMenuItem.Click += MarkAllToolStripMenuItem_Click;
			ctsmSelectAll.Click += MarkAllToolStripMenuItem_Click;

			undoToolStripMenuItem.Click += UndoToolStripMenuItem_Click;
			ctsmUndo.Click += UndoToolStripMenuItem_Click;
			tsbUndo.Click += UndoToolStripMenuItem_Click;

			copyToolStripMenuItem.Click += CopyToolStripMenuItem_Click;
			tsbCopy.Click += CopyToolStripMenuItem_Click;
			ctsmCopy.Click += CopyToolStripMenuItem_Click;

			cutToolStripMenuItem.Click += CutToolStripMenuItem_Click;
			tsbCut.Click += CutToolStripMenuItem_Click;
			ctsmCut.Click += CutToolStripMenuItem_Click;

			pasteToolStripMenuItem.Click += PasteToolStripMenuItem_Click;
			tsbPaste.Click += PasteToolStripMenuItem_Click;
			ctsmPaste.Click += PasteToolStripMenuItem_Click;
			

			textBox.TextChanged += TextBox_TextChanged;
			ShowWordCount();

			contextMenuStrip1.Opening += ContextMenuStrip1_Opening;
			editToolStripMenuItem.DropDownOpening += EditToolStripMenuItem_DropDownOpening;

			Clipboard.Clear();
		}

		private void EditToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
		{
			pasteToolStripMenuItem.Enabled = Clipboard.GetDataObject().GetDataPresent(DataFormats.Text);
		}

		private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{
			ctsmPaste.Enabled = Clipboard.GetDataObject().GetDataPresent(DataFormats.Text);			
		}

			private void ShowWordCount()
		{
			tsslWordCount.Text = $"Count Words : {WordCount(textBox.Text)}";
		}
		private int WordCount(string str)
		{
			string[] arr = str.Split(" \n\t".ToArray<char>());
			return arr.Length - 1;
		}
		private void TextBox_TextChanged(object sender, EventArgs e)
		{
			ShowWordCount();
		}

		private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox.Paste();
		}

		private void CutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox.Cut();
		}

		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox.Copy();
		}

		private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox.Undo();
		}

		private void MarkAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox.SelectAll();			
		}

		private void SaveFile()
		{			
			if (saveFileName == "")
			{
				SaveFileDialog saveDialog = new SaveFileDialog();
				if (saveDialog.ShowDialog() == DialogResult.OK)
				{
					saveFileName = saveDialog.FileName;
				}
				else
				{
					return;
				}
			}
			using (TextWriter writer = new StreamWriter(saveFileName))
			{
				savedText = textBox.Text;
				writer.Write(savedText);
			}
		}
		private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
		{			
			SaveFile();
		}
		private DialogResult CheckChanges()
		{
			DialogResult res = DialogResult.OK;
			if (textBox.Text != savedText)
			{
				res = MessageBox.Show("Do you want save changes?", "To be or not to be?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				if(res == DialogResult.Yes)
				{
					SaveFile();
				}				
			}
			return res;
		}
		private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(CheckChanges() == DialogResult.Cancel)
			{
				return;
			}
			OpenFileDialog openDialog = new OpenFileDialog();			
			if (openDialog.ShowDialog() == DialogResult.OK)
			{
				saveFileName = openDialog.FileName;
				using (TextReader reader = new StreamReader(saveFileName))
				{
					savedText = reader.ReadToEnd();
					textBox.Text = savedText;
				}
			}
		}

		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveDialog = new SaveFileDialog();
			if(saveDialog.ShowDialog()== DialogResult.OK)
			{
				using (TextWriter writer = new StreamWriter(saveDialog.FileName))
				{
					writer.Write(textBox.Text);
				}
			}			
		}
		private void NewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (CheckChanges() == DialogResult.Cancel)
			{
				return;
			}
			textBox.Clear();
			saveFileName = "";
			savedText = "";			
		}
		private void BackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ColorDialog colorDialog = new ColorDialog();
			if (colorDialog.ShowDialog() == DialogResult.OK)
			{
				textBox.BackColor = colorDialog.Color;
			}
		}

		private void FontColorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ColorDialog colorDialog = new ColorDialog();
			if(colorDialog.ShowDialog()== DialogResult.OK)
			{
				textBox.ForeColor = colorDialog.Color;
			}
		}

		private void FontToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FontDialog fontDialog = new FontDialog();
			if (fontDialog.ShowDialog() == DialogResult.OK)
			{
				textBox.Font = fontDialog.Font;
			}
		}
	}
}
