using Terraria.Localization;
using TwilightForestTerraria.Content.Items.Materials.Crafting;

namespace TwilightForestTerraria.Content.Items.Armour.Ironwood
{
	[AutoloadEquip(EquipType.Head)]
	public class IronwoodHelmet : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 18;
			Item.height = 18;
			Item.value = (Item.sellPrice(copper: 78) * 3 + ContentSamples.ItemsByType[ItemID.IronBar].value * 5 + ContentSamples.ItemsByType[ItemID.GoldBar].value) / 5 * 3 * 20;
		}
		public override bool IsArmorSet(Item head, Item body, Item legs) => body.type == ModContent.ItemType<IronwoodChestplate>() && legs.type == ModContent.ItemType<IronwoodLeggings>();
		public override void UpdateArmorSet(Player player)
		{
			player.moveSpeed += 0.10f;
			player.jumpSpeedBoost += 1.0f;
			player.setBonus = Language.GetTextValue("Mods.TwilightForestTerraria.SetBonus.Ironwood");
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
