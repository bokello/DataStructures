public class Solution {
    public string FirstPalindrome(string[] words) {
        
        foreach(string w in words)
        {
            if(isPalindrome(w))
                return w;
        }
        
        return "";
        
    }
    
    private bool isPalindrome(string word)
    {
        int left = 0;
        int right = word.Length - 1;
        
        while(left < right)
        {
            if(word[left] != word[right])
                return false;
            
            left++;
            right--;
        }
        
        return true;
    }
}