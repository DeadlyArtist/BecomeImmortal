using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
	public class LocationActionData(ELocationAction actionType, LootTable lootTable)
	{
		public ELocationAction ActionType { get; set; } = actionType;
		public LootTable LootTable { get; set; } = lootTable;
	}
}
