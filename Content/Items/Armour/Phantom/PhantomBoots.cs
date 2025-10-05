namespace TwilightForestTerraria.Content.Items.Armour.Phantom
{
	[AutoloadEquip(EquipType.Legs)]
	public class PhantomBoots : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 22;
			Item.height = 18;
			Item.defense = 7;
			Item.value = Item.sellPrice(0, 8, 50, 0);
		}
		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Generic) += 0.08f;
			player.GetCritChance(DamageClass.Generic) += 0.04f;
			player.moveSpeed += 0.05f;
		}
	}
}
