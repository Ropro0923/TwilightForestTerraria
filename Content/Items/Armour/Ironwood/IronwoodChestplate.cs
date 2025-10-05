using TwilightForestTerraria.Common;
using TwilightForestTerraria.Content.Items.Materials.Crafting;

namespace TwilightForestTerraria.Content.Items.Armour.Ironwood
{
	[AutoloadEquip(EquipType.Body)]
	public class IronwoodChestplate : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 26;
			Item.defense = 5;
			Item.value = ItemValue.SellPrices.IronwoodBar * 30;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<IronwoodBar>(30)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}
