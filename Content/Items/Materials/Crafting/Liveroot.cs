namespace TwilightForestTerraria.Content.Items.Materials.Crafting
{
    public class Liveroot : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.value = Item.sellPrice(copper: 78);
        }
	}
}
