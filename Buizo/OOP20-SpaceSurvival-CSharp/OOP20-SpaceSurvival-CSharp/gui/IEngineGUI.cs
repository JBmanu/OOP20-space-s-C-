using OOP20_SpaceSurvival_CSharp.utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace OOP20_SpaceSurvival_CSharp.gui
{
    interface IEngineGUI
    {
        LinkActionGUI GetMainLink();

        Rectangle GetRectangle();

        Visibility GetVisibility();

        List<LinkActionGUI> GetLinks();

        void SetVisibility(Visibility state);

        bool IsVisible();
    }
}
