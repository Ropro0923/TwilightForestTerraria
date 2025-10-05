using TwilightForestTerraria.Common;

namespace TwilightForestTerraria.Content.Items.Materials.Boss
{
	public class NagaScales : ModItem
	{
		public override void SetDefaults() 
		{
			Item.width = 20;
			Item.height = 18;
			Item.rare = ItemRarityID.Blue;
			Item.maxStack = Item.CommonMaxStack;
			Item.value = ItemValue.SellPrices.NagaScales;
		}
	}
}
