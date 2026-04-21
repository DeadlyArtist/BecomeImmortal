using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.ELocationAction;

namespace Defs
{
	public static class LocationDefs
	{
		public static List<Location> All = new();
		public static Location RuinedCity { get; } = Define(nameof(RuinedCity), [Explore, Scavenge]);
		public static Location Sewers { get; } = Define(nameof(Sewers), [Explore, Hunt]);
		public static Location Laboratory { get; } = Define(nameof(Laboratory), [Scavenge]);
		public static Location Outskirts { get; } = Define(nameof(Outskirts), [Explore, Scavenge, Forage, Hunt]);
		public static Location Forest { get; } = Define(nameof(Forest), [Explore, Forage, Hunt]);
		public static Location Mountains { get; } = Define(nameof(Mountains), [Explore, Forage, Hunt]);

		public static Location Define(string id, List<ELocationAction> actions)
		{
			var item = new Location(id, id.ToTextCase(), actions);
			All.Add(item);
			return item;
		}
	}
}
