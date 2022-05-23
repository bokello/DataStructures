public class Solution {
    public string LongestCommonPrefix(string[] str) {
        
        if(str.Length == 0)
               return "";

              string prefix = str[0];

              for(int i=1;i<str.Length;i++)
              {
                 while(str[i].IndexOf(prefix) != 0)
                   prefix = prefix.Substring(0,prefix.Length - 1);
              }

            return prefix;
      }
}