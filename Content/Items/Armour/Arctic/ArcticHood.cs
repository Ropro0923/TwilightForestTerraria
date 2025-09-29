using TwilightForestTerraria.Content.Items.Materials;

namespace TwilightForestTerraria.Content.Items.Armour.Arctic
{
	[AutoloadEquip(EquipType.Head)]
	public class ArcticHood : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 18;
			Item.height = 18;
			Item.rare = ItemRarityID.Blue;
		}
		public override bool IsArmorSet(Item head, Item body, Item legs) => body.type == ModContent.ItemType<ArcticJacket>() && legs.type == ModContent.ItemType<ArcticLeggings>();
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<ArcticFur>(12)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}
