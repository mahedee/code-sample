using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFP
{

    /// <summary>
    /// Item class for Pakistani Cricketer
    /// </summary>
    
    public class PakistaniCricketer : ICricketer
    {

        #region ICricketer Members

        public string BattingStrength()
        {
            return "75%";
        }

        public string BowlingStrength()
        {
            return "85%";
        }

        public string AllroundingStrength()
        {
            return "75%";
        }

        public string IconPlayer()
        {
            return "Shahid Afridi.";
        }

        #endregion
    }
}
