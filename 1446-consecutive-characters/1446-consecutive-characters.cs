public class Solution {
    public int MaxPower(string s) {
    
      int count = 0;
      int maxCount = 0;
        
     
      for(int i=0;i + 1 < s.Length;i++)
      {
          if(s[i] == s[i + 1])
              count++;
          else
          {
              maxCount = Math.Max(maxCount,count+1);
              count = 0;              
          }
              
      }
        
        
        
      return Math.Max(maxCount,count + 1);
        
    }
}