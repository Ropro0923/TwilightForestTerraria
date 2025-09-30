using TwilightForestTerraria.Content.Tiles.Trophies;

namespace TwilightForestTerraria.Content.Items.Placeables.Trophies
{
    public class NagaTrophy : ModItem
    {
        public override void SetDefaults()
        {
            Item.DefaultToPlaceableTile(ModContent.TileType<NagaTrophyTile>(), 0);
            Item.width = 32;
            Item.height = 32;
            Item.value = ContentSamples.ItemsByType[ItemID.EaterofWorldsTrophy].value;
            Item.rare = ItemRarityID.Blue;
        }
    }
}
