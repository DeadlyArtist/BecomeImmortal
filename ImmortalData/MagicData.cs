using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
	public class MagicData : IUnlockable
	{
		public bool Unlocked { get; set; }
		public double UnlockTime { get; set; }
		public RankData Rank { get; set; } = new();
	}
}
