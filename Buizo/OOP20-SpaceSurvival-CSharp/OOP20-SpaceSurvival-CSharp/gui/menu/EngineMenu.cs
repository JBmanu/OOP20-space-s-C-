using OOP20_SpaceSurvival_CSharp.utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OOP20_SpaceSurvival_CSharp.gui.menu
{

    class EngineMenu : IEngineGUI
    {
        public static readonly Rectangle RECTANGLE = new Rectangle(0, 0, 500, 500);
        public static readonly string TITLE = "SPACE SURVIVAL";
        public static readonly int N_BUTTON = LinksMenu.Values().Count;

        private readonly LinkActionGUI MainAction;
        private readonly List<LinksMenu> LinkButtons;
        private string NamePlayer { get; set; }

        private Visibility Visibility;

        public EngineMenu()
        {
            this.MainAction = LinkActionGUI.LINK_MENU;
            this.LinkButtons = LinksMenu.Values();
            this.NamePlayer = "";

            this.Visibility = Visibility.HIDDEN;
        }
        
        public List<LinkActionGUI> GetLinks()
        {
            return this.LinkButtons.Select(btn => btn.Link).ToList();
        }

        public LinkActionGUI GetMainLink()
        {
            return this.MainAction;
        }

        public Rectangle GetRectangle()
        {
            return RECTANGLE;
        }

        public Visibility GetVisibility()
        {
            return this.Visibility;
        }

        public bool IsVisible()
        {
            return this.Visibility.State;
        }

        public void SetVisibility(Visibility state)
        {
            this.Visibility = state;
        }

        public String GetTitle()
        {
            return TITLE;
        }

        public List<String> GetListTextLinks()
        {
            return this.LinkButtons.Select(btn => btn.Name).ToList();
        }
    }
}
