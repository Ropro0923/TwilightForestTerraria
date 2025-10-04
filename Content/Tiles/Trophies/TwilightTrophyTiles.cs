using Terraria.Localization;
using Terraria.ObjectData;

namespace TwilightForestTerraria.Content.Tiles.Trophies
{
    public class TwilightTrophyTile : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileID.Sets.FramesOnKillWall[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3Wall);
            TileObjectData.addTile(Type);
            AddMapEntry(new Color(120, 85, 60), Language.GetText("MapObject.Trophy"));
            DustType = DustID.WoodFurniture;
        }
    }
    public class HydraTrophyTile : TwilightTrophyTile
    {
    }
    public class MinoshroomTrophyTile : TwilightTrophyTile
    {
    }
    public class NagaTrophyTile : TwilightTrophyTile
    {
    }
    public class NightPhantomTrophyTile : TwilightTrophyTile
    {
    }
    public class QuestingRamTrophyTile : TwilightTrophyTile
    {
    }
    public class SnowQueenTrophyTile : TwilightTrophyTile
    {
    }
    public class TwilightLichTrophyTile : TwilightTrophyTile
    {
    }
    public class UrGhastTrophyTile : TwilightTrophyTile
    {
    }
}
