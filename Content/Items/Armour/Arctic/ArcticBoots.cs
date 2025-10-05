using TwilightForestTerraria.Common;
using TwilightForestTerraria.Content.Items.Materials.Crafting;

namespace TwilightForestTerraria.Content.Items.Armour.Arctic
{
	[AutoloadEquip(EquipType.Legs)]
	public class ArcticBoots : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 18;
			Item.rare = ItemRarityID.Green;
			Item.defense = 2;
			Item.value = ItemValue.SellPrices.ArcticFur * 25;
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
