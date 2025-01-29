using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using XPT.Core.Audio.MP3Sharp.Decoding;

namespace yay.Content.Items
{
    // This is a basic item template.
    // Please see tModLoader's ExampleMod for every other example:
    // https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
#pragma warning disable CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
    public class butterchicken : ModItem
#pragma warning restore CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
    {
		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.yay.hjson' file.
		public override void SetDefaults()
		{
			
			Item.width = 32;
			Item.height = 32;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.useStyle = ItemUseStyleID.EatFood;
			Item.value = Item.buyPrice(platinum: 100);
			Item.rare = ItemRarityID.Red;
			Item.UseSound = SoundID.Item1;
			Item.useTurn = true;
            Item.maxStack = 9999;
            Item.healLife = 1000;
            Item.consumable = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}
