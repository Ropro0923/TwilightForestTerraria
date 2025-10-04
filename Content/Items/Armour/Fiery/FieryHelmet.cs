using Terraria.Localization;
using TwilightForestTerraria.Content.Items.Materials.Crafting;

namespace TwilightForestTerraria.Content.Items.Armour.Fiery
{
	[AutoloadEquip(EquipType.Head)]
	public class FieryHelmet : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 18;
			Item.height = 18;
			Item.value = Item.sellPrice(0, 1, 72, 22) * 20;
			Item.rare = ItemRarityID.Pink;
			Item.defense = 19;
		}
		public override bool IsArmorSet(Item head, Item body, Item legs) => body.type == ModContent.ItemType<FieryChestplate>() && legs.type == ModContent.ItemType<FieryLeggings>();
		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = Language.GetTextValue("Mods.TwilightForestTerraria.SetBonus.Fiery");
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<FieryBar>(20)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}
}
