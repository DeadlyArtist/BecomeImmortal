using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defs
{
	public static class ResearchDefs
	{
		public static List<Research> All = new();
		public static Research Scrap { get; } = Define(nameof(Scrap));

		public static Research Define(string id)
		{
			var item = new Research(id, id.ToTextCase());
			All.Add(item);
			return item;
		}

		public static void Setup()
		{

		}
	}
}
