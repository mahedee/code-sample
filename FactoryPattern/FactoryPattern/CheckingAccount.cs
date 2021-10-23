using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{

    /// <summary>
    /// Concrete class CheckingAccount
    /// </summary>
    public class CheckingAccount : IAccount
    {
        #region IAccount Members

        public string Withdraw(int amount)
        {
            throw new NotImplementedException();
        }

        public string Deposit(int amount)
        {
            throw new NotImplementedException();
        }

        public double InterestRate()
        {
            return 10.24;
        }

        #endregion
    }
}
