using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFP
{

    /// <summary>
    /// Client Class
    /// </summary>
    
    class Program
    {
        static void Main(string[] args)
        {
            AsianCricketerFactory objAsianFactory = new AsianCricketerFactory();
            ICricketer objIAsianCricketer = objAsianFactory.GetCricketer(CricketerBase.BangladeshiCricketer);
            Console.WriteLine("Bangladesh Cricket Team\nBatting Strength:" + objIAsianCricketer.BattingStrength());
            Console.WriteLine("Bowling Strength:" + objIAsianCricketer.BowlingStrength());
            Console.WriteLine("Allrounding Strength:" + objIAsianCricketer.AllroundingStrength());
            Console.WriteLine("Icon Player:" + objIAsianCricketer.IconPlayer());

            Console.WriteLine();

            EuropeanCricketerFactory objEuropeanFactory = new EuropeanCricketerFactory();
            ICricketer objIEuropeanCricketer = objEuropeanFactory.GetCricketer(CricketerBase.EnglishCricketer);
            Console.WriteLine("England Cricket Team\nBatting Strength:" + objIEuropeanCricketer.BattingStrength());

            Console.WriteLine("Bowling Strength:" + objIEuropeanCricketer.BowlingStrength());
            Console.WriteLine("Allrounding Strength:" + objIEuropeanCricketer.AllroundingStrength());
            Console.WriteLine("Icon Player:" + objIEuropeanCricketer.IconPlayer());


            Console.ReadLine();


        }
    }
}
