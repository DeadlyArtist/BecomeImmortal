using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
	public class AppCore
	{
		public ActsCore Acts { get; } = new();

		public AppCore()
		{

		}

		public static implicit operator ActsCore(AppCore core) => core.Acts;
	}
}
