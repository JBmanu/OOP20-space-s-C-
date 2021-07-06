using NUnit.Framework;

using OOP20_SpaceSurvival_CSharp.gui.sound;
using OOP20_SpaceSurvival_CSharp.gui;

namespace Test.Properties
{
    public class Tests
    {

        [Test]
        public void ControlEngineSoundFields()
        {
            EngineSound sound = new EngineSound();

            Assert.AreEqual(sound.GetTitle(), "SOUND");
            Assert.AreEqual(sound.GetVisibility(), Visibility.HIDDEN);
        }

        [Test]
        public void CheckValueSound()
        {
            EngineSound sound = new EngineSound();

            Assert.AreEqual(sound.GetValueUnitSound(TypeUnitSound.SLIDER_BACKGROUND), 50);
            Assert.AreEqual(sound.GetValueUnitSound(TypeUnitSound.SLIDER_EFFECT), 50);
        }

        [Test]
        public void CheckChangeValueSoundOfType()
        {
            EngineSound sound = new EngineSound();

            Assert.AreEqual(sound.GetValueUnitSound(TypeUnitSound.SLIDER_BACKGROUND), 50);
            Assert.AreEqual(sound.GetValueUnitSound(TypeUnitSound.SLIDER_EFFECT), 50);

            sound.SetValueUnitSound(TypeUnitSound.SLIDER_BACKGROUND, 100);
            sound.SetValueUnitSound(TypeUnitSound.SLIDER_EFFECT, 100);

            Assert.AreEqual(sound.GetValueUnitSound(TypeUnitSound.SLIDER_BACKGROUND), 100);
            Assert.AreEqual(sound.GetValueUnitSound(TypeUnitSound.SLIDER_EFFECT), 100);
        }

        [Test]
        public void CheckChangeStateSoundOfType()
        {
            EngineSound sound = new EngineSound();

            Assert.AreEqual(sound.GetStateUnitSound(TypeUnitSound.SLIDER_BACKGROUND), StateSlider.ON);
            Assert.AreEqual(sound.GetStateUnitSound(TypeUnitSound.SLIDER_EFFECT), StateSlider.ON);

            sound.SetStateUnitSound(TypeUnitSound.SLIDER_BACKGROUND, StateSlider.OFF);
            sound.SetStateUnitSound(TypeUnitSound.SLIDER_EFFECT, StateSlider.OFF);

            Assert.AreEqual(sound.GetStateUnitSound(TypeUnitSound.SLIDER_BACKGROUND), StateSlider.OFF);
            Assert.AreEqual(sound.GetStateUnitSound(TypeUnitSound.SLIDER_EFFECT), StateSlider.OFF);
        }

    }
}
