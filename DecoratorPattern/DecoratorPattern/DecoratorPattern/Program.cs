using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Base Insturment class

            CricketInstrument objCricketInstruments = new BasePackage();
            Console.WriteLine("::Base Package::");
            Console.WriteLine(objCricketInstruments.Insturments);
            Console.WriteLine("Instrument's Cost: " + objCricketInstruments.Cost);

            Console.WriteLine();

            //Smart Package
            objCricketInstruments = new SmartPackage(objCricketInstruments);
            Console.WriteLine("::Smart Package::");
            Console.WriteLine(objCricketInstruments.Insturments);
            Console.WriteLine("Instrument's Cost: " + objCricketInstruments.Cost);

            Console.WriteLine();

            //Special Package
            objCricketInstruments = new SpecialPackage(objCricketInstruments);
            Console.WriteLine("::Special Package::");
            Console.WriteLine(objCricketInstruments.Insturments);
            Console.WriteLine("Instrument's Cost: " + objCricketInstruments.Cost);

            Console.ReadLine();


        }
    }
}
