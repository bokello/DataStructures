public class Solution {
    public bool CanPermutePalindrome(string s) {
        
        int count  = 0;
        int[] arr = new int[128];
        
        for(int i=0;i < s.Length;i++)
        {
            arr[s[i]]++;
            
            if(arr[s[i]] % 2 == 0)
                count--;
            else
                count++;
        }
        
        return count <=1;
        
        
        
    }
}