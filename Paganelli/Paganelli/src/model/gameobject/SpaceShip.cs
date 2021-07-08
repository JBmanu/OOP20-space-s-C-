using System.Collections.Generic;
using Paganelli.model;

namespace Paganelli
{
    public class SpaceShip
    {
        private readonly List<SoundPath> _soundQueue = new List<SoundPath>();
        public double Aceleration { get; set; } = 1;
        public List<SoundPath> GetSoundQueue()
        {
            return this._soundQueue;
        }
    }
}