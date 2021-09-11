using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// Concrete class SavingsAccount
    /// </summary>
    public class SavingsAccount : IAccount
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
            return 12.5;
        }

        #endregion
    }
}
