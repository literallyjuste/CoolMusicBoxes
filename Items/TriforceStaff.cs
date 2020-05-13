using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CoolMusicBoxes.Items
{
    public class TriforceStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Triforce Staff");
            Tooltip.SetDefault("Shoots a triforce.");
            Item.staff[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.width = 33;
            item.height = 33;
            item.maxStack = 1;
            item.value = 10000;
            item.rare = 1;
            item.useStyle = 5;
            item.autoReuse = false;
			item.shoot = mod.ProjectileType("TriforceProjectile");
            item.shootSpeed = 16f;
            item.noMelee = true;
            item.magic = true;
            item.UseSound = SoundID.Item20;
            item.useAnimation = 2;
            item.damage = 350000;
            item.knockBack = 5; 
            item.mana = 75;
            item.holdStyle = 2; 
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
    }
}