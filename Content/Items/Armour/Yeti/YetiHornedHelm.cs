using Terraria.Localization;
using TwilightForestTerraria.Common;
using TwilightForestTerraria.Content.Items.Armour.Arctic;
using TwilightForestTerraria.Content.Items.Materials.Boss;

namespace TwilightForestTerraria.Content.Items.Armour.Yeti
{
	[AutoloadEquip(EquipType.Head)]
	public class YetiHornedHelm : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 26;
			Item.rare = ItemRarityID.Orange;
			Item.value = ItemValue.SellPrices.AlphaYetiFur * 12 + ItemValue.SellPrices.ArcticFur * 12;
			Item.defense = 8;
		}
		public override void UpdateEquip(Player player)
		{
			player.GetCritChance(DamageClass.Melee) += 0.08f;
		}
		public override bool IsArmorSet(Item head, Item body, Item legs) => body.type == ModContent.ItemType<YetiJacket>() && legs.type == ModContent.ItemType<YetiBoots>();
		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = Language.GetTextValue("Mods.TwilightForestTerraria.SetBonus.Yeti");
			player.buffImmune[BuffID.Frostburn] = true;
			player.buffImmune[BuffID.Frostburn2] = true;
			player.buffImmune[BuffID.Chilled] = true;
			player.buffImmune[BuffID.Frozen] = true;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<ArcticHood>(25)
				.AddIngredient<AlphaYetiFur>(12)
				.AddTile(TileID.Loom)
				.Register();
		}
	}
}
