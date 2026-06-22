    public class Solution {
        public int MaxProfit(int[] prices)
        {
            var profit = 0;
            
            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine($"Bought for {prices[i]}");
                for (var x = i + 1; x < prices.Length; x++)
                {
                    Console.WriteLine($"Sold for={prices[x]}");
                    profit = prices[x] - prices[i] >  profit ? prices[x] - prices[i] : profit;
                    Console.WriteLine($"Profit={profit}\n");
                }
            }

            return profit;
        }
    }