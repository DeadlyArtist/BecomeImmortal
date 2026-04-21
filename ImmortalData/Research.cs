using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
	public class Research : IRegisterable
	{
		public string Id { get; set; }
		public string Name { get; set; }

		public Research[] RequiredNodes = default!;

		public Research(string id, string name)
		{
			Id = id;
			Name = name;
		}

		// Must be set in secondary step to avoid cyclic dependencies
		public void SetRequiredNodes(Research[] researches)
		{
			RequiredNodes = researches;
		}
	}
}
