using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
	public class ResearchData : IUnlockable, ICompletable
	{
		public bool Unlocked { get; set; }
		public double UnlockTime { get; set; }
		public bool Completed { get; set; }
		public double CompletionTime { get; set; }

		public Research Research { get; set; }

		public ResearchData(Research research)
		{
			Research = research;
		}
	}
}
