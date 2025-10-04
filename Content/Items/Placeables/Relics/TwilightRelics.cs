
namespace TwilightForestTerraria.Content.Items.Placeables.Relics
{
    public abstract class TwilightRelic : ModItem
    {
        public abstract string Relic { get; }
        public override void SetDefaults()
        {
            if (ModContent.TryFind<ModTile>(Mod.Name, $"{Relic}RelicTile", out var tile))
            {
                Item.DefaultToPlaceableTile(tile.Type);
            }
            Item.width = 30;
            Item.height = 40;
            Item.rare = ItemRarityID.Master;
            Item.master = true;
        }
        public override string Texture => $"TwilightForestTerraria/Content/Items/Placeables/Relics/{Relic}Relic" + (TwilightForestTerrariaConfig.Instance.ColoredRelics ? "_Colored" : "");
    }
    public class NagaRelic : TwilightRelic
    {
        public override string Relic => "Naga";
    }
    public class HydraRelic : TwilightRelic
    {
        public override string Relic => "Hydra";
    }
    public class MinoshroomRelic : TwilightRelic
    {
        public override string Relic => "Minoshroom";
    }
    public class NightPhantomRelic : TwilightRelic
    {
        public override string Relic => "NightPhantom";
    }
    public class QuestingRamRelic : TwilightRelic
    {
        public override string Relic => "QuestingRam";
    }
    public class SnowQueenRelic : TwilightRelic
    {
        public override string Relic => "SnowQueen";
    }
    public class TwilightLichRelic : TwilightRelic
    {
        public override string Relic => "TwilightLich";
    }
    public class UrGhastRelic : TwilightRelic
    {
        public override string Relic => "UrGhast";
    }
}