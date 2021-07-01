using System;
using System.Collections.Generic;
using System.Text;

namespace OOP20_SpaceSurvival_CSharp.gui.settings
{
    class UnitSettings
    {
        public static readonly UnitSettings UNIT_SKIN = new UnitSettings("Skin");

        public string Titile { get; private set; }

        private UnitSettings(string title) => this.Titile = title;

        public static List<UnitSettings> Values()
        {
            List<UnitSettings> values = new List<UnitSettings>
            {
                UNIT_SKIN
            };

            return values;
        }
    }
}
