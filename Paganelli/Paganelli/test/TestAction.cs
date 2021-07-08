using NUnit.Framework;
using Paganelli.controller;
using Paganelli.model.utility;

namespace Paganelli.test
{
    public class TestAction
    {
        [Test]
        public void TestCallerCommandShip()
        {
            SpaceShip ship = new SpaceShip();
            CallerCommandShip callerShip = new CallerCommandShip(ship);
            callerShip.Execute(CommandKey.KEY_W_PRESSED);
            callerShip.Execute(CommandKey.KEY_UP_PRESSED);
            callerShip.Execute(CommandKey.KEY_SPACE_BAR);
            Assert.AreEqual(2, ship.Aceleration);
            callerShip.Execute(CommandKey.KEY_W_RELEASED);
            callerShip.Execute(CommandKey.KEY_UP_RELEASED);
            callerShip.Execute(CommandKey.KEY_W_RELEASED);
            callerShip.Execute(CommandKey.KEY_UP_RELEASED);
            callerShip.Execute(CommandKey.KEY_SPACE_BAR);
            Assert.AreEqual(0, ship.Aceleration);
            callerShip.Execute(CommandKey.KEY_W_RELEASED);
            callerShip.Execute(CommandKey.KEY_UP_RELEASED);
            Assert.AreEqual(0, ship.Aceleration);
        }

}

}