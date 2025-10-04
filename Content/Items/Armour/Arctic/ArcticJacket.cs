using TwilightForestTerraria.Content.Items.Materials.Boss;
using TwilightForestTerraria.Content.Items.Materials.Crafting;

namespace TwilightForestTerraria.Content.Items.Armour.Arctic
{
	[AutoloadEquip(EquipType.Body)]
	public class ArcticJacket : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 18;
			Item.height = 18;
			Item.defense = 6;
			Item.rare = ItemRarityID.Green;
			Item.value = Item.sellPrice(0, 0, 3, 20) * 30;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<ArcticFur>(30)
				.AddTile(TileID.Loom)
				.Register();
		}
	}
}
