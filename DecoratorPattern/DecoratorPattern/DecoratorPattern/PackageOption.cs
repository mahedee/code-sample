using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DecoratorPattern
{
    /// <summary>
    /// Decorator for concrete package option
    /// </summary>
    public abstract class PackageOption : CricketInstrument
    {
        double cost = 00;
        string instruments = "Abstract Package Option";

        public override double Cost
        {
            get { return cost; }
        }


        public override string Insturments
        {
            get { return instruments; }
        }

    }
}
