using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace yay.Content.Items.Projectiles.Melee
{
 #pragma warning disable CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.     
      internal class swordsploderprojectile : ModProjectile
      {
        public override void SetDefaults()
        {
            Projectile.width = 24;
            Projectile.height = 24;
            Projectile.friendly = true;
            Projectile.penetrate = -1;
            Projectile.tileCollide = false;
            Projectile.ownerHitCheck = true;
            Projectile.extraUpdates = 1;
            Projectile.timeLeft = 300;
            Projectile.aiStyle = ProjAIStyleID.Arrow;
        }

        public override void AI()
        {
           Projectile.ai[0] += 1f;
			if (Projectile.ai[0] >= 15f) {
				Projectile.ai[0] = 15f;
				Projectile.velocity.Y += 0.1f;
			}

			// The projectile is rotated to face the direction of travel
			Projectile.rotation = Projectile.velocity.ToRotation() + MathHelper.PiOver2;

			// Cap downward velocity
			if (Projectile.velocity.Y > 16f) {
				Projectile.velocity.Y = 16f;
			}
        }





    }



}