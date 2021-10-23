using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFP
{
    /// <summary>
    /// A Factory interface
    /// </summary>
    public interface ICricketerFactory
    {
        ICricketer GetCricketer(CricketerBase cricketerBase); 
    }
}
