
using TwilightForestTerraria.Common;

namespace TwilightForestTerraria.Content.Items.Materials.Boss
{
	public class AlphaYetiFur : ModItem
	{
		public override void SetDefaults() 
		{
			Item.width = 20;
			Item.height = 20;
			Item.rare = ItemRarityID.Green;
			Item.maxStack = Item.CommonMaxStack;
			Item.value = ItemValue.SellPrices.AlphaYetiFur;
		}
	}
}
