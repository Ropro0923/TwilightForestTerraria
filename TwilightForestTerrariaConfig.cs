using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace TwilightForestTerraria
{
    public class TwilightForestTerrariaConfig : ModConfig
    {
        public static TwilightForestTerrariaConfig Instance { get; private set; }
        public override void OnLoaded() => Instance = this;
        public override void OnChanged() => Instance = this;
        public override ConfigScope Mode => ConfigScope.ServerSide;
        #region Miscellaneous
        [Header("Miscellaneous")]
        [DefaultValue(true)]
        [ReloadRequired]
        public bool ColoredRelics { get; set; } 
        #endregion
    }
}