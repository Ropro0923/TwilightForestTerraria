using System.Collections.Generic;
using System.IO;
using Terraria.ModLoader.IO;

namespace TwilightForestTerraria.Core.WorldSaving
{
    public class BaseWorldFlags : ModSystem
    {
        private static bool portalBeenOpened;
        public static bool PortalBeenOpened
        {
            get => portalBeenOpened;
            set
            {
                portalBeenOpened = value;
            }
        }
        public override void OnWorldLoad()
        {
            PortalBeenOpened = false;
        }
        public override void OnWorldUnload()
        {
            PortalBeenOpened = false;
        }
        public override void NetSend(BinaryWriter writer)
        {
            BitsByte flags = new();
            flags[0] = PortalBeenOpened;
            writer.Write(flags);
        }
        public override void NetReceive(BinaryReader reader)
        {
            BitsByte flags = reader.ReadByte();
            PortalBeenOpened = flags[0];
        }
        public override void SaveWorldData(TagCompound tag)
        {
            if (WorldGen.generatingWorld)
                return;
            var flags = new List<string>();
            if (PortalBeenOpened)
                flags.Add("PortalBeenOpened");
            tag["flags"] = flags;
        }
        public override void LoadWorldData(TagCompound tag)
        {
            var flags = tag.GetList<string>("flags");
            PortalBeenOpened = flags.Contains("PortalBeenOpened");
        }
    }
}