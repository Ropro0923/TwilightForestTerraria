using TwilightForestTerraria.Common;

namespace TwilightForestTerraria.Content.Items.Materials.Crafting
{
    public class ArmorShard : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
			Item.value = ItemValue.SellPrices.ArmorShard;
        }
	}
}
