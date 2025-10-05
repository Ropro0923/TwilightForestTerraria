using TwilightForestTerraria.Common;
using TwilightForestTerraria.Content.Items.Materials.Boss;

namespace TwilightForestTerraria.Content.Items.Armour.Yeti
{
	[AutoloadEquip(EquipType.Body)]
	public class YetiJacket : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 36;
			Item.rare = ItemRarityID.Orange;
			Item.value = ItemValue.SellPrices.AlphaYetiFur * 30;
			Item.defense = 9;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<AlphaYetiFur>(30)
				.AddTile(TileID.Loom)
				.Register();
		}
	}
}
