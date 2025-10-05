using TwilightForestTerraria.Common;
using TwilightForestTerraria.Content.Items.Materials.Crafting;

namespace TwilightForestTerraria.Content.Items.Armour.Arctic
{
	[AutoloadEquip(EquipType.Body)]
	public class ArcticJacket : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 34;
			Item.height = 32;
			Item.defense = 2;
			Item.rare = ItemRarityID.Green;
			Item.value = ItemValue.SellPrices.ArcticFur * 30;
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
