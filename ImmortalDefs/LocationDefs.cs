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
		public static Location RuinedCity { get; } = Define(nameof(RuinedCity));
		public static Location Sewers { get; } = Define(nameof(Sewers));
		public static Location Laboratory { get; } = Define(nameof(Laboratory));
		public static Location Outskirts { get; } = Define(nameof(Outskirts));
		public static Location Forest { get; } = Define(nameof(Forest));
		public static Location Mountains { get; } = Define(nameof(Mountains));

		public static void Setup()
		{
			RuinedCity.AddAction(new LocationActionData(Explore, new LootTable([])));
			RuinedCity.AddAction(new LocationActionData(Scavenge, new LootTable([])));

			Sewers.AddAction(new LocationActionData(Explore, new LootTable([])));
			Sewers.AddAction(new LocationActionData(Hunt, new LootTable([])));

			Laboratory.AddAction(new LocationActionData(Explore, new LootTable([])));

			Outskirts.AddAction(new LocationActionData(Explore, new LootTable([])));
			Outskirts.AddAction(new LocationActionData(Scavenge, new LootTable([])));
			Outskirts.AddAction(new LocationActionData(Forage, new LootTable([])));
			Outskirts.AddAction(new LocationActionData(Hunt, new LootTable([])));

			Forest.AddAction(new LocationActionData(Explore, new LootTable([])));
			Forest.AddAction(new LocationActionData(Forage, new LootTable([])));
			Forest.AddAction(new LocationActionData(Hunt, new LootTable([])));

			Mountains.AddAction(new LocationActionData(Explore, new LootTable([])));
			Mountains.AddAction(new LocationActionData(Forage, new LootTable([])));
			Mountains.AddAction(new LocationActionData(Hunt, new LootTable([])));
		}

		public static Location Define(string id)
		{
			var item = new Location(id, id.ToTextCase());
			All.Add(item);
			return item;
		}
	}
}
