
/*
20. Valid Parentheses

Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
 

Example 1:

Input: s = "()"
Output: true


*/

        public bool IsValid(string s) {
        
        Dictionary<char,char> map = new Dictionary<char,char>();
        map.Add(')','(');
        map.Add('}','{');
        map.Add(']','[');
        
        Stack<char> stk = new Stack<char>();
        
        for(int i=0;i < s.Length; i++)
        {
            if(map.ContainsKey(s[i]))
            {
               char topElement = (stk.Count == 0) ? '#' : stk.Pop();
                
                if(topElement == map[s[i]])
                   return false;
            }
            else
               stk.Push(s[i]);            
        }
        
        return !stack.Any();        
        
    }