namespace Matteini.gameObject.moveableObject.movement
{
    public interface IMovementLogic
    {
        void Move(MoveableObject moveableObject);
            
        void StartMoving(MoveableObject moveableObject) {
            moveableObject.IsMoving = true;
        }
        
        void StopMoving( MoveableObject moveableObject) {
            moveableObject.IsMoving = false;
        }
    }
}