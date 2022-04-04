public class Solution {
    public bool IsSubsequence(string s, string t) {
    
        int sLength = s.Length;
        int tLength = t.Length;
        
        int left = 0;
        int right = 0;
        
        while(right < tLength)
        {
            if(left >= sLength)
               return true;
                
            if(t[right] == s[left])
                left++;            
            
            right++;
        }
        
        if(left >= sLength)
               return true;
        
        return false;
        
    }
}