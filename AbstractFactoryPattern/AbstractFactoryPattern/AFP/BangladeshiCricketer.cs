using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFP
{

    /// <summary>
    /// Item class for Bangladeshi Cricketer
    /// </summary>
    
    public class BangladeshiCricketer : ICricketer
    {
        #region ICricketer Members

        public string BattingStrength()
        {
            return "60%";
        }

        public string BowlingStrength()
        {
            return "70%";
        }

        public string AllroundingStrength()
        {
            return "85%";
        }

        public string IconPlayer()
        {
            return "Shakib Al Hasan";
        }

        #endregion
    }
}
