using Terraria.Localization;
using Terraria.ObjectData;

namespace TwilightForestTerraria.Content.Tiles.PlacedBars
{
    public abstract class PlacedBar : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileShine[Type] = 1100;
            Main.tileSolid[Type] = true;
            Main.tileSolidTop[Type] = true;
            Main.tileFrameImportant[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.addTile(Type);
            VanillaFallbackOnModDeletion = TileID.MetalBars;
            AddMapEntry(new Color(224, 194, 101), Language.GetText("MapObject.MetalBar"));
        }

        public override bool TileFrame(int i, int j, ref bool resetFrame, ref bool noBreak)
        {
            if (!WorldGen.SolidTileAllowBottomSlope(i, j + 1))
            {
                WorldGen.KillTile(i, j);
            }
            return true;
        }
    }
    public class FieryBarPlaced : PlacedBar
    {
    }
    public class IronwoodBarPlaced : PlacedBar
    {
    }
    public class KnightmetalBarPlaced : PlacedBar
    {
    }
}