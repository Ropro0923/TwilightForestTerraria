using Terraria.Localization;
using TwilightForestTerraria.Common;
using TwilightForestTerraria.Content.Items.Materials.Crafting;

namespace TwilightForestTerraria.Content.Items.Armour.Knightly
{
	[AutoloadEquip(EquipType.Head)]
	public class KnightlyHelmet : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 22;
			Item.value = ItemValue.SellPrices.KnightmetalBar * 20;
			Item.defense = 30;
			Item.rare = ItemRarityID.LightRed;
		}
		public override void UpdateEquip(Player player)
		{
			player.GetCritChance(DamageClass.Melee) += 0.05f;
			player.GetDamage(DamageClass.Melee) += 0.10f;
		}
		public override bool IsArmorSet(Item head, Item body, Item legs) => body.type == ModContent.ItemType<KnightlyChestplate>() && legs.type == ModContent.ItemType<KnightlyBoots>();
		public override void UpdateArmorSet(Player player)
		{
			player.statDefense += 5;
			player.GetDamage(DamageClass.Melee) += 0.05f;
			player.setBonus = Language.GetTextValue("Mods.TwilightForestTerraria.SetBonus.Knightly");
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<KnightmetalBar>(20)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}
