using Terraria.Localization;
using TwilightForestTerraria.Common;
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
			Item.value = ItemValue.SellPrices.AlphaYetiFur * 12;
			Item.defense = 7;
		}
		public override void UpdateEquip(Player player)
		{
			base.UpdateEquip(player);
		}
		public override bool IsArmorSet(Item head, Item body, Item legs) => body.type == ModContent.ItemType<YetiJacket>() && legs.type == ModContent.ItemType<YetiBoots>();
		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = Language.GetTextValue("Mods.TwilightForestTerraria.SetBonus.Yeti");
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<AlphaYetiFur>(12)
				.AddTile(TileID.Loom)
				.Register();
		}
	}
}
