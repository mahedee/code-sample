using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFP
{

    

    /// <summary>
    /// Concrete factory class for European Cricketer
    /// </summary>
    
    public class EuropeanCricketerFactory : ICricketerFactory
    {

        #region ICricketerFactory Members

        public ICricketer GetCricketer(CricketerBase cricketerBase)
        {
            ICricketer objICricketer = null;

            switch (cricketerBase)
            {
                case CricketerBase.EnglishCricketer:
                    objICricketer = new EnglishCricketer();
                    break;
                default:
                    break;
            }
            return objICricketer;
        }

        #endregion
    }
}
