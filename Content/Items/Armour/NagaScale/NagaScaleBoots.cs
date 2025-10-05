using TwilightForestTerraria.Common;
using TwilightForestTerraria.Content.Items.Materials.Boss;

namespace TwilightForestTerraria.Content.Items.Armour.NagaScale
{
	[AutoloadEquip(EquipType.Legs)]
	public class NagaScaleBoots : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 18;
			Item.height = 18;
			Item.value = ItemValue.SellPrices.NagaScales * 20;
			Item.rare = ItemRarityID.Blue;
			Item.defense = 6;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<NagaScales>(25)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}
