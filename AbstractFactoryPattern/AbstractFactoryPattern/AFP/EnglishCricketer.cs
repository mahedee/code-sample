using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFP
{

    /// <summary>
    /// Item class for English Cricketer
    /// </summary>
   
    public class EnglishCricketer : ICricketer
    {

        #region ICricketer Members

        public string BattingStrength()
        {
            return "75%";
        }

        public string BowlingStrength()
        {
            return "80%";
        }

        public string AllroundingStrength()
        {
            return "70%";
        }

        public string IconPlayer()
        {
            return "Kavin Pietersen";
        }

        #endregion
    }
}
