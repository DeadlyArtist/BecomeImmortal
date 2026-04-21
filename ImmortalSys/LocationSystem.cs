using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sys
{
	public class LocationSystem(SysCore core) : ISys
	{
		public SysCore Core { get; } = core;

		public void Explore(Location location)
		{

		}

		public void Scavenge(Location location)
		{

		}
	}
}
