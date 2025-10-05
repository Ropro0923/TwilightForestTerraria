using TwilightForestTerraria.Common;
using TwilightForestTerraria.Content.Items.Materials.Crafting;

namespace TwilightForestTerraria.Content.Items.Armour.Ironwood
{
	[AutoloadEquip(EquipType.Legs)]
	public class IronwoodBoots : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 18;
			Item.height = 18;
			Item.defense = 4;
			Item.value = ItemValue.SellPrices.IronwoodBar * 25;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<IronwoodBar>(25)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}
