using TwilightForestTerraria.Common;

namespace TwilightForestTerraria.Content.Items.Armour.Steeleaf
{
	[AutoloadEquip(EquipType.Legs)]
	public class SteeleafBoots : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 18;
			Item.value = ItemValue.SellPrices.Steeleaf * 25;
			Item.rare = ItemRarityID.Pink;
			Item.defense = 12;
		}
		public override void UpdateEquip(Player player)
		{
			player.GetCritChance(DamageClass.Generic) += 0.08f;
			player.moveSpeed += 0.15f;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<Materials.Crafting.Steeleaf>(25)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}
}
