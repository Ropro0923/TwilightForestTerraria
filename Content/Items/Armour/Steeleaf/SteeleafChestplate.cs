using TwilightForestTerraria.Common;

namespace TwilightForestTerraria.Content.Items.Armour.Steeleaf
{
	[AutoloadEquip(EquipType.Body)]
	public class SteeleafChestplate : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 20;
			Item.rare = ItemRarityID.Pink;
			Item.defense = 8;
			Item.value = ItemValue.SellPrices.Steeleaf * 30;
		}
		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Generic) += 0.08f;
			player.GetCritChance(DamageClass.Generic) += 0.05f;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<Materials.Crafting.Steeleaf>(30)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}
}
