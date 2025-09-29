using TwilightForestTerraria.Content.Tiles;

namespace TwilightForestTerraria.Content.Items.Placeable
{
	public class Liveroot : ModItem
	{
        public override void SetStaticDefaults()
        {
            ItemID.Sets.SortingPriorityMaterials[Item.type] = 58;
            Item.rare = ItemRarityID.Green;
		}

		public override void SetDefaults()
        {
			Item.DefaultToPlaceableTile(ModContent.TileType<Liveroots>());
			Item.width = 12;
			Item.height = 12;
			Item.value = Item.sellPrice(silver: 1, copper: 52);
		}
	}
}