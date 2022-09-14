public class Solution {
    public char RepeatedCharacter(string s) {
        
      HashSet<char> set = new HashSet<char>();
        
        for(int i=0;i < s.Length; i++)
        {
            if(set.Contains(s[i]))
                return s[i];
            else
                set.Add(s[i]);
        }
        
       return ' '; 
        
    }
}