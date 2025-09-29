using TwilightForestTerraria.Content.Items.Materials;

namespace TwilightForestTerraria.Content.Items.Armour.Arctic
{
	[AutoloadEquip(EquipType.Legs)]
	public class ArcticLeggings : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 18;
			Item.height = 18;
			Item.rare = ItemRarityID.Blue;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<ArcticFur>(16)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}
