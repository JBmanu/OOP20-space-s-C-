using NUnit.Framework;
using Paganelli.controller;
using Paganelli.model;
using Paganelli.model.sound.category;
using Paganelli.model.utility;

namespace Paganelli.test
{
    public class TestAudio
    {
        [Test]
        public void TestCallerAudio()
        {
            CallerAudio callerAudio = new CallerAudio(new SoundEffect(SoundPath.SHOOT));
            callerAudio.Execute(CommandAudioType.AUDIO_ON);
            Assert.IsTrue(callerAudio.GetSound().IsPlaying);
            callerAudio.Execute(CommandAudioType.AUDIO_OFF);
            Assert.IsFalse(callerAudio.GetSound().IsPlaying);
        }
    }

}