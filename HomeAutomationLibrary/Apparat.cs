using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Flags] public enum Func
{
    None = 0,
    OnOff = 1<<0,
    Dimmer = 1<<1,
}

namespace HomeAutomationLibrary
{
    public class Apparat
    {
        #region Private
        private string navn_;
        private int port_;
        private string billede_;
        private Func funktionalitet_;
        #endregion
        #region Public Properties
        /// <summary>
        /// Name of the apparat
        /// </summary>
        public string Navn_ { get => navn_; set => navn_ = value; }
        /// <summary>
        /// The port which the apparat is connected to
        /// </summary>
        public int Port_ { get => port_; set => port_ = (value>0 && value<4 ? value : 0); }
        /// <summary>
        /// The picture for the apparat button
        /// </summary>
        public string Billede_ { get => billede_; set => billede_ = value; }
        /// <summary>
        /// The functionality of the apparat
        /// </summary>
        public Func Funktionalitet_ { get => funktionalitet_; set => funktionalitet_ = (value == Func.OnOff || value == Func.Dimmer ? value : Func.OnOff); }
        #endregion
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public Apparat()
        {
            Navn_ = "DummyApparat";
            Port_ = 1;
            Funktionalitet_ = Func.OnOff;
        }
        /// <summary>
        /// Parametrized constructor
        /// </summary>
        /// <param name="navn">The name of the apparat</param>
        /// <param name="port">The port of the apparat</param>
        /// <param name="func">The functionality of the apparat</param>
        public Apparat(string navn, int port, Func func)
        {
            Navn_ = navn;
            Port_ = port;
            Funktionalitet_ = func;
        }
        #endregion
    }
}
