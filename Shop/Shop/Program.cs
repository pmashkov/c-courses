using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Nouts nout1 = new Nouts("pro", 150, "pro2", 6, 17, 3, "Asus");

            Console.WriteLine("Выбран наутбук: \n"+
                "\nМодель - " + nout1.model +
                "\nМонитор - " + nout1.monitor +
                "\nИмя производителя - " + nout1.companyName);
            Console.WriteLine("\n" + nout1.Show());

            Console.ReadKey();
        }
    }
}
