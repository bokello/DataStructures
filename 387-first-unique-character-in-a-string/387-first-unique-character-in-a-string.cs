public class Solution {
    public int FirstUniqChar(string s) {
        int[] chars = new int[26];
        
        for(int i=0;i < s.Length; i++)
        {            
            chars[s[i] - 'a']++;            
        }
        
        for(int j=0;j < s.Length; j++)
        {
            if(chars[s[j] - 'a']  == 1)
                return j;
        }
        
        return -1;
    }
}