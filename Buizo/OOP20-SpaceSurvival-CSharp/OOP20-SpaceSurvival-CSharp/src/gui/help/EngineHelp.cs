using OOP20_SpaceSurvival_CSharp.utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OOP20_SpaceSurvival_CSharp.gui.help
{
    class EngineHelp : IEngineGUI
    {
        public static readonly Rectangle RECTANGLE = new Rectangle(0, 0, 500, 500);
        public static readonly String TITLE = "HELP";
        public static readonly int N_UNIT = UnitsHelp.Values().Count;

        private readonly LinkActionGUI MainAction;
        private readonly LinkActionGUI ActionBack;

        private readonly List<UnitsHelp> ListUnitHelp;
        private readonly List<string> BtnText;

        private Visibility Visibility;

        public EngineHelp()
        {
            this.MainAction = LinkActionGUI.LINK_HELP;
            this.ActionBack = LinkActionGUI.LINK_BACK;
            this.ListUnitHelp = UnitsHelp.Values();
            this.BtnText = new List<string>() { ActionBack.Name };
            this.Visibility = Visibility.HIDDEN;
        }

        public List<LinkActionGUI> GetLinks()
        {
            return new List<LinkActionGUI>() { ActionBack };
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

        public LinkActionGUI GetBackLink()
        {
            return this.ActionBack;
        }

        public List<string> GetListTitleOfUnitsHelp()
        {
            return this.ListUnitHelp.Select(unit => unit.Title).ToList();
        }

        public List<string> GetListTextButtons()
        {
            return this.BtnText;
        }
    }
}
