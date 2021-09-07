using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// Base type or decorator for concrete cricket instrument package.
    /// Developed by: Mahedee
    /// </summary>
    public abstract class CricketInstrument : ICricketInstrument
    {
        private double cost = 00;
        private string instrument = "Cricket Instruments: ";

        #region ICricketInstrument Members

        public virtual double Cost
        {
            get { return cost; }
        }

        public virtual string Insturments
        {
            get { return instrument; }
        }

        #endregion
    }
}
