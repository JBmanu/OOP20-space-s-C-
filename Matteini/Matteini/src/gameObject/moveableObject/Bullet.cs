using Matteini.gameObject.fireableObject.weapon;
using Matteini.gameObject.moveableObject.movement;
using Matteini.gameObject.utils;

namespace Matteini.gameObject.moveableObject
{
    public class Bullet : MoveableObject
    {
        private int Damage { get; set; }
        private Effect Effect { get; set; }
        private Weapon OriginWeapon { get; set; }
        
        public Bullet(EngineImage engineImage, P2d position, IBoundingBox bb, IEventComponent eventComponent, 
            V2d velocity, double acceleration, IMovementLogic movementLogic, P2d targetPosition, int damage, 
            Effect effect, Weapon originWeapon) 
            : base(engineImage, position, bb, eventComponent, velocity, acceleration, movementLogic, targetPosition)
        {
            this.Damage = damage;
            this.Effect = effect;
            this.OriginWeapon = originWeapon;
        }
    }
}