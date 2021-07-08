using System.Collections.Generic;
using System.IO;

namespace Paganelli.model
{
    public class SoundPath
    {
        public static readonly SoundPath SHOOT  = new SoundPath("res/shoot.wav", SoundType.EFFECT);
        public static readonly SoundPath ENEMY_SHOOT  = new SoundPath("res/enemyShoot.wav", SoundType.EFFECT);
        
        private readonly string path;
        private readonly SoundType type;

        private SoundPath(string path, SoundType type)
        {
            this.path = path;
            this.type = type;
        }

        /**
         * Return a list of values
         */
        public static List<SoundPath> Values()
        {
            List<SoundPath> list = new List<SoundPath>();
            list.Add(SHOOT);
            list.Add(ENEMY_SHOOT);
            return list;
        }

        public SoundType GetType()
        {
            return this.type;
        }
        
    }
    
    /**
    * Enumeration representing the type of sounds.
    *
    */
    public class SoundType
    {
        /**
        * Type of sound loop, when the clip is finished it restarts. 
        */
        public static SoundType LOOP = new SoundType("LOOP");
        /**
        * Type of sound effect, no restarts when finished.
         */
        public static SoundType EFFECT = new SoundType("EFFECT");

        /**
         * Returns a soundPath list made up of all that have the same type as the passed one.
         * @return a List.
         */
        private string type;
        private SoundType(string type)
        {
            this.type = type;
        }
        
        public List<SoundPath> GetSoundPaths()
        {
            List<SoundPath> l = new List<SoundPath>();
            SoundPath.Values().ForEach(sound =>
            {
                if(sound.GetType().ToString().Equals(this.type))
                {
                    l.Add(sound);
                }
            });
            return l;
        }
    }
}