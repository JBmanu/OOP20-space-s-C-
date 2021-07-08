using Matteini.gameObject.fireableObject.firinglogic;
using Matteini.gameObject.fireableObject.weapon;
using Matteini.gameObject.mainObject;
using Matteini.gameObject.moveableObject.movement;
using Matteini.gameObject.utils;

namespace Matteini.gameObject.fireableObject
{
    public class FireableObject : MainObject
    {
        public FireableObject(EngineImage engineImage, P2d position, IBoundingBox bb, IEventComponent eventComponent,
            V2d velocity, double acceleration, IMovementLogic movementLogic, P2d targetPosition, int life,
            int impactDamage, int score, Weapon weapon, IFiringLogic firingLogic)
            : base(engineImage, position, bb, eventComponent, velocity, acceleration, movementLogic, targetPosition,
                life,
                impactDamage, score)
        {
            Weapon = weapon;
            FiringLogic = firingLogic;
        }

        public Weapon Weapon { get; set; }
        public IFiringLogic FiringLogic { get; set; }
    }
}