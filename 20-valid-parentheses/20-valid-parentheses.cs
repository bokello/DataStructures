public class Solution {
    public bool IsValid(string s) {
        
          Dictionary<char,char> map = new Dictionary<char,char>();
          map.Add(')','(');
          map.Add('}','{');
          map.Add(']','[');
        
          Stack<char> stack = new Stack<char>();
        
          for(int i=0;i < s.Length; i++)
          {
              if(map.ContainsKey(s[i]))
              {
                  char top = stack.Count == 0 ? '#' : stack.Pop();
                  
                  if(top != map[s[i]])
                      return false;
              }
              else
              {
                  stack.Push(s[i]);
              }
              
          }
        
          return !stack.Any();
        
    }
}