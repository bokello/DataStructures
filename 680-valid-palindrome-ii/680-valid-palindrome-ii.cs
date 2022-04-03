public class Solution {
      public bool ValidPalindrome(string s) {
         
         int i = 0;
         int j = s.Length - 1;

         while(i < j)
         {
            if(s[i] != s[j])
               return isPalindrome(s,i + 1 , j) || isPalindrome(s,i,j-1);

               i++;
               j--;
         }

          return true;
        }

        public bool isPalindrome(string s , int i, int j)
        {
            while( i < j){

               if(s[i++] != s[j--])
                  return false;
            }

            return true;
        }

}