using TwilightForestTerraria.Content.Items.Materials.Boss;

namespace TwilightForestTerraria.Content.Items.Materials.Crafting
{
    public class FieryBar : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.rare = ItemRarityID.Pink;
            Item.maxStack = Item.CommonMaxStack;
			Item.value = Item.sellPrice(0, 1, 72, 22);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<FieryBlood>(), 3)
                .AddIngredient(ItemID.AdamantiteBar)
                .AddTile(TileID.AdamantiteForge)
                .Register();

            CreateRecipe()
                .AddIngredient(ModContent.ItemType<FieryBlood>(), 3)
                .AddIngredient(ItemID.TitaniumBar)
                .AddTile(TileID.AdamantiteForge)
                .Register();
        }
	}
}
