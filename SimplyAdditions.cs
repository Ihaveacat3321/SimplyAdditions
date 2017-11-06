using Terraria.ModLoader;

namespace SimplyAdditions
{
	class SimplyAdditions : Mod
	{
		public SimplyAdditions()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = false
			};
		}
	}
}
