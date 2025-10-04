using Terraria.Localization;
using TwilightForestTerraria.Content.Items.Materials.Crafting;
using TwilightForestTerraria.Core.Players;

namespace TwilightForestTerraria.Content.Items.Armour.Arctic
{
	[AutoloadEquip(EquipType.Head)]
	public class ArcticHood : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 18;
			Item.height = 18;
			Item.rare = ItemRarityID.Green;
			Item.defense = 6;
			Item.value = Item.sellPrice(0, 0, 3, 20) * 20;
		}
		public override bool IsArmorSet(Item head, Item body, Item legs) => body.type == ModContent.ItemType<ArcticJacket>() && legs.type == ModContent.ItemType<ArcticLeggings>();
		public override void UpdateArmorSet(Player player)
		{
			ArmourPlayer modPlayer = player.GetModPlayer<ArmourPlayer>();
			modPlayer.Arctic = true;
			player.setBonus = Language.GetTextValue("Mods.TwilightForestTerraria.SetBonus.Arctic");
			player.buffImmune[BuffID.Frostburn] = true;
			player.buffImmune[BuffID.Frostburn2] = true;
			player.buffImmune[BuffID.Chilled] = true;
			player.buffImmune[BuffID.Frozen] = true;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<ArcticFur>(20)
				.AddTile(TileID.Loom)
				.Register();
		}
	}
}
