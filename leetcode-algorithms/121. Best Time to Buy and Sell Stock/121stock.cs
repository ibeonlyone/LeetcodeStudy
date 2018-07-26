using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeStudy
{
    class Stock121
    {
        public static int MaxProfit(int[] prices)
        {
            if (prices.Length <= 1)
                return 0;
            int profit = 0;
            int maxProfit = 0;
            int peak = prices[0];
            int valley = prices[0];
            int i = 0;
            while (i<prices.Length-1) {
                
                while (i<prices.Length - 1&& prices[i] >= prices[i + 1] ) {
                    i++;
                }
                valley = prices[i];
                peak = prices[i];
                for(int j=i;j < prices.Length;j++) {
                    if (peak < prices[j]) {
                        peak = prices[j];
                    }
                }
                profit = peak - valley;
                if (profit >= maxProfit)
                    maxProfit = profit;
                i++;
            }
            return maxProfit;


        }
    }
}