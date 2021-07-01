using System;
using System.Collections.Generic;
using System.Text;

namespace OOP20_SpaceSurvival_CSharp.gui.help
{
    class UnitsHelp
    {
        public static readonly UnitsHelp PANEL_MOVE = new UnitsHelp("Move");
        public static readonly UnitsHelp PANEL_SHOT = new UnitsHelp("Shot");
        public static readonly UnitsHelp PANEL_PAUSE = new UnitsHelp("Pause");

        public string Title { get; private set; }

        public UnitsHelp(string title) => this.Title = title;

        public static List<UnitsHelp> Values()
        {
            List<UnitsHelp> values = new List<UnitsHelp>
            {
                PANEL_MOVE,
                PANEL_SHOT,
                PANEL_PAUSE,
            };

            return values;
        }

    }
}
