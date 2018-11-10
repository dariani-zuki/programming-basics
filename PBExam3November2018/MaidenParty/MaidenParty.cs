using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaidenParty
{
    class MaidenParty
    {
        static void Main(string[] args)
        {
            double maidenPartyPrice = double.Parse(Console.ReadLine());
            int loveLetters = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int keychains = int.Parse(Console.ReadLine());
            int cartoons = int.Parse(Console.ReadLine());
            int luckSurpises = int.Parse(Console.ReadLine());

            int totalProducts = loveLetters + roses + keychains + cartoons + luckSurpises;

            double loveLettersPrice = 0.60;
            double rosesPrice = 7.20;
            double keychainPrice = 3.60;
            double carttonPrice = 18.20;
            double luckSurprisePrice = 22;

            double discount = default(double);

            double hosting = 0.10;

            if (totalProducts >= 25)
            {
                discount = 0.35;
            }

            double totalSum = loveLetters * loveLettersPrice + roses * rosesPrice + keychains * keychainPrice + cartoons * carttonPrice + luckSurpises * luckSurprisePrice;

            totalSum = totalSum - totalSum * discount;
            totalSum = totalSum - totalSum * hosting;

            if (totalSum >= maidenPartyPrice)
            {
                Console.WriteLine($"Yes! {(totalSum - maidenPartyPrice):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(maidenPartyPrice - totalSum):f2} lv needed.");
            }
        }
    }
}
