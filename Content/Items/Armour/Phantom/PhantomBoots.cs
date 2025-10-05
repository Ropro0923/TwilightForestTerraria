using TwilightForestTerraria.Common;

namespace TwilightForestTerraria.Content.Items.Armour.Phantom
{
	[AutoloadEquip(EquipType.Legs)]
	public class PhantomBoots : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 22;
			Item.height = 18;
			Item.value = ItemValue.SellPrices.PhantomArmor;
			Item.rare = ItemRarityID.Yellow;
			Item.defense = 17;
		}
		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Generic) += 0.04f;
			player.GetCritChance(DamageClass.Generic) += 0.04f;
		}
	}
}
