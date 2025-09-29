using Terraria.Localization;
using TwilightForestTerraria.Content.Items.Materials;

namespace TwilightForestTerraria.Content.Items.Armour.Fiery
{
	[AutoloadEquip(EquipType.Head)]
	public class FieryHelmet : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 18;
			Item.height = 18;
			Item.rare = ItemRarityID.Red;
		}
		public override bool IsArmorSet(Item head, Item body, Item legs) => body.type == ModContent.ItemType<FieryChestplate>() && legs.type == ModContent.ItemType<FieryLeggings>();
		public override void UpdateArmorSet(Player player)
		{
			ArmourPlayer modPlayer = player.GetModPlayer<ArmourPlayer>();
			modPlayer.Fiery = true;
			player.setBonus = GetSetBonusString();
		}
		public static string GetSetBonusString()
        {
            return Language.GetTextValue($"Mods.TwilightForestTerraria.SetBonus.Fiery");
        }
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<FierySteel>(12)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}
