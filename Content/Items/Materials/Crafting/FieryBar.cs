using TwilightForestTerraria.Common;
using TwilightForestTerraria.Content.Items.Materials.Boss;
using TwilightForestTerraria.Content.Tiles.PlacedBars;

namespace TwilightForestTerraria.Content.Items.Materials.Crafting
{
    public class FieryBar : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 24;
            Item.rare = ItemRarityID.Pink;
            Item.maxStack = Item.CommonMaxStack;
            Item.value = ItemValue.SellPrices.FieryBar;
            Item.DefaultToPlaceableTile(ModContent.TileType<FieryBarPlaced>());
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<FieryBlood>(), 3)
                .AddIngredient(ItemID.MythrilBar)
                .AddTile(TileID.MythrilAnvil)
                .Register();

            CreateRecipe()
                .AddIngredient(ModContent.ItemType<FieryBlood>(), 3)
                .AddIngredient(ItemID.OrichalcumBar)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
	}
}
