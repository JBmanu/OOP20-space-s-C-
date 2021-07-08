using System;

namespace Paganelli.model.sound.command.implementation
{
    public class StopSound : ICommandAudio
    {
        public void Execute(Sound sound)
        {
            sound.IsPlaying = false;
            Console.WriteLine("STOP_SOUND");
        }
    }
}