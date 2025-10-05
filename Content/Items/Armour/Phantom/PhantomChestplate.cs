using TwilightForestTerraria.Common;

namespace TwilightForestTerraria.Content.Items.Armour.Phantom
{
	[AutoloadEquip(EquipType.Body)]
	public class PhantomChestplate : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 28;
			Item.value = ItemValue.SellPrices.PhantomArmor;
			Item.rare = ItemRarityID.Yellow;
			Item.defense = 23;
		}
		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Generic) += 0.12f;
			player.GetCritChance(DamageClass.Generic) += 0.12f;	
		}
	}
}
