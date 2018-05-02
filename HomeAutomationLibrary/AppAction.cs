using HomeAutomationLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_PRJ2_WINFORMS
{
    public class AppAction
    {
        private bool onOffIsSelected_;
        private bool dimmerIsSelected_;
        /// <summary>
        /// Bool to set if dimmer is selected
        /// </summary>
        public bool DimmerIsSelected { get => dimmerIsSelected_; set => dimmerIsSelected_ = value;}

        public bool OnOffIsSelected{ get => onOffIsSelected_; set => onOffIsSelected_ = value; }



        public AppAction(Apparat selected)
        {
            if ((selected.Functionality_ & Func.OnOff) == Func.OnOff)
            {
                onOffIsSelected_ = true;
            }
            if((selected.Functionality_ & Func.Dimmer) == Func.Dimmer)
            {
                dimmerIsSelected_ = true;
            }
        }

    }
}
