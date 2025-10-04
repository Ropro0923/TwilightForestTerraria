namespace TwilightForestTerraria.Content.Items.Materials.Crafting
{
    public class RawIronwoodMaterials : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.value = (Item.sellPrice(copper: 78) * 3 + ContentSamples.ItemsByType[ItemID.IronBar].value * 5 + ContentSamples.ItemsByType[ItemID.GoldBar].value) / 5;
        }
        public override void AddRecipes()
        {
            CreateRecipe(5)
                .AddIngredient(ModContent.ItemType<Liveroot>(), 3)
                .AddIngredient(ItemID.IronBar, 5)
                .AddIngredient(ItemID.GoldBar, 1)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
	}
}
