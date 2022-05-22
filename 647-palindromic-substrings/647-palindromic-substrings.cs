public class Solution {
    public int CountSubstrings(string s) {
        int ans = 0;
        
        for(int i=0; i < s.Length; i++)
        {
            // odd length palindrome
            ans += countPalindromesAroundCenter(s,i,i);
            
            // even length palindrome
            ans += countPalindromesAroundCenter(s,i, i + 1);            
        }
        
        return ans;
    }
    
    private int countPalindromesAroundCenter(string s, int left, int right)
    {
        int ans = 0;
        
        while(left >= 0 && right < s.Length && s[left] == s[right])
        {                       
            left--;
            right++; 
         
            ans++;
        }
        
        return ans;
        
    }
}