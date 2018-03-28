using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructMenu
{
	public partial class ConstructMenuForm : Form
	{
		ToolStripMenuItem last = null;
		Color colorMenu = SystemColors.Control;
		Color colorChoose = SystemColors.ActiveCaption;
		public ConstructMenuForm()
		{
			InitializeComponent();

			tbTopItem.TextChanged += TbTopItem_TextChanged;
			tbSubItem.TextChanged += TbSubItem_TextChanged;

			btnTopItem.Click += BtnTopItem_Click;

			btnSumItem.Click += BtnSumItem_Click;	
		}

		private void BtnSumItem_Click(object sender, EventArgs e)
		{
			last.DropDownItems.Add(tbSubItem.Text);
		}

		private void BtnTopItem_Click(object sender, EventArgs e)
		{			
			ToolStripMenuItem item = menuStrip1.Items.Add(tbTopItem.Text) as ToolStripMenuItem;
			item.Click += Item_Click;
			if (last != null)
			{
				last.BackColor = colorMenu;
			}
			last = item;
			last.BackColor = colorChoose; 
		}

		private void Item_Click(object sender, EventArgs e)
		{
			last.BackColor = colorMenu;
			last = sender as ToolStripMenuItem;
			last.BackColor = colorChoose;
		}

		private void TbSubItem_TextChanged(object sender, EventArgs e)
		{
			if (tbSubItem.Text.Length > 0)
			{
				btnSumItem.Enabled = true;
			}
			else
			{
				btnSumItem.Enabled = false;
			}
		}

		private void TbTopItem_TextChanged(object sender, EventArgs e)
		{
			if(tbTopItem.Text.Length > 0)
			{
				btnTopItem.Enabled = true;
			}
			else
			{
				btnTopItem.Enabled = false;
			}
		}
	}
}
