using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileExplorer
{
	class DirectoryEx
	{
		public DirectoryInfo Dir { get; set; }
		public DriveInfo Drive { get; set; }
		public int Level { get; set; }
		public override string ToString()
		{
			if (Drive != null)
			{
				return Drive.Name;
			}
			else
			{
				return new string(' ', Level * 4) + Dir.Name;
			}
		}
	}
}
