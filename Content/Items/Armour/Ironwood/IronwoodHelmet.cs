using Terraria.Localization;
using TwilightForestTerraria.Common;
using TwilightForestTerraria.Content.Items.Materials.Crafting;

namespace TwilightForestTerraria.Content.Items.Armour.Ironwood
{
	[AutoloadEquip(EquipType.Head)]
	public class IronwoodHelmet : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 20;
			Item.height = 18;
			Item.defense = 5;
			Item.value = ItemValue.SellPrices.IronwoodBar * 20;
		}
		public override bool IsArmorSet(Item head, Item body, Item legs) => body.type == ModContent.ItemType<IronwoodChestplate>() && legs.type == ModContent.ItemType<IronwoodBoots>();
		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = Language.GetTextValue("Mods.TwilightForestTerraria.SetBonus.Ironwood");
			player.statDefense += 3;
			player.moveSpeed += 0.6f;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<IronwoodBar>(20)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}
