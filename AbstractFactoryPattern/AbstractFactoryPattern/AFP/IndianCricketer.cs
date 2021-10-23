using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFP
{

    /// <summary>
    /// Item class for Indian Cricketer
    /// </summary>
    
    public class IndianCricketer : ICricketer
    {

        #region ICricketer Members

        public string BattingStrength()
        {
            return "85%";
        }

        public string BowlingStrength()
        {
            return "60%";
        }

        public string AllroundingStrength()
        {
            return "70%";
        }

        public string IconPlayer()
        {
            return "Shachin Tendulkar.";
        }

        #endregion
    }
}
