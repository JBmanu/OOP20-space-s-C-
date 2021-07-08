using Matteini.gameObject.moveableObject.movement;
using Matteini.gameObject.utils;

namespace Matteini.gameObject.mainObject
{
    public class MainObject : Matteini.gameObject.moveableObject.MoveableObject
    {
        public MainObject(EngineImage engineImage, P2d position, IBoundingBox bb, IEventComponent eventComponent,
            V2d velocity, double acceleration, IMovementLogic movementLogic, P2d targetPosition, int life,
            int impactDamage, int score)
            : base(engineImage, position, bb, eventComponent, velocity, acceleration, movementLogic, targetPosition)
        {
            Life = life;
            ImpactDamage = impactDamage;
            Status = Status.Normal;
            Score = score;
        }

        public int Life { get; set; }
        public int ImpactDamage { get; set; }
        public Status Status { get; set; }
        public int Score { get; set; }
    }
}