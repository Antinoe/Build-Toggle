using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace BuildToggle
{
    public class BuildTogglePlayer : ModPlayer
    {	
		public bool cannotBuild = false;
		
		public static BuildTogglePlayer ModPlayer(Player Player)
		{
			return Player.GetModPlayer<BuildTogglePlayer>();
		}
		public override void PostUpdate()
		{
			//Controls
			if (BuildToggle.ToggleBuilding.JustPressed)
			{
				cannotBuild = !cannotBuild;
			}
		}
		public override void PostUpdateMiscEffects()
		{
			if (cannotBuild)
			{
				Player.noBuilding = true;
			}
		}
    }
}