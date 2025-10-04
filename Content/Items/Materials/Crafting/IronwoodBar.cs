    namespace TwilightForestTerraria.Content.Items.Materials.Crafting
{
    public class IronwoodBar : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = Item.CommonMaxStack;
            Item.value = (Item.sellPrice(copper: 78) * 3 + ContentSamples.ItemsByType[ItemID.IronBar].value * 5 + ContentSamples.ItemsByType[ItemID.GoldBar].value) / 5 * 3;
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
