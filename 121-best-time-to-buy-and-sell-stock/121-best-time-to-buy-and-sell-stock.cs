public class Solution {
    public int MaxProfit(int[] prices) {
    
      int maxProfit  = 0;
      int minValue = int.MaxValue;
        
      for(int i=0;i < prices.Length;i++)
      {
          
          if(prices[i] < minValue)
          {
              minValue = prices[i];
          }
          else if(prices[i] - minValue > maxProfit)
          {              
              maxProfit = prices[i] - minValue;
          }
      }
        
        
     return maxProfit;
    
        
        
    }
}