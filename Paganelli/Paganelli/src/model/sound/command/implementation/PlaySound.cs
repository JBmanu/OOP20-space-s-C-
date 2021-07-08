using System;

namespace Paganelli.model.sound.command.implementation
{
    public class PlaySound : ICommandAudio
    {
        public void Execute(Sound sound)
        {
            sound.IsPlaying = true;
            Console.WriteLine("PLAY_SOUND");
        }
    }
}