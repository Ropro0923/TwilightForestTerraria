using TwilightForestTerraria.Content.Items.Materials.Crafting;

namespace TwilightForestTerraria.Content.Items.Armour.Arctic
{
	[AutoloadEquip(EquipType.Legs)]
	public class ArcticLeggings : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 18;
			Item.height = 18;
			Item.rare = ItemRarityID.Green;
			Item.defense = 6;
			Item.value = Item.sellPrice(0, 0, 3, 20) * 25;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<ArcticFur>(25)
				.AddTile(TileID.Loom)
				.Register();
		}
	}
}
