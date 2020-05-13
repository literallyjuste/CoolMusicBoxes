using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ModLoader;
using System.IO;
using Terraria.DataStructures;
using Terraria.GameInput;

namespace CoolMusicBoxes
{
	public class CoolMusicBoxes : Mod
	{
		public CoolMusicBoxes() {

		}
		public override void Load() {
			if (!Main.dedServ) {
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/CodeVeinDream"), ItemType("CodeVeinDreamInv"), TileType("CodeVeinDreamPlaced"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/CodeVeinTheme"), ItemType("CodeVeinThemeInv"), TileType("CodeVeinThemePlaced"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/DarkSoulsTheme"), ItemType("DarkSoulsThemeInv"), TileType("DarkSoulsThemePlaced"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/HollowKnightPathofPain"), ItemType("HollowKnightPathofPainInv"), TileType("HollowKnightPathofPainPlaced"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/NierAutomataSimone"), ItemType("NierAutomataSimoneInv"), TileType("NierAutomataSimonePlaced"));
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/UndertaleDatingStart"), ItemType("UndertaleDatingStartInv"), TileType("UndertaleDatingStartPlaced"));
			}
		}
/*	public override void UpdateMusic(ref int music, ref MusicPriority priority) {
		if (Main.myPlayer == -1 || Main.gameMenu || !Main.LocalPlayer.active) {
		return;
	}
	// Make sure your logic here goes from lowest priority to highest so your intended priority is maintained.
	if (Main.LocalPlayer.GetModPlayer<ExamplePlayer>().ZoneExample) {
		music = GetSoundSlot(SoundType.Music, "Sounds/Music/CodeVeinTheme");
		priority = MusicPriority.BiomeLow;
	}
		}*/
	}
}
