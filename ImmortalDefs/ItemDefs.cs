using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defs
{
	public static class ItemDefs
	{
		public static List<Item> All = new();

		// <ItemGen:Start>

		// Workstations
		public static Item Computer { get; } = Define(nameof(Computer));
		public static Item TinkeringStation { get; } = Define(nameof(TinkeringStation));
		public static Item AlchemicalPot { get; } = Define(nameof(AlchemicalPot));
		public static Item Forge { get; } = Define(nameof(Forge));
		public static Item RitualAltar { get; } = Define(nameof(RitualAltar));
		
		// Tech
		public static Item Scrap { get; } = Define(nameof(Scrap));
		public static Item RustyGear { get; } = Define(nameof(RustyGear));
		public static Item ControlCircuit { get; } = Define(nameof(ControlCircuit));
		public static Item DataChip { get; } = Define(nameof(DataChip));
		public static Item Battery { get; } = Define(nameof(Battery));
		public static Item Plastic { get; } = Define(nameof(Plastic));
		public static Item CarbonFiber { get; } = Define(nameof(CarbonFiber));
		public static Item Cables { get; } = Define(nameof(Cables));
		public static Item Nanite { get; } = Define(nameof(Nanite));
		public static Item Servo { get; } = Define(nameof(Servo));
		public static Item Magnet { get; } = Define(nameof(Magnet));
		public static Item Gyroscope { get; } = Define(nameof(Gyroscope));
		public static Item Antenna { get; } = Define(nameof(Antenna));
		public static Item Cooler { get; } = Define(nameof(Cooler));
		public static Item Insulator { get; } = Define(nameof(Insulator));
		public static Item Glass { get; } = Define(nameof(Glass));
		public static Item Compass { get; } = Define(nameof(Compass));
		public static Item Vial { get; } = Define(nameof(Vial));
		public static Item DroneCarapace { get; } = Define(nameof(DroneCarapace));
		public static Item Drone { get; } = Define(nameof(Drone));
		public static Item Camera { get; } = Define(nameof(Camera));
		public static Item MotionSensor { get; } = Define(nameof(MotionSensor));
		public static Item VacuumContainer { get; } = Define(nameof(VacuumContainer));
		public static Item CPU { get; } = Define(nameof(CPU));
		public static Item GPU { get; } = Define(nameof(GPU));
		public static Item QPU { get; } = Define(nameof(QPU));
		public static Item Monitor { get; } = Define(nameof(Monitor));
		public static Item ComputerMouse { get; } = Define(nameof(ComputerMouse));
		public static Item Keyboard { get; } = Define(nameof(Keyboard));
		public static Item Controller { get; } = Define(nameof(Controller));
		public static Item FingerprintScanner { get; } = Define(nameof(FingerprintScanner));
		public static Item FacialScanner { get; } = Define(nameof(FacialScanner));
		public static Item DNAScanner { get; } = Define(nameof(DNAScanner));
		
		// Flora
		public static Item DustpetalFlower { get; } = Define(nameof(DustpetalFlower));
		public static Item IronleafHerb { get; } = Define(nameof(IronleafHerb));
		public static Item GreycapMushroom { get; } = Define(nameof(GreycapMushroom));
		public static Item SpiritBloom { get; } = Define(nameof(SpiritBloom));
		public static Item BlueheartVine { get; } = Define(nameof(BlueheartVine));
		public static Item BloodthornRoot { get; } = Define(nameof(BloodthornRoot));
		public static Item CinderGrass { get; } = Define(nameof(CinderGrass));
		public static Item AshcapFungus { get; } = Define(nameof(AshcapFungus));
		public static Item ElbwoodBark { get; } = Define(nameof(ElbwoodBark));
		public static Item Nightwood { get; } = Define(nameof(Nightwood));
		public static Item NightglowFlower { get; } = Define(nameof(NightglowFlower));
		public static Item EtherLotus { get; } = Define(nameof(EtherLotus));
		public static Item ZapZapResin { get; } = Define(nameof(ZapZapResin));
		public static Item YellResin { get; } = Define(nameof(YellResin));
		public static Item NorthwindFlower { get; } = Define(nameof(NorthwindFlower));
		public static Item BluemenFungus { get; } = Define(nameof(BluemenFungus));
		public static Item GreenMucusFlower { get; } = Define(nameof(GreenMucusFlower));
		public static Item PurpleWitchHerb { get; } = Define(nameof(PurpleWitchHerb));
		public static Item SewerMoss { get; } = Define(nameof(SewerMoss));
		public static Item SnowLotus { get; } = Define(nameof(SnowLotus));
		public static Item PurpleMoss { get; } = Define(nameof(PurpleMoss));
		
		// Fauna
		public static Item MutatedRatPelt { get; } = Define(nameof(MutatedRatPelt));
		public static Item MutatedRatTooth { get; } = Define(nameof(MutatedRatTooth));
		public static Item YuckBeetle { get; } = Define(nameof(YuckBeetle));
		public static Item GlowfangBeetle { get; } = Define(nameof(GlowfangBeetle));
		public static Item StarwingButterfly { get; } = Define(nameof(StarwingButterfly));
		public static Item StonewallCicada { get; } = Define(nameof(StonewallCicada));
		public static Item WhiteMantis { get; } = Define(nameof(WhiteMantis));
		public static Item GravelSnakePoison { get; } = Define(nameof(GravelSnakePoison));
		public static Item KillerMoth { get; } = Define(nameof(KillerMoth));
		public static Item DragonHeadSalamander { get; } = Define(nameof(DragonHeadSalamander));
		public static Item CrimsonSnakeScale { get; } = Define(nameof(CrimsonSnakeScale));
		public static Item MoonTailSnakeVenom { get; } = Define(nameof(MoonTailSnakeVenom));
		public static Item GreenCrossSpider { get; } = Define(nameof(GreenCrossSpider));
		public static Item BlackNunSpiderFangs { get; } = Define(nameof(BlackNunSpiderFangs));
		public static Item BrownSnakeGland { get; } = Define(nameof(BrownSnakeGland));
		public static Item CrazyBearEye { get; } = Define(nameof(CrazyBearEye));
		public static Item LongclawLionClaw { get; } = Define(nameof(LongclawLionClaw));
		public static Item NightTigerEye { get; } = Define(nameof(NightTigerEye));
		public static Item NightTigerPelt { get; } = Define(nameof(NightTigerPelt));
		public static Item SteelBearScale { get; } = Define(nameof(SteelBearScale));

		// <ItemGen:End>

		public static Item Define(string id)
		{
			var item = new Item(id, id.ToTextCase());
			All.Add(item);
			return item;
		}
	}
}
