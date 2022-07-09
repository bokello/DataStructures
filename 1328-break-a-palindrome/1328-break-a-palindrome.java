class Solution {
    public String breakPalindrome(String palindrome) {
        
        
        int N = palindrome.length();
        
        if(N == 1)
            return "";
        
        char[] palindromeArr = palindrome.toCharArray();
        
        for(int i=0;i < N / 2; i++)
        {
            
            if(palindromeArr[i] != 'a')
            {
                palindromeArr[i] = 'a';
                return String.valueOf(palindromeArr);
            }
        }
        
        palindromeArr[N - 1] = 'b';
        return String.valueOf(palindromeArr);
        
        
    }
}