using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
	public class DataCore
	{
		public BaseCore Base { get; } = new();

		public Time Time => Base.Time;

		public Registry<Item> Items { get; } = new();
		public Registry<Location> Locations { get; } = new();
		public Registry<Research> Researches { get; } = new();

		public static implicit operator BaseCore(DataCore core) => core.Base;
	}
}
