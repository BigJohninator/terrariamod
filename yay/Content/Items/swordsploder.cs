using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using yay.Content.Items.Projectiles.Melee;

namespace yay.Content.Items
{
    // This is a basic item template.
    // Please see tModLoader's ExampleMod for every other example:
    // https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
    #pragma warning disable CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
    public class swordsploder : ModItem
    {
		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.yay.hjson' file.
		public override void SetDefaults()
		{
			Item.damage = 370;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 12;
			Item.useAnimation = 12;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 6305;
			Item.value = Item.buyPrice(platinum: 100);
			Item.rare = ItemRarityID.Blue;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.noUseGraphic = true;
			Item.noMelee = true;
			Item.shootSpeed = 2.1f;
			Item.shoot = ModContent.ProjectileType<swordsploderprojectile>();
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 99);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}