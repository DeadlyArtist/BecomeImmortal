using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
	public class Location : IRegisterable
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public HashSet<ELocationAction> actions { get; set; } = new();

		public Location(string id, string name, List<ELocationAction> actions)
		{
			Id = id;
			Name = name;
			foreach (ELocationAction action in actions) actions.Add(action);
		}
	}
}
