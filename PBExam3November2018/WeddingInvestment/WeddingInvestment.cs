using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingInvestment
{
    class WeddingInvestment
    {
        static void Main(string[] args)
        {
            string contractPeriod = Console.ReadLine();
            string contractType = Console.ReadLine();
            string isThereDesert = Console.ReadLine();

            int months = int.Parse(Console.ReadLine());

            double orderPrice = default(double);

            switch (contractPeriod)
            {
                case "one":
                    switch (contractType)
                    {
                        case "Small":
                            orderPrice = 9.98;
                            break;
                        case "Middle":
                            orderPrice = 18.99;
                            break;
                        case "Large":
                            orderPrice = 25.98;
                            break;
                        case "ExtraLarge":
                            orderPrice = 35.99;
                            break;
                    }
                    break;
                case "two":
                    switch (contractType)
                    {
                        case "Small":
                            orderPrice = 8.58;
                            break;
                        case "Middle":
                            orderPrice = 17.09;
                            break;
                        case "Large":
                            orderPrice = 23.59;
                            break;
                        case "ExtraLarge":
                            orderPrice = 31.79;
                            break;
                    }
                    break;
            }

            if (isThereDesert.Equals("yes"))
            {
                if (orderPrice <= 10)
                {
                    orderPrice += 5.50;
                }
                else if (orderPrice <= 30)
                {
                    orderPrice += 4.35;
                }
                else if (orderPrice > 30)
                {
                    orderPrice += 3.85;
                }
            }

            double totalSum = orderPrice * months;

            if (contractPeriod == "two")
            {
                totalSum = totalSum - totalSum * 0.0375;
            }

            Console.WriteLine($"{totalSum:f2} lv.");
        }
    }
}

