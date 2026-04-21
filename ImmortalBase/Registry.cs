using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
	public class Registry<T> where T : class, IRegisterable
	{
		public OrderedDictionary<string, T> Entries { get; set; } = new();

		public void Register(T entry)
		{
			Entries.Add(entry.Id, entry);
		}

		public void Unregister(T entry)
		{
			Entries.Remove(entry.Id);
		}
	}
}
