using System;

namespace Paganelli
{
    public class UpRelease: ICommandShip
    {
        public void Execute(SpaceShip ship)
        {
            ship.Aceleration -= 0.5;
            if (ship.Aceleration < 0)
            {
                ship.Aceleration = 0;
            }
            Console.WriteLine("UP_RELEASE");
        }
    }
}