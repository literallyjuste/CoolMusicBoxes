using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
 
namespace CoolMusicBoxes.NPCs            //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
    [AutoloadHead]
    public class MusicPerson : ModNPC
    {
        /*public override bool Autoload(ref string name, ref string texture, ref string[] altTextures)
        {
            name = "Music Man";
            return mod.Properties.Autoload;
        }*/
        public override void SetDefaults()
        {
            npc.townNPC = true; //This defines if the npc is a town Npc or not
            npc.friendly = true;  //this defines if the npc can hur you or not()
            npc.width = 18; //the npc sprite width
            npc.height = 46;  //the npc sprite height
            npc.aiStyle = 7; //this is the npc ai style, 7 is Pasive Ai
            npc.defense = 250;  //the npc defense
            npc.lifeMax = 25000;// the npc life
            npc.HitSound = SoundID.NPCHit1;  //the npc sound when is hit
            npc.DeathSound = SoundID.NPCDeath1;  //the npc sound when he dies
            npc.knockBackResist = 0.5f;  //the npc knockback resistance
            Main.npcFrameCount[npc.type] = 25; //this defines how many frames the npc sprite sheet has
            NPCID.Sets.ExtraFramesCount[npc.type] = 9;
            NPCID.Sets.AttackFrameCount[npc.type] = 4;
            NPCID.Sets.DangerDetectRange[npc.type] = 150; //this defines the npc danger detect range
            NPCID.Sets.AttackType[npc.type] = 2; //this is the attack type,  0 (throwing), 1 (shooting), or 2 (magic). 3 (melee)
            NPCID.Sets.AttackTime[npc.type] = 30; //this defines the npc attack speed
            NPCID.Sets.AttackAverageChance[npc.type] = 10;//this defines the npc atack chance
            NPCID.Sets.HatOffsetY[npc.type] = 4; //this defines the party hat position
            animationType = NPCID.Guide;  //this copy the guide animation
        }
        public override bool CanTownNPCSpawn(int numTownNPCs, int money) //Whether or not the conditions have been met for this town NPC to be able to move into town.
        {
            if (NPC.downedMoonlord)  
            {
                return true;
            }
            return false;
        }
        public override string TownNPCName()     //Allows you to give this town NPC any name when it spawns
        {
            switch (WorldGen.genRand.Next(6))
            {
                case 0:
                    return "Lucio";
                case 1:
                    return "Cost6654";
                case 2:
                    return "literallyjuste";
                case 3:
                    return "NotPinkCost";
                case 4:
                    return "Kat";
                case 5:
                    return "Bob Ross";
                default:
                    return "may god help up all";
            }
        }
 
        public override void SetChatButtons(ref string button, ref string button2)  //Allows you to set the text for the buttons that appear on this town NPC's chat window.
        {
            button = "Shop";   //this defines the buy button name
        }
        public override void OnChatButtonClicked(bool firstButton, ref bool openShop) //Allows you to make something happen whenever a button is clicked on this town NPC's chat window. The firstButton parameter tells whether the first button or second button (button and button2 from SetChatButtons) was clicked. Set the shop parameter to true to open this NPC's shop.
        {
 
            if (firstButton)
            {
                openShop = true;   //so when you click on buy button opens the shop
            }
        }
 
        public override void SetupShop(Chest shop, ref int nextSlot)       //Allows you to add items to this town NPC's shop. Add an item by setting the defaults of shop.item[nextSlot] then incrementing nextSlot.
        {
            shop.item[nextSlot].SetDefaults(mod.ItemType("CodeVeinDreamInv")); 
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("CodeVeinThemeInv"));  
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("DarkSoulsThemeInv"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("HollowKnightPathofPainInv"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("NierAutomataSimoneInv"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("UndertaleDatingStartInv"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.CatEars);
            nextSlot++;
        }
 
        public override string GetChat()       //Allows you to give this town NPC a chat message when a player talks to it.
        {
            int wizardNPC = NPC.FindFirstNPC(NPCID.Wizard);   //this make so when this npc is close to Wizard
            if (wizardNPC >= 0 && Main.rand.Next(4) == 0)    //has 1 in 3 chance to show this message
            {
                return "Yes " + Main.npc[wizardNPC].GivenName + " is a wizard, but he's not as good as Cost6654";
            }
            int anglerNPC = NPC.FindFirstNPC(NPCID.Angler);
            if (anglerNPC >= 0 && Main.rand.Next(4) == 0)
            {
                return "I despise " + Main.npc[anglerNPC].GivenName + " with every cell of my body.";
            }
            switch (Main.rand.Next(4))
            {
                case 0:
                    return "Need some cool Music?";
                case 1:
                    return "My items are not expensive at all.";
                case 2:
                    return "oh no";
                case 3:
                    return "Code Vein has incredible Music.";
                default:
                    return "I hate" + Main.npc[anglerNPC].GivenName;
 
            }
        }
        public override void TownNPCAttackStrength(ref int damage, ref float knockback)//  Allows you to determine the damage and knockback of this town NPC attack
        {
            damage = 400;  //npc damage
            knockback = 2f;   //npc knockback
        }
 
        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)  //Allows you to determine the cooldown between each of this town NPC's attack. The cooldown will be a number greater than or equal to the first parameter, and less then the sum of the two parameters.
        {
            cooldown = 5;
            randExtraCooldown = 10;
        }
        //------------------------------------This is an example of how to make the npc use a sward attack-------------------------------
        public override void DrawTownAttackSwing(ref Texture2D item, ref int itemSize, ref float scale, ref Vector2 offset)//Allows you to customize how this town NPC's weapon is drawn when this NPC is swinging it (this NPC must have an attack type of 3). Item is the Texture2D instance of the item to be drawn (use Main.itemTexture[id of item]), itemSize is the width and height of the item's hitbox
        {
            scale = 1f;
            item = Main.itemTexture[mod.ItemType("TriforceStaff")]; //this defines the item that this npc will use
            itemSize = 56;
        }
 
        public override void TownNPCAttackMagic(ref float auraLightMultiplier) //  Allows you to determine the width and height of the item this town NPC swings when it attacks, which controls the range of this NPC's swung weapon.
        {
            auraLightMultiplier = 1;
        }
        public override void TownNPCAttackProj(ref int projType, ref int attackDelay) {
			projType = mod.ProjectileType("TriforceProjectile");
			attackDelay = 1;
		}
    }
}