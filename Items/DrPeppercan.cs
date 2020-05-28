using Terraria.ID;
using Terraria.ModLoader;

namespace CoolMusicBoxes.Items
{
	public class DrPeppercan : ModItem
	{

		public override void SetDefaults()
		{

			item.width = 67;
			item.height = 128;
			item.rare = 1;
            item.useStyle = 2;
            item.useTime = 300;
            item.consumable = true;
            item.maxStack = 1;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/HeavenlyMusic");
            item.value = 999999999;
            item.buffType = mod.BuffType("DrPepperBlessing");
            item.buffTime = 180000;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dr. Pepper Can");
			Tooltip.SetDefault("This is the drink of the gods.\nIt's the best softdrink.\n(This item can and most likely will break your current session, making weird stuff happen.)");
		}
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("EarthElement"), 3);
            recipe.AddIngredient(mod.ItemType("AirElement"), 3);
			recipe.AddIngredient(mod.ItemType("WaterElement"), 3);
            recipe.AddIngredient(mod.ItemType("FireElement"), 3);
            recipe.AddIngredient(mod.ItemType("DrPeppercanEmpty"), 1);
            recipe.AddIngredient(mod.ItemType("RealityFragment"), 1);
            recipe.AddIngredient(mod.ItemType("SouloftheWorld"), 1);
            recipe.AddIngredient(ItemID.Ectoplasm, 100);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
