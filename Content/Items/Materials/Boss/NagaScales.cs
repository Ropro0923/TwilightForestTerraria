namespace TwilightForestTerraria.Content.Items.Materials.Boss
{
	public class NagaScales : ModItem
	{
		public override void SetDefaults() 
		{
			Item.width = 20;
			Item.height = 20;
			Item.rare = ItemRarityID.Blue;
			Item.maxStack = Item.CommonMaxStack;
			Item.value = Item.sellPrice(0, 0, 1, 12);
		}
	}
}
