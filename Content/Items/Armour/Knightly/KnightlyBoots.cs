using TwilightForestTerraria.Common;
using TwilightForestTerraria.Content.Items.Materials.Crafting;

namespace TwilightForestTerraria.Content.Items.Armour.Knightly
{
	[AutoloadEquip(EquipType.Legs)]
	public class KnightlyBoots : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 18;
			Item.value = ItemValue.SellPrices.KnightmetalBar * 25;
			Item.rare = ItemRarityID.Lime;
			Item.defense = 15;
		}
		public override void UpdateEquip(Player player)
		{
			player.GetCritChance(DamageClass.Melee) += 0.10f;
			player.moveSpeed += 0.10f;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<KnightmetalBar>(25)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}
