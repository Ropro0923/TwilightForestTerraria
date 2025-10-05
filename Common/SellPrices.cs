namespace TwilightForestTerraria.Common
{
    public static class ItemValue
    {
        public static class SellPrices
        {
            public static readonly int Trophy = ContentSamples.ItemsByType[ItemID.EaterofWorldsTrophy].value;
            public static readonly int Liveroot = Item.sellPrice(copper: 78);
            public static readonly int RawIronwoodMaterials = (Liveroot * 3 + ContentSamples.ItemsByType[ItemID.IronBar].value * 3 + ContentSamples.ItemsByType[ItemID.GoldBar].value) / 3;
            public static readonly int IronwoodBar = RawIronwoodMaterials * 3;
            public static readonly int ArcticFur = Item.sellPrice(0, 0, 3, 20);
            public static readonly int FieryBar = 3 * FieryBlood + ContentSamples.ItemsByType[ItemID.MythrilBar].value;
            public static readonly int NagaScales = Item.sellPrice(0, 0, 1, 12);
            public static readonly int FieryBlood = Item.sellPrice(0, 1, 4, 22);
            public static readonly int ArmorShard = Item.sellPrice(0, 0, 65, 1);
            public static readonly int ArmorShardCluster = ArmorShard * 4;
            public static readonly int KnightmetalBar = ArmorShardCluster + ArmorShard;
            public static readonly int AlphaYetiFur = Item.sellPrice(0, 5, 2, 1);
            public static readonly int Steeleaf = Item.sellPrice(0, 3, 1, 0);
                        public static readonly int PhantomArmor = Item.sellPrice(0, 8, 50, 0);

        }
    }
}
