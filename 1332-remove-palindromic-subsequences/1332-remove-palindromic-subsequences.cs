public class Solution {
    public int RemovePalindromeSub(string s) {
        
        if(s.Length == 0)
            return 0;
        else if(isPalindrome(s))
            return 1;
        else
            return 2;
        
        return 0;
        
        
    }
    
    public bool isPalindrome(string s)
    {
        int left = 0;
        int right  = s.Length - 1;
        
        while(left < right)
        {
            if(s[left] != s[right])
               return false;
            
            left++;
            right--;            
        }
        
        return true;
        
        
    }
    
}