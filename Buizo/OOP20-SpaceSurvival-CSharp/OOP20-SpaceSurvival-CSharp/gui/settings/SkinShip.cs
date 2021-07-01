using System;
using System.Collections.Generic;
using System.Text;

namespace OOP20_SpaceSurvival_CSharp.gui.settings
{
    class SkinShip
    {
        public static readonly SkinShip SPECIAL = new SkinShip("Start");
        public static readonly SkinShip STANDARD = new SkinShip("Settings");
        public static readonly SkinShip DELUXE = new SkinShip("Sound");
        public static readonly SkinShip NORMAL = new SkinShip("Help");
        public static readonly SkinShip ATOMIC = new SkinShip("Quit");

        public string Name { get; private set; }

        private SkinShip(string name) => this.Name = name;

        public static List<SkinShip> Values()
        {
            List<SkinShip> values = new List<SkinShip>
            {
                SPECIAL,
                STANDARD,
                DELUXE,
                NORMAL,
                ATOMIC
            };

            return values;
        }
    }
}

