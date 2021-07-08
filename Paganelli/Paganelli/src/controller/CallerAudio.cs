using System;
using Paganelli.model;
using Paganelli.model.sound;
using Paganelli.model.sound.command;
using Paganelli.model.sound.command.implementation;
using Paganelli.model.utility;

namespace Paganelli.controller
{
    public class CallerAudio
    {

            private readonly ICommandAudio _cmdAudioOn;
            private readonly ICommandAudio _cmdAudioOff;
            private readonly ICommandAudio _cmdResetTiming;
            private Sound _sound;
        
            /** 
             * Constructor for CallerAudio, initialize a new CallerAudio setting the passed sound.
             * 
             * @param sound the sound that will be set on this caller.
             */
            public CallerAudio(Sound sound) {
                this._cmdAudioOn = new PlaySound();
                this._cmdAudioOff = new StopSound();
                this._cmdResetTiming = new ResetTiming();
                this._sound = sound;
            }
        
            /** 
             * Get the current sound.
             * 
             * @return the current sound of this caller.
             */
            public Sound GetSound() {
                return this._sound;
            }
        
            /** 
             * Set sound to the caller.
             * 
             * @param sound the sound that will be set on this caller.
             */
            public void SetSound(Sound sound) {
                this._sound = _sound;
            }

            /** 
             * Change the volume of the current sound.
             * 
             * @param currentVolume the volume that will be set on the current sound.
             */
            public void ChangeVolume(double currentVolume)
            {
                double parsedVolume = currentVolume / 100;
                //this._sound.setVolume(parsedVolume);
            }

            /** 
             * Read the passed command and execute the command on the specified concrete command. 
             * 
             * @param cmd the command to execute
             */
            public void Execute(CommandAudioType cmd) {
                if (cmd.Equals(CommandAudioType.AUDIO_ON))
                {
                   _cmdAudioOn.Execute(this._sound);
                }
                else if (cmd.Equals(CommandAudioType.AUDIO_OFF))
                {
                    _cmdAudioOff.Execute(this._sound);
                }
                else if (cmd.Equals(CommandAudioType.RESET_TIMING))
                {
                    _cmdResetTiming.Execute(this._sound);
                }
            }
        
            /** 
             * Returns a string that specifies the possible commands this caller can execute.
             * @return return the string
             */
            public override string ToString() {
                return "CallerAudio{" 
                        + "CommandAudio= cmdAudioOn, cmdAudioOff, cmdResetTiming" + "}";
            }
        }

    
}