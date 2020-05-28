using Terraria;
using Terraria.ModLoader;

namespace CoolMusicBoxes.Buffs
{
    public class DrPepperBlessing : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Blessing of the gods(Dr. Pepper)");
            Description.SetDefault("You are a god, blessed by gods. Loved by the gods.");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false; //Add this so the nurse doesn't remove the buff when healing
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense += 4000;
            player.lifeRegen += 20000;
            player.manaRegen += 2000;
            player.allDamageMult += 4000;
            player.statLifeMax2 = 42069420;
            player.statManaMax2 = 42069;
        }
    }
}