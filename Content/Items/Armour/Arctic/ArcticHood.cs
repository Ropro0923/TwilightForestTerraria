using TwilightForestTerraria.Common;
using TwilightForestTerraria.Content.Items.Materials.Crafting;

namespace TwilightForestTerraria.Content.Items.Armour.Arctic
{
	[AutoloadEquip(EquipType.Head)]
	public class ArcticHood : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 20;
			Item.height = 18;
			Item.rare = ItemRarityID.Green;
			Item.defense = 2;
			Item.value = ItemValue.SellPrices.ArcticFur * 20;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<ArcticFur>(20)
				.AddTile(TileID.Loom)
				.Register();
		}
	}
}
