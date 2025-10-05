using TwilightForestTerraria.Common;
using TwilightForestTerraria.Content.Items.Materials.Crafting;

namespace TwilightForestTerraria.Content.Items.Armour.Fiery
{
	[AutoloadEquip(EquipType.Body)]
	public class FieryChestplate : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 26;
			Item.rare = ItemRarityID.Pink;
			Item.defense = 19;
			Item.value = ItemValue.SellPrices.FieryBar * 30;
		}
        public override void UpdateEquip(Player player)
        {
            player.GetDamage(DamageClass.Generic) += 0.12f;
            player.GetCritChance(DamageClass.Generic) += 0.06f;
        }
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<FieryBar>(30)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}
}
