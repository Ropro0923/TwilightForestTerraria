namespace TwilightForestTerraria.Core.Players
{
    public class ArmourPlayer : ModPlayer
    {
        public bool Arctic;
        public override void ResetEffects()
        {
            Arctic = false;
        }
    }
}