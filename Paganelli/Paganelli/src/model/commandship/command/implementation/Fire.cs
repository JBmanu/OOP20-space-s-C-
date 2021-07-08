using System;
using Paganelli.model;

namespace Paganelli
{
    public class Fire : ICommandShip
    {
        public void Execute(SpaceShip ship)
        {
            Console.WriteLine("FIRE");
            ship.GetSoundQueue().Add(SoundPath.SHOOT);
        }

    }
}