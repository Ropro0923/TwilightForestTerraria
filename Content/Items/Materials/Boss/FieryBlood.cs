namespace TwilightForestTerraria.Content.Items.Materials.Boss
{
	public class FieryBlood : ModItem
	{
		public override void SetDefaults() 
		{
			Item.width = 20;
			Item.height = 20;
			Item.rare = ItemRarityID.Pink;
			Item.maxStack = Item.CommonMaxStack;
			Item.value = Item.sellPrice(0, 1, 4, 22);
		}
	}
}
