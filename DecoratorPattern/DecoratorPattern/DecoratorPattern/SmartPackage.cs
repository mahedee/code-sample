using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// Smart Package = Base Package (Bat, Ball) + 6 Stamps
    /// Developed by: Mahedee
    /// </summary>
    public class SmartPackage : PackageOption
    {
        double cost = 600;
        string instruments = "6 Stamps";
        CricketInstrument objCricketInstrument;

        public SmartPackage(CricketInstrument objPCricketInstrument)
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
