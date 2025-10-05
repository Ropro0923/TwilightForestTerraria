using TwilightForestTerraria.Common;
using TwilightForestTerraria.Content.Items.Materials.Crafting;

namespace TwilightForestTerraria.Content.Items.Armour.Knightly
{
	[AutoloadEquip(EquipType.Body)]
	public class KnightlyChestplate : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 28;
			Item.value = ItemValue.SellPrices.KnightmetalBar * 30;
			Item.rare = ItemRarityID.Lime;
			Item.defense = 24;
		}
		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Melee) += 0.08f;
			player.GetCritChance(DamageClass.Melee) += 0.10f;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<KnightmetalBar>(30)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}
