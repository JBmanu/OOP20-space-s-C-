using System;
using System.Collections.Generic;
using System.Text;

namespace OOP20_SpaceSurvival_CSharp.gui
{
    public class Visibility
    {
        public static readonly Visibility VISIBLE = new Visibility(true);
        public static readonly Visibility HIDDEN = new Visibility(false);

        public bool State { get; private set; }

        private Visibility(bool state) => this.State = state;

        public static IEnumerable<Visibility> Values
        {
            get
            {
                yield return VISIBLE;
                yield return HIDDEN;
            }
        }
    }
}
