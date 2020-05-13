using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CoolMusicBoxes.Items
{
    public class MusicPersonVoodooDoll : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Music Person Voodoo Doll");
            Tooltip.SetDefault("Kills the Music Person.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            item.value = 10000;
            item.rare = 1;
            item.useStyle = 5;
            item.noMelee = true;
            item.UseSound = SoundID.Item20;
            item.useAnimation = 2;
            // Set other item.X values here
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.SetResult(this);
			recipe.AddTile(86);
			recipe.AddRecipe();
        }
        /*public override void UseItem(Player player) {
            
        }*/
    }
}