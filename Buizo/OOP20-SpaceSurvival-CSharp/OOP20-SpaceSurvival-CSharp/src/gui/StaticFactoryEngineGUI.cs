using OOP20_SpaceSurvival_CSharp.gui.help;
using OOP20_SpaceSurvival_CSharp.gui.menu;
using OOP20_SpaceSurvival_CSharp.gui.settings;
using OOP20_SpaceSurvival_CSharp.gui.sound;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP20_SpaceSurvival_CSharp.gui
{
    class StaticFactoryEngineGUI
    {
        public static EngineMenu CreateEngineMenu()
        {
            return new EngineMenu();
        }

        public static EngineSettings CreateEngineSettings()
        {
            return new EngineSettings();
        }

        public static EngineSound CreateEngineSound()
        {
            return new EngineSound();
        }

        public static EngineHelp CreateEngineHelp()
        {
            return new EngineHelp();
        }





    }
}
