using TwilightForestTerraria.Content.Items.Materials.Crafting;

namespace TwilightForestTerraria.Content.Items.Armour.Fiery
{
	[AutoloadEquip(EquipType.Body)]
	public class FieryChestplate : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 18;
			Item.height = 18;
			Item.rare = ItemRarityID.Pink;
			Item.defense = 12;
			Item.value = Item.sellPrice(0, 1, 72, 22) * 30;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<FieryBar>(30)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}
}
