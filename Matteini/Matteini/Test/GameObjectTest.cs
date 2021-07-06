using Matteini.gameObject.fireableObject;
using Matteini.gameObject.fireableObject.firinglogic.implementation;
using Matteini.gameObject.fireableObject.weapon;
using Matteini.gameObject.mainObject;
using Matteini.gameObject.moveableObject.movement.implementation;
using Matteini.gameObject.utils;
using NUnit.Framework;

namespace Matteini.Test
{
    public class Tests
    {
        private const int Shoots = 20;
        private FireableObject _gameObject;
        private Weapon _weapon;

        [SetUp]
        public void Setup()
        {
            _gameObject = new FireableObject(new EngineImage(), new P2d(), new RectBoundingBox(new AffineTransform()),
                null, new V2d(), 0, new FixedMovementLogic(), new P2d(),
                50, 70, 20, new Weapon(), new BossFiringLogic());
            _weapon = new Weapon(_gameObject);
        }

        [Test]
        public void TestGameObject()
        {
            Assert.AreEqual(null, _gameObject.EventComponent);
            Assert.AreEqual(0, _gameObject.Acceleration);
            Assert.AreEqual(50, _gameObject.Life);
            Assert.AreEqual(70, _gameObject.ImpactDamage);
            Assert.AreEqual(20,_gameObject.Score);
            Assert.AreEqual(Status.Normal, _gameObject.Status);
        }
        
        [Test]
        public void TestWeapon()
        {
            for (int i = 0; i < Shoots; i++)
            {
                _weapon.Shoot();
            }
            Assert.AreEqual(20, _weapon.ShootedBullets.Count);
            Assert.AreEqual(AmmoType.Normal, _weapon.AmmoType);
            _weapon.SetAmmoType(AmmoType.Fire);
            Assert.AreEqual(AmmoType.Fire, _weapon.AmmoType);
        }
    }
}