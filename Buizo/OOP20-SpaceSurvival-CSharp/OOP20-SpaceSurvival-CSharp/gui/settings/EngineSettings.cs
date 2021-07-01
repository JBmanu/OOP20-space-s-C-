using OOP20_SpaceSurvival_CSharp.utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OOP20_SpaceSurvival_CSharp.gui.settings
{
    class EngineSettings : IEngineGUI
    {
        public static readonly Rectangle RECTANGLE = new Rectangle(0, 0, 500, 500);
        public static readonly string TITLE = "SETTINGS";

        public static readonly string DIR_SX = "<";

        public static readonly string DIR_DX = ">";

        public static readonly int INDEX_INIT_SKIN = 0;

        public static readonly int STEP_INDEX_SKIN = 1;

        private readonly LinkActionGUI MainAction;
        private readonly LinkActionGUI ActionBack;

        private readonly List<UnitSettings> UnitsSettings;
        private readonly List<SkinShip> ListSkin;

        private int chooseSkin;

        private Visibility Visibility;

        public EngineSettings()
        {
            this.MainAction = LinkActionGUI.LINK_SETTING;
            this.ActionBack = LinkActionGUI.LINK_BACK;

            this.UnitsSettings = UnitSettings.Values();
            this.ListSkin = SkinShip.Values();
            

            this.chooseSkin = INDEX_INIT_SKIN;
            //
            //this.skin = new EngineImage(ScaleOf.ICON_SKIN, (int)RECTANGLE.getWidth(), this.listSkin.get(chooseSkin).getSkin());
        }

        public List<LinkActionGUI> GetLinks()
        {
            return new List<LinkActionGUI>() { this.ActionBack };
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

        public List<string> GetListTextUnit()
        {
            return this.UnitsSettings.Select(unit => unit.Titile).ToList();
        }

        public string GetTextBtnBack()
        {
            return this.ActionBack.Name;
        }

        public SkinShip GetSkinShip()
        {
            return this.ListSkin[this.chooseSkin];
        }

        public void changeSkinDx()
        {
            this.chooseSkin = this.chooseSkin + STEP_INDEX_SKIN < SkinShip.Values().Count()
                    ? this.chooseSkin + STEP_INDEX_SKIN : INDEX_INIT_SKIN;
        }
        public void changeSkinSx()
        {
            this.chooseSkin = this.chooseSkin - STEP_INDEX_SKIN >= INDEX_INIT_SKIN
                    ? this.chooseSkin - STEP_INDEX_SKIN : SkinShip.Values().Count() - STEP_INDEX_SKIN;
        }
    }
}
