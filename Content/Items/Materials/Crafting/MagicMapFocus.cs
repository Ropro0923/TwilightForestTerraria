using TwilightForestTerraria.Content.Items.Materials.NPCs;

namespace TwilightForestTerraria.Content.Items.Materials.Crafting
{
    public class MagicMapFocus : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 28;
            Item.rare = ItemRarityID.Blue;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<RavenFeather>(), 1)
                .AddIngredient(ModContent.ItemType<Torchberries>(), 5)
                .AddIngredient(ItemID.FallenStar, 5)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
	}
}
