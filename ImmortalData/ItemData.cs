using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
	public class ItemData
	{
		public Item Item { get; set; }
		public int Amount { get; set; }
		public double LastUsed { get; set; }

		public ItemData(Item item, int amount, double lastUsed)
		{
			Item = item;
			Amount = amount;
			LastUsed = lastUsed;
		}
	}
}
