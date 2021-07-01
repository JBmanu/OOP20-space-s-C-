using OOP20_SpaceSurvival_CSharp.utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP20_SpaceSurvival_CSharp.gui.pause
{
    class LinksPause
    {
        public static readonly LinksPause START_BUTTON = new LinksPause("Start", LinkActionGUI.LINK_BACK);
        public static readonly LinksPause SOUND_BUTTON = new LinksPause("Settings", LinkActionGUI.LINK_SOUND);
        public static readonly LinksPause HELP_BUTTON = new LinksPause("Sound", LinkActionGUI.LINK_HELP);
        public static readonly LinksPause QUIT_BUTTON = new LinksPause("Help", LinkActionGUI.LINK_QUIT);

        public string Text { get; private set; }

        public LinkActionGUI Link { get; private set; }

        private LinksPause(string name, LinkActionGUI link) => (this.Text, this.Link) = (name, link);

        public static List<LinksPause> Values()
        {
            List<LinksPause> values = new List<LinksPause>
            {
                START_BUTTON,
                SOUND_BUTTON,
                HELP_BUTTON,
                QUIT_BUTTON
            };

            return values;
        }
    }
}
