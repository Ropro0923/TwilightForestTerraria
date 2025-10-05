using Terraria.Localization;
using TwilightForestTerraria.Common;
using TwilightForestTerraria.Content.Items.Materials.Boss;

namespace TwilightForestTerraria.Content.Items.Armour.NagaScale
{
	[AutoloadEquip(EquipType.Head)]
	public class NagaScaleHelmet : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 18;
			Item.height = 18;
			Item.value = ItemValue.SellPrices.NagaScales * 20;
			Item.rare = ItemRarityID.Blue;
			Item.defense = 7;
		}
		public override bool IsArmorSet(Item head, Item body, Item legs) => body.type == ModContent.ItemType<NagaScaleTunic>() && legs.type == ModContent.ItemType<NagaScaleBoots>();
		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = Language.GetTextValue("Mods.TwilightForestTerraria.SetBonus.NagaScale");
			player.buffImmune[BuffID.OnFire] = true;
			player.buffImmune[BuffID.Poisoned] = true;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<NagaScales>(20)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}
