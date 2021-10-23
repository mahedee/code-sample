using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// Factory class to create object
    /// </summary>
    public static class Factory
    {
        public static IAccount CreateObject(FactoryObject factoryObject)
        {
            IAccount objIAccount = null;

            switch (factoryObject)
            {
                case FactoryObject.SavingAccount:
                    objIAccount = new SavingsAccount();
                    break;

                case FactoryObject.CheckingAccount:
                    objIAccount = new CheckingAccount();
                    break;

                default:
                    break;
            }

            return objIAccount;
        }
    }
}
