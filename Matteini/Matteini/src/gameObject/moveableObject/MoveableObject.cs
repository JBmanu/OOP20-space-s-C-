using Matteini.gameObject.moveableObject.movement;
using Matteini.gameObject.utils;

namespace Matteini.gameObject.moveableObject
{
    public class MoveableObject : Matteini.gameObject.GameObject
    {
        public MoveableObject(EngineImage engineImage, P2d position, IBoundingBox bb, IEventComponent eventComponent,
            V2d velocity, double acceleration, IMovementLogic movementLogic,
            P2d targetPosition) : base(engineImage, position, bb, eventComponent)
        {
            Velocity = velocity;
            Acceleration = acceleration;
            TargetPosition = targetPosition;
            MovementLogic = movementLogic;
        }

        public V2d Velocity { get; set; }
        public double Acceleration { get; set; }
        public P2d TargetPosition { get; set; }
        public IMovementLogic MovementLogic { get; set; }
        public bool IsMoving { get; set; }
    }
}