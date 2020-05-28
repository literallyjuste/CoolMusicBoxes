using Terraria.ID;
using Terraria.ModLoader;

namespace CoolMusicBoxes.Items
{
	public class DrPeppercanEmpty : ModItem
	{

		public override void SetDefaults()
		{

			item.width = 67;
			item.height = 128;
			item.rare = 1;
            item.value = 10000000;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dr. Pepper can (empty)");
			Tooltip.SetDefault("The vessel for the drink of gods.");
		}
	}
}
