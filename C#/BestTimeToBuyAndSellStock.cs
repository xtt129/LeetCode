public class Solution {
    public int MaxProfit(int[] prices) {
        if(null == prices || prices.Length < 2) return 0;
        int min = prices[0], profit = 0;
        for(int i = 1; i < prices.Length; ++i)
        {
            profit = Math.Max(profit, prices[i] - min);
            min = Math.Min(min, prices[i]);
        }
        return Math.Max(profit, 0);
    }
}