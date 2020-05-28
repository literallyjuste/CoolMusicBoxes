using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CoolMusicBoxes.Items
{
    public class FireElement : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fire Element");
            Tooltip.SetDefault("One of the four powers to become a god.");
        }

        public override void SetDefaults()
        {
            Item refItem = new Item();
            refItem.SetDefaults(ItemID.SoulofSight);
            item.width = 30;
            item.height = 30;
            item.maxStack = 999;
            item.value = 100000;
            item.rare = 1;
            item.noUseGraphic = true;
        }
    }
}