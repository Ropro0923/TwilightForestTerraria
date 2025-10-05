using Terraria.Localization;
using TwilightForestTerraria.Common;

namespace TwilightForestTerraria.Content.Items.Armour.Phantom
{
	[AutoloadEquip(EquipType.Head)]
	public class PhantomHelmet : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 26;
			Item.value = ItemValue.SellPrices.PhantomArmor;
			Item.rare = ItemRarityID.Yellow;
			Item.defense = 18;
		}
		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Melee) += 0.04f;
			player.GetCritChance(DamageClass.Melee) += 0.04f;
		}
		public override bool IsArmorSet(Item head, Item body, Item legs) => body.type == ModContent.ItemType<PhantomChestplate>() && legs.type == ModContent.ItemType<PhantomBoots>();
		public override void UpdateArmorSet(Player player)
		{
			player.GetModPlayer<TwilightForestTerrariaPlayer>().PhantomSet = true;
			player.setBonus = Language.GetTextValue("Mods.TwilightForestTerraria.SetBonus.Phantom");
		}
	}
}
