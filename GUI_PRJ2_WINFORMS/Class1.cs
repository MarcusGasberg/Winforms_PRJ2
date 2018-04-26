using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Func
{
    None = 0,
    Kys = 1
}

namespace GUI_PRJ2_WINFORMS
{
    public class Class1
    {
        #region Private fuckers
        private string navn_;
        private int port_;
        private string billede_;
        private Func funktionalitet;
        #endregion
        #region Public Props
        public string Navn_ { get => navn_; set => navn_ = value; }
        public int Port_ { get => port_; set => port_ = value; }
        public string Billede_ { get => billede_; set => billede_ = value; }
        public Func Funktionalitet { get => funktionalitet; set => funktionalitet = value; }
        #endregion
    }
}
