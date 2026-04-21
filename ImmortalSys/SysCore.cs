using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sys
{
	public class SysCore
	{
		public BaseCore Base => Data.Base;
		public DataCore Data => Laws.Data;
		public LawsCore Laws { get; } = new();

		public Time Time => Base.Time;

		public LocationSystem LocationSystem;

		public SysCore()
		{
			LocationSystem = new(this);
		}

		public static implicit operator BaseCore(SysCore core) => core.Base;
		public static implicit operator DataCore(SysCore core) => core.Data;
		public static implicit operator LawsCore(SysCore core) => core.Laws;
	}
}
