public class Solution {
    public bool IsAnagram(string s1, string s2) {
          if(s1.Length != s2.Length)
               return false;

            int[] charCount = new int[26];
             
           for(int i=0;i < s1.Length;i++)
           {
              charCount[s1[i] - 'a']++;
              charCount[s2[i] - 'a']--;
           }

           foreach(var idx in charCount)
           {
                if(idx > 0)
                  return false;
           }
        
         return true;
    }
}