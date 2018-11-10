using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTheWedding
{
    class ChallengeTheWedding
    {
        static void Main(string[] args)
        {
            int men = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());

            if (men == 0 || women == 0 || tables == 0)
            {
                return;
            }

            bool allMet = false;

            while (tables > 0)
            {
                for (int j = 1; j <= men; j++)
                {
                    for (int k = 1; k <= women; k++)
                    {
                        Console.Write($"({j} <-> {k}) ");
                        tables--;
                        if (tables == 0)
                        {
                            break;
                        }
                        if (j == men)
                        {
                            allMet = true;
                        }
                    }
                    if (tables == 0)
                    {
                        break;
                    }

                }
                if (allMet)
                {
                    break;
                }
            }
        }
    }
}
