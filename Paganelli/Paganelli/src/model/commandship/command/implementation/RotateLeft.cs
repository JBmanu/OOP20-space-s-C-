using System;

namespace Paganelli
{
    public class RotateLeft : ICommandShip
    {
        public void Execute(SpaceShip ship)
        {
            Console.WriteLine("ROTATE_LEFT");
        }
    }
}