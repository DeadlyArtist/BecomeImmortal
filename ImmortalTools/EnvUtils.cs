using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
	public static class EnvUtils
	{
		public static string ApplicationPath = AppDomain.CurrentDomain.BaseDirectory;

		/// <summary>
		/// Climbs up from the current assembly location until it finds
		/// a directory containing a *.sln file whose name matches the solution.
		/// </summary>
		public static string GetSolutionDir()
		{
			var dir = new DirectoryInfo(
				Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)!);

			while (dir != null)
			{
				var sln = dir.GetFiles("*.sln").FirstOrDefault();
				if (sln != null)
				{
					// Found the solution root.
					return dir.FullName;
				}
				dir = dir.Parent;
			}

			throw new DirectoryNotFoundException("Could not locate solution directory (.sln not found).");
		}
	}
}
