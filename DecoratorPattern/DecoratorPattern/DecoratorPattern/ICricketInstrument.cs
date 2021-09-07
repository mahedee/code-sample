using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// Interface for Cricket Instrument
    /// Developed by: Mahedee
    /// </summary>
    public interface ICricketInstrument
    {
        double Cost { get; }
        string Insturments { get; }
    }
}
