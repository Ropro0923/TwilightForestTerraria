using TwilightForestTerraria.Content.Items.Materials;

namespace TwilightForestTerraria.Content.Items.Armour.Fiery
{
	[AutoloadEquip(EquipType.Body)]
	public class FieryChestplate : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 18;
			Item.height = 18;
			Item.rare = ItemRarityID.Red;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<FierySteel>(20)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}
