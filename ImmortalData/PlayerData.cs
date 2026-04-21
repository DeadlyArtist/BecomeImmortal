using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
	public class PlayerData
	{
		public string Name { get; set; } = "Unnamed";
		public double StartTime { get; set; }
		public int Health { get; set; } = 100;
		public float Radiation { get; set; }

		public HashSet<Location> Locations { get; set; } = new();
		public HashSet<ItemData> Items { get; set; } = new();
		public HashSet<ResearchData> Researches { get; set; } = new();

		public TechData Tech { get; set; } = new();
		public CultivationData Cultivation { get; set; } = new();
		public MagicData Magic { get; set; } = new();
		public PsyData Psy { get; set; } = new();

		public double GetAge(DataCore core) => core.Time.Now - StartTime;
	}
}
