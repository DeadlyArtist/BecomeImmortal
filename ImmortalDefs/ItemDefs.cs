using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defs
{
	public static class ItemDefs
	{
		public static List<Item> All = new();
		public static Item Scrap { get; } = Define(nameof(Scrap));

		public static Item Define(string id)
		{
			var item = new Item(id, id.ToTextCase());
			All.Add(item);
			return item;
		}
	}
}
