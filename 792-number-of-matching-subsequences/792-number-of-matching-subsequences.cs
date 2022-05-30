public class Solution {
    public int NumMatchingSubseq(string s, string[] words) {
        
        int matches = 0;
        
        foreach(string w in words)
        {
            if(isSubSequence(w,s))
                matches++;
        }
        
        
        return matches;
        
    }
    
    
    public bool isSubSequence(string s, string t)
    {
        int sLeft = 0;
        int tRight = 0;
        
        while(sLeft < s.Length && tRight < t.Length)
        {
            if(s[sLeft] == t[tRight])
                sLeft++;
            
            tRight++;
        }
        
        return sLeft == s.Length;
        
        
        
    }
    
}