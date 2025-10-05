using Terraria.Localization;
using TwilightForestTerraria.Common;

namespace TwilightForestTerraria.Content.Items.Armour.Steeleaf
{
	[AutoloadEquip(EquipType.Head)]
	public class SteeleafHatSummon : ModItem
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
			player.slotsMinions += 1;
			player.maxTurrets += 1;
			player.setBonus = Language.GetTextValue("Mods.TwilightForestTerraria.SetBonus.SteeleafSummon");
		}
		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Summon) += 0.20f;
			player.GetCritChance(DamageClass.Summon) += 0.08f;
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
