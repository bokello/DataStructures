public class Solution 
{
    
    
    public int CountVowelStrings(int n) {
        
        return countVowelStringUtil(n,1);
    }
    
    private int countVowelStringUtil(int n, int vowels)
    {
        if(n == 0)
            return 1;
    
        int result = 0;
        
        for(int i=vowels;i <=5;i++)
        {
            result += countVowelStringUtil(n - 1,i);
        }
        
        return result;
    }
}