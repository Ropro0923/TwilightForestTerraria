using Microsoft.Xna.Framework;
using Terraria.IO;
using Terraria.Localization;
using Terraria.WorldBuilding;

namespace TwilightForestTerraria.Content.Tiles
{
	public class Liveroots : ModTile
	{
		public override void SetStaticDefaults()
		{
			TileID.Sets.Ore[Type] = true;
			TileID.Sets.FriendlyFairyCanLureTo[Type] = true;
			Main.tileSpelunker[Type] = true;
			Main.tileOreFinderPriority[Type] = 220;
			Main.tileMergeDirt[Type] = true;
			Main.tileSolid[Type] = true;
			LocalizedText name = CreateMapEntryName();
			AddMapEntry(new Color(136, 146, 54), name);
			HitSound = SoundID.Dig;
		}
	}
	
	public class SpawnLiveroot : ModSystem
	{
		public static LocalizedText LiverootGeneratingMessage
		{
			get;
			set;
		}
		public override void SetStaticDefaults()
		{
			LiverootGeneratingMessage = Mod.GetLocalization("WorldGeneration.OreGeneration.LiverootGenerating");
		}
		/*
		public override void ModifyWorldGenTasks(List<GenPass> tasks, ref double totalWeight)
		{
			int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));

			if (ShiniesIndex != -1)
			{
				tasks.Insert(ShiniesIndex + 1, new GenerateLiveroot("SpawnLiveroot", 240f));
			}
		}
		*/
	}
	

	public class GenerateLiveroot : GenPass
	{
		public GenerateLiveroot(string name, float loadWeight) : base(name, loadWeight)
		{
		}

		protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
		{
			progress.Message = SpawnLiveroot.LiverootGeneratingMessage.Value;

			for (int k = 0; k < (int)(Main.maxTilesX * Main.maxTilesY * 6E-05); k++)
			{
				int x = WorldGen.genRand.Next(0, Main.maxTilesX);
				int y = WorldGen.genRand.Next((int)GenVars.worldSurfaceLow, Main.maxTilesY);
				WorldGen.TileRunner(x, y, WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(2, 6), ModContent.TileType<Liveroots>());
			}
		}
	}
}
