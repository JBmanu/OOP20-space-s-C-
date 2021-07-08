using OOP20_SpaceSurvival_CSharp.utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OOP20_SpaceSurvival_CSharp.gui.pause
{
    class EnginePause : IEngineGUI
    {
        public static readonly Rectangle RECTANGLE = new Rectangle(0, 0, 500, 500);
        public static readonly String TITLE = "PAUSE";
        public static readonly int N_BUTTON = LinksPause.Values().Count;

        private readonly LinkActionGUI MainAction;
        private readonly List<LinksPause> LinkButtons;

        private Visibility Visibility;

        public EnginePause()
        {
            this.MainAction = LinkActionGUI.LINK_MENU;
            this.LinkButtons = LinksPause.Values();

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

        public string GetTitle()
        {
            return TITLE;
        }

        public List<string> GetListText()
        {
            return this.LinkButtons.Select(btn => btn.Text).ToList();
        }
    }
}
