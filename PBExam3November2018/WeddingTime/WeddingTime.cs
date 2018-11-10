using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingTime
{
    class WeddingTime
    {
        static void Main(string[] args)
        {
            double wiskeyPrice = double.Parse(Console.ReadLine());
            double water = double.Parse(Console.ReadLine());
            double wine = double.Parse(Console.ReadLine());
            double champagne = double.Parse(Console.ReadLine());
            double wiskey = double.Parse(Console.ReadLine());

            double champagnePrice = wiskeyPrice * 0.50;
            double winePrice = champagnePrice - champagnePrice * 0.60;
            double waterPrice = champagnePrice - champagnePrice * 0.90;

            double totalSum = wiskey * wiskeyPrice + wine * winePrice + champagne * champagnePrice + water * waterPrice;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
