namespace TwilightForestTerraria.Content.Items.Placeables.Trophies
{
    public abstract class TwilightTrophy : ModItem
    {
        public abstract string Trophy { get; }
        public override void SetDefaults()
        {
            Item.DefaultToPlaceableTile(Mod.TryFind($"{Trophy}TrophyTile", out ModTile Tile) ? Tile.Type : 0, 0);
            Item.width = 32;
            Item.height = 32;
            Item.value = ContentSamples.ItemsByType[ItemID.EaterofWorldsTrophy].value;
            Item.rare = ItemRarityID.Blue;
        }
    }
    public class HydraTrophy : TwilightTrophy
    {
        public override string Trophy => "Hydra";
    }
    public class MinoshroomTrophy : TwilightTrophy
    {
        public override string Trophy => "Minoshroom";
    }
    public class NagaTrophy : TwilightTrophy
    {
        public override string Trophy => "Naga";
    }
    public class NightPhantomTrophy : TwilightTrophy
    {
        public override string Trophy => "NightPhantom";
    }
    public class QuestingRamTrophy : TwilightTrophy
    {
        public override string Trophy => "QuestingRam";
    }
    public class SnowQueenTrophy : TwilightTrophy
    {
        public override string Trophy => "SnowQueenTrophy";
    }
    public class TwilightLichTrophy : TwilightTrophy
    {
        public override string Trophy => "TwilightLich";
    }
    public class UrGhastTrophy : TwilightTrophy
    {
        public override string Trophy => "UrGhast";
    }
}