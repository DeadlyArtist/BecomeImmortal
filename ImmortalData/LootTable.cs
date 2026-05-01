using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
	public class LootTable(List<LootEntry> entries)
	{
		public List<LootEntry> Entries { get; set; } = entries;
	}
}
