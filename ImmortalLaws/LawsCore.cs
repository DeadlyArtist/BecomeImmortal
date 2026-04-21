using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laws
{
	public class LawsCore
	{
		public BaseCore Base => Data.Base;
		public DataCore Data { get; } = new();

		public Time Time => Base.Time;

		public LawsCore()
		{

		}

		public static implicit operator BaseCore(LawsCore core) => core.Base;
		public static implicit operator DataCore(LawsCore core) => core.Data;
	}
}
