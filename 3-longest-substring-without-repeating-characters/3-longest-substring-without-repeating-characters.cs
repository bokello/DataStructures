public class Solution {
    public int LengthOfLongestSubstring(string str) {
    
        int[] charCount = new int[128];
        
        int result = 0;
        int left = 0;
        int right = 0;
        
        while(right < str.Length)
        {
            charCount[str[right]]++;
            
            while(charCount[str[right]] > 1)
            {
                
                charCount[str[left]]--;
                left++;
            }
            
           result = Math.Max(result,right-left+1);
           right++;
            
        }
        
        return result;
    
    }
}