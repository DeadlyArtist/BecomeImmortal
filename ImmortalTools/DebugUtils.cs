using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Tools
{
	public static class DebugUtils
	{
		public static T qwe<T>(this T obj)
		{
			Debug.WriteLine(obj);
			return obj;
		}
	}
}
