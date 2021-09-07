using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// Base Cricket Insturment Package
    /// </summary>
    public class BasePackage : CricketInstrument
    {
        double cost = 1500;
        string instruments = "Ball and Bat";

        public override double Cost
        {
            get { return cost; }
        }

        public override string Insturments
        {
            get { return base.Insturments + instruments; }
        }

    }
}
