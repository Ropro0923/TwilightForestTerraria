using TwilightForestTerraria.Content.Items.Materials.Crafting;

namespace TwilightForestTerraria.Content.Items.Armour.Ironwood
{
	[AutoloadEquip(EquipType.Body)]
	public class IronwoodChestplate : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 18;
			Item.height = 18;
			Item.value = (Item.sellPrice(copper: 78) * 3 + ContentSamples.ItemsByType[ItemID.IronBar].value * 5 + ContentSamples.ItemsByType[ItemID.GoldBar].value) / 5 * 3 * 30;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<IronwoodBar>(30)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}
