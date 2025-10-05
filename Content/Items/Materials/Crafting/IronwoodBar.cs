using TwilightForestTerraria.Common;
using TwilightForestTerraria.Content.Tiles.PlacedBars;

namespace TwilightForestTerraria.Content.Items.Materials.Crafting
{
    public class IronwoodBar : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 24;
            Item.maxStack = Item.CommonMaxStack;
            Item.value = ItemValue.SellPrices.IronwoodBar;
            Item.DefaultToPlaceableTile(ModContent.TileType<IronwoodBarPlaced>());
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<RawIronwoodMaterials>(), 3)
                .AddTile(TileID.Furnaces)
                .Register();
        }
	}
}
