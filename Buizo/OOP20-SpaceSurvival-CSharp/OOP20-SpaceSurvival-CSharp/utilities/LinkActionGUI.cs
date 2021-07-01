using System;
using System.Collections.Generic;
using System.Text;

namespace OOP20_SpaceSurvival_CSharp.utilities
{
    class LinkActionGUI
    {
        public static readonly LinkActionGUI LINK_MENU = new LinkActionGUI("Menu");
        public static readonly LinkActionGUI LINK_GAME = new LinkActionGUI("Game");
        public static readonly LinkActionGUI LINK_SETTING = new LinkActionGUI("Setting");
        public static readonly LinkActionGUI LINK_SCOREBOARD = new LinkActionGUI("Scoreboard");
        public static readonly LinkActionGUI LINK_SOUND = new LinkActionGUI("Sound");
        public static readonly LinkActionGUI LINK_HELP = new LinkActionGUI("Help");
        public static readonly LinkActionGUI LINK_QUIT = new LinkActionGUI("Quit");
        public static readonly LinkActionGUI LINK_PAUSE = new LinkActionGUI("Pause");
        public static readonly LinkActionGUI LINK_LOADING = new LinkActionGUI("Loading");
        public static readonly LinkActionGUI LINK_BACK = new LinkActionGUI("Back");
        public static readonly LinkActionGUI LINK_DEAD = new LinkActionGUI("Dead");

        internal object Select(Func<object, object> p)
        {
            throw new NotImplementedException();
        }

        public string Name { get; private set;  }
        private LinkActionGUI(String name) => this.Name = name;

        public static List<LinkActionGUI> Values()
        {
            List<LinkActionGUI> values = new List<LinkActionGUI>
            {
                LINK_MENU,
                LINK_GAME,
                LINK_SETTING,
                LINK_SCOREBOARD,
                LINK_SOUND,
                LINK_HELP,
                LINK_QUIT,
                LINK_PAUSE,
                LINK_LOADING,
                LINK_BACK,
                LINK_DEAD
            };

            return values;
        }


       
    }
}
