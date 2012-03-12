using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace DataTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2012,03, 12, 22, 40 ,33);
            DateTime date2 = new DateTime();

            date2 = DateTime.Now;

            Console.WriteLine(date1.ToString("F"));
            Console.WriteLine(date1.ToString());
            Console.WriteLine(date1.ToString("D"));
            Console.WriteLine(date1.ToString(CultureInfo.CreateSpecificCulture("fr-FR")));
            Console.WriteLine(date1.ToString("F", new CultureInfo("fr-FR")));
            Console.WriteLine();
            Console.WriteLine(date2.ToString());
            
            Console.ReadKey();
        }
    }
}
