using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grind100
{
    partial class Program
    {
        static int MaxProfit(int[] prices)
        {
            int maxSoFar = 0;
            int bestAns = 0;
            for (int i = prices.Length - 1; i >= 0; i--)
            {
                if (prices[i] > maxSoFar) maxSoFar = prices[i];
                bestAns = Math.Max(bestAns, maxSoFar - prices[i]);
            }
            return bestAns;
        }
    }
}
