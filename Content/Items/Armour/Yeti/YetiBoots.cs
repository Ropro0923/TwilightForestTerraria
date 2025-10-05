using TwilightForestTerraria.Common;
using TwilightForestTerraria.Content.Items.Armour.Arctic;
using TwilightForestTerraria.Content.Items.Materials.Boss;

namespace TwilightForestTerraria.Content.Items.Armour.Yeti
{
	[AutoloadEquip(EquipType.Legs)]
	public class YetiBoots : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 18;
			Item.rare = ItemRarityID.Orange;
			Item.value = ItemValue.SellPrices.AlphaYetiFur * 25 + ItemValue.SellPrices.ArcticFur * 25;
			Item.defense = 8;
		}
        public override void UpdateEquip(Player player)
        {
            player.GetAttackSpeed(DamageClass.Melee) += 0.08f;
        }
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<ArcticBoots>(25)
				.AddIngredient<AlphaYetiFur>(25)
				.AddTile(TileID.Loom)
				.Register();
		}
	}
}
