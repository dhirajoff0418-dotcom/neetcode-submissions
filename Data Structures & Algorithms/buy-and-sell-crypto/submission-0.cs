public class Solution {
    public int MaxProfit(int[] prices) {
        int profit=0;
        for(int i=0;i<prices.Length;i++){
            for(int j=i+1;j<prices.Length;j++){
                int Calprofit = prices[j] - prices[i];
                if(Calprofit>profit){
                    profit=Calprofit;
                }
            }
        }
        return profit;
        int minPrice = int.MaxValue;
        int maxProfit = 0;
        
    }
}
