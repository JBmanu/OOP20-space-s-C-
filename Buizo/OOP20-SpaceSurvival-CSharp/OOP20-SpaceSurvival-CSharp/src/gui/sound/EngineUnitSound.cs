using System;
using System.Collections.Generic;
using System.Text;

namespace OOP20_SpaceSurvival_CSharp.gui.sound
{
    public class EngineUnitSound
    {
        public int ValueSound { get; set; }

        public StateSlider StateSlider { get; set; }

        public EngineUnitSound()
        {
            this.ValueSound = 50;
            this.StateSlider = StateSlider.ON;
        }

        public bool IsActive()
        {
            return this.StateSlider.State;
        }
    }
}
