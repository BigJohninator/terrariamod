using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace yay.Content.Items.Projectiles.Melee
{
      
      internal class LittleJohnProjectile : ModProjectile
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
            Projectile.aiStyle = ProjAIStyleID.ShortSword;
        }

        public override void AI()
        {
            base.AI();
            Projectile.rotation = Projectile.velocity.ToRotation() + MathHelper.PiOver2 - MathHelper.PiOver4 * Projectile.spriteDirection;

            int halfprojwidth = Projectile.width / 2;
            int halfprojheight = Projectile.height / 2;

            DrawOriginOffsetX = 0;
            DrawOffsetX = -((32 / 2) - halfprojheight);
            DrawOriginOffsetY = -((32 / 2) - halfprojwidth);
        }





    }



}