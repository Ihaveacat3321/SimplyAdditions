using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SimplyAdditions.Items
{
	[AutoloadEquip(EquipType.Shield)]
	public class MythrilShield : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Not actually made of Mithril.");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 12200;
			item.rare = 3;
			item.accessory = true;
			item.defense = 3;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.noKnockback = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CobaltShield, 1);
			recipe.AddIngredient(ItemID.PlatinumBar, 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}