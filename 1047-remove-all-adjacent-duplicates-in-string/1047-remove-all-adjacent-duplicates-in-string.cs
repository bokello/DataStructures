public class Solution {
    public string RemoveDuplicates(string s) {
           
         string result = string.Empty;
         Stack<char> stack = new Stack<char>();
        
         for(int i=s.Length-1;i >=0;i--)
         {
             if(stack.Count == 0 || stack.Peek() != s[i])
                 stack.Push(s[i]);
             else
                 stack.Pop();
         }
        
         while(stack.Count !=0)
             result += stack.Pop();
        
        return result;
          
    }
}