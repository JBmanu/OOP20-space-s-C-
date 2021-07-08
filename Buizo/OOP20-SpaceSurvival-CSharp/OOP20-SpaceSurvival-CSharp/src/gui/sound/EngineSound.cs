using OOP20_SpaceSurvival_CSharp.utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace OOP20_SpaceSurvival_CSharp.gui.sound
{
    public class EngineSound : IEngineGUI
    {
        public static readonly Rectangle RECTANGLE = new Rectangle(0, 0, 500, 500);
        public static readonly string TITLE = "SOUND";
        public static readonly int N_UNIT_SOUND = TypeUnitSound.Values().Count;

        private readonly LinkActionGUI MainAction;
        private readonly LinkActionGUI ActionBack;
        private readonly EngineMixerSound MixerSound;
        private Visibility Visibility;

        public EngineSound()
        {
            this.MainAction = LinkActionGUI.LINK_SOUND;
            this.ActionBack = LinkActionGUI.LINK_BACK;
            this.MixerSound = new EngineMixerSound(TypeUnitSound.Values());

            this.Visibility = Visibility.HIDDEN;
        }

        public List<LinkActionGUI> GetLinks()
        {
            return new List<LinkActionGUI>() { ActionBack };
        }

        public LinkActionGUI GetMainLink()
        {
            return this.MainAction;
        }

        public Rectangle GetRectangle()
        {
            return RECTANGLE;
        }

        public Visibility GetVisibility()
        {
            return this.Visibility;
        }

        public bool IsVisible()
        {
            return this.Visibility.State;
        }

        public void SetVisibility(Visibility state)
        {
            this.Visibility = state;
        }

        public String GetTitle()
        {
            return TITLE;
        }

        public LinkActionGUI GetBackLink()
        {
            return this.ActionBack;
        }

        public string GetTextBtnBack()
        {
            return this.ActionBack.Name;
        }

        public List<string> GetListTextSlider()
        {
            return this.MixerSound.GetTextUnitsSound();
        }

        public List<TypeUnitSound> GetListTypeUnitSound()
        {
            return this.MixerSound.ListTypeUnitSound;
        }

        public int GetValueUnitSound(TypeUnitSound type)
        {
            return this.MixerSound.GetValueSound(type);
        }

        public void SetValueUnitSound(TypeUnitSound type, int value)
        {
            this.MixerSound.SetValueSound(type, value);
        }

        public StateSlider GetStateUnitSound(TypeUnitSound type)
        {
            return this.MixerSound.GetStateSound(type);
        }

        public void SetStateUnitSound(TypeUnitSound type, StateSlider stateUnitSound)
        {
            this.MixerSound.SetStateSound(type, stateUnitSound);
        }

        public bool IsActiveUnitSound(TypeUnitSound type)
        {
            return this.MixerSound.IsActiveSound(type);
        }
        public void ChangeStateUnitSound(TypeUnitSound type)
        {
            this.MixerSound.ChangeStateSound(type);
        }

    }
}
