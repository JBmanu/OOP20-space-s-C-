using System.Collections.Generic;

namespace Paganelli.model.utility
{
        /**
         * 
         * Enum for multiple commands audio.
         *
         */
        public class CommandAudioType
         {
         /** 
         * Type of command to pass to the CallerAudio to start sound.
         */
         public static CommandAudioType AUDIO_ON = new CommandAudioType("AUDIO_ON");
            
         /**
         * Type of command to pass to the CallerAudio to stop sound.
         */
         public static CommandAudioType AUDIO_OFF = new CommandAudioType("AUDIO_OFF");
            
         /**
         * Type of command to pass to the CallerAudio to reset the timing of the sound.
         */
         public static CommandAudioType RESET_TIMING = new CommandAudioType("RESET_TIMING");

         private readonly string String;

         CommandAudioType(string String) {
            this.String = String;
         }

        /**
        * Type of command to pass to the CallerAudio to reset the timing of the sound.
        * 
        * @return the string representing the command
        */
         public string getValue() {
             return this.String;
         }
       
        /**
        * Return all the values.
        * 
        * @return a list of CommandAudioType values
        */
        public List<CommandAudioType> Values()
        {
            List<CommandAudioType> list = new List<CommandAudioType>()
            {
                AUDIO_ON,
                AUDIO_OFF,
                RESET_TIMING
            };
            return list;
        }
        
    }

    
}