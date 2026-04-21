using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laws
{
	public class PlayerManager : ILaw
	{
		public LawsCore Core {  get; }

		public PlayerData PlayerData { get; set; }

		public double Age => PlayerData.GetAge();
	}
}
