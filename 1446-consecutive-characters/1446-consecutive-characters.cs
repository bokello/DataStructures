public class Solution {
    public int MaxPower(string s) {
    
       int MaxLength = 0;    
       int count = 0;
      
      if(s.Length == 1)
          return 1;
        
        
       for(int i=1;i < s.Length; i++)
       {
           if(s[i] == s[i-1])
               count++;
           else
           {
               MaxLength = Math.Max(MaxLength,count + 1);
               count = 0;               
           }
       }
        
       return Math.Max(MaxLength,count+1);
    }
}