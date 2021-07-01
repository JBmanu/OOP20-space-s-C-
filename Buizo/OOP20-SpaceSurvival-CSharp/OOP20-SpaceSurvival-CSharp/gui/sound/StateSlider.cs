using System;
using System.Collections.Generic;
using System.Text;

namespace OOP20_SpaceSurvival_CSharp.gui.sound
{
    class StateSlider
    {
        public static readonly StateSlider ON = new StateSlider(true);
        public static readonly StateSlider OFF = new StateSlider(false);

        public bool State { get; private set; }

        private StateSlider(bool state) => this.State = state;

        public static List<StateSlider> Values()
        {
            List<StateSlider> values = new List<StateSlider>
            {
                ON,
                OFF
            };

            return values;
        }
    }
}
