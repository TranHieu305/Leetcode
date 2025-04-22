namespace Test._0121._Best_Time_to_Buy_and_Sell_Stock
{
    public class Solution
    {
        /// <summary>
        /// Finds the maximum profit from a single buy-sell transaction.
        /// Tracks the lowest price so far and computes max profit at each step.
        ///
        /// Time Complexity: O(n) — single pass through the prices array.
        /// Space Complexity: O(1) — uses constant extra space.
        /// </summary>
        public int MaxProfit(int[] prices)
        {
            var buy = int.MaxValue;
            var maxProfit = 0;
            
            foreach (var pr in prices)
            {
                if (pr < buy)
                {
                    buy = pr;
                }
                else
                {
                    maxProfit = Math.Max(maxProfit, pr - buy);
                }
            }
            return maxProfit;
        }
    }
}
