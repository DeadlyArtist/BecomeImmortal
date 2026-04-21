using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acts
{
	public class LocationActs(ActsCore core) : IAct
	{
		public ActsCore Core { get; } = core;

		public void Explore(Location location) => Core.Sys.LocationSystem.Explore(location);
	}
}
