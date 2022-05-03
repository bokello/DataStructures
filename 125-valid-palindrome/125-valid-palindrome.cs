public class Solution {
    public bool IsPalindrome(string str) {
        
        int left = 0;
        int right = str.Length-1;

        while(left < right)
        {
            while(left < right && !char.IsLetterOrDigit(str[left]))
               left++;

            while(left < right && !char.IsLetterOrDigit(str[right]))
               right--;

             if(Char.ToLower(str[left]) != Char.ToLower(str[right]))
                 return false;

             left++;
             right--;		
        }


        return true;
        }
}