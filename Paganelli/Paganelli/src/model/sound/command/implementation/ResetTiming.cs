using System;
using Paganelli.model.sound;
using Paganelli.model.sound.command;

namespace Paganelli.model.sound.command.implementation
{
    public class ResetTiming : ICommandAudio
    {
        public void Execute(Sound sound)
        {
            Console.WriteLine("RESET_TIMING");
        }
    }
}