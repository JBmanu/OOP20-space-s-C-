using System;

namespace Paganelli
{
    public class RotateRight: ICommandShip
    {
        public void Execute(SpaceShip ship)
        {
            Console.WriteLine("ROTATE_RIGHT");
        }
    }
}