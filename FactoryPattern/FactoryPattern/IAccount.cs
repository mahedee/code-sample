using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    public interface IAccount
    {
        string Withdraw(int amount);
        string Deposit(int amount);

        double InterestRate();
    }
}
