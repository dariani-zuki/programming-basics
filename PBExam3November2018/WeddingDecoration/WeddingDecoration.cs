using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingDecoration
{
    class WeddingDecoration
    {
        static void Main(string[] args)
        {
            double ballonsPrice = 0.1;
            double flowersPrice = 1.5;
            double candlesPrice = 0.5;
            double ribbonPrice = 2;

            double budget = double.Parse(Console.ReadLine());

            int balloons = default(int);
            int flowers = default(int);
            int candles = default(int);
            int ribbon = default(int);

            string command = String.Empty;

            int quantity = default(int);

            double totalPrice = default(int);

            while (budget > 0)
            {
                command = Console.ReadLine();
                if (command == "stop")
                {
                    break;
                }
                quantity = int.Parse(Console.ReadLine());
                switch (command)
                {
                    case "balloons":
                        balloons += quantity;
                        budget = budget - quantity * ballonsPrice;
                        break;
                    case "flowers":
                        flowers += quantity;
                        budget = budget - quantity * flowersPrice;
                        break;
                    case "candles":
                        candles += quantity;
                        budget = budget - quantity * candlesPrice;
                        break;
                    case "ribbon":
                        ribbon += quantity;
                        budget = budget - quantity * ribbonPrice;
                        break;

                    default:
                        break;
                }
                if (command == "stop")
                {
                    break;
                }
            }

            totalPrice = balloons * ballonsPrice + flowers * flowersPrice + candles * candlesPrice + ribbon * ribbonPrice;

            if (command == "stop")
            {
                Console.WriteLine($"Spend money: {totalPrice:f2}");
                Console.WriteLine($"Money left: {(budget):f2}");
                Console.WriteLine($"Purchased decoration is {balloons} balloons, {ribbon} m ribbon, {flowers} flowers and {candles} candles.");
            }
            else
            {
                Console.WriteLine("All money is spent!");
                Console.WriteLine($"Purchased decoration is {balloons} balloons, {ribbon} m ribbon, {flowers} flowers and {candles} candles.");
            }

        }

    }
}

