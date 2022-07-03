using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;


namespace BuildToggle
{
	public class BuildToggle : Mod
	{
		public static ModKeybind ToggleBuilding;
		
        public override void Load()
        {
            ToggleBuilding = KeybindLoader.RegisterKeybind(this, "Toggle Building", "OemTilde");
        }
        
        public override void Unload()
        {
            ToggleBuilding = null;
        }
    }
}