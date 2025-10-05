using TwilightForestTerraria.Common;

namespace TwilightForestTerraria.Content.Items.Materials.Crafting
{
    public class ArmorShardCluster : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 28;
            Item.value = ItemValue.SellPrices.ArmorShardCluster;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<ArmorShard>(4)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
	}
}
