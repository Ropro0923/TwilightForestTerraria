using Terraria.Localization;
using TwilightForestTerraria.Common;
using TwilightForestTerraria.Content.Items.Materials.Crafting;

namespace TwilightForestTerraria.Content.Items.Armour.Fiery
{
	[AutoloadEquip(EquipType.Head)]
	public class FieryMaskRanged : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 20;
			Item.height = 18;
			Item.value = ItemValue.SellPrices.FieryBar * 20;
			Item.rare = ItemRarityID.Pink;
			Item.defense = 8;
		}
		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Ranged) += 0.20f;
			player.GetCritChance(DamageClass.Ranged) += 0.08f;
        }
		public override bool IsArmorSet(Item head, Item body, Item legs) => body.type == ModContent.ItemType<FieryChestplate>() && legs.type == ModContent.ItemType<FieryBoots>();
		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = Language.GetTextValue("Mods.TwilightForestTerraria.SetBonus.FieryRanged");
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<FieryBar>(20)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}
}
