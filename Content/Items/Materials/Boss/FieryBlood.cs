using TwilightForestTerraria.Common;

namespace TwilightForestTerraria.Content.Items.Materials.Boss
{
	public class FieryBlood : ModItem
	{
		public override void SetDefaults() 
		{
			Item.width = 16;
			Item.height = 26;
			Item.rare = ItemRarityID.Pink;
			Item.maxStack = Item.CommonMaxStack;
			Item.value = ItemValue.SellPrices.FieryBlood;
		}
	}
}
