
namespace TwilightForestTerraria.Common
{
    public class TwilightForestTerrariaPlayer : ModPlayer
    {
        public bool FieryRanged;
        public bool KnightlySet;
        public bool PhantomSet;
        public bool YetiSet;
        public override void ResetEffects()
        {
            FieryRanged = false;
            KnightlySet = false;
            PhantomSet = false;
            YetiSet = false;
        }
        public override void ModifyHurt(ref Player.HurtModifiers modifiers)
        {
            if (KnightlySet)
            {
                modifiers.FinalDamage *= 0.90f;
            }
        }
        public override bool FreeDodge(Player.HurtInfo info)
        {
            if (PhantomSet & Main.rand.NextBool(10))
            {
                return true;
            }
            return base.FreeDodge(info);
        }
        public override void OnHitByNPC(NPC npc, Player.HurtInfo hurtInfo)
        {
            if (YetiSet)
            {
                int debuff = Main.rand.Next([BuffID.Frostburn, BuffID.Frostburn2, BuffID.Chilled, BuffID.Frozen]);
                npc.AddBuff(debuff, 420);
            }
            base.OnHitByNPC(npc, hurtInfo);
        }
    }
}