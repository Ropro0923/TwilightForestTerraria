using TwilightForestTerraria.Common;
using TwilightForestTerraria.Content.Items.Materials.Boss;

namespace TwilightForestTerraria.Content.Items.Armour.Yeti
{
	[AutoloadEquip(EquipType.Legs)]
	public class YetiBoots : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 18;
			Item.rare = ItemRarityID.Orange;
			Item.value = ItemValue.SellPrices.AlphaYetiFur * 25;
			Item.defense = 7;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<AlphaYetiFur>(25)
				.AddTile(TileID.Loom)
				.Register();
		}
	}
}
