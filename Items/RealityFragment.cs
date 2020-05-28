using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CoolMusicBoxes.Items
{
    public class RealityFragment : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Reality Fragment");
            Tooltip.SetDefault("All fragments combined, making a fragment of reality.\nIt is used to make the drink of gods.");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.maxStack = 999;
            item.value = 100000;
            item.rare = 1;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FragmentNebula, 30);
            recipe.AddIngredient(ItemID.FragmentSolar, 30);
            recipe.AddIngredient(ItemID.FragmentStardust, 30);
            recipe.AddIngredient(ItemID.FragmentVortex, 30);
            recipe.AddTile(412);
            recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}