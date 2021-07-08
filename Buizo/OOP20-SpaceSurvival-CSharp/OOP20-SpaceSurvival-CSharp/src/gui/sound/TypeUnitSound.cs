using System;
using System.Collections.Generic;
using System.Text;

namespace OOP20_SpaceSurvival_CSharp.gui.sound
{
    public class TypeUnitSound
    {
        public static readonly TypeUnitSound SLIDER_BACKGROUND = new TypeUnitSound("Main");
        public static readonly TypeUnitSound SLIDER_EFFECT = new TypeUnitSound("Effect");

        public string Type { get; private set; }

        private TypeUnitSound(string type) => this.Type = type;

        public static List<TypeUnitSound> Values()
        {
            List<TypeUnitSound> values = new List<TypeUnitSound>
            {
                SLIDER_BACKGROUND,
                SLIDER_EFFECT
            };

            return values;
        }

    }
}
