

namespace TwilightForestTerraria.Content.Items.Armour
{
    public class ArmourPlayer : ModPlayer
    {
        public bool Fiery;
        public override void ResetEffects()
        {
            Fiery = false;
        }
        public override void OnHitByNPC(NPC npc, Player.HurtInfo hurtInfo)
        {
            if (Fiery)
                npc.AddBuff(BuffID.OnFire, 300);
            base.OnHitByNPC(npc, hurtInfo);
        }
    }
}