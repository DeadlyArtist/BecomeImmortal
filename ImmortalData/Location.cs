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
		public Dictionary<ELocationAction, LocationActionData> Actions { get; set; } = new();

		public Location(string id, string name)
		{
			Id = id;
			Name = name;
		}

		public void AddAction(LocationActionData action)
		{
			Actions.Add(action.ActionType, action);
		}

		public void AddActions(List<LocationActionData> actions)
		{
			foreach (var action in actions) AddAction(action);
		}
	}
}
