using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Create object by factory pattern
            IAccount objSavingAccount = Factory.CreateObject(FactoryObject.SavingAccount);
            IAccount objCheckingAccount = Factory.CreateObject(FactoryObject.CheckingAccount);

            //Access object
            Console.WriteLine("Saving Account Interest Rate: " + objSavingAccount.InterestRate());
            Console.WriteLine("Checking Account Interest Rate: " + objCheckingAccount.InterestRate());


            Console.ReadLine();
            
        }
    }
}
