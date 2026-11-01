public class Solution {
    public int MaxProfit(int[] prices) {
        var maxP = 0;
        var minBuy = prices[0];

        foreach (var sell in prices)
        {
            maxP = Math.Max(maxP, sell - minBuy);
            minBuy = Math.Min(minBuy, sell);
        }
        
        return maxP;
    }
}
