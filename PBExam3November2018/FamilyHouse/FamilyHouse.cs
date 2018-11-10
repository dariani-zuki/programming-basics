using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyHouse
{
    class FamilyHouse
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());

            double electricityBill = 0;

            for (int i = 0; i < months; i++)
            {
                electricityBill = electricityBill + double.Parse(Console.ReadLine());
            }

            double waterPrice = 20;
            double internetPrice = 15;
            double otherPrice = 0.20;

            double waterBill = months * waterPrice;
            double internetBill = months * internetPrice;

            double totalSum = electricityBill + waterBill + internetBill;
            double otherSum = totalSum + totalSum * otherPrice;
            totalSum += otherSum;
            double avgSum = totalSum / months;

            Console.WriteLine($"Electricity: {electricityBill:f2} lv \n" +
                $"Water: {waterBill:f2} lv \n" +
                $"Internet: {internetBill:f2} lv \n" +
                $"Other: {otherSum:f2} lv \n" +
                $"Average: {avgSum:f2} lv");

        }
    }
}
