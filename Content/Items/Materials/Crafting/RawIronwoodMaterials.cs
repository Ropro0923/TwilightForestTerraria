using TwilightForestTerraria.Common;

namespace TwilightForestTerraria.Content.Items.Materials.Crafting
{
    public class RawIronwoodMaterials : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 28;
            Item.value = ItemValue.SellPrices.RawIronwoodMaterials;
        }
        public override void AddRecipes()
        {
            CreateRecipe(3)
                .AddIngredient(ModContent.ItemType<Liveroot>(), 3)
                .AddIngredient(ItemID.IronBar, 3)
                .AddIngredient(ItemID.GoldBar, 1)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
	}
}
