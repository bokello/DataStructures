import java.util.HashMap;
import java.util.Stack;

/*
 * @lc app=leetcode id=20 lang=java
 *
 * [20] Valid Parentheses
 */

// @lc code=start
class Solution {

    private HashMap<Character,Character> map; 

    public Solution()
    {
        map = new HashMap<>();

        map.put(')','(');
        map.put('}','{');
        map.put(']','[');
    }

    public boolean isValid(String s) {
     
        Stack<Character> stack = new Stack<Character>();

        for(int i=0;i < s.length();i++)
        {
             char c = s.charAt(i);

            if(map.containsKey(c))
            {
                char topElement = stack.empty() ? '#' : stack.pop();

                if(topElement != map.get(c))
                   return false;

            }
            else
            {
                stack.push(c);
            }

        }
        
        return stack.isEmpty();

    }
}
// @lc code=end

