using OOP20_SpaceSurvival_CSharp.utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP20_SpaceSurvival_CSharp.gui.menu
{
    class LinksMenu
    {
        public static readonly LinksMenu START_BUTTON = new LinksMenu("Start", LinkActionGUI.LINK_MENU);
        public static readonly LinksMenu SETTINGS_BUTTON = new LinksMenu("Settings", LinkActionGUI.LINK_SETTING);
        public static readonly LinksMenu SOUND_BUTTON = new LinksMenu("Sound", LinkActionGUI.LINK_SOUND);
        public static readonly LinksMenu HELP_BUTTON = new LinksMenu("Help", LinkActionGUI.LINK_HELP);
        public static readonly LinksMenu QUIT_BUTTON = new LinksMenu("Quit", LinkActionGUI.LINK_QUIT);

        public string Name { get; private set; }
        public LinkActionGUI Link { get; private set; }

        private LinksMenu(string name, LinkActionGUI link) => (this.Name, this.Link) = (name, link);

        public static List<LinksMenu> Values()
        {
            List<LinksMenu> values = new List<LinksMenu>
            {
                START_BUTTON,
                SETTINGS_BUTTON,
                SOUND_BUTTON,
                HELP_BUTTON,
                QUIT_BUTTON
            };

            return values;
        }
    }
}
