using TwilightForestTerraria.Common;
using TwilightForestTerraria.Content.Tiles.PlacedBars;

namespace TwilightForestTerraria.Content.Items.Materials.Crafting
{
    public class KnightmetalBar : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 24;
            Item.value = ItemValue.SellPrices.KnightmetalBar;
            Item.DefaultToPlaceableTile(ModContent.TileType<KnightmetalBarPlaced>());
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<ArmorShardCluster>(4)
                .AddTile(TileID.Furnaces)
                .Register();
        }
	}
}
