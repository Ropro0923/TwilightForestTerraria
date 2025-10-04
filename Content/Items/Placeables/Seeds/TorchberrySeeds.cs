
using TwilightForestTerraria.Content.Tiles.Herbs;

namespace TwilightForestTerraria.Content.Items.Placeables.Seeds
{
	public class TorchberrySeeds : ModItem
	{
		public override void SetDefaults()
		{
			Item.DefaultToPlaceableTile(ModContent.TileType<TorchberryBush>());
			Item.width = 12;
			Item.height = 14;
		}
	}
}
