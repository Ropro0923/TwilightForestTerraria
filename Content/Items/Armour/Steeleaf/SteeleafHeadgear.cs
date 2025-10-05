using Terraria.Localization;
using TwilightForestTerraria.Common;

namespace TwilightForestTerraria.Content.Items.Armour.Steeleaf
{
	[AutoloadEquip(EquipType.Head)]
	public class SteeleafHeadgear : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 20;
			Item.height = 20;
			Item.value = ItemValue.SellPrices.Steeleaf * 12;
			Item.rare = ItemRarityID.Pink;
			Item.defense = 3;
		}
		public override bool IsArmorSet(Item head, Item body, Item legs) => body.type == ModContent.ItemType<SteeleafChestplate>() && legs.type == ModContent.ItemType<SteeleafBoots>();
		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = Language.GetTextValue("Mods.TwilightForestTerraria.SetBonus.SteeleafMagic");
			player.GetDamage(DamageClass.Magic) += 0.04f;
			player.GetCritChance(DamageClass.Magic) += 0.04f;
			player.manaCost -= 0.15f;
		}
		public override void UpdateEquip(Player player)
		{
			player.statManaMax2 += 110;
			player.GetDamage(DamageClass.Magic) += 0.18f;
			player.GetCritChance(DamageClass.Magic) += 0.9f;
        }
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<Materials.Crafting.Steeleaf>(12)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}
}
