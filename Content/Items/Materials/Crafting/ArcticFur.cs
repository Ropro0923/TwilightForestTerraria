namespace TwilightForestTerraria.Content.Items.Materials.Crafting
{
    public class ArcticFur : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.value = Item.sellPrice(0, 0, 3, 20);
        }
	}
}
