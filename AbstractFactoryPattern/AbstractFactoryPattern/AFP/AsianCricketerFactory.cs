using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFP
{

    /// <summary>
    /// Concrete factory class for Asian Cricketer
    /// </summary>
    
    public class AsianCricketerFactory : ICricketerFactory
    {

        #region ICricketerFactory Members

        public ICricketer GetCricketer(CricketerBase cricketerBase)
        {
            ICricketer objICricketer = null;

            switch (cricketerBase)
            {
                case CricketerBase.BangladeshiCricketer:
                    objICricketer = new BangladeshiCricketer();
                    break;
                case CricketerBase.IndianCricketer:
                    objICricketer = new IndianCricketer();
                    break;
                default:
                    break;
            }
            return objICricketer;
        }

        #endregion
    }
}
