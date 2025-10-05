using Terraria.Localization;

namespace TwilightForestTerraria.Content.Items.Armour.Phantom
{
	[AutoloadEquip(EquipType.Head)]
	public class PhantomHelmet : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 26;
			Item.defense = 8;
			Item.value = Item.sellPrice(0, 8, 50, 0);
		}
		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Generic) += 0.08f;
			player.GetCritChance(DamageClass.Generic) += 0.04f;
		}
		public override bool IsArmorSet(Item head, Item body, Item legs) => body.type == ModContent.ItemType<PhantomChestplate>() && legs.type == ModContent.ItemType<PhantomBoots>();
		public override void UpdateArmorSet(Player player)
		{
			player.GetCritChance(DamageClass.Generic) += 0.04f;
			player.GetDamage(DamageClass.Generic) += 0.04f;
			player.setBonus = Language.GetTextValue("Mods.TwilightForestTerraria.SetBonus.Phantom");
		}
	}
}
