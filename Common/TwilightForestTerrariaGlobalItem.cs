namespace TwilightForestTerraria.Common
{
    public class TwilightForestTerrariaGlobalItem : GlobalItem
    {
        public override bool InstancePerEntity => true;
        public override bool CanConsumeAmmo(Item item, Item ammo, Player player)
        {
            if (true)
            {
                if (player.GetModPlayer<TwilightForestTerrariaPlayer>().FieryRanged)
                {
                    return Main.rand.NextBool(5);
                }
            }
            return base.CanConsumeAmmo(item, ammo, player);
        }
    }
}