using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
	// Item definition for registry
	public class Item : IRegisterable
	{
		public string Id { get; set; }
		public string Name { get; set; }

		public Item(string id, string name)
		{
			Id = id;
			Name = name;
		}
	}
}
