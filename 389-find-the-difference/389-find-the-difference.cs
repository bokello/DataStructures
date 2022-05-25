public class Solution {
    public char FindTheDifference(string s, string t) {
        
        char extra = '\0';
        Dictionary<char,int> sMap = new Dictionary<char,int>();
        
        foreach(char ch in s)
            sMap[ch] = sMap.GetValueOrDefault(ch,0)+1;
        
        foreach(char chars in t)
        {
            int charCount = sMap.GetValueOrDefault(chars,0);
            
            if(charCount == 0)
            {
                extra = chars;
                break;
            }
            else
            {
                sMap[chars]--;
            }                            
        }
        
        return extra;
    }
}