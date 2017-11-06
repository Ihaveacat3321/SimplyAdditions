using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SimplyAdditions.Items.Weapons
{
	public class ShortExcalibur : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Short Excalibur");
			Tooltip.SetDefault("A shortsword forged like Excalibur.");
		}
		public override void SetDefaults()
		{
			item.damage = 46;
			item.melee = true;
			item.width = 48;
			item.height = 48;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useStyle = 3;
			item.knockBack = 2;
			item.value = 40000;
			item.rare = 5;
			item.autoReuse = false;
		}
		
		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(3) == 0)
			{
				Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 57);
			}
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedBar, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
