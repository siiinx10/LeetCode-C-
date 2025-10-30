public class Solution {
    public int MaxProfit(int[] prices) {

        int maxProfit = 0;
        int profit;
        for(int i = 0; i < prices.Length; i++){
            for (int j = i + 1; j < prices.Length; j++){
                profit = prices[j] - prices[i];
                if(profit > maxProfit){
                    maxProfit = profit;
                }
            }
        }

        return maxProfit;
        
    }
}
