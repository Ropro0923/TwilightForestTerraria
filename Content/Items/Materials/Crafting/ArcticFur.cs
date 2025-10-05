using TwilightForestTerraria.Common;

namespace TwilightForestTerraria.Content.Items.Materials.Crafting
{
    public class ArcticFur : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 16;
			Item.value = ItemValue.SellPrices.ArcticFur;
        }
	}
}
