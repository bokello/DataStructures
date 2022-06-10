public class Solution {
    public int LengthOfLongestSubstring(string str) {
    
          int[] sCount = new int[128];
        
          int result = 0;
          int l=0;
          int r=0;
        
          while(r < str.Length)
          {
              sCount[str[r]]++;
              
              while(sCount[str[r]] > 1)
              {
                  sCount[str[l]]--;
                  l++;
              }
              
              result = Math.Max(result,r - l + 1);
              
              r++;
              
          }
        
         return result;
    
    }
}