namespace Matteini.gameObject.fireableObject.firinglogic
{
    public interface IFiringLogic
    {
        void StartFiring(FireableObject fireableObject);
        
        void StartChangingAmmo(FireableObject fireableObject);
    }
}