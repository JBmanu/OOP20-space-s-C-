using System;

namespace Paganelli
{
    public class Up : ICommandShip
    {
        public void Execute(SpaceShip ship)
        {
            ship.Aceleration += 0.5;
            Console.WriteLine("UP");
        }
    }
}