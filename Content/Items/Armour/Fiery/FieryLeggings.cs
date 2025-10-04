using TwilightForestTerraria.Content.Items.Materials.Crafting;

namespace TwilightForestTerraria.Content.Items.Armour.Fiery
{
	[AutoloadEquip(EquipType.Legs)]
	public class FieryLeggings : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 18;
			Item.height = 18;
			Item.value = Item.sellPrice(0, 1, 72, 22) * 25;
			Item.rare = ItemRarityID.Pink;
			Item.defense = 12;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<FieryBar>(25)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}
}
