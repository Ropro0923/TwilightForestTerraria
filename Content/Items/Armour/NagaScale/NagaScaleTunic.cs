using TwilightForestTerraria.Common;
using TwilightForestTerraria.Content.Items.Materials.Boss;

namespace TwilightForestTerraria.Content.Items.Armour.NagaScale
{
	[AutoloadEquip(EquipType.Body)]
	public class NagaScaleTunic : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 26;
			Item.rare = ItemRarityID.Blue;
			Item.defense = 8;
			Item.value = ItemValue.SellPrices.NagaScales * 30;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<NagaScales>(30)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}
