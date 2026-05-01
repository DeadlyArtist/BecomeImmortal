using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
	public class LootEntry
	{
		public Item Item { get; set; }
		public double Weight { get; set; } = 1;
		public int MinCount { get; set; }
		public int MaxCount { get; set; }

		public LootEntry(Item item)
		{
			Item = item;
		}

		public static LootEntryBuilder Builder(Item item) => new LootEntryBuilder(item);
	}

	public class LootEntryBuilder
	{
		public LootEntry LootEntry { get; set; }

		public LootEntryBuilder(Item item)
		{
			LootEntry = new(item);
		}

		public LootEntryBuilder Weight(double weight)
		{
			LootEntry.Weight = weight;
			return this;
		}

		public LootEntryBuilder Count(int maxCount, int minCount = 1)
		{
			LootEntry.MinCount = minCount;
			LootEntry.MaxCount = maxCount;
			return this;
		}

		public LootEntry Build() => LootEntry;
	}
}
