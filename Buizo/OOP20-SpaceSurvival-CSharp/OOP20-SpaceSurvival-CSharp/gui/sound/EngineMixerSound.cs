using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP20_SpaceSurvival_CSharp.gui.sound
{
    class EngineMixerSound
    {
        public List<TypeUnitSound> ListTypeUnitSound { get; set; }
        public Dictionary<TypeUnitSound, EngineUnitSound> MapUnit { get; set; }

        public EngineMixerSound(List<TypeUnitSound> unitSound)
        {
            this.ListTypeUnitSound = unitSound;
            this.MapUnit = new Dictionary<TypeUnitSound, EngineUnitSound>();
            
            foreach(TypeUnitSound unit in this.ListTypeUnitSound)
            {
                this.MapUnit.Add(unit, new EngineUnitSound());
            }
        }

        public int GetValueSound(TypeUnitSound type)
        {
            return this.MapUnit[type].ValueSound;
        }

        public void SetValueSound(TypeUnitSound type, int value)
        {
            this.MapUnit[type].ValueSound = value;
        }

        public StateSlider GetStateSound(TypeUnitSound type)
        {
            return this.MapUnit[type].StateSlider;
        }

        public void SetStateSound(TypeUnitSound type, StateSlider stateSlider)
        {
            this.MapUnit[type].StateSlider = stateSlider;
        }

        public void ChangeStateSound(TypeUnitSound type)
        {
            this.MapUnit[type].StateSlider = this.MapUnit[type].StateSlider == StateSlider.OFF 
                ? StateSlider.ON : StateSlider.OFF;
        }

        public bool IsActiveSound(TypeUnitSound type)
        {
            return this.MapUnit[type].isActive();
        }

        public List<string> GetTextUnitsSound()
        {
            return this.ListTypeUnitSound.Select(unit => unit.Type).ToList();
        }
    }
}
