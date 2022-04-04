public class Solution {
    public bool IsSubsequence(string s, string t) {
    
        int sLength = s.Length;
        int tLength = t.Length;
        
        int left = 0;
        int right = 0;
        
        while(left < sLength && right < tLength)
        {       
            if(t[right] == s[left])
                left++;            
            
            right++;
        }
        
        
        return left == sLength;
        
    }
}