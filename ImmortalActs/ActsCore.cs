namespace Acts
{
	public class ActsCore
	{
		public BaseCore Base => Data.Base;
		public DataCore Data => Laws.Data;
		public LawsCore Laws => Sys.Laws;
		public SysCore Sys { get; } = new();

		public Time Time => Base.Time;

		public ActsCore()
		{

		}

		public static implicit operator BaseCore(ActsCore core) => core.Base;
		public static implicit operator DataCore(ActsCore core) => core.Data;
		public static implicit operator LawsCore(ActsCore core) => core.Laws;
		public static implicit operator SysCore(ActsCore core) => core.Sys;
	}
}
