using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
 
namespace CoolMusicBoxes.NPCs
{
    public class GlobalNPCs : GlobalNPC
    {
        public override void NPCLoot(NPC npc) {
            if(Main.hardMode && !npc.boss && npc.lifeMax > 50 && Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneRockLayerHeight) {
                if(Main.rand.Next(100) < 1){
                    Item.NewItem(npc.getRect(), mod.ItemType("EarthElement"));
                }
            }
            if(Main.hardMode && !npc.boss && npc.lifeMax > 50 && Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneSkyHeight) {
                if(Main.rand.Next(100) < 1){
                    Item.NewItem(npc.getRect(), mod.ItemType("AirElement"));
                }
            }
            if(Main.hardMode && !npc.boss && npc.lifeMax > 50 && Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneBeach) {
                if(Main.rand.Next(100) < 1){
                    Item.NewItem(npc.getRect(), mod.ItemType("WaterElement"));
                }
            }
            if(Main.hardMode && !npc.boss && npc.lifeMax > 50 && Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneUnderworldHeight) {
                if(Main.rand.Next(100) < 1){
                    Item.NewItem(npc.getRect(), mod.ItemType("FireElement"));
                }
            }
        }
    }
}