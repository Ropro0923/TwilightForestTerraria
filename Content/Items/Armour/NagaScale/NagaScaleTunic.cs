using TwilightForestTerraria.Content.Items.Materials.Boss;

namespace TwilightForestTerraria.Content.Items.Armour.NagaScale
{
	[AutoloadEquip(EquipType.Body)]
	public class NagaScaleTunic : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 18;
			Item.height = 18;
			Item.rare = ItemRarityID.Blue;
			Item.defense = 8;
			Item.value = Item.sellPrice(0, 0, 30, 0);
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
