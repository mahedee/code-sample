using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// Special Package = Base Package (Bat, Ball) + 6 Stamps + 1 Pair - Gloves
    /// Developed by: Mahedee
    /// </summary>
    public class SpecialPackage : PackageOption
    {
        double cost = 500;
        string instruments = "Gloves - 1 Pair";
        CricketInstrument objCricketInstrument;

        public SpecialPackage(CricketInstrument objPCricketInstrument)
        {
            objCricketInstrument = objPCricketInstrument;
        }

        public override double Cost
        {
            get { return objCricketInstrument.Cost + cost; }
        }

        public override string Insturments
        {
            get { return objCricketInstrument.Insturments + ", " + instruments; }
        }

    }
}
