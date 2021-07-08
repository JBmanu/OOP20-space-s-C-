using System;
using System.Collections.Generic;
using Matteini.gameObject.moveableObject;
using Matteini.gameObject.utils;

namespace Matteini.gameObject.fireableObject.weapon
{
    public class Weapon
    {
        public FireableObject Owner { get; set; }
        public AmmoType AmmoType { get; set; }
        public Magazine Magazine { get; set; }
        public int Munitions { get; set; }
        public HashSet<Bullet> ShootedBullets { get; set; }
        public bool CanShoot { get; set; }

        public Weapon()
        {
            this.AmmoType = AmmoType.Normal;
            this.Magazine = Magazine.Unlimited;
            this.Munitions = int.MaxValue;
            this.ShootedBullets = new HashSet<Bullet>();
            this.CanShoot = true;
        }
        
        public Weapon(FireableObject owner)
        {
            this.AmmoType = AmmoType.Normal;
            this.Magazine = Magazine.Unlimited;
            this.Munitions = int.MaxValue;
            this.ShootedBullets = new HashSet<Bullet>();
            this.CanShoot = true;
            this.Owner = owner;
        }
        
        public void Shoot() {
            EngineImage engineImage = new EngineImage();
            P2d position = new P2d(); 
            V2d velocity = new V2d();
            double acceleration = 0;

            Bullet bullet = new Bullet(engineImage, position, new RectBoundingBox(new AffineTransform()), null,
                velocity, acceleration, null, new P2d(), 50, Effect.None, this);
            AffineTransform newTransform = new AffineTransform();

            if (Magazine == Magazine.Limited) {
                Munitions--;
                if (Munitions == 0) {
                    SetAmmoType(AmmoType.Normal);
                }
            }
            ShootedBullets.Add(bullet);
        }
        
        public void SetAmmoType(AmmoType ammoType) {
            this.AmmoType = ammoType;
            if (this.AmmoType == AmmoType.Normal) {
                this.Magazine = Magazine.Unlimited;
                this.Munitions = int.MaxValue;
            } else {
                this.Magazine = Magazine.Limited;
                this.Munitions = 25;
            }
        }
    }
}