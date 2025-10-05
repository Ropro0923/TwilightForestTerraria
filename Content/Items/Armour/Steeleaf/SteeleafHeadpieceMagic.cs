using Terraria.Localization;
using TwilightForestTerraria.Common;

namespace TwilightForestTerraria.Content.Items.Armour.Steeleaf
{
	[AutoloadEquip(EquipType.Head)]
	public class SteeleafHeadpieceMagic : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 20;
			Item.height = 20;
			Item.value = ItemValue.SellPrices.Steeleaf * 12;
			Item.rare = ItemRarityID.Pink;
			Item.defense = 8;
		}
		public override bool IsArmorSet(Item head, Item body, Item legs) => body.type == ModContent.ItemType<SteeleafChestplate>() && legs.type == ModContent.ItemType<SteeleafBoots>();
		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = Language.GetTextValue("Mods.TwilightForestTerraria.SetBonus.SteeleafMagic");
		}
		public override void UpdateEquip(Player player)
		{
			player.statMana += 60;
			player.GetDamage(DamageClass.Magic) += 0.20f;
			player.manaCost -= 0.15f;
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
