using NUnit.Framework;
using OOP20_SpaceSurvival_CSharp.gui.menu;
using OOP20_SpaceSurvival_CSharp.gui.sound;
using OOP20_SpaceSurvival_CSharp.gui;
using System.Linq;

namespace Test
{
    public class Tests
    {

        [Test]
        public void ControlEngineMenuFields()
        {
            EngineMenu menu = new EngineMenu();

            Assert.AreEqual(menu.GetTitle(), "SPACE SURVIVAL");
            Assert.AreEqual(menu.GetVisibility(), Visibility.HIDDEN);
            Assert.AreEqual(menu.NamePlayer, "");
        }


        [Test]
        public void CheckLinkOfEngineMenu()
        {
            EngineMenu menu = new EngineMenu();

            Assert.AreEqual(menu.GetListTextLinks(), LinksMenu.Values().Select(link => link.Name));
            
        }

    }
}