using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CoolMusicBoxes.Items
{
    public class SouloftheWorld : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul of the world");
            Tooltip.SetDefault("All the souls of this world, combined.\nThis item has incredible power, but can only be used in the drink of the gods.");
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
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SoulofFright, 20);
            recipe.AddIngredient(ItemID.SoulofSight, 20);
            recipe.AddIngredient(ItemID.SoulofMight, 20);
            recipe.AddIngredient(ItemID.SoulofFlight, 40);
            recipe.AddIngredient(ItemID.SoulofLight, 50);
            recipe.AddIngredient(ItemID.SoulofNight, 50);
            recipe.AddTile(412);
            recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}