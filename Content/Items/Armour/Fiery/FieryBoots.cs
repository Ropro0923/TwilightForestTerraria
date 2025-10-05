using TwilightForestTerraria.Common;
using TwilightForestTerraria.Content.Items.Materials.Crafting;

namespace TwilightForestTerraria.Content.Items.Armour.Fiery
{
	[AutoloadEquip(EquipType.Legs)]
	public class FieryBoots : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 18;
			Item.value = ItemValue.SellPrices.FieryBar * 25;
			Item.rare = ItemRarityID.Pink;
			Item.defense = 10;
		}
		public override void UpdateEquip(Player player)
		{
			player.GetCritChance(DamageClass.Generic) += 0.10f;
			player.moveSpeed += 0.10f;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<FieryBar>(25)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}
}
